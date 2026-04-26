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
    public partial class FormMarca : Form
    {
        private List<Marca> listaMarca;

        public FormMarca()
        {
            InitializeComponent();
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                listaMarca = marcaNegocio.listarMarcas();

                dgvMarcas.DataSource = null;
                dgvMarcas.DataSource = listaMarca;

                dgvMarcas.AllowUserToAddRows = true;
                dgvMarcas.ReadOnly = false;

                dgvMarcas.Columns["Id"].ReadOnly = true;

                dgvMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvMarcas.MultiSelect = false;

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
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;

            try
            {
                seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                negocio.modificarMarca(seleccionado);

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
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿De verdad querés eliminar la marca?", "Eliminando",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                    negocio.eliminarMarca(seleccionado.Id);

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
            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = listaMarca;
        }

        private void tbFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Marca> listaFiltrada;
            string filtro = tbFiltroRapido.Text;

            if (filtro.Length >= 1)
            {
               listaFiltrada = listaMarca.FindAll(x =>  x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Id.ToString().Contains(filtro.Normalize()));
            }
            else
            {
                listaFiltrada = listaMarca;
            }

            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = listaFiltrada;
        }
    }
}
