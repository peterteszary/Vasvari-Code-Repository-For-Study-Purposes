﻿namespace listbox_gui
{
    partial class listaexport
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
            this.lista = new System.Windows.Forms.ListBox();
            this.generalas = new System.Windows.Forms.Button();
            this.valasztottelem = new System.Windows.Forms.Label();
            this.elemhozzaadgomb = new System.Windows.Forms.Button();
            this.szamhozzaad = new System.Windows.Forms.TextBox();
            this.torlesgomb = new System.Windows.Forms.Button();
            this.listatorlesegomb = new System.Windows.Forms.Button();
            this.listarendezesegomb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listaimport = new System.Windows.Forms.Button();
            this.fileexport = new System.Windows.Forms.Button();
            this.fileimport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 20;
            this.lista.Location = new System.Drawing.Point(3, 12);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(257, 604);
            this.lista.TabIndex = 0;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // generalas
            // 
            this.generalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generalas.Location = new System.Drawing.Point(270, 12);
            this.generalas.Name = "generalas";
            this.generalas.Size = new System.Drawing.Size(327, 73);
            this.generalas.TabIndex = 1;
            this.generalas.Text = "Számlista generálása";
            this.generalas.UseVisualStyleBackColor = true;
            this.generalas.Click += new System.EventHandler(this.generalas_Click);
            // 
            // valasztottelem
            // 
            this.valasztottelem.AutoSize = true;
            this.valasztottelem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valasztottelem.Location = new System.Drawing.Point(338, 88);
            this.valasztottelem.Name = "valasztottelem";
            this.valasztottelem.Size = new System.Drawing.Size(206, 24);
            this.valasztottelem.TabIndex = 2;
            this.valasztottelem.Text = "Választott elem: 5000";
            this.valasztottelem.Click += new System.EventHandler(this.label1_Click);
            // 
            // elemhozzaadgomb
            // 
            this.elemhozzaadgomb.Enabled = false;
            this.elemhozzaadgomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.elemhozzaadgomb.Location = new System.Drawing.Point(270, 150);
            this.elemhozzaadgomb.Name = "elemhozzaadgomb";
            this.elemhozzaadgomb.Size = new System.Drawing.Size(327, 40);
            this.elemhozzaadgomb.TabIndex = 3;
            this.elemhozzaadgomb.Text = "Szám hozzáadása";
            this.elemhozzaadgomb.UseVisualStyleBackColor = true;
            this.elemhozzaadgomb.Click += new System.EventHandler(this.elemhozzaad_Click);
            // 
            // szamhozzaad
            // 
            this.szamhozzaad.Enabled = false;
            this.szamhozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szamhozzaad.Location = new System.Drawing.Point(270, 115);
            this.szamhozzaad.Name = "szamhozzaad";
            this.szamhozzaad.Size = new System.Drawing.Size(323, 29);
            this.szamhozzaad.TabIndex = 4;
            this.szamhozzaad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.szamhozzaad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // torlesgomb
            // 
            this.torlesgomb.Enabled = false;
            this.torlesgomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.torlesgomb.Location = new System.Drawing.Point(270, 196);
            this.torlesgomb.Name = "torlesgomb";
            this.torlesgomb.Size = new System.Drawing.Size(327, 37);
            this.torlesgomb.TabIndex = 5;
            this.torlesgomb.Text = "Elem törlése";
            this.torlesgomb.UseVisualStyleBackColor = true;
            this.torlesgomb.Click += new System.EventHandler(this.torlesgomb_Click);
            // 
            // listatorlesegomb
            // 
            this.listatorlesegomb.Enabled = false;
            this.listatorlesegomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listatorlesegomb.Location = new System.Drawing.Point(270, 239);
            this.listatorlesegomb.Name = "listatorlesegomb";
            this.listatorlesegomb.Size = new System.Drawing.Size(327, 38);
            this.listatorlesegomb.TabIndex = 6;
            this.listatorlesegomb.Text = "Lista törlése";
            this.listatorlesegomb.UseVisualStyleBackColor = true;
            this.listatorlesegomb.Click += new System.EventHandler(this.listatorlesegomb_Click);
            // 
            // listarendezesegomb
            // 
            this.listarendezesegomb.Enabled = false;
            this.listarendezesegomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listarendezesegomb.Location = new System.Drawing.Point(270, 283);
            this.listarendezesegomb.Name = "listarendezesegomb";
            this.listarendezesegomb.Size = new System.Drawing.Size(327, 37);
            this.listarendezesegomb.TabIndex = 7;
            this.listarendezesegomb.Text = "Lista rendezése";
            this.listarendezesegomb.UseVisualStyleBackColor = true;
            this.listarendezesegomb.Click += new System.EventHandler(this.listarendezesegomb_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(270, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Lista exportálása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaimport
            // 
            this.listaimport.Enabled = false;
            this.listaimport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listaimport.Location = new System.Drawing.Point(270, 488);
            this.listaimport.Name = "listaimport";
            this.listaimport.Size = new System.Drawing.Size(271, 37);
            this.listaimport.TabIndex = 9;
            this.listaimport.Text = "Lista importálása";
            this.listaimport.UseVisualStyleBackColor = true;
            // 
            // fileexport
            // 
            this.fileexport.Enabled = false;
            this.fileexport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileexport.Location = new System.Drawing.Point(547, 445);
            this.fileexport.Name = "fileexport";
            this.fileexport.Size = new System.Drawing.Size(46, 37);
            this.fileexport.TabIndex = 10;
            this.fileexport.Text = "...";
            this.fileexport.UseVisualStyleBackColor = true;
            this.fileexport.Click += new System.EventHandler(this.button2_Click);
            // 
            // fileimport
            // 
            this.fileimport.Enabled = false;
            this.fileimport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileimport.Location = new System.Drawing.Point(547, 488);
            this.fileimport.Name = "fileimport";
            this.fileimport.Size = new System.Drawing.Size(46, 37);
            this.fileimport.TabIndex = 11;
            this.fileimport.Text = "...";
            this.fileimport.UseVisualStyleBackColor = true;
            // 
            // listaexport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 630);
            this.Controls.Add(this.fileimport);
            this.Controls.Add(this.fileexport);
            this.Controls.Add(this.listaimport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listarendezesegomb);
            this.Controls.Add(this.listatorlesegomb);
            this.Controls.Add(this.torlesgomb);
            this.Controls.Add(this.szamhozzaad);
            this.Controls.Add(this.elemhozzaadgomb);
            this.Controls.Add(this.valasztottelem);
            this.Controls.Add(this.generalas);
            this.Controls.Add(this.lista);
            this.Name = "listaexport";
            this.Text = "Számlista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button generalas;
        private System.Windows.Forms.Label valasztottelem;
        private System.Windows.Forms.Button elemhozzaadgomb;
        private System.Windows.Forms.TextBox szamhozzaad;
        private System.Windows.Forms.Button torlesgomb;
        private System.Windows.Forms.Button listatorlesegomb;
        private System.Windows.Forms.Button listarendezesegomb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button listaimport;
        private System.Windows.Forms.Button fileexport;
        private System.Windows.Forms.Button fileimport;
    }
}

