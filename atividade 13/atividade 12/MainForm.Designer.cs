/*
 * Created by SharpDevelop.
 * User: Gabriel
 * Date: 23/06/2026
 * Time: 23:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_12
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_idade;
		private System.Windows.Forms.TextBox txt_box_idade;
		private System.Windows.Forms.Label lbl__carteira;
		private System.Windows.Forms.TextBox txt_box_carteira;
		private System.Windows.Forms.Button btn_verifivardirecao;
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
			this.lbl_idade = new System.Windows.Forms.Label();
			this.txt_box_idade = new System.Windows.Forms.TextBox();
			this.lbl__carteira = new System.Windows.Forms.Label();
			this.txt_box_carteira = new System.Windows.Forms.TextBox();
			this.btn_verifivardirecao = new System.Windows.Forms.Button();
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_idade
			// 
			this.lbl_idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_idade.Location = new System.Drawing.Point(221, 88);
			this.lbl_idade.Name = "lbl_idade";
			this.lbl_idade.Size = new System.Drawing.Size(90, 39);
			this.lbl_idade.TabIndex = 0;
			this.lbl_idade.Text = "Idade:";
			// 
			// txt_box_idade
			// 
			this.txt_box_idade.Location = new System.Drawing.Point(328, 94);
			this.txt_box_idade.Multiline = true;
			this.txt_box_idade.Name = "txt_box_idade";
			this.txt_box_idade.Size = new System.Drawing.Size(154, 33);
			this.txt_box_idade.TabIndex = 1;
			// 
			// lbl__carteira
			// 
			this.lbl__carteira.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl__carteira.Location = new System.Drawing.Point(12, 169);
			this.lbl__carteira.Name = "lbl__carteira";
			this.lbl__carteira.Size = new System.Drawing.Size(520, 39);
			this.lbl__carteira.TabIndex = 2;
			this.lbl__carteira.Text = "Possui Carteira de Motorista ? (sim/não)";
			this.lbl__carteira.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txt_box_carteira
			// 
			this.txt_box_carteira.Location = new System.Drawing.Point(538, 169);
			this.txt_box_carteira.Multiline = true;
			this.txt_box_carteira.Name = "txt_box_carteira";
			this.txt_box_carteira.Size = new System.Drawing.Size(154, 33);
			this.txt_box_carteira.TabIndex = 3;
			// 
			// btn_verifivardirecao
			// 
			this.btn_verifivardirecao.Location = new System.Drawing.Point(298, 236);
			this.btn_verifivardirecao.Name = "btn_verifivardirecao";
			this.btn_verifivardirecao.Size = new System.Drawing.Size(146, 38);
			this.btn_verifivardirecao.TabIndex = 4;
			this.btn_verifivardirecao.Text = "verificar direção";
			this.btn_verifivardirecao.UseVisualStyleBackColor = true;
			this.btn_verifivardirecao.Click += new System.EventHandler(this.Btn_verifivardirecaoClick);
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_resultado.Location = new System.Drawing.Point(39, 345);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(807, 39);
			this.lbl_resultado.TabIndex = 5;
			this.lbl_resultado.Text = "Resultado:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(904, 475);
			this.Controls.Add(this.lbl_resultado);
			this.Controls.Add(this.btn_verifivardirecao);
			this.Controls.Add(this.txt_box_carteira);
			this.Controls.Add(this.lbl__carteira);
			this.Controls.Add(this.txt_box_idade);
			this.Controls.Add(this.lbl_idade);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "atividade 13";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
