namespace osszefoglalo
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
            this.DialogusAblak = new System.Windows.Forms.GroupBox();
            this.CsakBezarGomb = new System.Windows.Forms.Button();
            this.ValasztasGomb = new System.Windows.Forms.Button();
            this.Ablakok = new System.Windows.Forms.GroupBox();
            this.Ablakok_Teszt = new System.Windows.Forms.Label();
            this.MegnyitasGomb = new System.Windows.Forms.Button();
            this.MentesMaskentGomb = new System.Windows.Forms.Button();
            this.HatterSzinGomb = new System.Windows.Forms.Button();
            this.KarakterValtGomb = new System.Windows.Forms.Button();
            this.HatterSzinAblak = new System.Windows.Forms.ColorDialog();
            this.BetuFormaAblak = new System.Windows.Forms.FontDialog();
            this.CheckBoxAblak = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.CheckBoxEllenorzoGomb = new System.Windows.Forms.Button();
            this.DialogusAblak.SuspendLayout();
            this.Ablakok.SuspendLayout();
            this.CheckBoxAblak.SuspendLayout();
            this.SuspendLayout();
            // 
            // DialogusAblak
            // 
            this.DialogusAblak.BackColor = System.Drawing.Color.NavajoWhite;
            this.DialogusAblak.Controls.Add(this.ValasztasGomb);
            this.DialogusAblak.Controls.Add(this.CsakBezarGomb);
            this.DialogusAblak.Location = new System.Drawing.Point(12, 12);
            this.DialogusAblak.Name = "DialogusAblak";
            this.DialogusAblak.Size = new System.Drawing.Size(237, 107);
            this.DialogusAblak.TabIndex = 0;
            this.DialogusAblak.TabStop = false;
            this.DialogusAblak.Text = "Dialógusablak";
            // 
            // CsakBezarGomb
            // 
            this.CsakBezarGomb.Location = new System.Drawing.Point(28, 49);
            this.CsakBezarGomb.Name = "CsakBezarGomb";
            this.CsakBezarGomb.Size = new System.Drawing.Size(75, 38);
            this.CsakBezarGomb.TabIndex = 0;
            this.CsakBezarGomb.Text = "Csak bezár";
            this.CsakBezarGomb.UseVisualStyleBackColor = true;
            this.CsakBezarGomb.Click += new System.EventHandler(this.CsakBezarGomb_Click);
            // 
            // ValasztasGomb
            // 
            this.ValasztasGomb.Location = new System.Drawing.Point(128, 49);
            this.ValasztasGomb.Name = "ValasztasGomb";
            this.ValasztasGomb.Size = new System.Drawing.Size(75, 38);
            this.ValasztasGomb.TabIndex = 1;
            this.ValasztasGomb.Text = "Választás";
            this.ValasztasGomb.UseVisualStyleBackColor = true;
            this.ValasztasGomb.Click += new System.EventHandler(this.ValasztasGomb_Click);
            // 
            // Ablakok
            // 
            this.Ablakok.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Ablakok.Controls.Add(this.KarakterValtGomb);
            this.Ablakok.Controls.Add(this.HatterSzinGomb);
            this.Ablakok.Controls.Add(this.MentesMaskentGomb);
            this.Ablakok.Controls.Add(this.MegnyitasGomb);
            this.Ablakok.Controls.Add(this.Ablakok_Teszt);
            this.Ablakok.Location = new System.Drawing.Point(12, 138);
            this.Ablakok.Name = "Ablakok";
            this.Ablakok.Size = new System.Drawing.Size(237, 300);
            this.Ablakok.TabIndex = 1;
            this.Ablakok.TabStop = false;
            this.Ablakok.Text = "Ablakok";
            // 
            // Ablakok_Teszt
            // 
            this.Ablakok_Teszt.AutoSize = true;
            this.Ablakok_Teszt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ablakok_Teszt.Location = new System.Drawing.Point(85, 30);
            this.Ablakok_Teszt.Name = "Ablakok_Teszt";
            this.Ablakok_Teszt.Size = new System.Drawing.Size(65, 25);
            this.Ablakok_Teszt.TabIndex = 0;
            this.Ablakok_Teszt.Text = "Teszt";
            // 
            // MegnyitasGomb
            // 
            this.MegnyitasGomb.Location = new System.Drawing.Point(6, 71);
            this.MegnyitasGomb.Name = "MegnyitasGomb";
            this.MegnyitasGomb.Size = new System.Drawing.Size(225, 23);
            this.MegnyitasGomb.TabIndex = 1;
            this.MegnyitasGomb.Text = "Megnyitás";
            this.MegnyitasGomb.UseVisualStyleBackColor = true;
            this.MegnyitasGomb.Click += new System.EventHandler(this.MegnyitasGomb_Click);
            // 
            // MentesMaskentGomb
            // 
            this.MentesMaskentGomb.Location = new System.Drawing.Point(6, 100);
            this.MentesMaskentGomb.Name = "MentesMaskentGomb";
            this.MentesMaskentGomb.Size = new System.Drawing.Size(225, 23);
            this.MentesMaskentGomb.TabIndex = 2;
            this.MentesMaskentGomb.Text = "Mentés másként";
            this.MentesMaskentGomb.UseVisualStyleBackColor = true;
            this.MentesMaskentGomb.Click += new System.EventHandler(this.MentesMaskentGomb_Click);
            // 
            // HatterSzinGomb
            // 
            this.HatterSzinGomb.Location = new System.Drawing.Point(6, 129);
            this.HatterSzinGomb.Name = "HatterSzinGomb";
            this.HatterSzinGomb.Size = new System.Drawing.Size(225, 23);
            this.HatterSzinGomb.TabIndex = 3;
            this.HatterSzinGomb.Text = "Háttérszín";
            this.HatterSzinGomb.UseVisualStyleBackColor = true;
            this.HatterSzinGomb.Click += new System.EventHandler(this.HatterSzinGomb_Click);
            // 
            // KarakterValtGomb
            // 
            this.KarakterValtGomb.Location = new System.Drawing.Point(6, 158);
            this.KarakterValtGomb.Name = "KarakterValtGomb";
            this.KarakterValtGomb.Size = new System.Drawing.Size(225, 23);
            this.KarakterValtGomb.TabIndex = 4;
            this.KarakterValtGomb.Text = "Karakterszintű formázások";
            this.KarakterValtGomb.UseVisualStyleBackColor = true;
            this.KarakterValtGomb.Click += new System.EventHandler(this.KarakterValtGomb_Click);
            // 
            // BetuFormaAblak
            // 
            this.BetuFormaAblak.ShowColor = true;
            // 
            // CheckBoxAblak
            // 
            this.CheckBoxAblak.Controls.Add(this.CheckBoxEllenorzoGomb);
            this.CheckBoxAblak.Controls.Add(this.checkBox3);
            this.CheckBoxAblak.Controls.Add(this.checkBox2);
            this.CheckBoxAblak.Controls.Add(this.checkBox1);
            this.CheckBoxAblak.Location = new System.Drawing.Point(279, 13);
            this.CheckBoxAblak.Name = "CheckBoxAblak";
            this.CheckBoxAblak.Size = new System.Drawing.Size(226, 106);
            this.CheckBoxAblak.TabIndex = 2;
            this.CheckBoxAblak.TabStop = false;
            this.CheckBoxAblak.Text = "CheckBox Ablak";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 43);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 66);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // CheckBoxEllenorzoGomb
            // 
            this.CheckBoxEllenorzoGomb.Location = new System.Drawing.Point(93, 20);
            this.CheckBoxEllenorzoGomb.Name = "CheckBoxEllenorzoGomb";
            this.CheckBoxEllenorzoGomb.Size = new System.Drawing.Size(127, 63);
            this.CheckBoxEllenorzoGomb.TabIndex = 3;
            this.CheckBoxEllenorzoGomb.Text = "Ellenőrzés";
            this.CheckBoxEllenorzoGomb.UseVisualStyleBackColor = true;
            this.CheckBoxEllenorzoGomb.Click += new System.EventHandler(this.CheckBoxEllenorzoGomb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckBoxAblak);
            this.Controls.Add(this.Ablakok);
            this.Controls.Add(this.DialogusAblak);
            this.Name = "Form1";
            this.Text = "Összefoglaló";
            this.DialogusAblak.ResumeLayout(false);
            this.Ablakok.ResumeLayout(false);
            this.Ablakok.PerformLayout();
            this.CheckBoxAblak.ResumeLayout(false);
            this.CheckBoxAblak.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DialogusAblak;
        private System.Windows.Forms.Button ValasztasGomb;
        private System.Windows.Forms.Button CsakBezarGomb;
        private System.Windows.Forms.GroupBox Ablakok;
        private System.Windows.Forms.Button KarakterValtGomb;
        private System.Windows.Forms.Button HatterSzinGomb;
        private System.Windows.Forms.Button MentesMaskentGomb;
        private System.Windows.Forms.Button MegnyitasGomb;
        private System.Windows.Forms.Label Ablakok_Teszt;
        private System.Windows.Forms.ColorDialog HatterSzinAblak;
        private System.Windows.Forms.FontDialog BetuFormaAblak;
        private System.Windows.Forms.GroupBox CheckBoxAblak;
        private System.Windows.Forms.Button CheckBoxEllenorzoGomb;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

