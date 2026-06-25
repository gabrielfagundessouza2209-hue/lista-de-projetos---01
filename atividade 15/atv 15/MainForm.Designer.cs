/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 08:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atv_15
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_diploma;
		private System.Windows.Forms.TextBox txt_diploma;
		private System.Windows.Forms.Label lbl_idade;
		private System.Windows.Forms.TextBox txt_idade;
		private System.Windows.Forms.Button btn_verificar_vaga;
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
			this.lbl_diploma = new System.Windows.Forms.Label();
			this.txt_diploma = new System.Windows.Forms.TextBox();
			this.lbl_idade = new System.Windows.Forms.Label();
			this.txt_idade = new System.Windows.Forms.TextBox();
			this.btn_verificar_vaga = new System.Windows.Forms.Button();
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_diploma
			// 
			this.lbl_diploma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_diploma.Location = new System.Drawing.Point(83, 42);
			this.lbl_diploma.Name = "lbl_diploma";
			this.lbl_diploma.Size = new System.Drawing.Size(514, 62);
			this.lbl_diploma.TabIndex = 0;
			this.lbl_diploma.Text = "Possui diploma de ensino superior ? (sim/não)\r\n";
			// 
			// txt_diploma
			// 
			this.txt_diploma.Location = new System.Drawing.Point(614, 51);
			this.txt_diploma.Multiline = true;
			this.txt_diploma.Name = "txt_diploma";
			this.txt_diploma.Size = new System.Drawing.Size(100, 20);
			this.txt_diploma.TabIndex = 1;
			// 
			// lbl_idade
			// 
			this.lbl_idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_idade.Location = new System.Drawing.Point(278, 113);
			this.lbl_idade.Name = "lbl_idade";
			this.lbl_idade.Size = new System.Drawing.Size(82, 31);
			this.lbl_idade.TabIndex = 2;
			this.lbl_idade.Text = "Idade:";
			// 
			// txt_idade
			// 
			this.txt_idade.Location = new System.Drawing.Point(366, 122);
			this.txt_idade.Multiline = true;
			this.txt_idade.Name = "txt_idade";
			this.txt_idade.Size = new System.Drawing.Size(100, 20);
			this.txt_idade.TabIndex = 3;
			// 
			// btn_verificar_vaga
			// 
			this.btn_verificar_vaga.Location = new System.Drawing.Point(346, 193);
			this.btn_verificar_vaga.Name = "btn_verificar_vaga";
			this.btn_verificar_vaga.Size = new System.Drawing.Size(120, 39);
			this.btn_verificar_vaga.TabIndex = 4;
			this.btn_verificar_vaga.Text = "Verificar qualificação";
			this.btn_verificar_vaga.UseVisualStyleBackColor = true;
			this.btn_verificar_vaga.Click += new System.EventHandler(this.Button1Click);
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_resultado.Location = new System.Drawing.Point(83, 300);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(631, 31);
			this.lbl_resultado.TabIndex = 5;
			this.lbl_resultado.Text = "Resultado:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(873, 482);
			this.Controls.Add(this.lbl_resultado);
			this.Controls.Add(this.btn_verificar_vaga);
			this.Controls.Add(this.txt_idade);
			this.Controls.Add(this.lbl_idade);
			this.Controls.Add(this.txt_diploma);
			this.Controls.Add(this.lbl_diploma);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "qualificação de vaga ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
