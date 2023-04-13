namespace SzamGeneraloLista
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
            this.GeneraloGomb = new System.Windows.Forms.Button();
            this.GeneraltSzamok = new System.Windows.Forms.ListBox();
            this.GeneralasOpciok = new System.Windows.Forms.GroupBox();
            this.PrimRadioGomb = new System.Windows.Forms.RadioButton();
            this.ParosRadioGomb = new System.Windows.Forms.RadioButton();
            this.ParatlanRadioButton = new System.Windows.Forms.RadioButton();
            this.HarommalRadioButton = new System.Windows.Forms.RadioButton();
            this.HattalRadioButton = new System.Windows.Forms.RadioButton();
            this.KilenccelRadioButton = new System.Windows.Forms.RadioButton();
            this.NegyzetRadioButton = new System.Windows.Forms.RadioButton();
            this.MutatButton = new System.Windows.Forms.Button();
            this.EredmenyLabel = new System.Windows.Forms.Label();
            this.HozzaadottLista = new System.Windows.Forms.ListBox();
            this.GeneralasOpciok.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneraloGomb
            // 
            this.GeneraloGomb.Location = new System.Drawing.Point(25, 12);
            this.GeneraloGomb.Name = "GeneraloGomb";
            this.GeneraloGomb.Size = new System.Drawing.Size(173, 36);
            this.GeneraloGomb.TabIndex = 0;
            this.GeneraloGomb.Text = "Generálás";
            this.GeneraloGomb.UseVisualStyleBackColor = true;
            this.GeneraloGomb.Click += new System.EventHandler(this.GeneraloGomb_Click);
            // 
            // GeneraltSzamok
            // 
            this.GeneraltSzamok.FormattingEnabled = true;
            this.GeneraltSzamok.Location = new System.Drawing.Point(25, 64);
            this.GeneraltSzamok.Name = "GeneraltSzamok";
            this.GeneraltSzamok.Size = new System.Drawing.Size(173, 355);
            this.GeneraltSzamok.TabIndex = 1;
            this.GeneraltSzamok.SelectedIndexChanged += new System.EventHandler(this.GeneraltSzamok_SelectedIndexChanged);
            // 
            // GeneralasOpciok
            // 
            this.GeneralasOpciok.Controls.Add(this.NegyzetRadioButton);
            this.GeneralasOpciok.Controls.Add(this.KilenccelRadioButton);
            this.GeneralasOpciok.Controls.Add(this.HattalRadioButton);
            this.GeneralasOpciok.Controls.Add(this.HarommalRadioButton);
            this.GeneralasOpciok.Controls.Add(this.ParatlanRadioButton);
            this.GeneralasOpciok.Controls.Add(this.ParosRadioGomb);
            this.GeneralasOpciok.Controls.Add(this.PrimRadioGomb);
            this.GeneralasOpciok.Location = new System.Drawing.Point(224, 64);
            this.GeneralasOpciok.Name = "GeneralasOpciok";
            this.GeneralasOpciok.Size = new System.Drawing.Size(200, 217);
            this.GeneralasOpciok.TabIndex = 2;
            this.GeneralasOpciok.TabStop = false;
            this.GeneralasOpciok.Text = "Lista opciók";
            this.GeneralasOpciok.Enter += new System.EventHandler(this.GeneralasOpciok_Enter);
            // 
            // PrimRadioGomb
            // 
            this.PrimRadioGomb.AutoSize = true;
            this.PrimRadioGomb.Location = new System.Drawing.Point(7, 33);
            this.PrimRadioGomb.Name = "PrimRadioGomb";
            this.PrimRadioGomb.Size = new System.Drawing.Size(59, 17);
            this.PrimRadioGomb.TabIndex = 0;
            this.PrimRadioGomb.TabStop = true;
            this.PrimRadioGomb.Text = "Prímek";
            this.PrimRadioGomb.UseVisualStyleBackColor = true;
            this.PrimRadioGomb.CheckedChanged += new System.EventHandler(this.PrimRadioGomb_CheckedChanged);
            // 
            // ParosRadioGomb
            // 
            this.ParosRadioGomb.AutoSize = true;
            this.ParosRadioGomb.Location = new System.Drawing.Point(7, 57);
            this.ParosRadioGomb.Name = "ParosRadioGomb";
            this.ParosRadioGomb.Size = new System.Drawing.Size(91, 17);
            this.ParosRadioGomb.TabIndex = 1;
            this.ParosRadioGomb.TabStop = true;
            this.ParosRadioGomb.Text = "Páros számok";
            this.ParosRadioGomb.UseVisualStyleBackColor = true;
            this.ParosRadioGomb.CheckedChanged += new System.EventHandler(this.ParosRadioGomb_CheckedChanged);
            // 
            // ParatlanRadioButton
            // 
            this.ParatlanRadioButton.AutoSize = true;
            this.ParatlanRadioButton.Location = new System.Drawing.Point(6, 80);
            this.ParatlanRadioButton.Name = "ParatlanRadioButton";
            this.ParatlanRadioButton.Size = new System.Drawing.Size(103, 17);
            this.ParatlanRadioButton.TabIndex = 2;
            this.ParatlanRadioButton.TabStop = true;
            this.ParatlanRadioButton.Text = "Páratlan számok";
            this.ParatlanRadioButton.UseVisualStyleBackColor = true;
            this.ParatlanRadioButton.CheckedChanged += new System.EventHandler(this.ParatlanRadioButton_CheckedChanged);
            // 
            // HarommalRadioButton
            // 
            this.HarommalRadioButton.AutoSize = true;
            this.HarommalRadioButton.Location = new System.Drawing.Point(6, 103);
            this.HarommalRadioButton.Name = "HarommalRadioButton";
            this.HarommalRadioButton.Size = new System.Drawing.Size(132, 17);
            this.HarommalRadioButton.TabIndex = 3;
            this.HarommalRadioButton.TabStop = true;
            this.HarommalRadioButton.Text = "3-mal osztható számok";
            this.HarommalRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HarommalRadioButton.UseVisualStyleBackColor = true;
            this.HarommalRadioButton.CheckedChanged += new System.EventHandler(this.HarommalRadioButton_CheckedChanged);
            // 
            // HattalRadioButton
            // 
            this.HattalRadioButton.AutoSize = true;
            this.HattalRadioButton.Location = new System.Drawing.Point(6, 127);
            this.HattalRadioButton.Name = "HattalRadioButton";
            this.HattalRadioButton.Size = new System.Drawing.Size(127, 17);
            this.HattalRadioButton.TabIndex = 4;
            this.HattalRadioButton.TabStop = true;
            this.HattalRadioButton.Text = "6-tal osztható számok";
            this.HattalRadioButton.UseVisualStyleBackColor = true;
            this.HattalRadioButton.CheckedChanged += new System.EventHandler(this.HattalRadioButton_CheckedChanged);
            // 
            // KilenccelRadioButton
            // 
            this.KilenccelRadioButton.AutoSize = true;
            this.KilenccelRadioButton.Location = new System.Drawing.Point(6, 151);
            this.KilenccelRadioButton.Name = "KilenccelRadioButton";
            this.KilenccelRadioButton.Size = new System.Drawing.Size(130, 17);
            this.KilenccelRadioButton.TabIndex = 5;
            this.KilenccelRadioButton.TabStop = true;
            this.KilenccelRadioButton.Text = "9-cel osztható számok";
            this.KilenccelRadioButton.UseVisualStyleBackColor = true;
            this.KilenccelRadioButton.CheckedChanged += new System.EventHandler(this.KilenccelRadioButton_CheckedChanged);
            // 
            // NegyzetRadioButton
            // 
            this.NegyzetRadioButton.AutoSize = true;
            this.NegyzetRadioButton.Location = new System.Drawing.Point(6, 175);
            this.NegyzetRadioButton.Name = "NegyzetRadioButton";
            this.NegyzetRadioButton.Size = new System.Drawing.Size(100, 17);
            this.NegyzetRadioButton.TabIndex = 6;
            this.NegyzetRadioButton.TabStop = true;
            this.NegyzetRadioButton.Text = "Négyzetszámok";
            this.NegyzetRadioButton.UseVisualStyleBackColor = true;
            this.NegyzetRadioButton.CheckedChanged += new System.EventHandler(this.NegyzetRadioButton_CheckedChanged);
            // 
            // MutatButton
            // 
            this.MutatButton.Location = new System.Drawing.Point(224, 287);
            this.MutatButton.Name = "MutatButton";
            this.MutatButton.Size = new System.Drawing.Size(200, 41);
            this.MutatButton.TabIndex = 3;
            this.MutatButton.Text = "Mutat";
            this.MutatButton.UseVisualStyleBackColor = true;
            this.MutatButton.Click += new System.EventHandler(this.MutatButton_Click);
            // 
            // EredmenyLabel
            // 
            this.EredmenyLabel.AutoSize = true;
            this.EredmenyLabel.Location = new System.Drawing.Point(309, 348);
            this.EredmenyLabel.Name = "EredmenyLabel";
            this.EredmenyLabel.Size = new System.Drawing.Size(35, 13);
            this.EredmenyLabel.TabIndex = 4;
            this.EredmenyLabel.Text = "label1";
            this.EredmenyLabel.Click += new System.EventHandler(this.EredmenyLabel_Click);
            // 
            // HozzaadottLista
            // 
            this.HozzaadottLista.FormattingEnabled = true;
            this.HozzaadottLista.Location = new System.Drawing.Point(452, 64);
            this.HozzaadottLista.Name = "HozzaadottLista";
            this.HozzaadottLista.Size = new System.Drawing.Size(164, 355);
            this.HozzaadottLista.TabIndex = 5;
            this.HozzaadottLista.SelectedIndexChanged += new System.EventHandler(this.HozzaadottLista_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.HozzaadottLista);
            this.Controls.Add(this.EredmenyLabel);
            this.Controls.Add(this.MutatButton);
            this.Controls.Add(this.GeneralasOpciok);
            this.Controls.Add(this.GeneraltSzamok);
            this.Controls.Add(this.GeneraloGomb);
            this.Name = "Form1";
            this.Text = "Számok";
            this.GeneralasOpciok.ResumeLayout(false);
            this.GeneralasOpciok.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GeneraloGomb;
        private System.Windows.Forms.ListBox GeneraltSzamok;
        private System.Windows.Forms.GroupBox GeneralasOpciok;
        private System.Windows.Forms.RadioButton PrimRadioGomb;
        private System.Windows.Forms.RadioButton NegyzetRadioButton;
        private System.Windows.Forms.RadioButton KilenccelRadioButton;
        private System.Windows.Forms.RadioButton HattalRadioButton;
        private System.Windows.Forms.RadioButton HarommalRadioButton;
        private System.Windows.Forms.RadioButton ParatlanRadioButton;
        private System.Windows.Forms.RadioButton ParosRadioGomb;
        private System.Windows.Forms.Button MutatButton;
        private System.Windows.Forms.Label EredmenyLabel;
        private System.Windows.Forms.ListBox HozzaadottLista;
    }
}

