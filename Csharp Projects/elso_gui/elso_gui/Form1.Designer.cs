namespace elso_gui
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
            this.gomb1 = new System.Windows.Forms.Button();
            this.gomb2 = new System.Windows.Forms.Button();
            this.gomb3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gomb1
            // 
            this.gomb1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.gomb1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.gomb1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gomb1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gomb1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gomb1.Location = new System.Drawing.Point(47, 53);
            this.gomb1.Name = "gomb1";
            this.gomb1.Size = new System.Drawing.Size(192, 94);
            this.gomb1.TabIndex = 0;
            this.gomb1.Text = "Gomb";
            this.gomb1.UseVisualStyleBackColor = false;
            this.gomb1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gomb2
            // 
            this.gomb2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.gomb2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.gomb2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gomb2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gomb2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gomb2.Location = new System.Drawing.Point(292, 53);
            this.gomb2.Name = "gomb2";
            this.gomb2.Size = new System.Drawing.Size(192, 94);
            this.gomb2.TabIndex = 1;
            this.gomb2.Text = "Gomb";
            this.gomb2.UseVisualStyleBackColor = false;
            // 
            // gomb3
            // 
            this.gomb3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.gomb3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.gomb3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gomb3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gomb3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gomb3.Location = new System.Drawing.Point(532, 53);
            this.gomb3.Name = "gomb3";
            this.gomb3.Size = new System.Drawing.Size(192, 94);
            this.gomb3.TabIndex = 2;
            this.gomb3.Text = "Gomb";
            this.gomb3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gomb3);
            this.Controls.Add(this.gomb2);
            this.Controls.Add(this.gomb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gomb1;
        private System.Windows.Forms.Button gomb2;
        private System.Windows.Forms.Button gomb3;
    }
}

