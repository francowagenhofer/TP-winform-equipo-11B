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
    public partial class FormArticulos : Form
    {
        public FormArticulos()
        {
            InitializeComponent();
        }

        private void FormArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articulo = new ArticuloNegocio();

            try
            {
                dgvArticulos.DataSource = articulo.listar();
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
