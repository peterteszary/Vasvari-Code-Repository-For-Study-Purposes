namespace szamlista_szurese
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
            this.KezdoLista = new System.Windows.Forms.ListBox();
            this.SzurtLista = new System.Windows.Forms.ListBox();
            this.GeneralasGomb = new System.Windows.Forms.Button();
            this.KezdoErtekTextBox = new System.Windows.Forms.TextBox();
            this.VegertekTextBox = new System.Windows.Forms.TextBox();
            this.KezdoertekMezo = new System.Windows.Forms.Label();
            this.VegertekMezo = new System.Windows.Forms.Label();
            this.ParosRadioButton = new System.Windows.Forms.RadioButton();
            this.ParatlanRadioButton = new System.Windows.Forms.RadioButton();
            this.HarommalOszthatoRadioButton = new System.Windows.Forms.RadioButton();
            this.OttelOszthatoRadioButton = new System.Windows.Forms.RadioButton();
            this.HettelOszthatoRadioButton = new System.Windows.Forms.RadioButton();
            this.OsztoValasztoComBox = new System.Windows.Forms.ComboBox();
            this.OsztoValasztoLabel = new System.Windows.Forms.Label();
            this.DarabszamLabel = new System.Windows.Forms.Label();
            this.DarabSzamTextBox = new System.Windows.Forms.TextBox();
            this.SzuresGomb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KezdoLista
            // 
            this.KezdoLista.FormattingEnabled = true;
            this.KezdoLista.Location = new System.Drawing.Point(178, 26);
            this.KezdoLista.Name = "KezdoLista";
            this.KezdoLista.Size = new System.Drawing.Size(120, 329);
            this.KezdoLista.TabIndex = 0;
            // 
            // SzurtLista
            // 
            this.SzurtLista.FormattingEnabled = true;
            this.SzurtLista.Location = new System.Drawing.Point(469, 26);
            this.SzurtLista.Name = "SzurtLista";
            this.SzurtLista.Size = new System.Drawing.Size(120, 329);
            this.SzurtLista.TabIndex = 1;
            // 
            // GeneralasGomb
            // 
            this.GeneralasGomb.BackColor = System.Drawing.Color.Beige;
            this.GeneralasGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GeneralasGomb.Location = new System.Drawing.Point(31, 324);
            this.GeneralasGomb.Name = "GeneralasGomb";
            this.GeneralasGomb.Size = new System.Drawing.Size(119, 31);
            this.GeneralasGomb.TabIndex = 2;
            this.GeneralasGomb.Text = "Generálás";
            this.GeneralasGomb.UseVisualStyleBackColor = false;
            this.GeneralasGomb.Click += new System.EventHandler(this.GeneralasGomb_Click);
            // 
            // KezdoErtekTextBox
            // 
            this.KezdoErtekTextBox.Location = new System.Drawing.Point(31, 42);
            this.KezdoErtekTextBox.Name = "KezdoErtekTextBox";
            this.KezdoErtekTextBox.Size = new System.Drawing.Size(100, 20);
            this.KezdoErtekTextBox.TabIndex = 3;
            // 
            // VegertekTextBox
            // 
            this.VegertekTextBox.Location = new System.Drawing.Point(31, 109);
            this.VegertekTextBox.Name = "VegertekTextBox";
            this.VegertekTextBox.Size = new System.Drawing.Size(100, 20);
            this.VegertekTextBox.TabIndex = 4;
            // 
            // KezdoertekMezo
            // 
            this.KezdoertekMezo.AutoSize = true;
            this.KezdoertekMezo.Location = new System.Drawing.Point(31, 26);
            this.KezdoertekMezo.Name = "KezdoertekMezo";
            this.KezdoertekMezo.Size = new System.Drawing.Size(61, 13);
            this.KezdoertekMezo.TabIndex = 5;
            this.KezdoertekMezo.Text = "Kezdőérték";
            // 
            // VegertekMezo
            // 
            this.VegertekMezo.AutoSize = true;
            this.VegertekMezo.Location = new System.Drawing.Point(31, 93);
            this.VegertekMezo.Name = "VegertekMezo";
            this.VegertekMezo.Size = new System.Drawing.Size(50, 13);
            this.VegertekMezo.TabIndex = 6;
            this.VegertekMezo.Text = "Végérték";
            // 
            // ParosRadioButton
            // 
            this.ParosRadioButton.AutoSize = true;
            this.ParosRadioButton.Location = new System.Drawing.Point(326, 26);
            this.ParosRadioButton.Name = "ParosRadioButton";
            this.ParosRadioButton.Size = new System.Drawing.Size(79, 17);
            this.ParosRadioButton.TabIndex = 7;
            this.ParosRadioButton.TabStop = true;
            this.ParosRadioButton.Text = "Páros szám";
            this.ParosRadioButton.UseVisualStyleBackColor = true;
            // 
            // ParatlanRadioButton
            // 
            this.ParatlanRadioButton.AutoSize = true;
            this.ParatlanRadioButton.Location = new System.Drawing.Point(326, 49);
            this.ParatlanRadioButton.Name = "ParatlanRadioButton";
            this.ParatlanRadioButton.Size = new System.Drawing.Size(91, 17);
            this.ParatlanRadioButton.TabIndex = 8;
            this.ParatlanRadioButton.TabStop = true;
            this.ParatlanRadioButton.Text = "Páratlan szám";
            this.ParatlanRadioButton.UseVisualStyleBackColor = true;
            // 
            // HarommalOszthatoRadioButton
            // 
            this.HarommalOszthatoRadioButton.AutoSize = true;
            this.HarommalOszthatoRadioButton.Location = new System.Drawing.Point(326, 72);
            this.HarommalOszthatoRadioButton.Name = "HarommalOszthatoRadioButton";
            this.HarommalOszthatoRadioButton.Size = new System.Drawing.Size(85, 17);
            this.HarommalOszthatoRadioButton.TabIndex = 9;
            this.HarommalOszthatoRadioButton.TabStop = true;
            this.HarommalOszthatoRadioButton.Text = "3-al osztható";
            this.HarommalOszthatoRadioButton.UseVisualStyleBackColor = true;
            // 
            // OttelOszthatoRadioButton
            // 
            this.OttelOszthatoRadioButton.AutoSize = true;
            this.OttelOszthatoRadioButton.Location = new System.Drawing.Point(326, 95);
            this.OttelOszthatoRadioButton.Name = "OttelOszthatoRadioButton";
            this.OttelOszthatoRadioButton.Size = new System.Drawing.Size(85, 17);
            this.OttelOszthatoRadioButton.TabIndex = 10;
            this.OttelOszthatoRadioButton.TabStop = true;
            this.OttelOszthatoRadioButton.Text = "5-el osztható";
            this.OttelOszthatoRadioButton.UseVisualStyleBackColor = true;
            // 
            // HettelOszthatoRadioButton
            // 
            this.HettelOszthatoRadioButton.AutoSize = true;
            this.HettelOszthatoRadioButton.Location = new System.Drawing.Point(326, 118);
            this.HettelOszthatoRadioButton.Name = "HettelOszthatoRadioButton";
            this.HettelOszthatoRadioButton.Size = new System.Drawing.Size(85, 17);
            this.HettelOszthatoRadioButton.TabIndex = 11;
            this.HettelOszthatoRadioButton.TabStop = true;
            this.HettelOszthatoRadioButton.Text = "7-el osztható";
            this.HettelOszthatoRadioButton.UseVisualStyleBackColor = true;
            // 
            // OsztoValasztoComBox
            // 
            this.OsztoValasztoComBox.FormattingEnabled = true;
            this.OsztoValasztoComBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.OsztoValasztoComBox.Location = new System.Drawing.Point(326, 174);
            this.OsztoValasztoComBox.Name = "OsztoValasztoComBox";
            this.OsztoValasztoComBox.Size = new System.Drawing.Size(121, 21);
            this.OsztoValasztoComBox.TabIndex = 12;
            this.OsztoValasztoComBox.SelectedIndexChanged += new System.EventHandler(this.OsztoValasztoComBox_SelectedIndexChanged);
            // 
            // OsztoValasztoLabel
            // 
            this.OsztoValasztoLabel.AutoSize = true;
            this.OsztoValasztoLabel.Location = new System.Drawing.Point(326, 155);
            this.OsztoValasztoLabel.Name = "OsztoValasztoLabel";
            this.OsztoValasztoLabel.Size = new System.Drawing.Size(86, 13);
            this.OsztoValasztoLabel.TabIndex = 13;
            this.OsztoValasztoLabel.Text = "Válasszon osztót";
            // 
            // DarabszamLabel
            // 
            this.DarabszamLabel.AutoSize = true;
            this.DarabszamLabel.Location = new System.Drawing.Point(31, 155);
            this.DarabszamLabel.Name = "DarabszamLabel";
            this.DarabszamLabel.Size = new System.Drawing.Size(60, 13);
            this.DarabszamLabel.TabIndex = 15;
            this.DarabszamLabel.Text = "Darabszám";
            // 
            // DarabSzamTextBox
            // 
            this.DarabSzamTextBox.Location = new System.Drawing.Point(31, 175);
            this.DarabSzamTextBox.Name = "DarabSzamTextBox";
            this.DarabSzamTextBox.Size = new System.Drawing.Size(100, 20);
            this.DarabSzamTextBox.TabIndex = 16;
            // 
            // SzuresGomb
            // 
            this.SzuresGomb.BackColor = System.Drawing.Color.Beige;
            this.SzuresGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SzuresGomb.Location = new System.Drawing.Point(326, 324);
            this.SzuresGomb.Name = "SzuresGomb";
            this.SzuresGomb.Size = new System.Drawing.Size(119, 31);
            this.SzuresGomb.TabIndex = 17;
            this.SzuresGomb.Text = "Szűrés";
            this.SzuresGomb.UseVisualStyleBackColor = false;
            this.SzuresGomb.Click += new System.EventHandler(this.SzuresGomb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(637, 385);
            this.Controls.Add(this.SzuresGomb);
            this.Controls.Add(this.DarabSzamTextBox);
            this.Controls.Add(this.DarabszamLabel);
            this.Controls.Add(this.OsztoValasztoLabel);
            this.Controls.Add(this.OsztoValasztoComBox);
            this.Controls.Add(this.HettelOszthatoRadioButton);
            this.Controls.Add(this.OttelOszthatoRadioButton);
            this.Controls.Add(this.HarommalOszthatoRadioButton);
            this.Controls.Add(this.ParatlanRadioButton);
            this.Controls.Add(this.ParosRadioButton);
            this.Controls.Add(this.VegertekMezo);
            this.Controls.Add(this.KezdoertekMezo);
            this.Controls.Add(this.VegertekTextBox);
            this.Controls.Add(this.KezdoErtekTextBox);
            this.Controls.Add(this.GeneralasGomb);
            this.Controls.Add(this.SzurtLista);
            this.Controls.Add(this.KezdoLista);
            this.Name = "Form1";
            this.Text = "Számlista szűrése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox KezdoLista;
        private System.Windows.Forms.ListBox SzurtLista;
        private System.Windows.Forms.Button GeneralasGomb;
        private System.Windows.Forms.TextBox KezdoErtekTextBox;
        private System.Windows.Forms.TextBox VegertekTextBox;
        private System.Windows.Forms.Label KezdoertekMezo;
        private System.Windows.Forms.Label VegertekMezo;
        private System.Windows.Forms.RadioButton ParosRadioButton;
        private System.Windows.Forms.RadioButton ParatlanRadioButton;
        private System.Windows.Forms.RadioButton HarommalOszthatoRadioButton;
        private System.Windows.Forms.RadioButton OttelOszthatoRadioButton;
        private System.Windows.Forms.RadioButton HettelOszthatoRadioButton;
        private System.Windows.Forms.ComboBox OsztoValasztoComBox;
        private System.Windows.Forms.Label OsztoValasztoLabel;
        private System.Windows.Forms.Label DarabszamLabel;
        private System.Windows.Forms.TextBox DarabSzamTextBox;
        private System.Windows.Forms.Button SzuresGomb;
    }
}

