namespace szovegszerkeszto
{
    partial class Form1
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
            this.szovegbeviteliablak = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újDokumentumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.megnyitásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésMáskéntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kivágásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.másolásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.beillesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segítségToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // szovegbeviteliablak
            // 
            this.szovegbeviteliablak.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.szovegbeviteliablak.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.szovegbeviteliablak.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szovegbeviteliablak.Location = new System.Drawing.Point(12, 27);
            this.szovegbeviteliablak.Name = "szovegbeviteliablak";
            this.szovegbeviteliablak.Size = new System.Drawing.Size(776, 411);
            this.szovegbeviteliablak.TabIndex = 0;
            this.szovegbeviteliablak.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.szerkesztésToolStripMenuItem,
            this.segítségToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újDokumentumToolStripMenuItem,
            this.toolStripSeparator1,
            this.megnyitásToolStripMenuItem,
            this.mentésMáskéntToolStripMenuItem,
            this.toolStripSeparator2,
            this.kilépésToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            this.fájlToolStripMenuItem.Click += new System.EventHandler(this.fájlToolStripMenuItem_Click);
            // 
            // újDokumentumToolStripMenuItem
            // 
            this.újDokumentumToolStripMenuItem.Name = "újDokumentumToolStripMenuItem";
            this.újDokumentumToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.újDokumentumToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.újDokumentumToolStripMenuItem.Text = "Új dokumentum";
            this.újDokumentumToolStripMenuItem.Click += new System.EventHandler(this.újDokumentumToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // megnyitásToolStripMenuItem
            // 
            this.megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            this.megnyitásToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.megnyitásToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.megnyitásToolStripMenuItem.Text = "Megnyitás";
            this.megnyitásToolStripMenuItem.Click += new System.EventHandler(this.megnyitásToolStripMenuItem_Click);
            // 
            // mentésMáskéntToolStripMenuItem
            // 
            this.mentésMáskéntToolStripMenuItem.Name = "mentésMáskéntToolStripMenuItem";
            this.mentésMáskéntToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.mentésMáskéntToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.mentésMáskéntToolStripMenuItem.Text = "Mentés másként";
            this.mentésMáskéntToolStripMenuItem.Click += new System.EventHandler(this.mentésMáskéntToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Q)));
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // szerkesztésToolStripMenuItem
            // 
            this.szerkesztésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kivágásToolStripMenuItem,
            this.másolásToolStripMenuItem,
            this.toolStripSeparator3,
            this.beillesztésToolStripMenuItem});
            this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
            // 
            // kivágásToolStripMenuItem
            // 
            this.kivágásToolStripMenuItem.Name = "kivágásToolStripMenuItem";
            this.kivágásToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kivágásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kivágásToolStripMenuItem.Text = "Kivágás";
            this.kivágásToolStripMenuItem.Click += new System.EventHandler(this.kivágásToolStripMenuItem_Click);
            // 
            // másolásToolStripMenuItem
            // 
            this.másolásToolStripMenuItem.Name = "másolásToolStripMenuItem";
            this.másolásToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.másolásToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.másolásToolStripMenuItem.Text = "Másolás";
            this.másolásToolStripMenuItem.Click += new System.EventHandler(this.másolásToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // beillesztésToolStripMenuItem
            // 
            this.beillesztésToolStripMenuItem.Name = "beillesztésToolStripMenuItem";
            this.beillesztésToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.beillesztésToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.beillesztésToolStripMenuItem.Text = "Beillesztés";
            this.beillesztésToolStripMenuItem.Click += new System.EventHandler(this.beillesztésToolStripMenuItem_Click);
            // 
            // segítségToolStripMenuItem
            // 
            this.segítségToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.névjegyToolStripMenuItem});
            this.segítségToolStripMenuItem.Name = "segítségToolStripMenuItem";
            this.segítségToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.segítségToolStripMenuItem.Text = "Segítség";
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.névjegyToolStripMenuItem.Text = "Névjegy";
            this.névjegyToolStripMenuItem.Click += new System.EventHandler(this.névjegyToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.szovegbeviteliablak);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Szövegszerkesztő";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox szovegbeviteliablak;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újDokumentumToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem megnyitásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésMáskéntToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kivágásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem másolásToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem beillesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segítségToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
    }
}

