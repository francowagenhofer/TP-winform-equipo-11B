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
        private BindingSource bindingSource;

        public FormMarca()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
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

                bindingSource.DataSource = listaMarca;
                dgvMarcas.DataSource = bindingSource;

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
            MarcaNegocio negocio = new MarcaNegocio();
            Marca nuevaMarca = new Marca();

            try
            {
                if (dgvMarcas.CurrentRow == null)
                    return;

                if (dgvMarcas.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Seleccioná la fila que querés agregar.");
                    return;
                }

                string descripcion = dgvMarcas.CurrentRow.Cells["Descripcion"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(descripcion))
                {
                    MessageBox.Show("Ingresá una descripción para la marca");
                    return;
                }

                nuevaMarca.Descripcion = descripcion;
                negocio.agregarMarca(nuevaMarca);

                MessageBox.Show("Marca agregada exitosamente");

                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;

            try
            {
                if (dgvMarcas.CurrentRow == null)
                    return;

                if (dgvMarcas.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("No se puede modificar una fila vacía.");
                    return;
                }

                seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                if (seleccionado.Id == 0)
                {
                    MessageBox.Show("No se puede modificar una marca que no existe.");
                    return;
                }

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
                if (dgvMarcas.CurrentRow == null)
                    return;

                if (dgvMarcas.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("No se puede eliminar una fila vacía.");
                    return;
                }

                seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                if (seleccionado.Id == 0)
                {
                    MessageBox.Show("No se puede eliminar una marca que no existe.");
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿De verdad querés eliminar la marca?",
                    "Eliminando",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
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
            bindingSource.DataSource = listaMarca;
        }

        private void tbFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Marca> listaFiltrada;
            string filtro = tbFiltroRapido.Text;

            if (filtro.Length >= 1)
            {
                listaFiltrada = listaMarca.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Id.ToString().Contains(filtro.Normalize()));
            }
            else
            {
                listaFiltrada = listaMarca;
            }

            bindingSource.DataSource = listaFiltrada;
        }
    }
}
