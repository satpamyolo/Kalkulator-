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
	public partial class Form_Hasil : Form
	{

		public Form_Hasil()
		{
			InitializeComponent();
		}

		private void proses(int nilaiA, int nilaiB, string operasi, string operasiLabel, float hasil)
		{
			listBox1.Items.Add(
				String.Format($"Hasil {operasiLabel} dari {nilaiA} {operasi} {nilaiB} = ") +
				String.Format(hasil % 1 == 0 ? "{0:0}" : "{0:0.00}", hasil)
				);
		}
		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnHitung_Click(object sender, EventArgs e)
		{
			FormInput formInput = new FormInput();
			formInput.prosesEvent += proses;
			formInput.ShowDialog();
		}
	}
}
