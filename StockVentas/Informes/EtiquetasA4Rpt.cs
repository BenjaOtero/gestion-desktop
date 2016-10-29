using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;

namespace StockVentas
{
    public partial class EtiquetasA4Rpt : Form
    {
        private DataTable tblEtiquetas;

        public EtiquetasA4Rpt(DataTable tblEtiquetas)
        {
            InitializeComponent();
            this.tblEtiquetas = tblEtiquetas;
        }

        private void EtiquetasA4Rpt_Load(object sender, EventArgs e)
        {
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            string path;
            path = Application.StartupPath + @"\Informes\EtiquetasA4.rdlc";
            this.reportViewer1.LocalReport.ReportPath = path;
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Dataset_informes", tblEtiquetas));
            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            pg.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0); //centesimas de pulgada
            pg.PaperSize = new PaperSize("A4", 827, 1169); // 8.27 in x 11.69 in
            pg.PrinterResolution.Kind = System.Drawing.Printing.PrinterResolutionKind.High;
            this.reportViewer1.SetPageSettings(pg);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }
    }
}
