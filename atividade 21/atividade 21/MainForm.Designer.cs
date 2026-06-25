/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 25/06/2026
 * Time: 09:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_21
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_Nome;
		private System.Windows.Forms.TextBox txt_nome;
		private System.Windows.Forms.Button btn_VerificarUsuario;
		
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
			this.lbl_Nome = new System.Windows.Forms.Label();
			this.txt_nome = new System.Windows.Forms.TextBox();
			this.btn_VerificarUsuario = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_Nome
			// 
			this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Nome.Location = new System.Drawing.Point(90, 121);
			this.lbl_Nome.Name = "lbl_Nome";
			this.lbl_Nome.Size = new System.Drawing.Size(137, 23);
			this.lbl_Nome.TabIndex = 0;
			this.lbl_Nome.Text = "Digite Seu nome:";
			// 
			// txt_nome
			// 
			this.txt_nome.Location = new System.Drawing.Point(102, 158);
			this.txt_nome.Name = "txt_nome";
			this.txt_nome.Size = new System.Drawing.Size(100, 20);
			this.txt_nome.TabIndex = 1;
			// 
			// btn_VerificarUsuario
			// 
			this.btn_VerificarUsuario.Location = new System.Drawing.Point(102, 203);
			this.btn_VerificarUsuario.Name = "btn_VerificarUsuario";
			this.btn_VerificarUsuario.Size = new System.Drawing.Size(95, 23);
			this.btn_VerificarUsuario.TabIndex = 2;
			this.btn_VerificarUsuario.Text = "Verificar Usuário";
			this.btn_VerificarUsuario.UseVisualStyleBackColor = true;
			this.btn_VerificarUsuario.Click += new System.EventHandler(this.Btn_VerificarUsuarioClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 383);
			this.Controls.Add(this.btn_VerificarUsuario);
			this.Controls.Add(this.txt_nome);
			this.Controls.Add(this.lbl_Nome);
			this.Name = "MainForm";
			this.Text = "verificar usuário";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
