/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 25/06/2026
 * Time: 09:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_22
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_numero;
		private System.Windows.Forms.Button btn_validar_numero;
		private System.Windows.Forms.TextBox txt_numero;
		
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
			this.lbl_numero = new System.Windows.Forms.Label();
			this.btn_validar_numero = new System.Windows.Forms.Button();
			this.txt_numero = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lbl_numero
			// 
			this.lbl_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_numero.Location = new System.Drawing.Point(28, 100);
			this.lbl_numero.Name = "lbl_numero";
			this.lbl_numero.Size = new System.Drawing.Size(223, 41);
			this.lbl_numero.TabIndex = 0;
			this.lbl_numero.Text = "Digite um número inteiro:";
			// 
			// btn_validar_numero
			// 
			this.btn_validar_numero.Location = new System.Drawing.Point(78, 181);
			this.btn_validar_numero.Name = "btn_validar_numero";
			this.btn_validar_numero.Size = new System.Drawing.Size(118, 23);
			this.btn_validar_numero.TabIndex = 1;
			this.btn_validar_numero.Text = "Validar número";
			this.btn_validar_numero.UseVisualStyleBackColor = true;
			this.btn_validar_numero.Click += new System.EventHandler(this.Btn_validar_numeroClick);
			// 
			// txt_numero
			// 
			this.txt_numero.Location = new System.Drawing.Point(92, 144);
			this.txt_numero.Name = "txt_numero";
			this.txt_numero.Size = new System.Drawing.Size(81, 20);
			this.txt_numero.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(278, 330);
			this.Controls.Add(this.txt_numero);
			this.Controls.Add(this.btn_validar_numero);
			this.Controls.Add(this.lbl_numero);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "numero fora da faiza esperada ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
