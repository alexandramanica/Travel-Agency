using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW2023_Tursim.Base
{
    public partial class InformatiiSuplimentare : Form
    {
        public InformatiiSuplimentare()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            tbInfo.Text = files[0];

        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbInfo.Text);
        }
    }
}
