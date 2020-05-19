using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class FormUtama : Form
    {

        public string bil1, bil2, hasil;
        public char operasi;

        public FormUtama()
        {
            InitializeComponent();
        }

        private void btnSatu_Click(object sender, EventArgs e)
        {
            hasil += "1";
            txtHasil.Text = hasil;
        }

        private void btnDua_Click(object sender, EventArgs e)
        {
            hasil += "2";
            txtHasil.Text = hasil;
        }

        private void btnTiga_Click(object sender, EventArgs e)
        {
            hasil += "3";
            txtHasil.Text = hasil;
        }

        private void btnEmpat_Click(object sender, EventArgs e)
        {
            hasil += "4";
            txtHasil.Text = hasil;
        }

        private void btnLima_Click(object sender, EventArgs e)
        {
            hasil += "5";
            txtHasil.Text = hasil;
        }

        private void btnEnam_Click(object sender, EventArgs e)
        {
            hasil += "6";
            txtHasil.Text = hasil;
        }

        private void btnTujuh_Click(object sender, EventArgs e)
        {
            hasil += "7";
            txtHasil.Text = hasil;
        }

        private void btnDelapan_Click(object sender, EventArgs e)
        {
            hasil += "8";
            txtHasil.Text = hasil;
        }

        private void btnSembilan_Click(object sender, EventArgs e)
        {
            hasil += "9";
            txtHasil.Text = hasil;
        }

        private void btnNol_Click(object sender, EventArgs e)
        {
            hasil += "0";
            txtHasil.Text = hasil;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            hasil = "";
            operasi = 'a';
            txtHasil.Text = hasil;
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            operasi = '/';
            hasil += "/";
            txtHasil.Text = hasil;
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            operasi = 'x';
            hasil += "x";
            txtHasil.Text = hasil;
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            operasi = '-';
            hasil += "-";
            txtHasil.Text = hasil;
        }

        private void btnSamaDengan_Click(object sender, EventArgs e)
        {
            string[] bilangan = hasil.Split(operasi);

            double bil1 = double.Parse(bilangan[0]);
            double bil2 = double.Parse(bilangan[1]);
            double result = 0;

            if (operasi == '+')
            {
                result = bil1 + bil2; 
            } else if (operasi == '-')
            {
                result = bil1 - bil2;
            } else if (operasi == 'x')
            {
                result = bil1 * bil2;
            } else if (operasi == '/')
            {
                result = bil1 / bil2;
            }

            hasil = Convert.ToString(result);
            //operasi = 'a';
            txtHasil.Text = Convert.ToString(result);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            hasil += "-";
            txtHasil.Text = hasil;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KalkulatorKu: \nCreated by M SAIF ALIKHAN @ 2020");
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            operasi = '+';
            hasil += "+";
            txtHasil.Text = hasil;
        }

        private void btnTitik_Click(object sender, EventArgs e)
        {
            hasil += ".";
            txtHasil.Text = hasil;
        }
    }
}
