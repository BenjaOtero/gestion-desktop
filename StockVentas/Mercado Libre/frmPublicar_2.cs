using System;
using System.Data;
using System.Windows.Forms;
using MercadoLibre.SDK;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;



using System.Diagnostics;

namespace StockVentas.Mercado_Libre
{
    public partial class frmPublicar_2 : Form
    {
        MeliApiService meli;
        string categoria;
        DataGridView dgvDatos;
        
        public frmPublicar_2(MeliApiService meli, string categoria, DataGridView dgvDatos)
        {
            InitializeComponent();
            this.meli = meli;
            this.categoria = categoria;
            this.dgvDatos = dgvDatos;
            BL.Utilitarios.AddEventosABM(grpCampos);
            txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(BL.Utilitarios.SoloNumeros);
            AddEventosValidacion();
        }

        private void frmPublicar_2_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            System.Drawing.Icon ico = Properties.Resources.icono_app;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          /*  if (checkBox1.Checked == true)
            {
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    row.Cells["Actualizar"].Value = 1;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    row.Cells["Actualizar"].Value = 0;
                }
            }*/
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            StockVentas.Mercado_Libre.frmProgress frm = new StockVentas.Mercado_Libre.frmProgress("subirImagenes", meli, dgvDatos);
            frm.ShowDialog();
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Close();
            Cursor.Current = Cursors.Arrow;
        }

        private void frmArticulosPrecios_FormClosing(object sender, FormClosingEventArgs e)
        {
          /*  bool checkeado = false;
            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                if (row.Cells["Actualizar"].Value != null)
                {
                    if (row.Cells["Actualizar"].Value.ToString() == "1")
                    {
                        checkeado = true;
                        continue;
                    }
                }
            }
            if (checkeado)
            {
                DialogResult respuesta =
                        MessageBox.Show("¿Desea guardar los cambios?", "Trend", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (respuesta)
                {
                    case DialogResult.Yes:

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }*/
        }

        private void ValidarCampos(object sender, CancelEventArgs e)
        {
            if ((sender == (object)txtTitulo))
            {
                if (string.IsNullOrEmpty(txtTitulo.Text))
                {
                    this.errorProvider1.SetError(txtTitulo, "Debe escribir un título.");
                    e.Cancel = true;
                }
            }
            if ((sender == (object)txtDescripcion))
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    this.errorProvider1.SetError(txtDescripcion, "Debe escribir una descripción.");
                    e.Cancel = true;
                }
            }
            if ((sender == (object)txtPrecio))
            {
                if (string.IsNullOrEmpty(txtPrecio.Text))
                {
                    this.errorProvider1.SetError(txtPrecio, "Debe escribir un precio.");
                    e.Cancel = true;
                }
            }
        }

        private void AddEventosValidacion()
        {
            foreach (Control ctl in grpCampos.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Validating += new System.ComponentModel.CancelEventHandler(this.ValidarCampos);
                    ctl.Validated += new System.EventHandler(this.CamposValidado);
                }
            }
        }

        private void CamposValidado(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void chkEnvios_Click(object sender, EventArgs e)
        {
            if (chkEnvios.Checked) grpIncluirMercadoEnvios.Enabled = true;
            else grpIncluirMercadoEnvios.Enabled = false;
        }
    }
}
