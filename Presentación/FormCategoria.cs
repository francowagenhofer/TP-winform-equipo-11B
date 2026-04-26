using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FormCategoria : Form
    {
        private List<Categoria> listaCategoria;

        public FormCategoria()
        {
            InitializeComponent();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                listaCategoria = categoriaNegocio.listarCategorias();
                dgvCategorias.DataSource = listaCategoria;
                dgvCategorias.Columns["Id"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado;

            try
            {
                seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                negocio.modificarCategoria(seleccionado);

                MessageBox.Show("Modificado exitosamente");
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿De verdad querés eliminar la categoría?", "Eliminando",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

                    negocio.eliminarCategoria(seleccionado.Id);

                    MessageBox.Show("Eliminado exitosamente");
                    cargar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            tbFiltroRapido.Clear();
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = listaCategoria;
        }

        private void tbFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Categoria> listaFiltrada;
            string filtro = tbFiltroRapido.Text;

            if (filtro.Length >= 1)
            {
                listaFiltrada = listaCategoria.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Id.ToString().Contains(filtro.Normalize()));
            }
            else
            {
                listaFiltrada = listaCategoria;
            }

            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = listaFiltrada;
        }
    }
}
