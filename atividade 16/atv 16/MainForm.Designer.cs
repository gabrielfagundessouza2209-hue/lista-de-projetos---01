/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 09:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atv_16
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_assinante;
		private System.Windows.Forms.TextBox txt_assinante;
		private System.Windows.Forms.Label lbl_Assistiu;
		private System.Windows.Forms.TextBox txt_assistiu;
		private System.Windows.Forms.Button btn_verificar_temporada;
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
			this.lbl_assinante = new System.Windows.Forms.Label();
			this.txt_assinante = new System.Windows.Forms.TextBox();
			this.lbl_Assistiu = new System.Windows.Forms.Label();
			this.txt_assistiu = new System.Windows.Forms.TextBox();
			this.btn_verificar_temporada = new System.Windows.Forms.Button();
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_assinante
			// 
			this.lbl_assinante.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_assinante.Location = new System.Drawing.Point(65, 64);
			this.lbl_assinante.Name = "lbl_assinante";
			this.lbl_assinante.Size = new System.Drawing.Size(385, 35);
			this.lbl_assinante.TabIndex = 0;
			this.lbl_assinante.Text = "É assinante do serviço ? (sim/não)";
			// 
			// txt_assinante
			// 
			this.txt_assinante.Location = new System.Drawing.Point(456, 73);
			this.txt_assinante.Multiline = true;
			this.txt_assinante.Name = "txt_assinante";
			this.txt_assinante.Size = new System.Drawing.Size(144, 22);
			this.txt_assinante.TabIndex = 1;
			// 
			// lbl_Assistiu
			// 
			this.lbl_Assistiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Assistiu.Location = new System.Drawing.Point(12, 145);
			this.lbl_Assistiu.Name = "lbl_Assistiu";
			this.lbl_Assistiu.Size = new System.Drawing.Size(420, 35);
			this.lbl_Assistiu.TabIndex = 2;
			this.lbl_Assistiu.Text = "já assisitu á série anterior ? (sim/não)";
			// 
			// txt_assistiu
			// 
			this.txt_assistiu.Location = new System.Drawing.Point(438, 154);
			this.txt_assistiu.Multiline = true;
			this.txt_assistiu.Name = "txt_assistiu";
			this.txt_assistiu.Size = new System.Drawing.Size(144, 22);
			this.txt_assistiu.TabIndex = 3;
			// 
			// btn_verificar_temporada
			// 
			this.btn_verificar_temporada.Location = new System.Drawing.Point(298, 246);
			this.btn_verificar_temporada.Name = "btn_verificar_temporada";
			this.btn_verificar_temporada.Size = new System.Drawing.Size(167, 35);
			this.btn_verificar_temporada.TabIndex = 4;
			this.btn_verificar_temporada.Text = "Verificar acesso";
			this.btn_verificar_temporada.UseVisualStyleBackColor = true;
			this.btn_verificar_temporada.Click += new System.EventHandler(this.Btn_verificar_temporadaClick);
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_resultado.Location = new System.Drawing.Point(106, 310);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(743, 35);
			this.lbl_resultado.TabIndex = 5;
			this.lbl_resultado.Text = "Resultado:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(861, 485);
			this.Controls.Add(this.lbl_resultado);
			this.Controls.Add(this.btn_verificar_temporada);
			this.Controls.Add(this.txt_assistiu);
			this.Controls.Add(this.lbl_Assistiu);
			this.Controls.Add(this.txt_assinante);
			this.Controls.Add(this.lbl_assinante);
			this.Name = "MainForm";
			this.Text = "atv 16";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
