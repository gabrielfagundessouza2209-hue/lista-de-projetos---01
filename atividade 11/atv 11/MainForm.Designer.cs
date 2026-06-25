/*
 * Created by SharpDevelop.
 * User: Gabriel
 * Date: 23/06/2026
 * Time: 22:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atv_11
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_valordeA;
		private System.Windows.Forms.TextBox txt_box_valorA;
		private System.Windows.Forms.Label lbl_valordeB;
		private System.Windows.Forms.TextBox txt_box_valorB;
		private System.Windows.Forms.Label lbl_valordeC;
		private System.Windows.Forms.TextBox txt_box_valorC;
		private System.Windows.Forms.Button btn_calcular_equacao;
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
			this.lbl_valordeA = new System.Windows.Forms.Label();
			this.txt_box_valorA = new System.Windows.Forms.TextBox();
			this.lbl_valordeB = new System.Windows.Forms.Label();
			this.txt_box_valorB = new System.Windows.Forms.TextBox();
			this.lbl_valordeC = new System.Windows.Forms.Label();
			this.txt_box_valorC = new System.Windows.Forms.TextBox();
			this.btn_calcular_equacao = new System.Windows.Forms.Button();
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_valordeA
			// 
			this.lbl_valordeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_valordeA.Location = new System.Drawing.Point(72, 62);
			this.lbl_valordeA.Name = "lbl_valordeA";
			this.lbl_valordeA.Size = new System.Drawing.Size(300, 59);
			this.lbl_valordeA.TabIndex = 0;
			this.lbl_valordeA.Text = "Insira o valor de A:";
			// 
			// txt_box_valorA
			// 
			this.txt_box_valorA.Location = new System.Drawing.Point(378, 77);
			this.txt_box_valorA.Multiline = true;
			this.txt_box_valorA.Name = "txt_box_valorA";
			this.txt_box_valorA.Size = new System.Drawing.Size(236, 29);
			this.txt_box_valorA.TabIndex = 1;
			// 
			// lbl_valordeB
			// 
			this.lbl_valordeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_valordeB.Location = new System.Drawing.Point(72, 146);
			this.lbl_valordeB.Name = "lbl_valordeB";
			this.lbl_valordeB.Size = new System.Drawing.Size(300, 59);
			this.lbl_valordeB.TabIndex = 2;
			this.lbl_valordeB.Text = "Insira o valor de B:";
			// 
			// txt_box_valorB
			// 
			this.txt_box_valorB.Location = new System.Drawing.Point(378, 176);
			this.txt_box_valorB.Multiline = true;
			this.txt_box_valorB.Name = "txt_box_valorB";
			this.txt_box_valorB.Size = new System.Drawing.Size(236, 29);
			this.txt_box_valorB.TabIndex = 3;
			// 
			// lbl_valordeC
			// 
			this.lbl_valordeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_valordeC.Location = new System.Drawing.Point(72, 247);
			this.lbl_valordeC.Name = "lbl_valordeC";
			this.lbl_valordeC.Size = new System.Drawing.Size(309, 59);
			this.lbl_valordeC.TabIndex = 4;
			this.lbl_valordeC.Text = "Insira o valor de C:";
			// 
			// txt_box_valorC
			// 
			this.txt_box_valorC.Location = new System.Drawing.Point(378, 247);
			this.txt_box_valorC.Multiline = true;
			this.txt_box_valorC.Name = "txt_box_valorC";
			this.txt_box_valorC.Size = new System.Drawing.Size(236, 29);
			this.txt_box_valorC.TabIndex = 5;
			// 
			// btn_calcular_equacao
			// 
			this.btn_calcular_equacao.Location = new System.Drawing.Point(680, 161);
			this.btn_calcular_equacao.Name = "btn_calcular_equacao";
			this.btn_calcular_equacao.Size = new System.Drawing.Size(288, 78);
			this.btn_calcular_equacao.TabIndex = 6;
			this.btn_calcular_equacao.Text = "Calcular raízes ";
			this.btn_calcular_equacao.UseVisualStyleBackColor = true;
			this.btn_calcular_equacao.Click += new System.EventHandler(this.Btn_calcular_equacaoClick);
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_resultado.Location = new System.Drawing.Point(62, 326);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(1106, 217);
			this.lbl_resultado.TabIndex = 7;
			this.lbl_resultado.Text = "Resultado da equação:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1246, 627);
			this.Controls.Add(this.lbl_resultado);
			this.Controls.Add(this.btn_calcular_equacao);
			this.Controls.Add(this.txt_box_valorC);
			this.Controls.Add(this.lbl_valordeC);
			this.Controls.Add(this.txt_box_valorB);
			this.Controls.Add(this.lbl_valordeB);
			this.Controls.Add(this.txt_box_valorA);
			this.Controls.Add(this.lbl_valordeA);
			this.Name = "MainForm";
			this.Text = "atv 11";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
