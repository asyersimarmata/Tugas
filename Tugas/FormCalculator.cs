using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas
{
    public partial class FormCalculator : Form
    {
        public delegate void Proses(int a, int b, string operasi, string simbol, float hasil);
        public event Proses onProses;
        public FormCalculator()
        {
            InitializeComponent();
            boxOperasi();
        }

        private void boxOperasi()
        {
            comboBoxOperasi.Items.Clear();
            comboBoxOperasi.Items.Add("Penjumlahan");
            comboBoxOperasi.Items.Add("Pengurangan");
            comboBoxOperasi.Items.Add("Perkalian");
            comboBoxOperasi.Items.Add("Pembagian");
            comboBoxOperasi.SelectedIndex = 0;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            int a = int.Parse(txtNilaiA.Text);
            int b = int.Parse(txtNilaiB.Text);

            string operasi = "";
            string simbol = "";
            float hasil = 0;

            switch (comboBoxOperasi.SelectedIndex)
            {
                case 0:
                    hasil = cal.Penjumlahan(a, b);
                    operasi = "penjumlahan";
                    simbol = "+";
                    break;
                case 1:
                    hasil = cal.Pengurangan(a, b);
                    operasi = "pengurangan";
                    simbol = "-";
                    break;
                case 2:
                    hasil = cal.Perkalian(a, b);
                    operasi = "perkalian";
                    simbol = "*";
                    break;
                case 3:
                    hasil = (float)cal.Pembagian(a, b);
                    operasi = "pembagian";
                    simbol = "/";
                    break;

            }
            onProses(a, b, operasi, simbol, hasil);
        }
    }
}
