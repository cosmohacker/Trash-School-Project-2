using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomEvents
{
    public partial class Form1 : Form
    {
        Random random;
        int num1, hak = 5, tahmin;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();
            num1 = random.Next(1, 50);
            lblRandom.Text = num1.ToString();
        }

        private void btnDene_Click(object sender, EventArgs e)
        {

            if (txtTahmin.Text.Length == 0)
            {
                txtTahmin.Text = "0";
            }

            if (txtTahmin.Text != num1.ToString())
            {
                lblCevap.Text = "Yanlış";
                hak--;
                lblHak.Text = "Hak : " + hak.ToString();
            }
            else if (txtTahmin.Text == num1.ToString())
            {
                lblCevap.Text = "Doğru";
            }

            if (txtTahmin.Text == "Rakam")
            {
                txtTahmin.Text = "0";
            }

            tahmin = Convert.ToInt32(txtTahmin.Text);
            if (tahmin < num1)
            {
                lblCevap.Text = "Yanlış, Daha büyük olmalı";
            }
            else if (tahmin > num1)
            {
                lblCevap.Text = "Yanlış, Daha küçük olmalı";
            }

            if (txtTahmin.Text == num1.ToString())
            {
                lblCevap.Text = "Doğru";
                lblHak.Text = "Hak : " + hak.ToString();
                MessageBox.Show("Tebrikler başardın " + num1.ToString(), "You Survived", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private void lblHak_TextChanged(object sender, EventArgs e)
        {
            if (lblHak.Text == "Hak : 0")
            {
                MessageBox.Show("Sayıyı bulamadınız tutulan sayı " + num1.ToString(), "You Died", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTahmin_Click(object sender, EventArgs e)
        {
            if (txtTahmin.Text == "Rakam")
            {
                txtTahmin.Text = "";
            }
        }

        private void txtTahmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
    }
}
