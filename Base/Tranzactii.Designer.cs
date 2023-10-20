namespace ProiectPAW2023_Tursim.Base
{
    partial class Tranzactii
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tranzactii));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTuristi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddTranzactie = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.citireDinFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvTranzactii = new System.Windows.Forms.DataGridView();
            this.saveFileTranzactii = new System.Windows.Forms.SaveFileDialog();
            this.openFileTranzactii = new System.Windows.Forms.OpenFileDialog();
            this.printDocumentTranzactii = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogTranzactii = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranzactii)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(89)))));
            this.btnPrint.Location = new System.Drawing.Point(438, 856);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(214, 131);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Printeaza tranzactiile";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tXTToolStripMenuItem
            // 
            this.tXTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.tXTToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(211, 46);
            this.tXTToolStripMenuItem.Text = "TXT";
            this.tXTToolStripMenuItem.Click += new System.EventHandler(this.tXTToolStripMenuItem_Click);
            // 
            // menuTuristi
            // 
            this.menuTuristi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tXTToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuTuristi.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTuristi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.menuTuristi.Name = "menuTuristi";
            this.menuTuristi.Size = new System.Drawing.Size(248, 41);
            this.menuTuristi.Text = "Salvare în fisiere";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 46);
            this.toolStripMenuItem1.Text = "XML";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btnAddTranzactie
            // 
            this.btnAddTranzactie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btnAddTranzactie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.btnAddTranzactie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTranzactie.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTranzactie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btnAddTranzactie.Location = new System.Drawing.Point(797, 856);
            this.btnAddTranzactie.Name = "btnAddTranzactie";
            this.btnAddTranzactie.Size = new System.Drawing.Size(214, 131);
            this.btnAddTranzactie.TabIndex = 6;
            this.btnAddTranzactie.Text = "Adauga o noua tranzactie";
            this.btnAddTranzactie.UseVisualStyleBackColor = false;
            this.btnAddTranzactie.Click += new System.EventHandler(this.btnAddTranzactie_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTuristi,
            this.citireDinFisierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1556, 45);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // citireDinFisierToolStripMenuItem
            // 
            this.citireDinFisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem});
            this.citireDinFisierToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citireDinFisierToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.citireDinFisierToolStripMenuItem.Name = "citireDinFisierToolStripMenuItem";
            this.citireDinFisierToolStripMenuItem.Size = new System.Drawing.Size(226, 41);
            this.citireDinFisierToolStripMenuItem.Text = "Citire din fisier";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.xMLToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(211, 46);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "manager.png");
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(163, 38);
            this.stergeToolStripMenuItem.Text = "Sterge ";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.contextMenuStrip1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 42);
            // 
            // dgvTranzactii
            // 
            this.dgvTranzactii.AllowUserToAddRows = false;
            this.dgvTranzactii.AllowUserToDeleteRows = false;
            this.dgvTranzactii.AllowUserToResizeColumns = false;
            this.dgvTranzactii.AllowUserToResizeRows = false;
            this.dgvTranzactii.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.dgvTranzactii.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTranzactii.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTranzactii.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTranzactii.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTranzactii.ColumnHeadersHeight = 40;
            this.dgvTranzactii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTranzactii.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(58)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTranzactii.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTranzactii.EnableHeadersVisualStyles = false;
            this.dgvTranzactii.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.dgvTranzactii.Location = new System.Drawing.Point(62, 137);
            this.dgvTranzactii.Name = "dgvTranzactii";
            this.dgvTranzactii.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(58)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTranzactii.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTranzactii.RowHeadersWidth = 50;
            this.dgvTranzactii.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTranzactii.RowTemplate.Height = 33;
            this.dgvTranzactii.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTranzactii.Size = new System.Drawing.Size(1460, 713);
            this.dgvTranzactii.TabIndex = 10;
            // 
            // openFileTranzactii
            // 
            this.openFileTranzactii.FileName = "openFileTranzactii";
            // 
            // printDocumentTranzactii
            // 
            this.printDocumentTranzactii.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentTranzactii_PrintPage);
            // 
            // printPreviewDialogTranzactii
            // 
            this.printPreviewDialogTranzactii.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogTranzactii.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogTranzactii.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogTranzactii.Document = this.printDocumentTranzactii;
            this.printPreviewDialogTranzactii.Enabled = true;
            this.printPreviewDialogTranzactii.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogTranzactii.Icon")));
            this.printPreviewDialogTranzactii.Name = "printPreviewDialogTranzactii";
            this.printPreviewDialogTranzactii.Visible = false;
            // 
            // Tranzactii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1556, 1017);
            this.Controls.Add(this.dgvTranzactii);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAddTranzactie);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tranzactii";
            this.Text = "Tranzactii";
            this.Load += new System.EventHandler(this.Tranzactii_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranzactii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuTuristi;
        private System.Windows.Forms.Button btnAddTranzactie;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileTranzactii;
        private System.Windows.Forms.OpenFileDialog openFileTranzactii;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Drawing.Printing.PrintDocument printDocumentTranzactii;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogTranzactii;
        public System.Windows.Forms.DataGridView dgvTranzactii;
        private System.Windows.Forms.ToolStripMenuItem citireDinFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
    }
}