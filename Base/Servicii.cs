using ProiectPAW2023_Tursim.Classes;
using ProiectPAW2023_Tursim.Forms.FormulareAdd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW2023_Tursim.Forms
{
    public partial class Servicii : Form
    {
        public DataTable dt = new DataTable();
        public Servicii()
        {
            InitializeComponent();
        }

        private void Servicii_Load(object sender, EventArgs e)
        {
            string[] activitati1 = { "safari", "acces la resort" };
            Serviciu s1 = new Serviciu(1, "Dubai", (float)230.9, 5, 2, "D1", activitati1, new DateTime(2020, 06, 06));
            Serviciu s2 = new Serviciu(2, "Tokyo", (float)340.9, 4, 2, "D1", activitati1, new DateTime(2019, 03, 08));
            Serviciu s3 = new Serviciu(3, "Maldive", (float)290.9, 3, 2, "D1", activitati1, new DateTime(2021, 12, 07));
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Locatie", typeof(string));
            dt.Columns.Add("Pret", typeof(float));
            dt.Columns.Add("NrZile", typeof(int));
            dt.Columns.Add("NrPersoane", typeof(int));
            dt.Columns.Add("Hotel", typeof(string));
            dt.Columns.Add("DataRezervare", typeof(DateTime));
            dt.Rows.Add(s1.IdServiciu,s1.NumeDestinatie,s1.PretZi,s1.NrZile,s1.NrPers,s1.Hotel,s1.DataInceput);
            dt.Rows.Add(s2.IdServiciu,s2.NumeDestinatie,s2.PretZi,s2.NrZile,s2.NrPers,s2.Hotel,s2.DataInceput);
            dt.Rows.Add(s3.IdServiciu,s3.NumeDestinatie,s3.PretZi,s3.NrZile,s3.NrPers,s3.Hotel,s3.DataInceput);
           
            dgvServicii.DataSource = dt;
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
                    dgvServicii.DataSource = ds.Tables[0];
                }
            }
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

                        for (int i = 0; i < dgvServicii.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvServicii.Columns.Count; j++)
                            {
                                writer.Write(dgvServicii.Rows[i].Cells[j].Value.ToString());
                                if (j < dgvServicii.Columns.Count - 1)
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

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add();
                }
            }
            object[] cellValues = new object[dgvServicii.Columns.Count];
            foreach (DataGridViewRow row in dgvServicii.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            return dt;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            DataTable dt2 = GetDataTableFromDGV(dgvServicii);
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

        private void btnAddServiciu_Click(object sender, EventArgs e)
        {
            FormularAddServiciu formularAddServiciu = new FormularAddServiciu(this);
            formularAddServiciu.ShowDialog();
        }
        private Bitmap bmp;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocumentServicii.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(30, 20, 10, 10);

            printPreviewDialogServicii.Document = printDocumentServicii;
            printPreviewDialogServicii.PrintPreviewControl.Zoom = 1;
            printPreviewDialogServicii.ShowDialog();
        }

        private void printDocumentServicii_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dgvServicii.Width, dgvServicii.Height);
            dgvServicii.DrawToBitmap(imagebmp, new Rectangle(0, 0, imagebmp.Width, imagebmp.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }
    }
}
