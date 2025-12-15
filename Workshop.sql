-- ============================================
-- БАЗА ДАННЫХ: Мастерская ремонта автомобилей
-- ============================================

-- Схема для курсового проекта
CREATE SCHEMA IF NOT EXISTS auto_repair;
SET search_path TO auto_repair;

-- ============================================
-- 1. Таблица "Мастерские"
-- ============================================
CREATE TABLE workshops (
    workshop_id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL UNIQUE,
    address VARCHAR(150),
    phone VARCHAR(20),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- ============================================
-- 2. Таблица "Бригады"
-- ============================================
CREATE TABLE brigades (
    brigade_id SERIAL PRIMARY KEY,
    workshop_id INT NOT NULL,
    name VARCHAR(100) NOT NULL,
    CHECK (name <> ''),
    FOREIGN KEY (workshop_id) REFERENCES workshops(workshop_id) ON DELETE CASCADE
);

CREATE INDEX idx_brigades_workshop_id ON brigades(workshop_id);

-- ============================================
-- 3. Таблица "Персонал"
-- ============================================
CREATE TABLE personnel (
    person_inn CHAR(12) PRIMARY KEY,
    workshop_id INT NOT NULL,
    brigade_id INT,
    full_name VARCHAR(120) NOT NULL,
    role VARCHAR(50) DEFAULT 'Механик',
    hired_at DATE DEFAULT CURRENT_DATE,
    CHECK (char_length(person_inn) = 12),
    FOREIGN KEY (workshop_id) REFERENCES workshops(workshop_id) ON DELETE CASCADE,
    FOREIGN KEY (brigade_id) REFERENCES brigades(brigade_id) ON DELETE SET NULL
);

CREATE INDEX idx_personnel_brigade_id ON personnel(brigade_id);

-- ============================================
-- 4. Таблица "Автомобили"
-- ============================================
CREATE TABLE cars (
    car_id SERIAL PRIMARY KEY,
    vin VARCHAR(20) UNIQUE NOT NULL,
    body_number VARCHAR(20),
    engine_number VARCHAR(20),
    owner_name VARCHAR(100),
    owner_phone VARCHAR(20)
);

-- ============================================
-- 5. Таблица "Неисправности"
-- ============================================
CREATE TABLE defects (
    defect_id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL UNIQUE,
    base_labor_cost NUMERIC(10,2) NOT NULL CHECK (base_labor_cost >= 0)
);

-- ============================================
-- 6. Таблица "Ремонт автомобиля"
-- ============================================
CREATE TABLE repairs (
    repair_id SERIAL PRIMARY KEY,
    car_id INT NOT NULL,
    defect_id INT NOT NULL,
    brigade_id INT NOT NULL,
    received_at DATE NOT NULL,
    finished_at DATE,
    labor_cost NUMERIC(10,2) DEFAULT 0 CHECK (labor_cost >= 0),
    parts_cost NUMERIC(10,2) DEFAULT 0 CHECK (parts_cost >= 0),
    total_cost NUMERIC(10,2) DEFAULT 0,
    status VARCHAR(30) DEFAULT 'в процессе',
    FOREIGN KEY (car_id) REFERENCES cars(car_id) ON DELETE CASCADE,
    FOREIGN KEY (defect_id) REFERENCES defects(defect_id) ON DELETE CASCADE,
    FOREIGN KEY (brigade_id) REFERENCES brigades(brigade_id) ON DELETE CASCADE
);

CREATE INDEX idx_repairs_car_id ON repairs(car_id);
CREATE INDEX idx_repairs_brigade_id ON repairs(brigade_id);

-- ============================================
-- 7. Таблица "Запчасти"
-- ============================================
CREATE TABLE parts (
    part_id SERIAL PRIMARY KEY,
    defect_id INT NOT NULL,
	car_id INT NOT NULL,
    name VARCHAR(100) NOT NULL,
    unit_price NUMERIC(10,2) NOT NULL CHECK (unit_price >= 0),
    quantity INT NOT NULL CHECK (quantity > 0),
    FOREIGN KEY (defect_id) REFERENCES defects(defect_id) ON DELETE CASCADE,
	FOREIGN KEY (car_id) REFERENCES cars(car_id) ON DELETE CASCADE
);

-- Индекс для быстрого поиска запчастей по ремонту
CREATE INDEX idx_parts_defect_id ON parts(defect_id);
CREATE INDEX idx_parts_car_id ON parts(car_id);

-- ============================================
-- ФУНКЦИЯ-ТРИГГЕР для пересчёта стоимости ремонта
-- ============================================

CREATE OR REPLACE FUNCTION update_repair_total()
RETURNS TRIGGER AS $$
DECLARE
    target_car_id INT;
    target_defect_id INT;
    parts_sum NUMERIC(18,2);
    labor NUMERIC(18,2);
BEGIN
    -- Определяем, какие ключи использовать
    IF (TG_OP = 'DELETE') THEN
        target_car_id := OLD.car_id;
        target_defect_id := OLD.defect_id;
    ELSE
        target_car_id := NEW.car_id;
        target_defect_id := NEW.defect_id;
    END IF;

    -- Сумма стоимости деталей для конкретного автомобиля и неисправности
    SELECT COALESCE(SUM(unit_price * quantity), 0)
    INTO parts_sum
    FROM parts
    WHERE car_id = target_car_id
      AND defect_id = target_defect_id;

    -- Получаем текущую стоимость работ
    SELECT labor_cost INTO labor
    FROM repairs
    WHERE car_id = target_car_id
      AND defect_id = target_defect_id;

    IF NOT FOUND THEN
        RETURN NULL; -- такого ремонта нет
    END IF;

    -- Обновляем соответствующую запись в repairs
    UPDATE repairs
    SET parts_cost = parts_sum,
        total_cost = COALESCE(labor, 0) + parts_sum
    WHERE car_id = target_car_id
      AND defect_id = target_defect_id;

    RETURN NULL; -- AFTER-триггер
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trg_update_repair_total
AFTER INSERT OR UPDATE OR DELETE
ON parts
FOR EACH ROW
EXECUTE FUNCTION update_repair_total();
-- ============================================
-- ПРЕДСТАВЛЕНИЯ (VIEWS)
-- ============================================

-- 1. Простое представление: список автомобилей
CREATE OR REPLACE VIEW vw_cars AS
SELECT car_id, vin, owner_name, owner_phone
FROM cars;

-- 2. Многотабличное представление: информация о ремонтах
CREATE OR REPLACE VIEW vw_repairs_detailed AS
SELECT r.repair_id, c.vin, d.name AS defect, b.name AS brigade,
       r.received_at, r.finished_at, r.total_cost, r.status
FROM repairs r
JOIN cars c ON r.car_id = c.car_id
JOIN defects d ON r.defect_id = d.defect_id
JOIN brigades b ON r.brigade_id = b.brigade_id;

-- 3. Представление с GROUP BY и HAVING: производительность бригад
CREATE OR REPLACE VIEW vw_brigade_performance AS
SELECT b.brigade_id, b.name AS brigade,
       COUNT(r.repair_id) AS total_repairs,
       SUM(r.total_cost) AS total_income
FROM brigades b
LEFT JOIN repairs r ON b.brigade_id = r.brigade_id
GROUP BY b.brigade_id, b.name
HAVING COUNT(r.repair_id) > 0;

-- 4. Отчёт "Стоимость ремонта"
CREATE OR REPLACE VIEW vw_repair_cost AS
SELECT 
    r.repair_id,
    c.vin,
    d.name AS defect,
    COALESCE(SUM(p.unit_price * p.quantity), 0) AS parts_sum,
    r.labor_cost,
    (r.labor_cost + COALESCE(SUM(p.unit_price * p.quantity), 0)) AS total_sum
FROM repairs r
JOIN cars c ON r.car_id = c.car_id
JOIN defects d ON r.defect_id = d.defect_id
LEFT JOIN parts p 
    ON p.car_id = r.car_id 
   AND p.defect_id = r.defect_id
GROUP BY 
    r.repair_id, c.vin, d.name, r.labor_cost;