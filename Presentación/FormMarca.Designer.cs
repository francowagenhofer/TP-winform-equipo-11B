namespace Presentación
{
    partial class FormMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpListado = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tbFiltroRapido = new System.Windows.Forms.TextBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.tlp1.SuspendLayout();
            this.tlpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 3;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.080526F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.75678F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.244864F));
            this.tlp1.Controls.Add(this.tlpListado, 1, 2);
            this.tlp1.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.tlp1.Controls.Add(this.labelTitulo, 1, 0);
            this.tlp1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 4;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7582F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.90765F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.64034F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.6938F));
            this.tlp1.Size = new System.Drawing.Size(602, 483);
            this.tlp1.TabIndex = 1;
            // 
            // tlpListado
            // 
            this.tlpListado.ColumnCount = 1;
            this.tlpListado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpListado.Controls.Add(this.dgvMarcas, 0, 0);
            this.tlpListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpListado.Location = new System.Drawing.Point(39, 121);
            this.tlpListado.Name = "tlpListado";
            this.tlpListado.RowCount = 1;
            this.tlpListado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListado.Size = new System.Drawing.Size(521, 243);
            this.tlpListado.TabIndex = 0;
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMarcas.Location = new System.Drawing.Point(10, 10);
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(10);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.RowTemplate.Height = 24;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(501, 223);
            this.dgvMarcas.StandardTab = true;
            this.dgvMarcas.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 370);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.278688F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.35593F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.10169F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 110);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnAgregar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnModificar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEliminar, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(515, 82);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAgregar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(10, 10);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 62);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(181, 10);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(10);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(151, 62);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEliminar.BackColor = System.Drawing.Color.MistyRose;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(352, 10);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(10);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(153, 62);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 94);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(515, 13);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(46, 10);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(10);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(507, 41);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Administrar Marcas";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(39, 64);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(521, 51);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.31007F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.68992F));
            this.tableLayoutPanel7.Controls.Add(this.tbFiltroRapido, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnLimpiarFiltro, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(515, 45);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // tbFiltroRapido
            // 
            this.tbFiltroRapido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFiltroRapido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFiltroRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltroRapido.Location = new System.Drawing.Point(5, 7);
            this.tbFiltroRapido.Margin = new System.Windows.Forms.Padding(5);
            this.tbFiltroRapido.Name = "tbFiltroRapido";
            this.tbFiltroRapido.Size = new System.Drawing.Size(326, 30);
            this.tbFiltroRapido.TabIndex = 2;
            this.tbFiltroRapido.Text = "Buscar Marca";
            this.tbFiltroRapido.TextChanged += new System.EventHandler(this.tbFiltroRapido_TextChanged);
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLimpiarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(339, 6);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(73, 33);
            this.btnLimpiarFiltro.TabIndex = 3;
            this.btnLimpiarFiltro.Text = "Limpiar";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // FormMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 483);
            this.Controls.Add(this.tlp1);
            this.MaximumSize = new System.Drawing.Size(620, 530);
            this.MinimumSize = new System.Drawing.Size(620, 530);
            this.Name = "FormMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMarca";
            this.Load += new System.EventHandler(this.FormMarca_Load);
            this.tlp1.ResumeLayout(false);
            this.tlp1.PerformLayout();
            this.tlpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.TableLayoutPanel tlpListado;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox tbFiltroRapido;
        private System.Windows.Forms.Button btnLimpiarFiltro;
    }
}