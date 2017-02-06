using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Drawing.Text;
using System.Web;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using MercadoLibre.SDK;
using HttpParamsUtility;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;

namespace StockVentas.Mercado_Libre
{
    public partial class frmPublicar : Form
    {
        public frmPublicar()
        {
            InitializeComponent();
        }
    }
}
