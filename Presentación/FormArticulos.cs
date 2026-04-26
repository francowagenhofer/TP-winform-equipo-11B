using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FormArticulos : Form
    {
        private List<Articulo> listaArticulo;

        public FormArticulos()
        {
            InitializeComponent();
        }

        private void FormArticulos_Load(object sender, EventArgs e)
        {
            cbCampo.Items.Add("Precio");
            cbCampo.Items.Add("Nombre");
            cargar();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow?.DataBoundItem;
                cargarImagen(seleccionado.Id);
            }    
        }

        private void cargar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                listaArticulo = articuloNegocio.listarArticulos();
                dgvArticulos.DataSource = listaArticulo;

                if (listaArticulo.Count > 0)
                    cargarImagen(listaArticulo[0].Id);

                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarImagen(int idArticulo)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
         
            try
            {
                string imagenUrl = imagenNegocio.obtenerImagen(idArticulo);
                pbImagen.Load(imagenUrl);
            }
            catch
            {
                pbImagen.Load("https://dummyimage.com/300x300/cccccc/000000&text=Sin+Imagen");
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Nombre"].Visible = true;
            dgvArticulos.Columns["Codigo"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["Marca"].Visible = true;
            dgvArticulos.Columns["Categoria"].Visible = true;
            dgvArticulos.Columns["Precio"].Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormArticulo alta = new FormArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;

            seleccionado= (Articulo)dgvArticulos.CurrentRow?.DataBoundItem;

            FormArticulo modificar = new FormArticulo(seleccionado);
            modificar.ShowDialog();

            cargar();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            FormDetalle detalle = new FormDetalle(seleccionado);
            detalle.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad queres eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminarArticulo(seleccionado.Id);
                    cargar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = tbFiltroRapido.Text;

            if (filtro.Length >= 2)
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Precio.ToString().Contains(filtro.Normalize()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            tbFiltroRapido.Clear();
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaArticulo;
            ocultarColumnas();
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Mayor a");
                cbCriterio.Items.Add("Menor a");
                cbCriterio.Items.Add("Igual a");
            }
            else
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Comienza con");
                cbCriterio.Items.Add("Termina con");
                cbCriterio.Items.Add("Contiene");
            }
        }

        private bool validarFiltro()
        {
            if (cbCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (cbCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (cbCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(tbFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debes cargar el filtro con algun precio.");
                    return true;
                }

                if (!(soloNumeros(tbFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Por favor, solo numeros para filtrar por precio.");
                    return true;
                }
            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cbCampo.SelectedItem.ToString();
                string criterio = cbCriterio.SelectedItem.ToString();
                string filtro = tbFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtrarArticulo(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // ------------------------------------------------------------

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            FormMarca gestion = new FormMarca();
            gestion.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FormCategoria gestion = new FormCategoria();
            gestion.ShowDialog();
        }

        
    }
}
