/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 23/06/2026
 * Time: 09:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace divisibilidade_2__5__10
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_num;
		private System.Windows.Forms.TextBox txt_num;
		private System.Windows.Forms.Button btn_verificar;
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
			this.lbl_num = new System.Windows.Forms.Label();
			this.txt_num = new System.Windows.Forms.TextBox();
			this.btn_verificar = new System.Windows.Forms.Button();
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_num
			// 
			this.lbl_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_num.Location = new System.Drawing.Point(89, 117);
			this.lbl_num.Name = "lbl_num";
			this.lbl_num.Size = new System.Drawing.Size(257, 38);
			this.lbl_num.TabIndex = 0;
			this.lbl_num.Text = "Digite um número:";
			// 
			// txt_num
			// 
			this.txt_num.Location = new System.Drawing.Point(353, 128);
			this.txt_num.Name = "txt_num";
			this.txt_num.Size = new System.Drawing.Size(200, 20);
			this.txt_num.TabIndex = 1;
			// 
			// btn_verificar
			// 
			this.btn_verificar.Location = new System.Drawing.Point(249, 187);
			this.btn_verificar.Name = "btn_verificar";
			this.btn_verificar.Size = new System.Drawing.Size(257, 54);
			this.btn_verificar.TabIndex = 3;
			this.btn_verificar.Text = "verificar números divisiveis por 5,10,2";
			this.btn_verificar.UseVisualStyleBackColor = true;
			this.btn_verificar.Click += new System.EventHandler(this.Btn_verificarClick);
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_resultado.Location = new System.Drawing.Point(89, 300);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(679, 38);
			this.lbl_resultado.TabIndex = 4;
			this.lbl_resultado.Text = "Resultado:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(838, 449);
			this.Controls.Add(this.lbl_resultado);
			this.Controls.Add(this.btn_verificar);
			this.Controls.Add(this.txt_num);
			this.Controls.Add(this.lbl_num);
			this.Name = "MainForm";
			this.Text = "divisibilidade 2 -5 -10";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
