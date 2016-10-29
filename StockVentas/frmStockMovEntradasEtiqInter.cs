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
            IfrmStockMovInforme formInterface = this.Owner as IfrmStockMovInforme;
            if (formInterface != null)
            {
                if(rdLaser.Checked)
                    formInterface.ImprimirEtiquetas("laser");
                else
                    formInterface.ImprimirEtiquetas("termica");
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
