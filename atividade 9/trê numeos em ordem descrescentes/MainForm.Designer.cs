/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 23/06/2026
 * Time: 10:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace trê_numeos_em_ordem_descrescentes
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_num1;
		private System.Windows.Forms.TextBox txt_box_1;
		private System.Windows.Forms.Label lbl_num2;
		private System.Windows.Forms.Label lbl_num3;
		private System.Windows.Forms.TextBox txt_box_3;
		private System.Windows.Forms.TextBox txt_box_2;
		private System.Windows.Forms.Button btn_ordemdescrescente;
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
			this.lbl_num1 = new System.Windows.Forms.Label();
			this.txt_box_1 = new System.Windows.Forms.TextBox();
			this.lbl_num2 = new System.Windows.Forms.Label();
			this.lbl_num3 = new System.Windows.Forms.Label();
			this.txt_box_3 = new System.Windows.Forms.TextBox();
			this.txt_box_2 = new System.Windows.Forms.TextBox();
			this.btn_ordemdescrescente = new System.Windows.Forms.Button();
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_num1
			// 
			this.lbl_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_num1.Location = new System.Drawing.Point(59, 64);
			this.lbl_num1.Name = "lbl_num1";
			this.lbl_num1.Size = new System.Drawing.Size(319, 37);
			this.lbl_num1.TabIndex = 0;
			this.lbl_num1.Text = "Digite o primeiro número:";
			// 
			// txt_box_1
			// 
			this.txt_box_1.Location = new System.Drawing.Point(384, 76);
			this.txt_box_1.Name = "txt_box_1";
			this.txt_box_1.Size = new System.Drawing.Size(100, 20);
			this.txt_box_1.TabIndex = 1;
			// 
			// lbl_num2
			// 
			this.lbl_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_num2.Location = new System.Drawing.Point(46, 125);
			this.lbl_num2.Name = "lbl_num2";
			this.lbl_num2.Size = new System.Drawing.Size(332, 37);
			this.lbl_num2.TabIndex = 2;
			this.lbl_num2.Text = "Digite o segundo número:";
			// 
			// lbl_num3
			// 
			this.lbl_num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_num3.Location = new System.Drawing.Point(59, 198);
			this.lbl_num3.Name = "lbl_num3";
			this.lbl_num3.Size = new System.Drawing.Size(310, 37);
			this.lbl_num3.TabIndex = 3;
			this.lbl_num3.Text = "Digite o terceiro número:";
			// 
			// txt_box_3
			// 
			this.txt_box_3.Location = new System.Drawing.Point(384, 210);
			this.txt_box_3.Name = "txt_box_3";
			this.txt_box_3.Size = new System.Drawing.Size(100, 20);
			this.txt_box_3.TabIndex = 4;
			// 
			// txt_box_2
			// 
			this.txt_box_2.Location = new System.Drawing.Point(384, 137);
			this.txt_box_2.Name = "txt_box_2";
			this.txt_box_2.Size = new System.Drawing.Size(100, 20);
			this.txt_box_2.TabIndex = 5;
			// 
			// btn_ordemdescrescente
			// 
			this.btn_ordemdescrescente.Location = new System.Drawing.Point(247, 268);
			this.btn_ordemdescrescente.Name = "btn_ordemdescrescente";
			this.btn_ordemdescrescente.Size = new System.Drawing.Size(166, 39);
			this.btn_ordemdescrescente.TabIndex = 6;
			this.btn_ordemdescrescente.Text = "ordenar números";
			this.btn_ordemdescrescente.UseVisualStyleBackColor = true;
			this.btn_ordemdescrescente.Click += new System.EventHandler(this.Btn_ordemdescrescenteClick);
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_resultado.Location = new System.Drawing.Point(59, 357);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(610, 103);
			this.lbl_resultado.TabIndex = 7;
			this.lbl_resultado.Text = "Resultado:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(826, 469);
			this.Controls.Add(this.lbl_resultado);
			this.Controls.Add(this.btn_ordemdescrescente);
			this.Controls.Add(this.txt_box_2);
			this.Controls.Add(this.txt_box_3);
			this.Controls.Add(this.lbl_num3);
			this.Controls.Add(this.lbl_num2);
			this.Controls.Add(this.txt_box_1);
			this.Controls.Add(this.lbl_num1);
			this.Name = "MainForm";
			this.Text = "trê numeos em ordem descrescentes";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
