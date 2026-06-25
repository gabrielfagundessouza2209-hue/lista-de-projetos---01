/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 16/06/2026
 * Time: 11:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_verificador;
		private System.Windows.Forms.Label lbl_num;
		private System.Windows.Forms.TextBox txt_num;
		private System.Windows.Forms.Label lbl_result;
		private System.Windows.Forms.Button btn_verificar;
		
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
			this.lbl_verificador = new System.Windows.Forms.Label();
			this.lbl_num = new System.Windows.Forms.Label();
			this.txt_num = new System.Windows.Forms.TextBox();
			this.lbl_result = new System.Windows.Forms.Label();
			this.btn_verificar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_verificador
			// 
			this.lbl_verificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_verificador.Location = new System.Drawing.Point(315, 21);
			this.lbl_verificador.Name = "lbl_verificador";
			this.lbl_verificador.Size = new System.Drawing.Size(307, 88);
			this.lbl_verificador.TabIndex = 0;
			this.lbl_verificador.Text = "Verificador de número ";
			// 
			// lbl_num
			// 
			this.lbl_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_num.Location = new System.Drawing.Point(140, 171);
			this.lbl_num.Name = "lbl_num";
			this.lbl_num.Size = new System.Drawing.Size(254, 53);
			this.lbl_num.TabIndex = 1;
			this.lbl_num.Text = "Digite um número:";
			// 
			// txt_num
			// 
			this.txt_num.Location = new System.Drawing.Point(405, 184);
			this.txt_num.Name = "txt_num";
			this.txt_num.Size = new System.Drawing.Size(267, 20);
			this.txt_num.TabIndex = 2;
			// 
			// lbl_result
			// 
			this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_result.Location = new System.Drawing.Point(169, 375);
			this.lbl_result.Name = "lbl_result";
			this.lbl_result.Size = new System.Drawing.Size(503, 53);
			this.lbl_result.TabIndex = 3;
			this.lbl_result.Text = "Resultado:";
			// 
			// btn_verificar
			// 
			this.btn_verificar.Location = new System.Drawing.Point(298, 260);
			this.btn_verificar.Name = "btn_verificar";
			this.btn_verificar.Size = new System.Drawing.Size(251, 78);
			this.btn_verificar.TabIndex = 4;
			this.btn_verificar.Text = "verificar";
			this.btn_verificar.UseVisualStyleBackColor = true;
			this.btn_verificar.Click += new System.EventHandler(this.Btn_verificarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(860, 591);
			this.Controls.Add(this.btn_verificar);
			this.Controls.Add(this.lbl_result);
			this.Controls.Add(this.txt_num);
			this.Controls.Add(this.lbl_num);
			this.Controls.Add(this.lbl_verificador);
			this.Name = "MainForm";
			this.Text = "atividade 1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
