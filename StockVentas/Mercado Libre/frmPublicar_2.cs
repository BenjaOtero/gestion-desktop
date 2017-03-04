using System;
using System.Data;
using System.Windows.Forms;
using MercadoLibre.SDK;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Http;
using HttpParamsUtility;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;



using System.Diagnostics;

namespace StockVentas.Mercado_Libre
{
    public partial class frmPublicar_2 : Form
    {
        MeliApiService meli;
        string categoria;
        DataTable tblPublicar;
        
        public frmPublicar_2(MeliApiService meli, string categoria, DataTable tblPublicar)
        {
            InitializeComponent();
            this.meli = meli;
            this.categoria = categoria;
            this.tblPublicar = tblPublicar;
            BL.Utilitarios.AddEventosABM(grpCampos);
            txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(BL.Utilitarios.SoloNumeros);
            AddEventosValidacion();
        }

        private void frmPublicar_2_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            System.Drawing.Icon ico = Properties.Resources.icono_app;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            grpBotones.CausesValidation = false;
            btnSalir.CausesValidation = false;
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
            string json = CreateJsonCopia();
      //      StockVentas.Mercado_Libre.frmProgress frm = new StockVentas.Mercado_Libre.frmProgress("subirImagenes", meli, tblPublicar);
         //   frm.ShowDialog();
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            Close();

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

        private string CreateJson()
        {
            DataSet ds = BL.MercadoLibreBLL.GetData();
            DataTable tblColores = ds.Tables[0];
            DataTable tblTalles = ds.Tables[1];
            PublicarVariacion publicarVariacion = new PublicarVariacion();
            publicarVariacion.title = txtTitulo.Text;
            publicarVariacion.category_id = categoria;
            publicarVariacion.price = Convert.ToInt32(txtPrecio.Text);
            publicarVariacion.currency_id = "ARS";
            publicarVariacion.buying_mode = "buy_it_now";
            publicarVariacion.listing_type_id = "bronze";
            string condicion;
            if (rdNuevo.Checked) condicion = "new";
            else condicion = "used";
            publicarVariacion.condition = condicion;
            publicarVariacion.description = "<div align =\"center\"><img src=\"https://trendsistemas.com/ml_images/descripcion_calzado_html.jpg\" alt=\"\" /></div>";
            publicarVariacion.variations = new List<variations>{
                        new variations() {
                        attribute_combinations = new List<attribute_combinations> {
                            new attribute_combinations() {id = "83000", value_id = "92028" },
                            new attribute_combinations() {id = "73002", value_id = "82071" }
                        },
                        picture_ids = new List<string> { "https://trendsistemas.com/ml_images/050003.jpg", "https://trendsistemas.com/ml_images/050004.jpg"},
                        seller_custom_field = "050001",
                        available_quantity = 2,
                        price = 10
                        },
                        new variations() {
                        attribute_combinations = new List<attribute_combinations> {
                            new attribute_combinations() {id = "83000", value_id = "92028" },
                            new attribute_combinations() {id = "73002", value_id = "82069" }
                        },
                        picture_ids = new List<string> { "https://trendsistemas.com/ml_images/050003.jpg", "https://trendsistemas.com/ml_images/050004.jpg"},
                        seller_custom_field = "050001",
                        available_quantity = 2,
                        price = 10
                        }
                    };
            string json = new JavaScriptSerializer().Serialize(publicarVariacion);
            return json;

        }

        private string CreateJsonCopia()
        {
            DataSet ds = BL.MercadoLibreBLL.GetData();
            DataTable tblColores = ds.Tables[0];
            tblColores.PrimaryKey = new DataColumn[] { tblColores.Columns["value_name"] };
            DataTable tblTalles = ds.Tables[1];
            tblTalles.PrimaryKey = new DataColumn[] { tblTalles.Columns["value_name"] };
            string value_id_talle = string.Empty;
            PublicarVariacion publicarVariacion = new PublicarVariacion();
            publicarVariacion.title = txtTitulo.Text;
            publicarVariacion.category_id = categoria;
            publicarVariacion.price = Convert.ToInt32(txtPrecio.Text);
            publicarVariacion.currency_id = "ARS";
            publicarVariacion.buying_mode = "buy_it_now";
            publicarVariacion.listing_type_id = "gold_special";
            string condicion;
            if (rdNuevo.Checked) condicion = "new";
            else condicion = "used";
            publicarVariacion.condition = condicion;
            publicarVariacion.description = "<div align =\"center\"><img src=\"https://trendsistemas.com/ml_images/descripcion_calzado_html.jpg\" alt=\"\" /></div>";

            var listVariaciones = new List<variations>();
            foreach (DataRow rowPublicar in tblPublicar.Rows)
            {
                string color = rowPublicar["DescripcionCOL"].ToString();
                string talle = rowPublicar["TalleART"].ToString();
                DataRow foundColor = tblColores.Rows.Find(color);
                DataRow foundTalle = tblTalles.Rows.Find(talle);
                if (foundColor != null)
                {
                    variations variacion = new variations();
                    List<attribute_combinations> attributes = new List<attribute_combinations>();
                    attribute_combinations colores = new attribute_combinations
                    {
                        id = "83000",
                        value_id = foundColor["value_id"].ToString(),
                    };
                    attributes.Add(colores);
                    if (!string.IsNullOrEmpty(value_id_talle))
                    {
                        attribute_combinations talles = new attribute_combinations
                        {
                            id = "73002",
                            value_id = value_id_talle,
                        };
                        attributes.Add(talles);
                    }
                    else
                    {
                        attribute_combinations talles = new attribute_combinations
                        {
                            id = "73002",
                            value_id = "82096",
                        };
                        attributes.Add(talles);                        
                    }
                    variacion.attribute_combinations = attributes;
                    List<string> imagenes = new List<string>();
                    if (!string.IsNullOrEmpty(rowPublicar["url_1"].ToString()))
                    {
                        imagenes.Add(rowPublicar["url_1"].ToString());
                    }
                    if (!string.IsNullOrEmpty(rowPublicar["url_2"].ToString()))
                    {
                        imagenes.Add(rowPublicar["url_2"].ToString());
                    }
                    if (!string.IsNullOrEmpty(rowPublicar["url_3"].ToString()))
                    {
                        imagenes.Add(rowPublicar["url_3"].ToString());
                    }
                    if (!string.IsNullOrEmpty(rowPublicar["url_4"].ToString()))
                    {
                        imagenes.Add(rowPublicar["url_4"].ToString());
                    }
                    variacion.picture_ids = imagenes;
                    variacion.seller_custom_field = rowPublicar["IdArticuloART"].ToString().Substring(0, 6);
                    variacion.available_quantity = Convert.ToInt32(rowPublicar["Stock"].ToString());
                    variacion.price = Convert.ToInt32(txtPrecio.Text);
                    listVariaciones.Add(variacion);
                }
                else
                {
                    MessageBox.Show("El color '" + rowPublicar["DescripcionCOL"].ToString() + "' no existe en Mercado Libre."
                         + '\r' + "No se publicará el producto.", "Trend", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
            }
            publicarVariacion.variations = listVariaciones;
            string json = new JavaScriptSerializer().Serialize(publicarVariacion);
            return json;
        }

    }
}
