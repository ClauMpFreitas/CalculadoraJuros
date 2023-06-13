using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraJuros
{
	public partial class FrmMontanteSimples : Form
	{
		public FrmMontanteSimples()
		{
			InitializeComponent();
		}
		void FrmMontanteSimplesShown(object sender, EventArgs e)
		{
			optjuros.Checked=false;
			optperiodo.Checked=false;
			optcapital.Checked=false;
			opttaxa.Checked=false;
			optmontante.Checked=false;
			txtjuros.Enabled=false;
			txtperiodo.Enabled=false;
			txttaxa.Enabled=false;;
			txtcapital.Enabled=false;
			txtmontante.Enabled=false;
		}
		void OptcapitalCheckedChanged(object sender, EventArgs e)
		{
			txtjuros.Enabled=false;
			txtperiodo.Enabled=true;
			txttaxa.Enabled=true;
			txtcapital.Enabled=false;
			txtmontante.Enabled=true;
		}
		void OptjurosCheckedChanged(object sender, EventArgs e)
		{
			txtjuros.Enabled=false;
			txtperiodo.Enabled=true;
			txttaxa.Enabled=true;
			txtcapital.Enabled=true;
			txtmontante.Enabled=false;
		}
		void OptperiodoCheckedChanged(object sender, EventArgs e)
		{
			txtjuros.Enabled=false;
			txtperiodo.Enabled=false;
			txttaxa.Enabled=true;
			txtcapital.Enabled=true;
			txtmontante.Enabled=true;
		}
		void OpttaxaCheckedChanged(object sender, EventArgs e)
		{
			txtjuros.Enabled=false;
			txtperiodo.Enabled=true;
			txttaxa.Enabled=false;
			txtcapital.Enabled=true;
			txtmontante.Enabled=true;
		}
		void OptmontanteCheckedChanged(object sender, EventArgs e)
		{
			txtjuros.Enabled=false;
			txtperiodo.Enabled=true;
			txttaxa.Enabled=true;
			txtcapital.Enabled=true;
			txtmontante.Enabled=false;
		}
		void BtnCalcularClick(object sender, EventArgs e)
		{
			if (optcapital.Checked==true)
			{
				double taxa = double.Parse(txttaxa.Text) / 100.0;
				int periodo = int.Parse(txtperiodo.Text);
				double montante = double.Parse(txtmontante.Text);

				double capital = montante / (1 + taxa * periodo);
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
				double montante = double.Parse(txtmontante.Text);
				
				int periodo = (int)((montante/capital-1)/taxa);
				txtperiodo.Text = periodo.ToString();
			}
			if (opttaxa.Checked==true)
			{
				int periodo = int.Parse(txtperiodo.Text);
				double capital = double.Parse(txtcapital.Text);
				double montante = double.Parse(txtmontante.Text);
				
				double taxa = ((montante/capital-1)/periodo) * 100;
				txttaxa.Text = Math.Round(taxa, 2).ToString();
			}
			if (optmontante.Checked==true)
			{
				int periodo = int.Parse(txtperiodo.Text);
				double capital = double.Parse(txtcapital.Text);
				double taxa = double.Parse(txttaxa.Text) / 100.0;
				
				double montante = capital*(1+taxa*periodo);
				txtmontante.Text = Math.Round(montante, 2).ToString();
			}
		}
	}
}
