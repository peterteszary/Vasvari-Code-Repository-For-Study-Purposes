using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osszefoglalo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CsakBezarGomb_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ezt csak be lehet zárni!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ValasztasGomb_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ez már egy választást is tartalmaz", "Üzenet", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Az OK gombra kattintott!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A MÉGSE gombra kattintott", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MegnyitasGomb_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Szöveges dokumentum(*.txt)|*.txt| Minden fájl(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {}
        }

        private void MentesMaskentGomb_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Szöveges dokumentum(*.txt)|*.txt| Minden fájl(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            { }
        }

        private void HatterSzinGomb_Click(object sender, EventArgs e)
        {
            if (HatterSzinAblak.ShowDialog() == DialogResult.OK)
            {
                Ablakok_Teszt.BackColor = HatterSzinAblak.Color;
            }
        }

        private void KarakterValtGomb_Click(object sender, EventArgs e)
        {
            if (BetuFormaAblak.ShowDialog() == DialogResult.OK)
            {
                Ablakok_Teszt.Font = BetuFormaAblak.Font;
                Ablakok_Teszt.ForeColor = BetuFormaAblak.Color;
            }
        }

        private void CheckBoxEllenorzoGomb_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Az első Checkbox van kiválasztva!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (checkBox2.Checked)
            {
                MessageBox.Show("A második Checkbox van kiválasztva!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (checkBox3.Checked)
            {
                MessageBox.Show("A harmadik Checkbox van kiválasztva!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
