namespace ListaGeneratorApp
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
            this.Lista = new System.Windows.Forms.ListBox();
            this.GeneralasGomb = new System.Windows.Forms.Button();
            this.valasztottelem = new System.Windows.Forms.Label();
            this.kodok = new System.Windows.Forms.ListBox();
            this.cim = new System.Windows.Forms.Label();
            this.MentesGomb = new System.Windows.Forms.Button();
            this.MegnyitasGomb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(12, 12);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(207, 420);
            this.Lista.TabIndex = 0;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.Lista_SelectedIndexChanged);
            // 
            // GeneralasGomb
            // 
            this.GeneralasGomb.Location = new System.Drawing.Point(226, 12);
            this.GeneralasGomb.Name = "GeneralasGomb";
            this.GeneralasGomb.Size = new System.Drawing.Size(75, 23);
            this.GeneralasGomb.TabIndex = 1;
            this.GeneralasGomb.Text = "Generálás";
            this.GeneralasGomb.UseVisualStyleBackColor = true;
            this.GeneralasGomb.Click += new System.EventHandler(this.GeneralasGomb_Click);
            // 
            // valasztottelem
            // 
            this.valasztottelem.AutoSize = true;
            this.valasztottelem.Location = new System.Drawing.Point(225, 49);
            this.valasztottelem.Name = "valasztottelem";
            this.valasztottelem.Size = new System.Drawing.Size(78, 13);
            this.valasztottelem.TabIndex = 2;
            this.valasztottelem.Text = "Választott elem";
            // 
            // kodok
            // 
            this.kodok.FormattingEnabled = true;
            this.kodok.Location = new System.Drawing.Point(226, 116);
            this.kodok.Name = "kodok";
            this.kodok.Size = new System.Drawing.Size(213, 316);
            this.kodok.TabIndex = 3;
            this.kodok.SelectedIndexChanged += new System.EventHandler(this.kodok_SelectedIndexChanged);
            // 
            // cim
            // 
            this.cim.AutoSize = true;
            this.cim.Location = new System.Drawing.Point(225, 74);
            this.cim.Name = "cim";
            this.cim.Size = new System.Drawing.Size(35, 13);
            this.cim.TabIndex = 4;
            this.cim.Text = "label1";
            // 
            // MentesGomb
            // 
            this.MentesGomb.Location = new System.Drawing.Point(445, 409);
            this.MentesGomb.Name = "MentesGomb";
            this.MentesGomb.Size = new System.Drawing.Size(75, 23);
            this.MentesGomb.TabIndex = 5;
            this.MentesGomb.Text = "Mentés";
            this.MentesGomb.UseVisualStyleBackColor = true;
            // 
            // MegnyitasGomb
            // 
            this.MegnyitasGomb.Location = new System.Drawing.Point(445, 380);
            this.MegnyitasGomb.Name = "MegnyitasGomb";
            this.MegnyitasGomb.Size = new System.Drawing.Size(75, 23);
            this.MegnyitasGomb.TabIndex = 6;
            this.MegnyitasGomb.Text = "Megnyitás";
            this.MegnyitasGomb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.MegnyitasGomb);
            this.Controls.Add(this.MentesGomb);
            this.Controls.Add(this.cim);
            this.Controls.Add(this.kodok);
            this.Controls.Add(this.valasztottelem);
            this.Controls.Add(this.GeneralasGomb);
            this.Controls.Add(this.Lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button GeneralasGomb;
        private System.Windows.Forms.Label valasztottelem;
        private System.Windows.Forms.ListBox kodok;
        private System.Windows.Forms.Label cim;
        private System.Windows.Forms.Button MentesGomb;
        private System.Windows.Forms.Button MegnyitasGomb;
    }
}

