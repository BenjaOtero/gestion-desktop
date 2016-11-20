using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Entities;
using System.Collections.Generic;

namespace StockVentas
{
    public partial class frmArticulosGenerarApartir : Form
    {
        public DataSet dtArticulos = null;
        public DataSet dtStock;
        private DataTable tblArticulos;
        private DataTable tblColores;
        private DataTable tblProveedores;
        private DataView viewColores;
        private Articulos entidad;
        string strDescripcion;
        string strDescripcionNueva;
        string codigo;
        private BindingSource bindingSource;
        Dictionary<Int32, String> tallesAmericanos;

        public frmArticulosGenerarApartir()
        {
            InitializeComponent();
        }

        public frmArticulosGenerarApartir(BindingSource bindingSource)
        {
            InitializeComponent();
            this.bindingSource = bindingSource;
            bindingSource.RemoveFilter();
            txtDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(BL.Utilitarios.EnterTab);
            txtHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(BL.Utilitarios.EnterTab);
            cmbTalleDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(BL.Utilitarios.EnterTab);
            cmbTalleHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(BL.Utilitarios.EnterTab);
            txtDesde.Enter += new System.EventHandler(BL.Utilitarios.SelTextoTextBox);
            txtHasta.Enter += new System.EventHandler(BL.Utilitarios.SelTextoTextBox);
            txtDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(BL.Utilitarios.SoloNumeros);
            txtHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(BL.Utilitarios.SoloNumeros);
        }

