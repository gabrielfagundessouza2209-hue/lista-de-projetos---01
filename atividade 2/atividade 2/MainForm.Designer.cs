/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 18/06/2026
 * Time: 09:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button_calculo;
		private System.Windows.Forms.Label lbl_aluno;
		private System.Windows.Forms.Label lbl_nota1;
		private System.Windows.Forms.Label lbl_nota2;
		private System.Windows.Forms.Label lbl_nota3;
		private System.Windows.Forms.TextBox text_Box_nome;
		private System.Windows.Forms.TextBox text_Box_nota1;
		private System.Windows.Forms.TextBox text_Box_nota2;
		private System.Windows.Forms.Label lbl_resultado;
		private System.Windows.Forms.TextBox text_Box_nota3;
		private System.Windows.Forms.Label label1;
		
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
			this.button_calculo = new System.Windows.Forms.Button();
			this.lbl_aluno = new System.Windows.Forms.Label();
			this.lbl_nota1 = new System.Windows.Forms.Label();
			this.lbl_nota2 = new System.Windows.Forms.Label();
			this.lbl_nota3 = new System.Windows.Forms.Label();
			this.text_Box_nome = new System.Windows.Forms.TextBox();
			this.text_Box_nota1 = new System.Windows.Forms.TextBox();
			this.text_Box_nota2 = new System.Windows.Forms.TextBox();
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.text_Box_nota3 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_calculo
			// 
			this.button_calculo.Location = new System.Drawing.Point(259, 301);
			this.button_calculo.Margin = new System.Windows.Forms.Padding(5);
			this.button_calculo.Name = "button_calculo";
			this.button_calculo.Size = new System.Drawing.Size(182, 35);
			this.button_calculo.TabIndex = 0;
			this.button_calculo.Text = "CALCULAR ";
			this.button_calculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button_calculo.UseVisualStyleBackColor = true;
			this.button_calculo.Click += new System.EventHandler(this.Button_calculoClick);
			// 
			// lbl_aluno
			// 
			this.lbl_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_aluno.Location = new System.Drawing.Point(218, 141);
			this.lbl_aluno.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_aluno.Name = "lbl_aluno";
			this.lbl_aluno.Size = new System.Drawing.Size(96, 35);
			this.lbl_aluno.TabIndex = 1;
			this.lbl_aluno.Text = "ALUNO:";
			// 
			// lbl_nota1
			// 
			this.lbl_nota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_nota1.Location = new System.Drawing.Point(218, 178);
			this.lbl_nota1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_nota1.Name = "lbl_nota1";
			this.lbl_nota1.Size = new System.Drawing.Size(96, 35);
			this.lbl_nota1.TabIndex = 2;
			this.lbl_nota1.Text = "NOTA1:";
			// 
			// lbl_nota2
			// 
			this.lbl_nota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_nota2.Location = new System.Drawing.Point(218, 213);
			this.lbl_nota2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_nota2.Name = "lbl_nota2";
			this.lbl_nota2.Size = new System.Drawing.Size(91, 35);
			this.lbl_nota2.TabIndex = 3;
			this.lbl_nota2.Text = "NOTA2:";
			// 
			// lbl_nota3
			// 
			this.lbl_nota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_nota3.Location = new System.Drawing.Point(218, 248);
			this.lbl_nota3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_nota3.Name = "lbl_nota3";
			this.lbl_nota3.Size = new System.Drawing.Size(96, 35);
			this.lbl_nota3.TabIndex = 4;
			this.lbl_nota3.Text = "NOTA3:";
			// 
			// text_Box_nome
			// 
			this.text_Box_nome.Location = new System.Drawing.Point(324, 142);
			this.text_Box_nome.Margin = new System.Windows.Forms.Padding(5);
			this.text_Box_nome.Name = "text_Box_nome";
			this.text_Box_nome.Size = new System.Drawing.Size(148, 26);
			this.text_Box_nome.TabIndex = 5;
			// 
			// text_Box_nota1
			// 
			this.text_Box_nota1.Location = new System.Drawing.Point(324, 178);
			this.text_Box_nota1.Margin = new System.Windows.Forms.Padding(5);
			this.text_Box_nota1.Name = "text_Box_nota1";
			this.text_Box_nota1.Size = new System.Drawing.Size(148, 26);
			this.text_Box_nota1.TabIndex = 6;
			// 
			// text_Box_nota2
			// 
			this.text_Box_nota2.Location = new System.Drawing.Point(324, 214);
			this.text_Box_nota2.Margin = new System.Windows.Forms.Padding(5);
			this.text_Box_nota2.Name = "text_Box_nota2";
			this.text_Box_nota2.Size = new System.Drawing.Size(148, 26);
			this.text_Box_nota2.TabIndex = 7;
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.Location = new System.Drawing.Point(218, 352);
			this.lbl_resultado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(610, 35);
			this.lbl_resultado.TabIndex = 8;
			this.lbl_resultado.Text = "RESPOSTA: ";
			// 
			// text_Box_nota3
			// 
			this.text_Box_nota3.Location = new System.Drawing.Point(324, 250);
			this.text_Box_nota3.Margin = new System.Windows.Forms.Padding(5);
			this.text_Box_nota3.Name = "text_Box_nota3";
			this.text_Box_nota3.Size = new System.Drawing.Size(148, 26);
			this.text_Box_nota3.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(473, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 35);
			this.label1.TabIndex = 10;
			this.label1.Text = "MEDIANA";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1007, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.text_Box_nota3);
			this.Controls.Add(this.lbl_resultado);
			this.Controls.Add(this.text_Box_nota2);
			this.Controls.Add(this.text_Box_nota1);
			this.Controls.Add(this.text_Box_nome);
			this.Controls.Add(this.lbl_nota3);
			this.Controls.Add(this.lbl_nota2);
			this.Controls.Add(this.lbl_nota1);
			this.Controls.Add(this.lbl_aluno);
			this.Controls.Add(this.button_calculo);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "MainForm";
			this.Text = "atividade 2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
