/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 22/06/2026
 * Time: 11:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Divisibilidade_por_3__e_por__7
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_num;
		private System.Windows.Forms.Label lbl_titulo;
		private System.Windows.Forms.TextBox txt_num;
		private System.Windows.Forms.Label lbl_resultado;
		private System.Windows.Forms.Button btn_verificar_divisibilidade;
		
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
			this.lbl_num = new System.Windows.Forms.Label();
			this.lbl_titulo = new System.Windows.Forms.Label();
			this.txt_num = new System.Windows.Forms.TextBox();
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.btn_verificar_divisibilidade = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_num
			// 
			this.lbl_num.Location = new System.Drawing.Point(88, 166);
			this.lbl_num.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.lbl_num.Name = "lbl_num";
			this.lbl_num.Size = new System.Drawing.Size(255, 58);
			this.lbl_num.TabIndex = 0;
			this.lbl_num.Text = "Digite um número: ";
			// 
			// lbl_titulo
			// 
			this.lbl_titulo.Location = new System.Drawing.Point(262, 24);
			this.lbl_titulo.Name = "lbl_titulo";
			this.lbl_titulo.Size = new System.Drawing.Size(308, 56);
			this.lbl_titulo.TabIndex = 1;
			this.lbl_titulo.Text = "divisibilidade por 3 e 7";
			// 
			// txt_num
			// 
			this.txt_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_num.Location = new System.Drawing.Point(354, 177);
			this.txt_num.Multiline = true;
			this.txt_num.Name = "txt_num";
			this.txt_num.Size = new System.Drawing.Size(307, 27);
			this.txt_num.TabIndex = 2;
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.Location = new System.Drawing.Point(142, 325);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(540, 51);
			this.lbl_resultado.TabIndex = 3;
			this.lbl_resultado.Text = "Resultado:";
			// 
			// btn_verificar_divisibilidade
			// 
			this.btn_verificar_divisibilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_verificar_divisibilidade.Location = new System.Drawing.Point(262, 244);
			this.btn_verificar_divisibilidade.Name = "btn_verificar_divisibilidade";
			this.btn_verificar_divisibilidade.Size = new System.Drawing.Size(263, 34);
			this.btn_verificar_divisibilidade.TabIndex = 4;
			this.btn_verificar_divisibilidade.Text = "verificar divisibilidade ";
			this.btn_verificar_divisibilidade.UseVisualStyleBackColor = true;
			this.btn_verificar_divisibilidade.Click += new System.EventHandler(this.Btn_verificar_divisibilidadeClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 473);
			this.Controls.Add(this.btn_verificar_divisibilidade);
			this.Controls.Add(this.lbl_resultado);
			this.Controls.Add(this.txt_num);
			this.Controls.Add(this.lbl_titulo);
			this.Controls.Add(this.lbl_num);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(8);
			this.Name = "MainForm";
			this.Text = "Divisibilidade_por_3_ e por_ 7";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
