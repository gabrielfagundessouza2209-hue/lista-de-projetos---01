/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 25/06/2026
 * Time: 09:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_23
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_Membro;
		private System.Windows.Forms.RadioButton rb_ativo;
		private System.Windows.Forms.RadioButton rb_inativo;
		private System.Windows.Forms.Button btn_verificar;
		private System.Windows.Forms.Label lbl_instrução;
		
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
			this.lbl_Membro = new System.Windows.Forms.Label();
			this.rb_ativo = new System.Windows.Forms.RadioButton();
			this.rb_inativo = new System.Windows.Forms.RadioButton();
			this.btn_verificar = new System.Windows.Forms.Button();
			this.lbl_instrução = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_Membro
			// 
			this.lbl_Membro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Membro.Location = new System.Drawing.Point(77, 35);
			this.lbl_Membro.Name = "lbl_Membro";
			this.lbl_Membro.Size = new System.Drawing.Size(274, 88);
			this.lbl_Membro.TabIndex = 0;
			this.lbl_Membro.Text = "Você é um membro ativo ou inativo ?";
			// 
			// rb_ativo
			// 
			this.rb_ativo.Location = new System.Drawing.Point(154, 126);
			this.rb_ativo.Name = "rb_ativo";
			this.rb_ativo.Size = new System.Drawing.Size(104, 24);
			this.rb_ativo.TabIndex = 1;
			this.rb_ativo.TabStop = true;
			this.rb_ativo.Text = "Ativo";
			this.rb_ativo.UseVisualStyleBackColor = true;
			// 
			// rb_inativo
			// 
			this.rb_inativo.Location = new System.Drawing.Point(154, 156);
			this.rb_inativo.Name = "rb_inativo";
			this.rb_inativo.Size = new System.Drawing.Size(104, 24);
			this.rb_inativo.TabIndex = 2;
			this.rb_inativo.TabStop = true;
			this.rb_inativo.Text = "Inativo";
			this.rb_inativo.UseVisualStyleBackColor = true;
			// 
			// btn_verificar
			// 
			this.btn_verificar.Location = new System.Drawing.Point(136, 259);
			this.btn_verificar.Name = "btn_verificar";
			this.btn_verificar.Size = new System.Drawing.Size(104, 32);
			this.btn_verificar.TabIndex = 3;
			this.btn_verificar.Text = "verificar";
			this.btn_verificar.UseVisualStyleBackColor = true;
			this.btn_verificar.Click += new System.EventHandler(this.Btn_verificarClick);
			// 
			// lbl_instrução
			// 
			this.lbl_instrução.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_instrução.Location = new System.Drawing.Point(77, 183);
			this.lbl_instrução.Name = "lbl_instrução";
			this.lbl_instrução.Size = new System.Drawing.Size(241, 56);
			this.lbl_instrução.TabIndex = 4;
			this.lbl_instrução.Text = "clique no botão abaixo para verificar sua inscrição\r\n";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 372);
			this.Controls.Add(this.lbl_instrução);
			this.Controls.Add(this.btn_verificar);
			this.Controls.Add(this.rb_inativo);
			this.Controls.Add(this.rb_ativo);
			this.Controls.Add(this.lbl_Membro);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "clube de beneficios";
			this.ResumeLayout(false);

		}
	}
}
