using System;

namespace ListakApp
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
            this.ElsoBevitelBox = new System.Windows.Forms.TextBox();
            this.ElsoHozzaAdGomb = new System.Windows.Forms.Button();
            this.ElsoFelulreGomb = new System.Windows.Forms.Button();
            this.ElsoLeGomb = new System.Windows.Forms.Button();
            this.ElsoAlulraGomb = new System.Windows.Forms.Button();
            this.ElsoTorolGomb = new System.Windows.Forms.Button();
            this.JobbraGomb = new System.Windows.Forms.Button();
            this.BalraGomb = new System.Windows.Forms.Button();
            this.ElsoLista = new System.Windows.Forms.ListBox();
            this.ElsoFelGomb = new System.Windows.Forms.Button();
            this.MasodikFelGomb = new System.Windows.Forms.Button();
            this.MasodikLista = new System.Windows.Forms.ListBox();
            this.MasodikTorolGomb = new System.Windows.Forms.Button();
            this.MasodikAlulraGomb = new System.Windows.Forms.Button();
            this.MasodikLeGomb = new System.Windows.Forms.Button();
            this.MasodikFelulreGomb = new System.Windows.Forms.Button();
            this.MasodikHozzaAdGomb = new System.Windows.Forms.Button();
            this.MasodikBevitelBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ElsoBevitelBox
            // 
            this.ElsoBevitelBox.Location = new System.Drawing.Point(12, 12);
            this.ElsoBevitelBox.Name = "ElsoBevitelBox";
            this.ElsoBevitelBox.Size = new System.Drawing.Size(120, 20);
            this.ElsoBevitelBox.TabIndex = 0;
            this.ElsoBevitelBox.TextChanged += new System.EventHandler(this.ElsoBevitelBox_TextChanged);
            // 
            // ElsoHozzaAdGomb
            // 
            this.ElsoHozzaAdGomb.Location = new System.Drawing.Point(151, 10);
            this.ElsoHozzaAdGomb.Name = "ElsoHozzaAdGomb";
            this.ElsoHozzaAdGomb.Size = new System.Drawing.Size(75, 23);
            this.ElsoHozzaAdGomb.TabIndex = 2;
            this.ElsoHozzaAdGomb.Text = "Hozzáad";
            this.ElsoHozzaAdGomb.UseVisualStyleBackColor = true;
            this.ElsoHozzaAdGomb.Click += new System.EventHandler(this.ElsoHozzaAdGomb_Click);
            // 
            // ElsoFelulreGomb
            // 
            this.ElsoFelulreGomb.Location = new System.Drawing.Point(151, 94);
            this.ElsoFelulreGomb.Name = "ElsoFelulreGomb";
            this.ElsoFelulreGomb.Size = new System.Drawing.Size(75, 23);
            this.ElsoFelulreGomb.TabIndex = 4;
            this.ElsoFelulreGomb.Text = "Felülre";
            this.ElsoFelulreGomb.UseVisualStyleBackColor = true;
            this.ElsoFelulreGomb.Click += new System.EventHandler(this.button3_Click);
            // 
            // ElsoLeGomb
            // 
            this.ElsoLeGomb.Location = new System.Drawing.Point(151, 152);
            this.ElsoLeGomb.Name = "ElsoLeGomb";
            this.ElsoLeGomb.Size = new System.Drawing.Size(75, 23);
            this.ElsoLeGomb.TabIndex = 6;
            this.ElsoLeGomb.Text = "Le";
            this.ElsoLeGomb.UseVisualStyleBackColor = true;
            this.ElsoLeGomb.Click += new System.EventHandler(this.ElsoLeGomb_Click);
            // 
            // ElsoAlulraGomb
            // 
            this.ElsoAlulraGomb.Location = new System.Drawing.Point(151, 181);
            this.ElsoAlulraGomb.Name = "ElsoAlulraGomb";
            this.ElsoAlulraGomb.Size = new System.Drawing.Size(75, 23);
            this.ElsoAlulraGomb.TabIndex = 7;
            this.ElsoAlulraGomb.Text = "Alulra";
            this.ElsoAlulraGomb.UseVisualStyleBackColor = true;
            this.ElsoAlulraGomb.Click += new System.EventHandler(this.ElsoAlulraGomb_Click);
            // 
            // ElsoTorolGomb
            // 
            this.ElsoTorolGomb.Location = new System.Drawing.Point(151, 295);
            this.ElsoTorolGomb.Name = "ElsoTorolGomb";
            this.ElsoTorolGomb.Size = new System.Drawing.Size(75, 23);
            this.ElsoTorolGomb.TabIndex = 8;
            this.ElsoTorolGomb.Text = "Töröl";
            this.ElsoTorolGomb.UseVisualStyleBackColor = true;
            this.ElsoTorolGomb.Click += new System.EventHandler(this.ElsoTorolGomb_Click);
            // 
            // JobbraGomb
            // 
            this.JobbraGomb.Location = new System.Drawing.Point(248, 94);
            this.JobbraGomb.Name = "JobbraGomb";
            this.JobbraGomb.Size = new System.Drawing.Size(38, 23);
            this.JobbraGomb.TabIndex = 9;
            this.JobbraGomb.Text = ">";
            this.JobbraGomb.UseVisualStyleBackColor = true;
            this.JobbraGomb.Click += new System.EventHandler(this.JobbraGomb_Click);
            // 
            // BalraGomb
            // 
            this.BalraGomb.Location = new System.Drawing.Point(248, 123);
            this.BalraGomb.Name = "BalraGomb";
            this.BalraGomb.Size = new System.Drawing.Size(38, 23);
            this.BalraGomb.TabIndex = 10;
            this.BalraGomb.Text = "<";
            this.BalraGomb.UseVisualStyleBackColor = true;
            this.BalraGomb.Click += new System.EventHandler(this.BalraGomb_Click);
            // 
            // ElsoLista
            // 
            this.ElsoLista.FormattingEnabled = true;
            this.ElsoLista.Location = new System.Drawing.Point(12, 39);
            this.ElsoLista.Name = "ElsoLista";
            this.ElsoLista.Size = new System.Drawing.Size(120, 277);
            this.ElsoLista.TabIndex = 11;
            this.ElsoLista.SelectedIndexChanged += new System.EventHandler(this.ElsoLista_SelectedIndexChanged);
            // 
            // ElsoFelGomb
            // 
            this.ElsoFelGomb.Location = new System.Drawing.Point(151, 123);
            this.ElsoFelGomb.Name = "ElsoFelGomb";
            this.ElsoFelGomb.Size = new System.Drawing.Size(75, 23);
            this.ElsoFelGomb.TabIndex = 12;
            this.ElsoFelGomb.Text = "Fel";
            this.ElsoFelGomb.UseCompatibleTextRendering = true;
            this.ElsoFelGomb.UseVisualStyleBackColor = true;
            this.ElsoFelGomb.Click += new System.EventHandler(this.ElsoFelGomb_Click);
            // 
            // MasodikFelGomb
            // 
            this.MasodikFelGomb.Location = new System.Drawing.Point(444, 123);
            this.MasodikFelGomb.Name = "MasodikFelGomb";
            this.MasodikFelGomb.Size = new System.Drawing.Size(75, 23);
            this.MasodikFelGomb.TabIndex = 20;
            this.MasodikFelGomb.Text = "Fel";
            this.MasodikFelGomb.UseVisualStyleBackColor = true;
            this.MasodikFelGomb.Click += new System.EventHandler(this.MasodikFelGomb_Click);
            // 
            // MasodikLista
            // 
            this.MasodikLista.FormattingEnabled = true;
            this.MasodikLista.Location = new System.Drawing.Point(305, 39);
            this.MasodikLista.Name = "MasodikLista";
            this.MasodikLista.Size = new System.Drawing.Size(120, 277);
            this.MasodikLista.TabIndex = 19;
            this.MasodikLista.SelectedIndexChanged += new System.EventHandler(this.MasodikLista_SelectedIndexChanged);
            // 
            // MasodikTorolGomb
            // 
            this.MasodikTorolGomb.Location = new System.Drawing.Point(444, 295);
            this.MasodikTorolGomb.Name = "MasodikTorolGomb";
            this.MasodikTorolGomb.Size = new System.Drawing.Size(75, 23);
            this.MasodikTorolGomb.TabIndex = 18;
            this.MasodikTorolGomb.Text = "Töröl";
            this.MasodikTorolGomb.UseVisualStyleBackColor = true;
            this.MasodikTorolGomb.Click += new System.EventHandler(this.MasodikTorolGomb_Click);
            // 
            // MasodikAlulraGomb
            // 
            this.MasodikAlulraGomb.Location = new System.Drawing.Point(444, 181);
            this.MasodikAlulraGomb.Name = "MasodikAlulraGomb";
            this.MasodikAlulraGomb.Size = new System.Drawing.Size(75, 23);
            this.MasodikAlulraGomb.TabIndex = 17;
            this.MasodikAlulraGomb.Text = "Alulra";
            this.MasodikAlulraGomb.UseVisualStyleBackColor = true;
            this.MasodikAlulraGomb.Click += new System.EventHandler(this.MasodikAlulraGomb_Click);
            // 
            // MasodikLeGomb
            // 
            this.MasodikLeGomb.Location = new System.Drawing.Point(444, 152);
            this.MasodikLeGomb.Name = "MasodikLeGomb";
            this.MasodikLeGomb.Size = new System.Drawing.Size(75, 23);
            this.MasodikLeGomb.TabIndex = 16;
            this.MasodikLeGomb.Text = "Le";
            this.MasodikLeGomb.UseVisualStyleBackColor = true;
            this.MasodikLeGomb.Click += new System.EventHandler(this.MasodikLeGomb_Click);
            // 
            // MasodikFelulreGomb
            // 
            this.MasodikFelulreGomb.Location = new System.Drawing.Point(444, 94);
            this.MasodikFelulreGomb.Name = "MasodikFelulreGomb";
            this.MasodikFelulreGomb.Size = new System.Drawing.Size(75, 23);
            this.MasodikFelulreGomb.TabIndex = 15;
            this.MasodikFelulreGomb.Text = "Felülre";
            this.MasodikFelulreGomb.UseVisualStyleBackColor = true;
            this.MasodikFelulreGomb.Click += new System.EventHandler(this.MasodikFelulreGomb_Click);
            // 
            // MasodikHozzaAdGomb
            // 
            this.MasodikHozzaAdGomb.Location = new System.Drawing.Point(444, 10);
            this.MasodikHozzaAdGomb.Name = "MasodikHozzaAdGomb";
            this.MasodikHozzaAdGomb.Size = new System.Drawing.Size(75, 23);
            this.MasodikHozzaAdGomb.TabIndex = 14;
            this.MasodikHozzaAdGomb.Text = "Hozzáad";
            this.MasodikHozzaAdGomb.UseVisualStyleBackColor = true;
            this.MasodikHozzaAdGomb.Click += new System.EventHandler(this.MasodikHozzaAdGomb_Click);
            // 
            // MasodikBevitelBox
            // 
            this.MasodikBevitelBox.Location = new System.Drawing.Point(305, 12);
            this.MasodikBevitelBox.Name = "MasodikBevitelBox";
            this.MasodikBevitelBox.Size = new System.Drawing.Size(120, 20);
            this.MasodikBevitelBox.TabIndex = 13;
            this.MasodikBevitelBox.TextChanged += new System.EventHandler(this.MasodikBevitelBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 349);
            this.Controls.Add(this.MasodikFelGomb);
            this.Controls.Add(this.MasodikLista);
            this.Controls.Add(this.MasodikTorolGomb);
            this.Controls.Add(this.MasodikAlulraGomb);
            this.Controls.Add(this.MasodikLeGomb);
            this.Controls.Add(this.MasodikFelulreGomb);
            this.Controls.Add(this.MasodikHozzaAdGomb);
            this.Controls.Add(this.MasodikBevitelBox);
            this.Controls.Add(this.ElsoFelGomb);
            this.Controls.Add(this.ElsoLista);
            this.Controls.Add(this.BalraGomb);
            this.Controls.Add(this.JobbraGomb);
            this.Controls.Add(this.ElsoTorolGomb);
            this.Controls.Add(this.ElsoAlulraGomb);
            this.Controls.Add(this.ElsoLeGomb);
            this.Controls.Add(this.ElsoFelulreGomb);
            this.Controls.Add(this.ElsoHozzaAdGomb);
            this.Controls.Add(this.ElsoBevitelBox);
            this.Name = "Form1";
            this.Text = "Listák";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MasodikBevitelBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ElsoLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ElsoBevitelBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox ElsoBevitelBox;
        private System.Windows.Forms.Button ElsoHozzaAdGomb;
        private System.Windows.Forms.Button ElsoFelulreGomb;
        private System.Windows.Forms.Button ElsoLeGomb;
        private System.Windows.Forms.Button ElsoAlulraGomb;
        private System.Windows.Forms.Button ElsoTorolGomb;
        private System.Windows.Forms.Button JobbraGomb;
        private System.Windows.Forms.Button BalraGomb;
        private System.Windows.Forms.ListBox ElsoLista;
        private System.Windows.Forms.Button ElsoFelGomb;
        private System.Windows.Forms.Button MasodikFelGomb;
        private System.Windows.Forms.ListBox MasodikLista;
        private System.Windows.Forms.Button MasodikTorolGomb;
        private System.Windows.Forms.Button MasodikAlulraGomb;
        private System.Windows.Forms.Button MasodikLeGomb;
        private System.Windows.Forms.Button MasodikFelulreGomb;
        private System.Windows.Forms.Button MasodikHozzaAdGomb;
        private System.Windows.Forms.TextBox MasodikBevitelBox;
    }
}

