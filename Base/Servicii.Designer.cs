namespace ProiectPAW2023_Tursim.Forms
{
    partial class Servicii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicii));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printPreviewDialogServicii = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentServicii = new System.Drawing.Printing.PrintDocument();
            this.openFileTranzactii = new System.Windows.Forms.OpenFileDialog();
            this.saveFileTranzactii = new System.Windows.Forms.SaveFileDialog();
            this.dgvServicii = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddServiciu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTuristi = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.citireDinFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrint = new System.Windows.Forms.Button();
            this.saveFileTranzactiiXML = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicii)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialogServicii
            // 
            this.printPreviewDialogServicii.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogServicii.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogServicii.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogServicii.Document = this.printDocumentServicii;
            this.printPreviewDialogServicii.Enabled = true;
            this.printPreviewDialogServicii.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogServicii.Icon")));
            this.printPreviewDialogServicii.Name = "printPreviewDialogTranzactii";
            this.printPreviewDialogServicii.Visible = false;
            // 
            // printDocumentServicii
            // 
            this.printDocumentServicii.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentServicii_PrintPage);
            // 
            // openFileTranzactii
            // 
            this.openFileTranzactii.FileName = "openFileTranzactii";
            // 
            // dgvServicii
            // 
            this.dgvServicii.AllowUserToAddRows = false;
            this.dgvServicii.AllowUserToDeleteRows = false;
            this.dgvServicii.AllowUserToResizeColumns = false;
            this.dgvServicii.AllowUserToResizeRows = false;
            this.dgvServicii.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.dgvServicii.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServicii.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvServicii.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicii.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvServicii.ColumnHeadersHeight = 40;
            this.dgvServicii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvServicii.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(58)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicii.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvServicii.EnableHeadersVisualStyles = false;
            this.dgvServicii.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.dgvServicii.Location = new System.Drawing.Point(26, 140);
            this.dgvServicii.Name = "dgvServicii";
            this.dgvServicii.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(58)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicii.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvServicii.RowHeadersWidth = 50;
            this.dgvServicii.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvServicii.RowTemplate.Height = 33;
            this.dgvServicii.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicii.Size = new System.Drawing.Size(1460, 713);
            this.dgvServicii.TabIndex = 15;
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
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(163, 38);
            this.stergeToolStripMenuItem.Text = "Sterge ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "manager.png");
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
            // btnAddServiciu
            // 
            this.btnAddServiciu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btnAddServiciu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.btnAddServiciu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddServiciu.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddServiciu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btnAddServiciu.Location = new System.Drawing.Point(767, 874);
            this.btnAddServiciu.Name = "btnAddServiciu";
            this.btnAddServiciu.Size = new System.Drawing.Size(214, 131);
            this.btnAddServiciu.TabIndex = 11;
            this.btnAddServiciu.Text = "Adauga o noua tranzactie";
            this.btnAddServiciu.UseVisualStyleBackColor = false;
            this.btnAddServiciu.Click += new System.EventHandler(this.btnAddServiciu_Click);
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
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
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
            // tXTToolStripMenuItem
            // 
            this.tXTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.tXTToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(211, 46);
            this.tXTToolStripMenuItem.Text = "TXT";
            this.tXTToolStripMenuItem.Click += new System.EventHandler(this.tXTToolStripMenuItem_Click);
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
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(89)))));
            this.btnPrint.Location = new System.Drawing.Point(405, 874);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(214, 131);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Printeaza o tranzanctie";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Servicii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1556, 1017);
            this.Controls.Add(this.dgvServicii);
            this.Controls.Add(this.btnAddServiciu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Servicii";
            this.Text = "Servicii";
            this.Load += new System.EventHandler(this.Servicii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicii)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogServicii;
        private System.Drawing.Printing.PrintDocument printDocumentServicii;
        private System.Windows.Forms.OpenFileDialog openFileTranzactii;
        private System.Windows.Forms.SaveFileDialog saveFileTranzactii;
        public System.Windows.Forms.DataGridView dgvServicii;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.Button btnAddServiciu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTuristi;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem citireDinFisierToolStripMenuItem;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.SaveFileDialog saveFileTranzactiiXML;
    }
}