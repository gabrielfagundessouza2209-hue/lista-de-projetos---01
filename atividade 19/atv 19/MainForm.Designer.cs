/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 10:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atv_19
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_num;
		private System.Windows.Forms.TextBox txt_box_num;
		private System.Windows.Forms.Button btn_verificar_divisibilidade;
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
			this.txt_box_num = new System.Windows.Forms.TextBox();
			this.btn_verificar_divisibilidade = new System.Windows.Forms.Button();
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_num
			// 
			this.lbl_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_num.Location = new System.Drawing.Point(155, 65);
			this.lbl_num.Name = "lbl_num";
			this.lbl_num.Size = new System.Drawing.Size(182, 33);
			this.lbl_num.TabIndex = 0;
			this.lbl_num.Text = "Número inteiro:";
			// 
			// txt_box_num
			// 
			this.txt_box_num.Location = new System.Drawing.Point(344, 65);
			this.txt_box_num.Multiline = true;
			this.txt_box_num.Name = "txt_box_num";
			this.txt_box_num.Size = new System.Drawing.Size(139, 32);
			this.txt_box_num.TabIndex = 1;
			// 
			// btn_verificar_divisibilidade
			// 
			this.btn_verificar_divisibilidade.Location = new System.Drawing.Point(267, 150);
			this.btn_verificar_divisibilidade.Name = "btn_verificar_divisibilidade";
			this.btn_verificar_divisibilidade.Size = new System.Drawing.Size(153, 23);
			this.btn_verificar_divisibilidade.TabIndex = 2;
			this.btn_verificar_divisibilidade.Text = "Verificar divisibilidade";
			this.btn_verificar_divisibilidade.UseVisualStyleBackColor = true;
			this.btn_verificar_divisibilidade.Click += new System.EventHandler(this.Btn_verificar_divisibilidadeClick);
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_resultado.Location = new System.Drawing.Point(103, 219);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(537, 33);
			this.lbl_resultado.TabIndex = 3;
			this.lbl_resultado.Text = "Resultado";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(865, 481);
			this.Controls.Add(this.lbl_resultado);
			this.Controls.Add(this.btn_verificar_divisibilidade);
			this.Controls.Add(this.txt_box_num);
			this.Controls.Add(this.lbl_num);
			this.Name = "MainForm";
			this.Text = "atv 19";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
