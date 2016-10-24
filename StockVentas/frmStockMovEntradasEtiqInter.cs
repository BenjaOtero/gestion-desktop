using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockVentas
{
    public partial class frmStockMovEntradasEtiqInter : Form
    {
        public frmStockMovEntradasEtiqInter()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmStockMovInforme);
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
