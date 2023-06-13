using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraJuros
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void BtnJurosSimplesClick(object sender, EventArgs e)
		{
			FrmJurosSimples fjs = new FrmJurosSimples();
			fjs.Show();
		}
		void BtnJurosCompostosClick(object sender, EventArgs e)
		{
			FrmJurosCompostos fjc = new FrmJurosCompostos();
			fjc.Show();
		}
		void BtnMontanteSimplesClick(object sender, EventArgs e)
		{
			FrmMontanteSimples fms = new FrmMontanteSimples();
			fms.Show();
		}
		void BtnMontanteCompostosClick(object sender, EventArgs e)
		{
			FrmMontanteCompostos fmc = new FrmMontanteCompostos();
			fmc.Show();
		}
		void BtnFormulasClick(object sender, EventArgs e)
		{
			FrmFormulas ffu = new FrmFormulas();
			ffu.Show();
		}
	}
}
