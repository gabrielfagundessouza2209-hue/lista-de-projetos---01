/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 25/06/2026
 * Time: 10:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_25
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_cancelamento;
		private System.Windows.Forms.Button bTN_verificar_cancelamento;
		private System.Windows.Forms.TextBox txt_sim_ou_nao;
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
			this.lbl_cancelamento = new System.Windows.Forms.Label();
			this.bTN_verificar_cancelamento = new System.Windows.Forms.Button();
			this.txt_sim_ou_nao = new System.Windows.Forms.TextBox();
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_cancelamento
			// 
			this.lbl_cancelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_cancelamento.Location = new System.Drawing.Point(136, 69);
			this.lbl_cancelamento.Name = "lbl_cancelamento";
			this.lbl_cancelamento.Size = new System.Drawing.Size(244, 23);
			this.lbl_cancelamento.TabIndex = 0;
			this.lbl_cancelamento.Text = "Você deseja cancelar a operação ?";
			// 
			// bTN_verificar_cancelamento
			// 
			this.bTN_verificar_cancelamento.Location = new System.Drawing.Point(210, 184);
			this.bTN_verificar_cancelamento.Name = "bTN_verificar_cancelamento";
			this.bTN_verificar_cancelamento.Size = new System.Drawing.Size(75, 23);
			this.bTN_verificar_cancelamento.TabIndex = 3;
			this.bTN_verificar_cancelamento.Text = "verificar";
			this.bTN_verificar_cancelamento.UseVisualStyleBackColor = true;
			this.bTN_verificar_cancelamento.Click += new System.EventHandler(this.btnVerificarCancelamentoClick);
			this.bTN_verificar_cancelamento.Enter += new System.EventHandler(this.btnVerificarCancelamentoClick);
			// 
			// txt_sim_ou_nao
			// 
			this.txt_sim_ou_nao.Location = new System.Drawing.Point(194, 138);
			this.txt_sim_ou_nao.Name = "txt_sim_ou_nao";
			this.txt_sim_ou_nao.Size = new System.Drawing.Size(100, 20);
			this.txt_sim_ou_nao.TabIndex = 4;
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_resultado.Location = new System.Drawing.Point(66, 250);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(381, 23);
			this.lbl_resultado.TabIndex = 5;
			this.lbl_resultado.Text = "Resultado:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 339);
			this.Controls.Add(this.lbl_resultado);
			this.Controls.Add(this.txt_sim_ou_nao);
			this.Controls.Add(this.bTN_verificar_cancelamento);
			this.Controls.Add(this.lbl_cancelamento);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "atividade 25";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
