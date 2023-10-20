using ProiectPAW2023_Tursim.Classes;
using ProiectPAW2023_Tursim.Forms.FormulareAdd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

using System.Threading;

namespace ProiectPAW2023_Tursim.Base
{
    public partial class Tranzactii : Form
    {
  
    
   public DataTable dt=new DataTable();

        public Tranzactii()
        {
            InitializeComponent();
            
        }

     

        private void btnAddTranzactie_Click(object sender, EventArgs e)
        {
            FormularAdaugaTranzactie formularAdaugaTranzactie = new FormularAdaugaTranzactie(this);
            formularAdaugaTranzactie.ShowDialog();
        }

        private void btnViewTranzactii_Click(object sender, EventArgs e)
        {
           
            
        }

        private void Tranzactii_Load(object sender, EventArgs e)
        {
            Tranzactie t1 = new Tranzactie(1, 2342, 3, 3, new DateTime(2022, 10, 15));
            Tranzactie t2 = new Tranzactie(2, 3340, 2, 2, new DateTime(2021, 10, 15));
            Tranzactie t3 = new Tranzactie(3, 1014, 3, 4, new DateTime(2020, 10, 15));
            Tranzactie t4 = new Tranzactie(4, 2200, 1, 3, new DateTime(2019, 10, 15));
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Valoare", typeof(int));
            dt.Columns.Add("IdClient", typeof(int));
            dt.Columns.Add("IdServiciu", typeof(int));
            dt.Columns.Add("Data", typeof(DateTime));

            dt.Rows.Add(t1.CodTranzactie, t1.ValoareTranzactie, t1.CodClientAsociat, t1.CodServiciuAsociat, t1.DataTranzactie);
            dt.Rows.Add(t2.CodTranzactie, t2.ValoareTranzactie, t2.CodClientAsociat, t2.CodServiciuAsociat, t2.DataTranzactie);
            dt.Rows.Add(t3.CodTranzactie, t3.ValoareTranzactie, t3.CodClientAsociat, t3.CodServiciuAsociat, t3.DataTranzactie);
            dt.Rows.Add(t4.CodTranzactie, t4.ValoareTranzactie, t4.CodClientAsociat, t4.CodServiciuAsociat, t4.DataTranzactie);

            dgvTranzactii.DataSource = dt;


        }

        private void dgvTranzactii_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idTranzactie = Convert.ToInt32(dgvTranzactii.Rows[e.RowIndex].Cells[0].Value.ToString());
            float valoareTranzactie = (float)Convert.ToDouble(dgvTranzactii.Rows[e.RowIndex].Cells[1].Value.ToString());
            int codCllient = Convert.ToInt32(dgvTranzactii.Rows[e.RowIndex].Cells[2].Value.ToString());
            int codServiciu = Convert.ToInt32(dgvTranzactii.Rows[e.RowIndex].Cells[3].Value.ToString());
            DateTime dataTranzactie = Convert.ToDateTime(dgvTranzactii.Rows[e.RowIndex].Cells[4].Value.ToString());
        }


        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgvTranzactii.CurrentCell.RowIndex;
            dgvTranzactii.Rows.RemoveAt(index);

        }

        private void tXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (TextWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine();

                        for (int i = 0; i < dgvTranzactii.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvTranzactii.Columns.Count; j++)
                            {
                                writer.Write(dgvTranzactii.Rows[i].Cells[j].Value.ToString());
                                if (j < dgvTranzactii.Columns.Count - 1)
                                    writer.Write("|");
                            }
                            writer.WriteLine();
                        }
                    }

                    MessageBox.Show("Salvarea în fișier s-a produs cu succes");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare la salvarea în fișier text: " + ex.Message);
            }
        }

        private Bitmap bmp;

        private void printDocumentTranzactii_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dgvTranzactii.Width, dgvTranzactii.Height);
            dgvTranzactii.DrawToBitmap(imagebmp, new Rectangle(0, 0, imagebmp.Width, imagebmp.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocumentTranzactii.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(30, 20, 10, 10);

            printPreviewDialogTranzactii.Document = printDocumentTranzactii;
            printPreviewDialogTranzactii.PrintPreviewControl.Zoom = 1;
            printPreviewDialogTranzactii.ShowDialog();
        }

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            foreach(DataGridViewColumn column in dgv.Columns)
            {
                if(column.Visible)
                {
                    dt.Columns.Add();
                }
            }
            object[] cellValues=new object[dgvTranzactii.Columns.Count];
            foreach(DataGridViewRow row in dgvTranzactii.Rows)
            {
                for(int i=0;i<row.Cells.Count;i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            return dt;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataTable dt2 = GetDataTableFromDGV(dgvTranzactii);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt2);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.DefaultExt = "xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (FileStream fileStream = File.OpenWrite(filePath))
                {
                    ds.WriteXml(fileStream);
                }

            }
        }

            private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                DataSet ds = new DataSet();
                ds.ReadXml(filePath);

                if (ds.Tables.Count > 0)
                {
                    dgvTranzactii.DataSource = ds.Tables[0];
                }
            }
        }

        public DataTable GetTranzactiiData()
        {
            DataTable dt = new DataTable();
            // Obțineți datele din dgvTranzactii și le atribuiți la dt
            dt = (DataTable)dgvTranzactii.DataSource;
            return dt;
        }
    }
}