        private void frmArticulosGenerarApartir_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            System.Drawing.Icon ico = Properties.Resources.icono_app;
            this.Icon = ico;
            this.ControlBox = true;
            this.MaximizeBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            tblArticulos = BL.GetDataBLL.Articulos();
            tblArticulos.DefaultView.Sort = "IdArticuloART";
            cmbArticulo.ValueMember = "DescripcionART";
            cmbArticulo.DisplayMember = "IdArticuloART";
            cmbArticulo.DropDownStyle = ComboBoxStyle.DropDown;
            cmbArticulo.DataSource = tblArticulos;
            cmbArticulo.SelectedValue = -1;
            AutoCompleteStringCollection articulosColection = new AutoCompleteStringCollection();
            foreach (DataRow row in tblArticulos.Rows)
            {
                articulosColection.Add(Convert.ToString(row["IdArticuloART"]));
            }
            cmbArticulo.AutoCompleteCustomSource = articulosColection;
            cmbArticulo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbArticulo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tblColores = BL.GetDataBLL.Colores();
            viewColores = new DataView(tblColores);
            viewColores.RowFilter = "IdColorCOL <> 0";
            lstColores.ValueMember = "IdColorCOL";
            lstColores.DisplayMember = "DescripcionCOL";
            lstColores.DataSource = viewColores;
            lstColores.SelectedValue = -1;
            rd1.Checked = true;
            tblProveedores = BL.GetDataBLL.Proveedores();
            tallesAmericanos = new Dictionary<int, string>();
            tallesAmericanos.Add(1, "XXS");
            tallesAmericanos.Add(2, "XS");
            tallesAmericanos.Add(3, "S");
            tallesAmericanos.Add(4, "M");
            tallesAmericanos.Add(5, "L");
            tallesAmericanos.Add(6, "XL");
            tallesAmericanos.Add(7, "XXL");
            cmbTalleDesde.DataSource = new BindingSource(tallesAmericanos, null);
            cmbTalleDesde.DisplayMember = "Value";
            cmbTalleDesde.ValueMember = "Key";
            cmbTalleDesde.SelectedValue = -1;
            cmbTalleHasta.DataSource = new BindingSource(tallesAmericanos, null);
            cmbTalleHasta.DisplayMember = "Value";
            cmbTalleHasta.ValueMember = "Key";
            cmbTalleHasta.SelectedValue = -1;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string idArticulo = null;
            string codigoColor;
            string codigoTalle;
            string nombreColor;
            int incrementar;
            if (ValidarControles())
            {
                Cursor.Current = Cursors.WaitCursor;
                DataRow selectedDataRow = ((DataRowView)cmbArticulo.SelectedItem).Row;
                codigo = selectedDataRow["IdArticuloART"].ToString();
                strDescripcion = cmbArticulo.SelectedValue.ToString();
                string colorTalle = codigo.Substring(codigo.Length - 4);
                string color = colorTalle.Substring(0, 2);
                string talle = colorTalle.Substring(2, 2);
                string[] separados;
                separados = strDescripcion.Split(" ".ToCharArray());
                int totalPalabras = separados.Count();
                int totalPalabrasDescripcionColor = 0;
                if (color != "00")
                {
                    DataRow[] colorEncontrado = tblColores.Select("IdColorCOL = '" + color + "'");
                    string descripcionColor = colorEncontrado[0]["DescripcionCOL"].ToString();
                    string[] separadosDescripcionColor;
                    separadosDescripcionColor = descripcionColor.Split(" ".ToCharArray());
                    totalPalabrasDescripcionColor = separadosDescripcionColor.Count();
                }
                if (color != "00" && talle != "00")
                {
                    totalPalabras = separados.Count() - totalPalabrasDescripcionColor - 1;
                }
                else if (color != "00" && talle == "00")
                {
                    totalPalabras = separados.Count() - totalPalabrasDescripcionColor;
                }
                else if (color == "00" && talle != "00")
                {
                    totalPalabras = separados.Count() - 1;
                }
                else 
                {
                    totalPalabras = separados.Count();
                }
                for (int i = 0; i <totalPalabras; i++)
                {
                    strDescripcionNueva += separados[i] + " ";
                }
                DataRow foundRow = tblArticulos.Rows.Find(codigo);
                DataRow[] foundRow2 = tblProveedores.Select("IdProveedorPRO = '" + foundRow["IdProveedorART"].ToString() + "'");
                entidad = new Articulos();
                entidad.IdItem = Convert.ToInt32(foundRow["IdItemART"].ToString());
                entidad.IdGenero = foundRow["IdGeneroART"].ToString();
                entidad.IdAlicuota = Convert.ToInt32(foundRow["IdAliculotaIvaART"].ToString());
                entidad.IdProveedor = Convert.ToInt32(foundRow["IdProveedorART"].ToString());
                entidad.DescripcionWeb = foundRow["DescripcionWebART"].ToString();
                entidad.PrecioCosto = Convert.ToDecimal(foundRow["PrecioCostoART"].ToString());
                entidad.PrecioPublico = Convert.ToDecimal(foundRow["PrecioPublicoART"].ToString());
                entidad.PrecioMayor = Convert.ToDecimal(foundRow["PrecioMayorART"].ToString()); 
                entidad.Fecha = DateTime.Now;
                entidad.Imagen = "";
                entidad.ImagenBack = "";
                entidad.ImagenColor = "";
           //     entidad.ActivoWeb = Convert.ToInt32(foundRow["ActivoWebART"].ToString());
                entidad.NuevoWeb = Convert.ToInt32(foundRow["NuevoART"].ToString());
                entidad.Proveedor = foundRow2[0]["RazonSocialPRO"].ToString();
                int largoCodigo = codigo.Length - 4;
                codigo = codigo.Substring(0, largoCodigo);
                if (lstColores.SelectedIndices.Count > 0)
                {
                    if (!string.IsNullOrEmpty(txtDesde.Text) || !string.IsNullOrEmpty(cmbTalleDesde.Text))
                    {
                        if (rdNumerico.Checked)
                        {
                            if (rd1.Checked)
                            {
                                incrementar = 1;
                            }
                            else
                            {
                                incrementar = 2;
                            }
                            foreach (DataRowView filaColor in lstColores.SelectedItems)
                            {
                                for (int i = Convert.ToInt32(txtDesde.Text); i <= Convert.ToInt32(txtHasta.Text); i += incrementar)
                                {
                                    codigoColor = filaColor.Row[0].ToString();
                                    nombreColor = filaColor.Row[1].ToString();
                                    if (codigoColor.Length == 1)
                                    {
                                        codigoColor = "0" + codigoColor;
                                    }
                                    codigoTalle = i.ToString();
                                    if (codigoTalle.Length == 1)
                                    {
                                        codigoTalle = "0" + codigoTalle;
                                    }
                                    idArticulo = codigo + codigoColor + codigoTalle;
                                    string descripcion = strDescripcionNueva + nombreColor + " T" + codigoTalle;
                                    entidad.IdArticulo = idArticulo;
                                    entidad.IdColor = Convert.ToInt32(codigoColor);
                                    entidad.Talle = codigoTalle;
                                    entidad.Descripcion = descripcion;
                                    BL.ArticulosBLL.InsertarDT(tblArticulos, entidad);
                                }
                            }
                        }
                        else
                        {
                            incrementar = 1;
                            foreach (DataRowView filaColor in lstColores.SelectedItems)
                            {
                                for (int i = Convert.ToInt32(cmbTalleDesde.SelectedValue); i <= Convert.ToInt32(cmbTalleHasta.SelectedValue); i += incrementar)
                                {
                                    codigoColor = filaColor.Row[0].ToString();
                                    nombreColor = filaColor.Row[1].ToString();
                                    if (codigoColor.Length == 1)
                                    {
                                        codigoColor = "0" + codigoColor;
                                    }
                                    codigoTalle = i.ToString();
                                    if (codigoTalle.Length == 1)
                                    {
                                        codigoTalle = "0" + codigoTalle;
                                    }
                                    string descripcionTalle = "";
                                    tallesAmericanos.TryGetValue(i, out descripcionTalle);
                                    idArticulo = codigo + codigoColor + codigoTalle;
                                    string descripcion = strDescripcionNueva + nombreColor + " " + descripcionTalle;
                                    entidad.IdArticulo = idArticulo;
                                    entidad.IdColor = Convert.ToInt32(codigoColor);
                                    entidad.Talle = codigoTalle;
                                    entidad.Descripcion = descripcion;
                                    BL.ArticulosBLL.InsertarDT(tblArticulos, entidad);
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (DataRowView filaColor in lstColores.SelectedItems)
                        {
                            codigoColor = filaColor.Row[0].ToString();
                            nombreColor = filaColor.Row[1].ToString();
                            if (codigoColor.Length == 1)
                            {
                                codigoColor = "0" + codigoColor;
                            }
                            idArticulo = codigo + codigoColor + "00";
                            string descripcion = strDescripcionNueva + nombreColor;
                            entidad.IdArticulo = idArticulo;
                            entidad.IdColor = Convert.ToInt32(codigoColor);
                            entidad.Talle = "";
                            entidad.Descripcion = descripcion;
                            BL.ArticulosBLL.InsertarDT(tblArticulos, entidad);
                        }
                    }
                }
                else
                {
                    if (txtDesde.Text != "")
                    {
                        if (rd1.Checked)
                        {
                            incrementar = 1;
                        }
                        else
                        {
                            incrementar = 2;
                        }
                        for (int i = Convert.ToInt32(txtDesde.Text); i <= Convert.ToInt32(txtHasta.Text); i += incrementar)
                        {
                            codigoTalle = i.ToString();
                            if (codigoTalle.Length == 1)
                            {
                                codigoTalle = "0" + codigoTalle;
                            }
                            idArticulo = codigo + "00" + codigoTalle;
                            string descripcion = strDescripcionNueva + "T" + codigoTalle;
                            entidad.IdArticulo = idArticulo;
                            entidad.IdColor = 0;
                            entidad.Talle = codigoTalle;
                            entidad.Descripcion = descripcion;
                            BL.ArticulosBLL.InsertarDT(tblArticulos, entidad);
                        }
                    }
                    else
                    {
                        idArticulo = codigo + "00" + "00";
                        string descripcion = strDescripcionNueva;
                        entidad.IdArticulo = idArticulo;
                        entidad.IdColor = 0;
                        entidad.Talle = "";
                        entidad.Descripcion = descripcion;
                        BL.ArticulosBLL.InsertarDT(tblArticulos, entidad);
                    }
                }                
                MessageBox.Show(idArticulo);
                strDescripcionNueva = "";
                txtDesde.Text = "";
                txtHasta.Text = "";
                Cursor.Current = Cursors.Arrow;
            }  
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            frmColores frm = new frmColores();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmArticulosGenerarApartir_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tblArticulos.GetChanges() != null)
            {
                if (!BL.UtilDB.ValidarServicioMysql())
                {
                    MessageBox.Show("NO SE CREARON LOS ARTICULOS." + '\r' + "No se pudo conectar con el servidor de base de datos."
                            + '\r' + "Consulte al administrador del sistema.", "Trend Sistemas", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    tblArticulos.RejectChanges();
                    return;
                }
                frmProgress progreso = new frmProgress(tblArticulos, "frmArticulosGenerar", "grabar");
                progreso.ShowDialog();
            }
        }

        private bool ValidarControles()
        {
            if (String.IsNullOrEmpty(cmbArticulo.Text))
            {
                MessageBox.Show("Debe seleccionar un artículo.", "Trend Gestión");
                cmbArticulo.Focus();
                return false;
            }
            if (txtDesde.Text != "" && txtHasta.Text == "")
            {
                MessageBox.Show("Debe indicar 'HASTA' que talle quiere generar.", "Trend Gestión");
                txtHasta.Focus();
                return false;
            }
            if (txtDesde.Text == "" && txtHasta.Text != "")
            {
                MessageBox.Show("Debe indicar 'DESDE' que talle quiere generar.", "Trend Gestión");
                txtDesde.Focus();
                return false;
            }
            if (txtDesde.Text != "" && txtHasta.Text != "")
            {
                var desde = Convert.ToInt32(txtDesde.Text);
                var hasta = Convert.ToInt32(txtHasta.Text);
                if (desde > hasta)
                {
                    MessageBox.Show("'Desde talle' debe ser menor o igual que 'hasta talle'.", "Trend Gestión");
                    txtDesde.Focus();
                    return false;
                }
            }
            return true;
        }

        private void rdAmericano_Click(object sender, EventArgs e)
        {
            txtDesde.Visible = false;
            txtDesde.Text = string.Empty;
            txtHasta.Visible = false;
            txtHasta.Text = string.Empty;
            cmbTalleDesde.Visible = true;

            cmbTalleDesde.Location = new System.Drawing.Point(92, 330);

            cmbTalleDesde.Size = new System.Drawing.Size(226, 20);
            cmbTalleHasta.Visible = true;
            cmbTalleHasta.Location = new System.Drawing.Point(92, 356);
            cmbTalleHasta.Size = new System.Drawing.Size(226, 20);
            grpIncrementar.Enabled = false;
        }

        private void rdNumerico_Click(object sender, EventArgs e)
        {
            cmbTalleDesde.Visible = false;
            cmbTalleDesde.SelectedValue = -1;
            cmbTalleHasta.Visible = false;
            cmbTalleHasta.SelectedValue = -1;
            txtDesde.Visible = true;
            txtHasta.Visible = true;
            grpIncrementar.Enabled = true;
        }

    }
}
