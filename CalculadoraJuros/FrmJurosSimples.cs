using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraJuros
{
	public partial class FrmJurosSimples : Form
	{
		public FrmJurosSimples()
		{
			InitializeComponent();
		}
		void BtnCalcularClick(object sender, EventArgs e)
		{
			if (optcapital.Checked==true)
			{
				double juros = double.Parse(txtjuros.Text);
				double taxa = double.Parse(txttaxa.Text) / 100.0;
				int periodo = int.Parse(txtperiodo.Text);
				
				double capital = juros/(taxa*periodo);
				txtcapital.Text = Math.Round(capital, 2).ToString();
			}
			if (optjuros.Checked==true)
			{
				double taxa = double.Parse(txttaxa.Text) / 100.0;
				int periodo = int.Parse(txtperiodo.Text);
				double capital = double.Parse(txtcapital.Text);
				
				double juros = capital*taxa*periodo;
				txtjuros.Text = Math.Round(juros, 2).ToString();
			}
			if (optperiodo.Checked==true)
			{
				double taxa = double.Parse(txttaxa.Text) / 100.0;
				double capital = double.Parse(txtcapital.Text);
				double juros = double.Parse(txtjuros.Text);
				
				int periodo = (int)(juros/(capital*taxa));
				txtperiodo.Text = periodo.ToString();
			}
			if (opttaxa.Checked==true)
			{
				int periodo = int.Parse(txtperiodo.Text);
				double capital = double.Parse(txtcapital.Text);
				double juros = double.Parse(txtjuros.Text);
				
				double taxa = (juros/(capital*periodo)) * 100;
				txttaxa.Text = Math.Round(taxa, 2).ToString();
				
			}
		}
		void OptcapitalCheckedChanged(object sender, EventArgs e)
		{
			if (optcapital.Checked==true)
			{
				txtjuros.Enabled=true;
				txtperiodo.Enabled=true;
				txttaxa.Enabled=true;
				txtcapital.Enabled=false;
			}
		}
		void OptjurosCheckedChanged(object sender, EventArgs e)
		{
			if (optjuros.Checked==true)
			{
				txtjuros.Enabled=false;
				txtperiodo.Enabled=true;
				txttaxa.Enabled=true;
				txtcapital.Enabled=true;
			}
		}
		void FrmJurosSimplesShown(object sender, EventArgs e)
		{
			optjuros.Checked=false;
			optperiodo.Checked=false;
			optcapital.Checked=false;
			opttaxa.Checked=false;
			txtjuros.Enabled=false;
			txtperiodo.Enabled=false;
			txttaxa.Enabled=false;;
			txtcapital.Enabled=false;
		}
		void OptperiodoCheckedChanged(object sender, EventArgs e)
		{
			if (optperiodo.Checked==true)
			{
				txtjuros.Enabled=true;
				txtperiodo.Enabled=false;
				txttaxa.Enabled=true;
				txtcapital.Enabled=true;
			}
		}
		void OpttaxaCheckedChanged(object sender, EventArgs e)
		{
			if (opttaxa.Checked==true)
			{
				txtjuros.Enabled=true;
				txtperiodo.Enabled=true;
				txttaxa.Enabled=false;
				txtcapital.Enabled=true;
			}
		}
	}
}
