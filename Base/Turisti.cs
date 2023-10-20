using ProiectPAW2023_Tursim.Classes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.IO;

namespace ProiectPAW2023_Tursim.Forms
{
    public partial class Turisti : Form
    {
        public DataTable dt = new DataTable();
        public Turisti()
        {
            InitializeComponent();
            
        }

        private void Turisti_Load(object sender, EventArgs e)
        {
            Turist t1 = new Turist(1, "Popescu", "Marian", "mPopescu@hmail.com", "0789234567", new DateTime(1993,07,07));
            Turist t2 = new Turist(2, "Iordan", "Daniela", "dIordan@hmail.com", "0765232453", new DateTime(1996,12,12));
            Turist t3 = new Turist(3, "Lazar", "Cristian", "cLazar@hmail.com", "0766454311", new DateTime(1997,03,03));
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nume", typeof(string));
            dt.Columns.Add("Prenume", typeof(string));
            dt.Columns.Add("Mail", typeof(string));
            dt.Columns.Add("Telefon", typeof(string));
            dt.Columns.Add("DataNastere", typeof(DateTime));
            dt.Rows.Add(t1.CodTurist,t1.Nume,t1.Prenume,t1.Email,t1.Telefon,t1.DataNastere);
            dt.Rows.Add(t2.CodTurist,t2.Nume,t2.Prenume,t2.Email,t2.Telefon,t2.DataNastere);
            dt.Rows.Add(t3.CodTurist,t3.Nume,t3.Prenume,t3.Email,t3.Telefon,t3.DataNastere);
            dgvTuristi.DataSource = dt;
        }

      
        private void btnAddTuristi_Click(object sender, EventArgs e)
        {
            FormularAdaugaTuristi formularAdaugaTuristi = new FormularAdaugaTuristi(this);
            formularAdaugaTuristi.ShowDialog();
          
            
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgvTuristi.CurrentCell.RowIndex;
            dgvTuristi.Rows.RemoveAt(index);
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

                        for (int i = 0; i < dgvTuristi.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvTuristi.Columns.Count; j++)
                            {
                                writer.Write(dgvTuristi.Rows[i].Cells[j].Value.ToString());
                                if (j < dgvTuristi.Columns.Count - 1)
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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
                    dgvTuristi.DataSource = ds.Tables[0];
                }
            }
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt2 = GetDataTableFromDGV(dgvTuristi);
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
            object[] cellValues = new object[dgvTuristi.Columns.Count];
            foreach (DataGridViewRow row in dgvTuristi.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            return dt;
        }

        private void btnPrintTurist_Click(object sender, EventArgs e)
        {
            printDocumentTuristi.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(30, 20, 10, 10);

            printPreviewDialogTuristi.Document = printDocumentTuristi;
            printPreviewDialogTuristi.PrintPreviewControl.Zoom = 1;
            printPreviewDialogTuristi.ShowDialog();
        }

        private void printDocumentTuristi_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dgvTuristi.Width, dgvTuristi.Height);
            dgvTuristi.DrawToBitmap(imagebmp, new Rectangle(0, 0, imagebmp.Width, imagebmp.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

       
    }
}
