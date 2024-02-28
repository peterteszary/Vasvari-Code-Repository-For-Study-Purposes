using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szovegszerkeszto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void újDokumentumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (szovegbeviteliablak.Text == "")
                szovegbeviteliablak.Clear();
            else 
            {
                DialogResult result = MessageBox.Show("Az ablak tartalma nem üres\n\nSzeretné törölni?", "Kérdés", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    szovegbeviteliablak.Clear();
                }
            }
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Szöveges állomány (*.txt)|*.txt|Minden fájl (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader megnyitas = new System.IO.StreamReader(openFileDialog.FileName);
                while (!megnyitas.EndOfStream)
                {
                    szovegbeviteliablak.Text = megnyitas.ReadToEnd();
                }
                megnyitas.Close();
            }
        }

        private void mentésMáskéntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.Filter = "Szöveges állomány (*.txt)|*.txt|Minden fájl (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter mentes = new System.IO.StreamWriter(saveFileDialog.FileName);
                mentes.WriteLine(szovegbeviteliablak.Text);
                mentes.Flush();
                mentes.Close();
            }
        }

        private void fájlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (szovegbeviteliablak.Text == "")
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

        private void kivágásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szovegbeviteliablak.Cut();
        }

        private void másolásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szovegbeviteliablak.Copy();
        }

        private void beillesztésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szovegbeviteliablak.Paste();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ez egy szövegszerkesztő program\n\n" + "Készítette: Teszáry Péter", "Névjegy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
