/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 08:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atv_14
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_desejo_carro;
		private System.Windows.Forms.TextBox txt_desejo_carro;
		private System.Windows.Forms.Label lbl_dinheiro;
		private System.Windows.Forms.TextBox txt_dinheiro;
		private System.Windows.Forms.Button btn_verificar_compra;
		private System.Windows.Forms.Label lbl_resultado;
		
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
			this.lbl_desejo_carro = new System.Windows.Forms.Label();
			this.txt_desejo_carro = new System.Windows.Forms.TextBox();
			this.lbl_dinheiro = new System.Windows.Forms.Label();
			this.txt_dinheiro = new System.Windows.Forms.TextBox();
			this.btn_verificar_compra = new System.Windows.Forms.Button();
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_desejo_carro
			// 
			this.lbl_desejo_carro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_desejo_carro.Location = new System.Drawing.Point(25, 108);
			this.lbl_desejo_carro.Name = "lbl_desejo_carro";
			this.lbl_desejo_carro.Size = new System.Drawing.Size(480, 34);
			this.lbl_desejo_carro.TabIndex = 0;
			this.lbl_desejo_carro.Text = "Deseja comprar um carro novo ? (sim/não):";
			// 
			// txt_desejo_carro
			// 
			this.txt_desejo_carro.Location = new System.Drawing.Point(511, 117);
			this.txt_desejo_carro.Multiline = true;
			this.txt_desejo_carro.Name = "txt_desejo_carro";
			this.txt_desejo_carro.Size = new System.Drawing.Size(172, 20);
			this.txt_desejo_carro.TabIndex = 1;
			// 
			// lbl_dinheiro
			// 
			this.lbl_dinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_dinheiro.Location = new System.Drawing.Point(38, 184);
			this.lbl_dinheiro.Name = "lbl_dinheiro";
			this.lbl_dinheiro.Size = new System.Drawing.Size(394, 34);
			this.lbl_dinheiro.TabIndex = 2;
			this.lbl_dinheiro.Text = "Tem dinheiro  suficiente?(sim/não):\r\n";
			// 
			// txt_dinheiro
			// 
			this.txt_dinheiro.Location = new System.Drawing.Point(438, 193);
			this.txt_dinheiro.Multiline = true;
			this.txt_dinheiro.Name = "txt_dinheiro";
			this.txt_dinheiro.Size = new System.Drawing.Size(266, 23);
			this.txt_dinheiro.TabIndex = 3;
			// 
			// btn_verificar_compra
			// 
			this.btn_verificar_compra.Location = new System.Drawing.Point(317, 258);
			this.btn_verificar_compra.Name = "btn_verificar_compra";
			this.btn_verificar_compra.Size = new System.Drawing.Size(152, 50);
			this.btn_verificar_compra.TabIndex = 4;
			this.btn_verificar_compra.Text = "Verificar compra";
			this.btn_verificar_compra.UseVisualStyleBackColor = true;
			this.btn_verificar_compra.Click += new System.EventHandler(this.Btn_verificar_compraClick);
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_resultado.Location = new System.Drawing.Point(58, 364);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(702, 34);
			this.lbl_resultado.TabIndex = 5;
			this.lbl_resultado.Text = "Resultado:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(851, 478);
			this.Controls.Add(this.lbl_resultado);
			this.Controls.Add(this.btn_verificar_compra);
			this.Controls.Add(this.txt_dinheiro);
			this.Controls.Add(this.lbl_dinheiro);
			this.Controls.Add(this.txt_desejo_carro);
			this.Controls.Add(this.lbl_desejo_carro);
			this.Name = "MainForm";
			this.Text = "Compra de carro novo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
