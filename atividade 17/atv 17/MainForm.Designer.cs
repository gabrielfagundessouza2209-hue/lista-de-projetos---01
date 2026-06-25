/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 10:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atv_17
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_nome;
		private System.Windows.Forms.TextBox txt_box_nome;
		private System.Windows.Forms.Label lbl_idade;
		private System.Windows.Forms.TextBox txt_box_idade;
		private System.Windows.Forms.Button btn_validar_acesso;
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
			this.lbl_nome = new System.Windows.Forms.Label();
			this.txt_box_nome = new System.Windows.Forms.TextBox();
			this.lbl_idade = new System.Windows.Forms.Label();
			this.txt_box_idade = new System.Windows.Forms.TextBox();
			this.btn_validar_acesso = new System.Windows.Forms.Button();
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_nome
			// 
			this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_nome.Location = new System.Drawing.Point(327, 97);
			this.lbl_nome.Name = "lbl_nome";
			this.lbl_nome.Size = new System.Drawing.Size(75, 23);
			this.lbl_nome.TabIndex = 0;
			this.lbl_nome.Text = "Nome:";
			// 
			// txt_box_nome
			// 
			this.txt_box_nome.Location = new System.Drawing.Point(425, 103);
			this.txt_box_nome.Multiline = true;
			this.txt_box_nome.Name = "txt_box_nome";
			this.txt_box_nome.Size = new System.Drawing.Size(100, 20);
			this.txt_box_nome.TabIndex = 1;
			// 
			// lbl_idade
			// 
			this.lbl_idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_idade.Location = new System.Drawing.Point(327, 139);
			this.lbl_idade.Name = "lbl_idade";
			this.lbl_idade.Size = new System.Drawing.Size(75, 23);
			this.lbl_idade.TabIndex = 2;
			this.lbl_idade.Text = "Idade:";
			// 
			// txt_box_idade
			// 
			this.txt_box_idade.Location = new System.Drawing.Point(425, 145);
			this.txt_box_idade.Multiline = true;
			this.txt_box_idade.Name = "txt_box_idade";
			this.txt_box_idade.Size = new System.Drawing.Size(100, 20);
			this.txt_box_idade.TabIndex = 3;
			// 
			// btn_validar_acesso
			// 
			this.btn_validar_acesso.Location = new System.Drawing.Point(362, 194);
			this.btn_validar_acesso.Name = "btn_validar_acesso";
			this.btn_validar_acesso.Size = new System.Drawing.Size(138, 34);
			this.btn_validar_acesso.TabIndex = 4;
			this.btn_validar_acesso.Text = "Validar acesso";
			this.btn_validar_acesso.UseVisualStyleBackColor = true;
			this.btn_validar_acesso.Click += new System.EventHandler(this.Btn_validar_acessoClick);
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_resultado.Location = new System.Drawing.Point(186, 254);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(541, 59);
			this.lbl_resultado.TabIndex = 5;
			this.lbl_resultado.Text = "Resultado:";
			this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(861, 474);
			this.Controls.Add(this.lbl_resultado);
			this.Controls.Add(this.btn_validar_acesso);
			this.Controls.Add(this.txt_box_idade);
			this.Controls.Add(this.lbl_idade);
			this.Controls.Add(this.txt_box_nome);
			this.Controls.Add(this.lbl_nome);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "validação de acesso por nome e idade";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
