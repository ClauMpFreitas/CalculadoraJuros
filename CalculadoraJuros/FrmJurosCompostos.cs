using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraJuros
{
	public partial class FrmJurosCompostos : Form
	{
		public FrmJurosCompostos()
		{
			InitializeComponent();
		}
		void OptcapitalCheckedChanged(object sender, EventArgs e)
		{
			if (optcapital.Checked==true)
			{
				txtjuros.Enabled=true;
				txtperiodo.Enabled=true;
				txttaxa.Enabled=true;
				txtcapital.Enabled=false;
				txtmontante.Enabled=false;
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
				txtmontante.Enabled=false;
			}
		}
		void OptperiodoCheckedChanged(object sender, EventArgs e)
		{
			if (optperiodo.Checked==true)
			{
				txtjuros.Enabled=true;
				txtperiodo.Enabled=false;
				txttaxa.Enabled=true;
				txtcapital.Enabled=true;
				txtmontante.Enabled=false;
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
				txtmontante.Enabled=false;
			}
		}
		void FrmJurosCompostosShown(object sender, EventArgs e)
		{
			optjuros.Checked=false;
			optperiodo.Checked=false;
			optcapital.Checked=false;
			opttaxa.Checked=false;
			txtjuros.Enabled=false;
			txtperiodo.Enabled=false;
			txttaxa.Enabled=false;;
			txtcapital.Enabled=false;
			txtmontante.Enabled=false;
		}
		void BtnCalcularClick(object sender, EventArgs e)
		{
			if (optcapital.Checked==true)
			{
				double juros = double.Parse(txtjuros.Text);
				double taxa = double.Parse(txttaxa.Text) / 100.0;
				int periodo = int.Parse(txtperiodo.Text);
				
				double capital = juros/(Math.Pow(1+taxa, periodo)-1);
				txtcapital.Text = Math.Round(capital, 2).ToString();
			}
			if (optjuros.Checked==true)
			{
				double taxa = double.Parse(txttaxa.Text) / 100.0;
				int periodo = int.Parse(txtperiodo.Text);
				double capital = double.Parse(txtcapital.Text);
				
				double juros = capital*((Math.Pow(1+taxa, periodo))-1);
				txtjuros.Text = Math.Round(juros, 2).ToString();
			}
			if (optperiodo.Checked==true)
			{
				double taxa = double.Parse(txttaxa.Text) / 100.0;
				double capital = double.Parse(txtcapital.Text);
				double juros = double.Parse(txtjuros.Text);
				
				int periodo = (int)(Math.Log10((juros/capital)+1)/Math.Log10(1+taxa));
				txtperiodo.Text = periodo.ToString();
			}
			if (opttaxa.Checked==true)
			{
				int periodo = int.Parse(txtperiodo.Text);
				double capital = double.Parse(txtcapital.Text);
				double juros = double.Parse(txtjuros.Text);
				double montante = capital + juros;
				txtmontante.Text=montante.ToString();
				
				double taxa = (Math.Pow(montante / capital, 1.0 / periodo) - 1) * 100;
				txttaxa.Text = Math.Round(taxa, 2).ToString();
			}
		}
	}
}
