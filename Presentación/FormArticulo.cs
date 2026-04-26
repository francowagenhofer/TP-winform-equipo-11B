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
    public partial class FormArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        private List<Imagen> imagenesArticulo = new List<Imagen>();

        public FormArticulo()
        {
            InitializeComponent();
        }

        public FormArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }

        private void FormArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            try
            {
                cbMarca.DataSource = marcaNegocio.listarMarcas();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";

                cbCategoria.DataSource = categoriaNegocio.listarCategorias();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    tbCodigo.Text = articulo.Codigo;
                    tbNombre.Text = articulo.Nombre;
                    tbDescripcion.Text = articulo.Descripcion;
                    tbPrecio.Text = articulo.Precio.ToString();

                    imagenesArticulo = imagenNegocio.listarImagenesPorArticulo(articulo.Id);
                    refrescarListaImagenes();

                    if (imagenesArticulo.Count > 0)
                        cargarImagen(imagenesArticulo[0].ImagenUrl);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagenes.Load(imagen);
            }
            catch (Exception ex)
            {
                pbImagenes.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSk8RLjeIEybu1xwZigumVersvGJXzhmG8-0Q&s");
            }
        }

        private void btnArchivoImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                tbUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }


        // falta modificar
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            string url = tbUrlImagen.Text.Trim();

            if (string.IsNullOrWhiteSpace(url))
                return;

            imagenesArticulo.Add(new Imagen { ImagenUrl = url });
            refrescarListaImagenes();
            listaImagenes.SelectedIndex = imagenesArticulo.Count - 1;
        }

        // falta modificar
        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            Imagen seleccionada = listaImagenes.SelectedItem as Imagen;

            if (seleccionada == null)
                return;

            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿De verdad querés eliminar la imagen?",
                    "Eliminando",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    ImagenNegocio imagenNegocio = new ImagenNegocio();

                    // Si ya existe en la base, eliminar de la BD
                    if (seleccionada.Id != 0)
                    {
                        imagenNegocio.eliminarImagen(seleccionada.Id);
                    }

                    // Siempre eliminar de la lista
                    imagenesArticulo.Remove(seleccionada);

                    refrescarListaImagenes();

                    if (imagenesArticulo.Count > 0)
                        listaImagenes.SelectedIndex = 0;
                    else
                        pbImagenes.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listaImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaImagenes.SelectedItem != null)
            {
                Imagen seleccionada = (Imagen)listaImagenes.SelectedItem;
                cargarImagen(seleccionada.ImagenUrl);
            }
        }

        private void refrescarListaImagenes()
        {
            listaImagenes.DataSource = null;
            listaImagenes.DataSource = imagenesArticulo;
            listaImagenes.DisplayMember = "ImagenUrl";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = tbCodigo.Text;
                articulo.Nombre = tbNombre.Text;
                articulo.Descripcion = tbDescripcion.Text;
                articulo.Precio = decimal.Parse(tbPrecio.Text);
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;

                articulo.Imagenes = imagenesArticulo;

                if (articulo.Id != 0)
                {
                    negocio.modificarArticulo(articulo);

                    // Solo agrego imagenes nuevas, las que ya existen no las modifico ni elimino
                    foreach (Imagen img in imagenesArticulo)
                    {
                        if (img.Id == 0)
                        {
                            img.IdArticulo = articulo.Id;
                            imagenNegocio.agregarImagen(img);
                        }
                    }

                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    articulo.Id = negocio.agregarArticulo(articulo);

                    foreach (Imagen img in imagenesArticulo)
                    {
                        img.IdArticulo = articulo.Id;
                        imagenNegocio.agregarImagen(img);
                    }

                    MessageBox.Show("Agregado exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
