using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad___
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void kivágásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();

        }

        private void szerkesztésToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void insertDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionLength = 0;
            richTextBox1.SelectedText = DateTime.Now.ToString("dd/mm/yyyy");
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked)

            {
                richTextBox1.WordWrap = false;
            }

           else richTextBox1.WordWrap = true;

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void beillesztésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void megnyitásToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Szöveges állomány (*.txt)|*.txt|Minden fájl (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader megnyitas = new System.IO.StreamReader(openFileDialog.FileName);
                while (!megnyitas.EndOfStream)
                {
                    richTextBox1.Text = megnyitas.ReadToEnd();
                }
                megnyitas.Close();
            }
        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.Filter = "Szöveges állomány (*.txt)|*.txt|Minden fájl (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter mentes = new System.IO.StreamWriter(saveFileDialog.FileName);
                mentes.WriteLine(richTextBox1.Text);
                mentes.Flush();
                mentes.Close();
            }
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
                Environment.Exit(0);

            else
            {
                DialogResult result = MessageBox.Show("Az ablak tartalma nem üres\n\nBiztosan kilép?", "Kérdés", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is NotePad+++\n\n" + "Made by: Peter Teszáry", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
           
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox1.DeselectAll();
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox1.DeselectAll();
        }
    }
}
