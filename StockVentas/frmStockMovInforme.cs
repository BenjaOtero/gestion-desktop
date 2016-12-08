using System;
using System.Data;
using System.Windows.Forms;

namespace StockVentas
{
    public partial class frmStockMovInforme : Form, IfrmStockMovInforme
    {
        public DataSet dsStockMov;
        DataTable tblStockMov;
        DataTable tblStockMovDetalle;
        DataTable tblLocales;
        DataView viewStockMov;
        private string tipo;
        string articulo;
        string descripcion;
        int PK;
        frmProgress progreso;
        private int? codigoError = null;
        DataRowCollection cfilas;
        DataRow nuevaFila;


        public frmStockMovInforme(DataSet dsStockMov, string tipo, string articulo, string descripcion)
        {
            InitializeComponent();
            this.dsStockMov = dsStockMov;
            this.tipo = tipo;
            this.articulo = articulo;
            this.descripcion = descripcion;
        }

        private void frmStockMovInforme_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Cursor.Current = Cursors.WaitCursor;
            System.Drawing.Icon ico = Properties.Resources.icono_app;
            this.Icon = ico;
            this.ControlBox = true;
            this.MaximizeBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            try
            {
                tblStockMov = dsStockMov.Tables[0];
            }
            catch (NullReferenceException)
            {
                return;
            }
            tblStockMov.TableName = "StockMov";
            tblStockMovDetalle = dsStockMov.Tables[1];
            tblStockMovDetalle.TableName = "StockMovDetalle";
            if (tipo == "compensaciones")
            {
                label1.Text = "Compensaciones de stock";
                label2.Text = "Detalle de compensaciones";
                this.Text = "Informe de compensaciones de stock";
            }
            tblLocales = BL.GetDataBLL.Locales();
            tblLocales.PrimaryKey = new DataColumn[] { tblLocales.Columns["IdLocalLOC"] };
            tblStockMov.Columns.Add("Origen", typeof(string));
            tblStockMov.Columns.Add("Destino", typeof(string));
            viewStockMov = new DataView(tblStockMov);
            int local;
            foreach (DataRowView fila in viewStockMov)
            {
                local = Convert.ToInt32(fila["OrigenMSTK"].ToString());
                DataRow foundRow = tblLocales.Rows.Find(local);
                fila["Origen"] = foundRow[1].ToString();
                local = Convert.ToInt32(fila["DestinoMSTK"].ToString());
                DataRow foundRow2 = tblLocales.Rows.Find(local);
                fila["Destino"] = foundRow2[1].ToString();
            }
            dgvStockMov.AllowUserToAddRows = false;
            bindingSource1.DataSource = dsStockMov;
            bindingSource1.DataMember = dsStockMov.Tables[0].ToString();
            bindingNavigator1.BindingSource = bindingSource1;
            dgvStockMov.DataSource = bindingSource1;
            dgvStockMov.Sort(this.dgvStockMov.Columns["OrdenarMSTK"], System.ComponentModel.ListSortDirection.Ascending);
            dgvStockMov.Columns["OrdenarMSTK"].Visible = false;
            dgvStockMov.Columns["CompensaMSTK"].Visible = false;
            dgvStockMov.Columns["OrigenMSTK"].Visible = false;
            dgvStockMov.Columns["DestinoMSTK"].Visible = false;
            if (tipo == "compensaciones")
            {
                dgvStockMov.Columns["Origen"].Visible = false;
                dgvStockMov.Columns["Destino"].HeaderText = "Local";
            }
            dgvStockMov.Columns["IdMovMSTK"].HeaderText = "Nº mov.";
            dgvStockMov.Columns["FechaMSTK"].HeaderText = "Fecha";
            dgvStockMov.Columns["DestinoMSTK"].Visible = false;
            dgvStockMov.ReadOnly = true;
            bindingSource2.DataSource = bindingSource1;
            bindingSource2.DataMember = "StockMovDetalle"; // StockMovDetalle es el nombre de la DataRelation creada en CrearDatasetCons en StockMov.BLL
            bindingSource2.Sort = "ordenar ASC";
            bindingNavigator2.BindingSource = bindingSource2;
            dgvStockDet.DataSource = bindingSource2;
            bindingSource2.Sort = "ordenar ASC";
        //    dgvStockDet.Columns["ordenar"].Visible = false;
            dgvStockDet.Columns["IdMovMSTKD"].Visible = false;
            dgvStockDet.Columns["FechaMSTK"].Visible = false;
            dgvStockDet.Columns["CompensaMSTKD"].Visible = false;
            dgvStockDet.Columns["OrigenMSTKD"].Visible = false;
            dgvStockDet.Columns["DestinoMSTKD"].Visible = false;
            dgvStockDet.Columns["IdMSTKD"].HeaderText = "Nº mov.";
            dgvStockDet.Columns["IdArticuloMSTKD"].HeaderText = "Artículo";
            dgvStockDet.Columns["DescripcionART"].HeaderText = "Descripción";
            dgvStockDet.Columns["CantidadMSTKD"].HeaderText = "Cantidad";
            dgvStockMov.Focus();
            dgvStockMov.Rows[0].Selected = true;
            Cursor.Current = Cursors.Arrow;
        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(articulo) || !string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Las opciones 'Modificar' y/o 'Borrar' no están disponibles cuando se usaron criterios de búsqueda",
                    "Trend Gestión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dsStockMov.Tables[0].Rows.Count == 0) return;
            if (tipo == "movimientos")
            {
                frmStockMov frm = new frmStockMov(dsStockMov);
                frm.PK = dgvStockMov.CurrentRow.Cells["IdMovMSTK"].Value.ToString();
                frm.ShowDialog();
            }
            else
            {
                frmStockComp frm = new frmStockComp(dsStockMov);
                frm.PK = dgvStockMov.CurrentRow.Cells["IdMovMSTK"].Value.ToString();
                frm.ShowDialog();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(articulo) || !string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Las opciones 'Modificar' y/o 'Borrar' no están disponibles cuando se usaron criterios de búsqueda",
                    "Trend Gestión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dsStockMov.Tables[0].Rows.Count == 0) return;
            if (MessageBox.Show("¿Desea borrar este registro y todos los movimientos relacionados?", "Trend Gestión",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                if (!BL.UtilDB.ValidarServicioMysql())
                {
                    MessageBox.Show("NO SE BORRARON LOS DATOS." + '\r' + "No se pudo conectar con el servidor de base de datos."
                            + '\r' + "Consulte al administrador del sistema.", "Trend Sistemas", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return;
                }
                Cursor.Current = Cursors.WaitCursor;
                PK = Convert.ToInt32(dgvStockMov.CurrentRow.Cells["IdMovMSTK"].Value.ToString());
                progreso = new frmProgress(PK, "frmStockMov_borrar", "grabar");
                progreso.ShowDialog();
                if (codigoError != null)
                {
                    Close();
                    return;
                }
                viewStockMov.RowFilter = "IdMovMSTK = '" + PK + "'";
                foreach (DataRowView row in viewStockMov)
                {
                    row.Delete();
                }
                tblStockMov.AcceptChanges();
                Cursor.Current = Cursors.Arrow;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmStockMovEntradasEtiqInter frm = new frmStockMovEntradasEtiqInter();
            frm.ShowDialog(this);
            SendToBack();
        }

        public void ImprimirEtiquetas(string impresora)
        {
            DataView viewStockMovDetalle = new DataView(tblStockMovDetalle);
            string pk = dgvStockMov.CurrentRow.Cells["IdMovMSTK"].Value.ToString();
            viewStockMovDetalle.RowFilter = "IdMovMSTKD = '" + pk + "'";
            viewStockMovDetalle.Sort = "ordenar";
            DataTable tblEntradasDetalle = viewStockMovDetalle.ToTable();
            DataTable tblEtiquetas;
            if (impresora == "laser")
            {
                tblEtiquetas = TablaEtiquetas("laser");
                int nroEtiqueta;
                DataRow rowEnBlanco;
                reintentar:
                try
                {
                    nroEtiqueta = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el número de etiqueta por la cual empezar a imprimir.",
                     "Titulo del diálogo", "1"));
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor numérico", "Trend Gestión");
                    goto reintentar;
                }
                if (nroEtiqueta > 1)
                {
                    rowEnBlanco = tblEntradasDetalle.NewRow();
                    rowEnBlanco["CantidadMSTKD"] = nroEtiqueta - 1;
                    tblEntradasDetalle.Rows.InsertAt(rowEnBlanco, 0);
                }
                tblEtiquetas = TablaEtiquetas("laser");
                int columna = 1;
                foreach (DataRow row in tblEntradasDetalle.Rows)
                {
                    int x = Convert.ToInt32(row["CantidadMSTKD"].ToString());
                    int i;
                    for (i = 0; i < x; i++)
                    {
                        if (columna == 1)
                        {
                            nuevaFila = tblEtiquetas.NewRow();
                            if (!string.IsNullOrEmpty(row["IdArticuloMSTKD"].ToString())) nuevaFila[0] = "*" + row["IdArticuloMSTKD"].ToString() + "*";
                            nuevaFila[1] = row["DescripcionART"].ToString();
                            nuevaFila[2] = "";
                            columna = 2;
                        }
                        else if (columna == 2)
                        {
                            if (!string.IsNullOrEmpty(row["IdArticuloMSTKD"].ToString())) nuevaFila[3] = "*" + row["IdArticuloMSTKD"].ToString() + "*";
                            nuevaFila[4] = row["DescripcionART"].ToString();
                            nuevaFila[5] = "";
                            columna = 3;
                        }
                        else if (columna == 3)
                        {
                            if (!string.IsNullOrEmpty(row["IdArticuloMSTKD"].ToString())) nuevaFila[6] = "*" + row["IdArticuloMSTKD"].ToString() + "*";
                            nuevaFila[7] = row["DescripcionART"].ToString();
                            nuevaFila[8] = "";
                            columna = 4;
                        }
                        else if (columna == 4)
                        {
                            if (!string.IsNullOrEmpty(row["IdArticuloMSTKD"].ToString())) nuevaFila[9] = "*" + row["IdArticuloMSTKD"].ToString() + "*";
                            nuevaFila[10] = row["DescripcionART"].ToString();
                            nuevaFila[11] = "";
                            cfilas.Add(nuevaFila);
                            nuevaFila = null;
                            columna = 1;
                        }
                    }
                }
                if (nuevaFila != null)
                {
                    nuevaFila[3] = string.Empty;
                    nuevaFila[4] = string.Empty;
                    nuevaFila[5] = string.Empty;
                    cfilas.Add(nuevaFila);
                }
                tblEntradasDetalle.Rows.RemoveAt(0);
                EtiquetasA4Rpt informeEtiquetas = new EtiquetasA4Rpt(tblEtiquetas);
                informeEtiquetas.Show();
            }
            else
            {
                tblEtiquetas = TablaEtiquetas("termica");
                int columna = 1;
                foreach (DataRow row in tblEntradasDetalle.Rows)
                {
                    int x = Convert.ToInt32(row["CantidadMSTKD"].ToString());
                    int i;
                    for (i = 0; i < x; i++)
                    {
                        if (columna == 1)
                        {
                            nuevaFila = tblEtiquetas.NewRow();
                            nuevaFila[0] = "*" + row["IdArticuloMSTKD"].ToString() + "*";
                            nuevaFila[1] = row["DescripcionART"].ToString();
                            nuevaFila[2] = "";
                            columna = 2;
                        }
                        else if (columna == 2)
                        {
                            nuevaFila[3] = "*" + row["IdArticuloMSTKD"].ToString() + "*";
                            nuevaFila[4] = row["DescripcionART"].ToString();
                            nuevaFila[5] = "";
                            cfilas.Add(nuevaFila);
                            nuevaFila = null;
                            columna = 1;
                        }
                    }
                }
                if (nuevaFila != null)
                {
                    nuevaFila[3] = string.Empty;
                    nuevaFila[4] = string.Empty;
                    nuevaFila[5] = string.Empty;
                    cfilas.Add(nuevaFila);
                }
                EtiquetasRpt frm = new EtiquetasRpt(tblEtiquetas, false);
                frm.Show();
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void dgvStockMov_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }

        private DataTable TablaEtiquetas(string tipoImpresora)
        {
            DataTable tblEtiquetas = new DataTable();
            if (tipoImpresora == "laser")
            {
                tblEtiquetas.Columns.Add("IdArticuloMSTKD", typeof(string));
                tblEtiquetas.Columns.Add("DescripcionART", typeof(string));
                tblEtiquetas.Columns.Add("Precio", typeof(string));
                tblEtiquetas.Columns.Add("IdArticuloMSTKD1", typeof(string));
                tblEtiquetas.Columns.Add("DescripcionART1", typeof(string));
                tblEtiquetas.Columns.Add("Precio1", typeof(string));
                tblEtiquetas.Columns.Add("IdArticuloMSTKD2", typeof(string));
                tblEtiquetas.Columns.Add("DescripcionART2", typeof(string));
                tblEtiquetas.Columns.Add("Precio2", typeof(string));
                tblEtiquetas.Columns.Add("IdArticuloMSTKD3", typeof(string));
                tblEtiquetas.Columns.Add("DescripcionART3", typeof(string));
                tblEtiquetas.Columns.Add("Precio3", typeof(string));
                cfilas = tblEtiquetas.Rows;
            }
            else
            {
                tblEtiquetas.Columns.Add("IdArticuloMSTKD", typeof(string));
                tblEtiquetas.Columns.Add("DescripcionART", typeof(string));
                tblEtiquetas.Columns.Add("Precio", typeof(string));
                tblEtiquetas.Columns.Add("IdArticuloMSTKD1", typeof(string));
                tblEtiquetas.Columns.Add("DescripcionART1", typeof(string));
                tblEtiquetas.Columns.Add("Precio1", typeof(string));
                cfilas = tblEtiquetas.Rows;
            }
            return tblEtiquetas;
        }

    }
}
