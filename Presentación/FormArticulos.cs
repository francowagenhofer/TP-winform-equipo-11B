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
            dgvArticulos.Columns["Id"].Visible = true;
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

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
        private void tbFiltroRapido_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
