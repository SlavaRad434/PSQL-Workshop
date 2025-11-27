using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;
using Workshop.DTO;
using Workshop.Services;

namespace Workshop.Forms
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
            dataGridView1.DataSource = _service.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dto = new TDto();
            var editForm = new EntityEditForm<TDto>(dto);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                _service.Add(dto);
                Reload();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is TDto dto)
            {
                _service.Delete(dto.Id);
                Reload();
            }
        }
    }
}