using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
	public partial class FormInput : Form
	{
        public delegate void Proses(int nilaiA, int nilaiB, string operasi, string operasiLabel, float hasil);

        public event Proses prosesEvent;

        public FormInput()
		{
			InitializeComponent();
            KalkulatorInit();
		}

        private void KalkulatorInit()
        {
            cmbOps.Items.Clear();
            cmbOps.Items.Add("Penjumlahan");
            cmbOps.Items.Add("Pengurangan");
            cmbOps.Items.Add("Perkalian");
            cmbOps.Items.Add("Pembagian");
            cmbOps.SelectedIndex = 0;
        }
        private void btnProses_Click(object sender, EventArgs e)
		{
            int nilaiA = int.Parse(txtNilaiA.Text);
            int nilaiB = int.Parse(txtNilaiB.Text);
            string op = "";
            string OpsLabel = "";
            float hasil = 0;
            switch (cmbOps.SelectedIndex)
            {
                //penjumlahan
                case 0:
                    hasil = Kalkulator.Operasi.Penjumlahan(nilaiA, nilaiB);
                    OpsLabel = "Penjumlahan";
                    op = "+";
                    break;
                //pengurangan
                case 1:
                    hasil = Kalkulator.Operasi.Pengurangan(nilaiA, nilaiB);
                    OpsLabel = "Pengurangan";
                    op = "-";
                    break;
                //perkalian
                case 2:
                    hasil = Kalkulator.Operasi.Perkalian(nilaiA, nilaiB);
                    OpsLabel = "Perkalian";
                    op = "x";
                    break;
                //pembagian
                case 3:
                    hasil = Kalkulator.Operasi.Pembagian(nilaiA, nilaiB);
                    OpsLabel = "Pembagian";
                    op = "/";
                    break;
            }
            prosesEvent(nilaiA, nilaiB, op, OpsLabel, hasil);
        }

		private void FormInput_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtNilaiB_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
