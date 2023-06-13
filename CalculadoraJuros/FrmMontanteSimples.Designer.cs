
namespace CalculadoraJuros
{
	partial class FrmMontanteSimples
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtmontante;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txttaxa;
		private System.Windows.Forms.TextBox txtperiodo;
		private System.Windows.Forms.TextBox txtjuros;
		private System.Windows.Forms.TextBox txtcapital;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton optmontante;
		private System.Windows.Forms.RadioButton opttaxa;
		private System.Windows.Forms.RadioButton optperiodo;
		private System.Windows.Forms.RadioButton optjuros;
		private System.Windows.Forms.RadioButton optcapital;
		private System.Windows.Forms.Label label6;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtmontante = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txttaxa = new System.Windows.Forms.TextBox();
			this.txtperiodo = new System.Windows.Forms.TextBox();
			this.txtjuros = new System.Windows.Forms.TextBox();
			this.txtcapital = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.optmontante = new System.Windows.Forms.RadioButton();
			this.opttaxa = new System.Windows.Forms.RadioButton();
			this.optperiodo = new System.Windows.Forms.RadioButton();
			this.optjuros = new System.Windows.Forms.RadioButton();
			this.optcapital = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtmontante
			// 
			this.txtmontante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtmontante.Location = new System.Drawing.Point(138, 234);
			this.txtmontante.Name = "txtmontante";
			this.txtmontante.Size = new System.Drawing.Size(100, 26);
			this.txtmontante.TabIndex = 23;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(23, 237);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 22;
			this.label5.Text = "Montante";
			// 
			// txttaxa
			// 
			this.txttaxa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttaxa.Location = new System.Drawing.Point(138, 206);
			this.txttaxa.Name = "txttaxa";
			this.txttaxa.Size = new System.Drawing.Size(100, 26);
			this.txttaxa.TabIndex = 21;
			// 
			// txtperiodo
			// 
			this.txtperiodo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtperiodo.Location = new System.Drawing.Point(186, 177);
			this.txtperiodo.Name = "txtperiodo";
			this.txtperiodo.Size = new System.Drawing.Size(100, 26);
			this.txtperiodo.TabIndex = 20;
			// 
			// txtjuros
			// 
			this.txtjuros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtjuros.Location = new System.Drawing.Point(186, 149);
			this.txtjuros.Name = "txtjuros";
			this.txtjuros.Size = new System.Drawing.Size(100, 26);
			this.txtjuros.TabIndex = 19;
			// 
			// txtcapital
			// 
			this.txtcapital.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcapital.Location = new System.Drawing.Point(186, 120);
			this.txtcapital.Name = "txtcapital";
			this.txtcapital.Size = new System.Drawing.Size(100, 26);
			this.txtcapital.TabIndex = 18;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(266, 300);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(114, 36);
			this.btnCalcular.TabIndex = 17;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(23, 206);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 16;
			this.label4.Text = "Taxa de juros";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(23, 177);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(157, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "Período (Em meses)";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 149);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 23);
			this.label2.TabIndex = 14;
			this.label2.Text = "Valor dos juros";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 23);
			this.label1.TabIndex = 13;
			this.label1.Text = "Valor do capital";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.optmontante);
			this.groupBox1.Controls.Add(this.opttaxa);
			this.groupBox1.Controls.Add(this.optperiodo);
			this.groupBox1.Controls.Add(this.optjuros);
			this.groupBox1.Controls.Add(this.optcapital);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(23, 19);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(569, 69);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "O que você quer calcular?";
			// 
			// optmontante
			// 
			this.optmontante.Location = new System.Drawing.Point(424, 39);
			this.optmontante.Name = "optmontante";
			this.optmontante.Size = new System.Drawing.Size(123, 24);
			this.optmontante.TabIndex = 4;
			this.optmontante.TabStop = true;
			this.optmontante.Text = "Montante";
			this.optmontante.UseVisualStyleBackColor = true;
			this.optmontante.CheckedChanged += new System.EventHandler(this.OptmontanteCheckedChanged);
			// 
			// opttaxa
			// 
			this.opttaxa.Location = new System.Drawing.Point(295, 39);
			this.opttaxa.Name = "opttaxa";
			this.opttaxa.Size = new System.Drawing.Size(123, 24);
			this.opttaxa.TabIndex = 3;
			this.opttaxa.TabStop = true;
			this.opttaxa.Text = "Taxa de juros";
			this.opttaxa.UseVisualStyleBackColor = true;
			this.opttaxa.CheckedChanged += new System.EventHandler(this.OpttaxaCheckedChanged);
			// 
			// optperiodo
			// 
			this.optperiodo.Location = new System.Drawing.Point(201, 39);
			this.optperiodo.Name = "optperiodo";
			this.optperiodo.Size = new System.Drawing.Size(104, 24);
			this.optperiodo.TabIndex = 2;
			this.optperiodo.TabStop = true;
			this.optperiodo.Text = "Período";
			this.optperiodo.UseVisualStyleBackColor = true;
			this.optperiodo.CheckedChanged += new System.EventHandler(this.OptperiodoCheckedChanged);
			// 
			// optjuros
			// 
			this.optjuros.Location = new System.Drawing.Point(115, 39);
			this.optjuros.Name = "optjuros";
			this.optjuros.Size = new System.Drawing.Size(80, 24);
			this.optjuros.TabIndex = 1;
			this.optjuros.TabStop = true;
			this.optjuros.Text = "Juros";
			this.optjuros.UseVisualStyleBackColor = true;
			this.optjuros.CheckedChanged += new System.EventHandler(this.OptjurosCheckedChanged);
			// 
			// optcapital
			// 
			this.optcapital.Location = new System.Drawing.Point(22, 39);
			this.optcapital.Name = "optcapital";
			this.optcapital.Size = new System.Drawing.Size(87, 24);
			this.optcapital.TabIndex = 0;
			this.optcapital.TabStop = true;
			this.optcapital.Text = "Capital";
			this.optcapital.UseVisualStyleBackColor = true;
			this.optcapital.CheckedChanged += new System.EventHandler(this.OptcapitalCheckedChanged);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(318, 133);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(243, 111);
			this.label6.TabIndex = 24;
			this.label6.Text = "OBS: Se acaso alguma textbox estiver desativada além da textbox que recebe o resu" +
	"ltado do cálculo, é porque ela não será necessária para a fórmula do cálculo.";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FrmMontanteSimples
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(614, 355);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtmontante);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txttaxa);
			this.Controls.Add(this.txtperiodo);
			this.Controls.Add(this.txtjuros);
			this.Controls.Add(this.txtcapital);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmMontanteSimples";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculadora de Juros";
			this.Shown += new System.EventHandler(this.FrmMontanteSimplesShown);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
