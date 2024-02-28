namespace NewProject
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
            this.szovegmezo = new System.Windows.Forms.RichTextBox();
            this.FeldolgozasGomb = new System.Windows.Forms.Button();
            this.szovegLista = new System.Windows.Forms.ListBox();
            this.betuValasztas = new System.Windows.Forms.ComboBox();
            this.Kivalogat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // szovegmezo
            // 
            this.szovegmezo.Location = new System.Drawing.Point(12, 22);
            this.szovegmezo.Name = "szovegmezo";
            this.szovegmezo.Size = new System.Drawing.Size(311, 394);
            this.szovegmezo.TabIndex = 1;
            this.szovegmezo.Text = "";
            this.szovegmezo.TextChanged += new System.EventHandler(this.szovegmezo_TextChanged);
            // 
            // FeldolgozasGomb
            // 
            this.FeldolgozasGomb.Location = new System.Drawing.Point(330, 379);
            this.FeldolgozasGomb.Name = "FeldolgozasGomb";
            this.FeldolgozasGomb.Size = new System.Drawing.Size(261, 37);
            this.FeldolgozasGomb.TabIndex = 2;
            this.FeldolgozasGomb.Text = "Listába szervezés";
            this.FeldolgozasGomb.UseVisualStyleBackColor = true;
            this.FeldolgozasGomb.Click += new System.EventHandler(this.FeldolgozasGomb_Click);
            // 
            // szovegLista
            // 
            this.szovegLista.FormattingEnabled = true;
            this.szovegLista.Location = new System.Drawing.Point(329, 22);
            this.szovegLista.Name = "szovegLista";
            this.szovegLista.Size = new System.Drawing.Size(261, 342);
            this.szovegLista.TabIndex = 3;
            this.szovegLista.SelectedIndexChanged += new System.EventHandler(this.szovegLista_SelectedIndexChanged);
            // 
            // betuValasztas
            // 
            this.betuValasztas.FormattingEnabled = true;
            this.betuValasztas.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "x",
            "y",
            "z",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T"});
            this.betuValasztas.Location = new System.Drawing.Point(597, 22);
            this.betuValasztas.Name = "betuValasztas";
            this.betuValasztas.Size = new System.Drawing.Size(191, 21);
            this.betuValasztas.TabIndex = 4;
            this.betuValasztas.SelectedIndexChanged += new System.EventHandler(this.betuValasztas_SelectedIndexChanged);
            // 
            // Kivalogat
            // 
            this.Kivalogat.FormattingEnabled = true;
            this.Kivalogat.Location = new System.Drawing.Point(597, 50);
            this.Kivalogat.Name = "Kivalogat";
            this.Kivalogat.Size = new System.Drawing.Size(191, 368);
            this.Kivalogat.TabIndex = 5;
            this.Kivalogat.SelectedIndexChanged += new System.EventHandler(this.Kivalogat_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Kivalogat);
            this.Controls.Add(this.betuValasztas);
            this.Controls.Add(this.szovegLista);
            this.Controls.Add(this.FeldolgozasGomb);
            this.Controls.Add(this.szovegmezo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox szovegmezo;
        private System.Windows.Forms.Button FeldolgozasGomb;
        private System.Windows.Forms.ListBox szovegLista;
        private System.Windows.Forms.ComboBox betuValasztas;
        private System.Windows.Forms.ListBox Kivalogat;
    }
}

