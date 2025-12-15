using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;
using Workshop2.DTO;
using Workshop.Services;

namespace Workshop2.Forms
{
    public partial class EntityGridForm<TEntity, TDto> : Form
        where TEntity : class
        where TDto : class, IEntityDto, new()
    {
        private readonly IEntityService<TEntity, TDto> _service;

        public EntityGridForm(IEntityService<TEntity, TDto> service)
        {
            InitializeComponent();
            _service = service;
            Reload();
        }

        private void Reload()
        {
            try
            {
                dataGridView1.DataSource = _service.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при загрузке данных: {ex.Message}",
                    "Ошибка базы данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                // Можно установить пустой источник данных
                dataGridView1.DataSource = new List<TDto>();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new TDto();
                var editForm = new EntityEditForm<TDto>(dto);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    _service.Add(dto);
                    Reload();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при добавлении: {ex.Message}",
                    "Ошибка базы данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow?.DataBoundItem is TDto dto)
                {
                    var editForm = new EntityEditForm<TDto>(dto);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        _service.Update(dto);
                        Reload();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при редактировании: {ex.Message}",
                    "Ошибка базы данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is TDto dto)
            {

                var result = MessageBox.Show(
                    $"Вы уверены, что хотите удалить",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _service.Delete(dto.Id); // Теперь принимает object
                        Reload();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Ошибка при удалении: {ex.Message}",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}