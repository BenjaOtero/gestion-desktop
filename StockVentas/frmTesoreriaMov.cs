﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace StockVentas
{
    public partial class frmTesoreriaMov : Form
    {
        DataSet dsTesoreriaMov;
        DataTable tblTesoreriaMov;
        DataTable tblLocales;
        DataTable tblPcs;
        DataView viewLocal;
        DataView viewPc; 
        private int idLocal;
        private int idPc;
        private string PK = string.Empty;
        string registroNuevo;
        DateTime fecha;

        public frmTesoreriaMov()
        {
            InitializeComponent();
            tblTesoreriaMov = BL.TesoreriaMovimientosBLL.GetTabla();
        }

        public frmTesoreriaMov(int idLocal, int idPc, string PK, DataTable tblTesoreria)
        {
            InitializeComponent();
            this.idLocal = idLocal;
            this.idPc = idPc;
            this.PK = PK;
            this.tblTesoreriaMov = tblTesoreria;
        }

        private void frmTesoreriaMov_Load(object sender, EventArgs e)
        {
            this.Location = new Point(50, 50);
            System.Drawing.Icon ico = Properties.Resources.icono_app;
            this.Icon = ico;
            this.ControlBox = true;
            this.MaximizeBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            dsTesoreriaMov = new DataSet();
            dsTesoreriaMov.DataSetName = "dsTesoreriaMov";
            if (tblTesoreriaMov.DataSet == null)
            {
                dsTesoreriaMov.Tables.Add(tblTesoreriaMov);
            }                
            tblLocales = BL.GetDataBLL.Locales();
            viewLocal = new DataView(tblLocales);
            viewLocal.RowFilter = "IdLocalLOC <>'1' AND IdLocalLOC <>'2' AND IdLocalLOC <>'11' AND IdLocalLOC <>'12'";
            lstLocales.ValueMember = "IdLocalLOC";
            lstLocales.DisplayMember = "NombreLOC";
            lstLocales.DataSource = viewLocal;
            tblPcs = BL.GetDataBLL.Pc();
            string local = lstLocales.SelectedValue.ToString();
            viewPc = new DataView(tblPcs);
            viewPc.RowFilter = "IdLocalPC = '" + local + "'";
            viewPc.Sort = "Detalle ASC";
            lstPc.ValueMember = "IdPC";
            lstPc.DisplayMember = "Detalle";
            lstPc.DataSource = viewPc;                           
            // agrego el DefaultValue porque al agregar un registro ( bindingSource1.AddNew()) si el campo FechaTESM es nulo no trabaja bien
            tblTesoreriaMov.Columns["FechaTESM"].DefaultValue = DateTime.Now;
            bindingSource1.DataSource = tblTesoreriaMov;
            bindingNavigator1.BindingSource = bindingSource1;
            lblClave.DataBindings.Add("Text", bindingSource1, "IdMovTESM", false, DataSourceUpdateMode.OnPropertyChanged);
            dateTimePicker1.DataBindings.Add("Value", bindingSource1, "FechaTESM", false, DataSourceUpdateMode.OnPropertyChanged);
            lstPc.DataBindings.Add("SelectedValue", bindingSource1, "IdPcTESM", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDetalle.DataBindings.Add("Text", bindingSource1, "DetalleTESM", false, DataSourceUpdateMode.OnPropertyChanged);
            txtImporte.DataBindings.Add("Text", bindingSource1, "ImporteTESM", false, DataSourceUpdateMode.OnPropertyChanged);
            if (PK == "")
            {
                AgregarNuevo();
            }
            else
            {
                lstLocales.SelectedValue = idLocal;
                lstPc.SelectedValue = idPc;
                lblClave.Text = PK;                
                bindingSource1.Filter = "IdMovTESM = '" + PK + "'";
            }
            lblClave.ForeColor = System.Drawing.Color.DarkRed;
            txtDetalle.KeyDown += new System.Windows.Forms.KeyEventHandler(BL.Utilitarios.EnterTab);
            txtImporte.KeyDown += new System.Windows.Forms.KeyEventHandler(BL.Utilitarios.EnterTab);
            txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(BL.Utilitarios.SoloNumerosConComa);
            txtDetalle.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (lstPc.SelectedIndex == -1)
            {                
                MessageBox.Show("Debe seleccionar una caja.", "Trend", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDetalle.Text == "")
            {
                MessageBox.Show("Debe escribir un detalle", "Trend", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDetalle.Focus();
                return;
            }
            if (txtImporte.Text == "")
            {
                MessageBox.Show("Debe escribir un importe", "Trend", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtImporte.Focus();
                return;
            }
            bindingSource1.EndEdit();
            if (PK == "")
            {
                AgregarNuevo();
            }
            else
            {
                Close(); 
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstLocales_SelectedValueChanged(object sender, EventArgs e)
        {
            string local = lstLocales.SelectedValue.ToString();
            viewPc = new DataView(tblPcs);
            viewPc.RowFilter = "IdLocalPC = '" + local + "'";
            viewPc.Sort = "Detalle ASC";
            lstPc.ValueMember = "IdPC";
            lstPc.DisplayMember = "Detalle";
            lstPc.DataSource = viewPc;
        }        

        private void frmTesoreriaMov_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (registroNuevo == lblClave.Text && txtDetalle.Text == string.Empty && txtImporte.Text == string.Empty)
            {
                bindingSource1.Remove(bindingSource1.Current);
            }            
            bindingSource1.EndEdit();
            if (tblTesoreriaMov.GetChanges() != null)
            {
                if (!BL.UtilDB.ValidarServicioMysql())
                {
                    MessageBox.Show("NO SE ACTUALIZARON LOS DATOS." + '\r' + "No se pudo conectar con el servidor de base de datos."
                            + '\r' + "Consulte al administrador del sistema.", "Trend Sistemas", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return;
                }
                BL.TesoreriaMovimientosBLL.GrabarDB(dsTesoreriaMov);
            }
        }

        private void AgregarNuevo()
        {
            this.lstLocales.SelectedValueChanged -= new System.EventHandler(this.lstLocales_SelectedValueChanged);
            bindingSource1.AddNew();
            Random rand = new Random();
            int clave = rand.Next(-2000000000, 2000000000);
            registroNuevo = clave.ToString();
            lblClave.Text = registroNuevo;
            dateTimePicker1.Value = DateTime.Now;
            if (lstPc.Items.Count > 0) lstPc.SetSelected(0, true);   
            txtDetalle.Focus();
            this.lstLocales.SelectedValueChanged += new System.EventHandler(this.lstLocales_SelectedValueChanged);

        }

        private void Grabar()
        {
            fecha = dateTimePicker1.Value;
            int mes = fecha.Month;
            int dia = fecha.Day;
            int year = fecha.Year;
            int hora = DateTime.Now.Hour;
            int minutos = DateTime.Now.Minute;
            int segundos = DateTime.Now.Second;
            fecha = new DateTime(year, mes, dia, hora, minutos, segundos);
            dateTimePicker1.Value = fecha;

        }

    }
}
