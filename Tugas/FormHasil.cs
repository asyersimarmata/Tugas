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
    public partial class FormHasil : Form
    {
        public FormHasil()
        {
            InitializeComponent();
        }

        private void proses(int a, int b, string operasi, string simbol, float hasil)
        {
            listBoxHasil.Items.Add(String.Format($"Hasil {operasi} {a} {simbol} {b} = ")+String.Format(hasil % 1 == 0 ? "{0:0}" : "{0:0.00}", hasil));
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            FormCalculator formCalculator = new FormCalculator();
            formCalculator.onProses += proses;
            formCalculator.ShowDialog();
        }
    }
}
