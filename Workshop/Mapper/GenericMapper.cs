namespace Workshop.Mapper
{
    public static class GenericMapper
    {
        public static TDto ToDto<TEntity, TDto>(TEntity entity)
            where TDto : new()
        {
            var dto = new TDto();

            foreach (var dtoProp in typeof(TDto).GetProperties())
            {
                var entityProp = typeof(TEntity).GetProperty(dtoProp.Name);

                if (entityProp != null && entityProp.CanRead && dtoProp.CanWrite)
                {
                    var value = entityProp.GetValue(entity);
                    dtoProp.SetValue(dto, value);
                }
            }
            return dto;
        }

        public static void ToEntity<TDto, TEntity>(TDto dto, TEntity entity)
        {
            foreach (var dtoProp in typeof(TDto).GetProperties())
            {
                if (dtoProp.Name == "Id") continue;

                var entityProp = typeof(TEntity).GetProperty(dtoProp.Name);

                if (entityProp != null && entityProp.CanWrite && dtoProp.CanRead)
                {
                    var value = dtoProp.GetValue(dto);
                    entityProp.SetValue(entity, value);
                }
            }
        }

        public static TEntity CreateEntity<TDto, TEntity>(TDto dto)
            where TEntity : new()
        {
            var entity = new TEntity();
            ToEntity(dto, entity);
            return entity;
        }
    }
}