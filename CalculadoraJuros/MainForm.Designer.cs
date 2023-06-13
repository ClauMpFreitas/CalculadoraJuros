
namespace CalculadoraJuros
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnJurosSimples;
		private System.Windows.Forms.Button btnJurosCompostos;
		private System.Windows.Forms.Button btnMontanteSimples;
		private System.Windows.Forms.Button btnMontanteCompostos;
		private System.Windows.Forms.Button btnFormulas;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnJurosSimples = new System.Windows.Forms.Button();
			this.btnJurosCompostos = new System.Windows.Forms.Button();
			this.btnMontanteSimples = new System.Windows.Forms.Button();
			this.btnMontanteCompostos = new System.Windows.Forms.Button();
			this.btnFormulas = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(29, 98);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(226, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(154, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(409, 53);
			this.label1.TabIndex = 1;
			this.label1.Text = "Calculadora de Juros";
			// 
			// btnJurosSimples
			// 
			this.btnJurosSimples.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnJurosSimples.Location = new System.Drawing.Point(277, 98);
			this.btnJurosSimples.Name = "btnJurosSimples";
			this.btnJurosSimples.Size = new System.Drawing.Size(277, 30);
			this.btnJurosSimples.TabIndex = 2;
			this.btnJurosSimples.Text = "Juros Simples";
			this.btnJurosSimples.UseVisualStyleBackColor = true;
			this.btnJurosSimples.Click += new System.EventHandler(this.BtnJurosSimplesClick);
			// 
			// btnJurosCompostos
			// 
			this.btnJurosCompostos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnJurosCompostos.Location = new System.Drawing.Point(277, 140);
			this.btnJurosCompostos.Name = "btnJurosCompostos";
			this.btnJurosCompostos.Size = new System.Drawing.Size(277, 30);
			this.btnJurosCompostos.TabIndex = 3;
			this.btnJurosCompostos.Text = "Juros Compostos";
			this.btnJurosCompostos.UseVisualStyleBackColor = true;
			this.btnJurosCompostos.Click += new System.EventHandler(this.BtnJurosCompostosClick);
			// 
			// btnMontanteSimples
			// 
			this.btnMontanteSimples.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMontanteSimples.Location = new System.Drawing.Point(277, 180);
			this.btnMontanteSimples.Name = "btnMontanteSimples";
			this.btnMontanteSimples.Size = new System.Drawing.Size(277, 30);
			this.btnMontanteSimples.TabIndex = 4;
			this.btnMontanteSimples.Text = "Montante com Juros Simples";
			this.btnMontanteSimples.UseVisualStyleBackColor = true;
			this.btnMontanteSimples.Click += new System.EventHandler(this.BtnMontanteSimplesClick);
			// 
			// btnMontanteCompostos
			// 
			this.btnMontanteCompostos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMontanteCompostos.Location = new System.Drawing.Point(277, 226);
			this.btnMontanteCompostos.Name = "btnMontanteCompostos";
			this.btnMontanteCompostos.Size = new System.Drawing.Size(277, 30);
			this.btnMontanteCompostos.TabIndex = 5;
			this.btnMontanteCompostos.Text = "Montante com Juros Compostos";
			this.btnMontanteCompostos.UseVisualStyleBackColor = true;
			this.btnMontanteCompostos.Click += new System.EventHandler(this.BtnMontanteCompostosClick);
			// 
			// btnFormulas
			// 
			this.btnFormulas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFormulas.Location = new System.Drawing.Point(277, 268);
			this.btnFormulas.Name = "btnFormulas";
			this.btnFormulas.Size = new System.Drawing.Size(277, 30);
			this.btnFormulas.TabIndex = 6;
			this.btnFormulas.Text = "Fórmulas Utilizadas";
			this.btnFormulas.UseVisualStyleBackColor = true;
			this.btnFormulas.Click += new System.EventHandler(this.BtnFormulasClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(614, 355);
			this.Controls.Add(this.btnFormulas);
			this.Controls.Add(this.btnMontanteCompostos);
			this.Controls.Add(this.btnMontanteSimples);
			this.Controls.Add(this.btnJurosCompostos);
			this.Controls.Add(this.btnJurosSimples);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculadora de Juros";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
