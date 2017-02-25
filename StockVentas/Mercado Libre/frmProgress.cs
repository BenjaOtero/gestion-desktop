using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using MercadoLibre.SDK;
using HttpParamsUtility;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;

namespace StockVentas.Mercado_Libre
{
    public partial class frmProgress : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;  //junto con protected override CreateParams inhabilitan el boton cerrar de frmProgress
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        BackgroundWorker bckWorker = new BackgroundWorker();
        string tarea;
        MeliApiService meli;
        DataGridView dgvDatos = new DataGridView();


        public frmProgress()
        {
            InitializeComponent();
        }

        public frmProgress(string tarea, MeliApiService meli, DataGridView dgvDatos)
        {
            InitializeComponent();
            this.tarea = tarea;
            this.meli = meli;
            this.dgvDatos = dgvDatos;
            bckWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bckWorker_DoWork);
        }

        private void frmProgress_Shown(object sender, EventArgs e)
        {
            this.CenterToScreen();
            if (tarea == "subirImagenes")
            {
                label1.Text = "Subiendo imagenes al servidor web...";
                label1.Left = 108;
            }
            bckWorker.RunWorkerAsync();
        }


        private void bckWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DataTable tblPublicar = new DataTable();
            tblPublicar = (DataTable)dgvDatos.DataSource;
            DataRow[] result = tblPublicar.Select("Publicar = 1");
            foreach (DataRow row in result)
            {
                if (row["url_1"] != null || row["url_1"].ToString() != string.Empty)
                {

                }
            }

            foreach (DataGridViewRow rowView in dgvDatos.Rows)
            {
                if (!rowView.IsNewRow)
                {
                    if (rowView.Cells["url_1"].Value != null || rowView.Cells["url_1"].Value.ToString() != string.Empty)
                    {
                        //string imagen = spl
                        string[] separados;
                        separados = rowView.Cells["url_1"].Value.ToString().Split(@"\".ToCharArray());
                        string imagen = separados[separados.Count() - 2] + "." + separados[separados.Count() - 1];
                        BL.UtilFTP.UploadFromFile(rowView.Cells["url_1"].Value.ToString(), "/images_ml/" + imagen);
                    }
                }

            }
        }
    }
}
