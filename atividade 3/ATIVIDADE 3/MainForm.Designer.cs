/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 18/06/2026
 * Time: 10:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ATIVIDADE_3
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox text_box_nota1;
		private System.Windows.Forms.Label lbl_verificação;
		private System.Windows.Forms.Label lbl_notas;
		private System.Windows.Forms.Label lbl_nota3;
		private System.Windows.Forms.Label lbl_nota2;
		private System.Windows.Forms.Label lbl_nota1;
		private System.Windows.Forms.Label lbl_aluno;
		private System.Windows.Forms.TextBox text_box_nota2;
		private System.Windows.Forms.TextBox text_box_nota3;
		private System.Windows.Forms.TextBox text_box_aluno;
		private System.Windows.Forms.Button button_calculo_notas;
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
			this.lbl_verificação = new System.Windows.Forms.Label();
			this.lbl_notas = new System.Windows.Forms.Label();
			this.lbl_nota3 = new System.Windows.Forms.Label();
			this.lbl_nota2 = new System.Windows.Forms.Label();
			this.lbl_nota1 = new System.Windows.Forms.Label();
			this.text_box_nota1 = new System.Windows.Forms.TextBox();
			this.lbl_aluno = new System.Windows.Forms.Label();
			this.text_box_nota2 = new System.Windows.Forms.TextBox();
			this.text_box_nota3 = new System.Windows.Forms.TextBox();
			this.text_box_aluno = new System.Windows.Forms.TextBox();
			this.button_calculo_notas = new System.Windows.Forms.Button();
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_verificação
			// 
			this.lbl_verificação.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_verificação.Location = new System.Drawing.Point(358, 40);
			this.lbl_verificação.Name = "lbl_verificação";
			this.lbl_verificação.Size = new System.Drawing.Size(231, 35);
			this.lbl_verificação.TabIndex = 0;
			this.lbl_verificação.Text = "Verificação de notas ";
			// 
			// lbl_notas
			// 
			this.lbl_notas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_notas.Location = new System.Drawing.Point(433, 101);
			this.lbl_notas.Name = "lbl_notas";
			this.lbl_notas.Size = new System.Drawing.Size(88, 35);
			this.lbl_notas.TabIndex = 1;
			this.lbl_notas.Text = "Notas:";
			// 
			// lbl_nota3
			// 
			this.lbl_nota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_nota3.Location = new System.Drawing.Point(244, 337);
			this.lbl_nota3.Name = "lbl_nota3";
			this.lbl_nota3.Size = new System.Drawing.Size(88, 35);
			this.lbl_nota3.TabIndex = 2;
			this.lbl_nota3.Text = "Nota3:";
			// 
			// lbl_nota2
			// 
			this.lbl_nota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_nota2.Location = new System.Drawing.Point(244, 288);
			this.lbl_nota2.Name = "lbl_nota2";
			this.lbl_nota2.Size = new System.Drawing.Size(88, 35);
			this.lbl_nota2.TabIndex = 3;
			this.lbl_nota2.Text = "Nota2:";
			// 
			// lbl_nota1
			// 
			this.lbl_nota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_nota1.Location = new System.Drawing.Point(244, 234);
			this.lbl_nota1.Name = "lbl_nota1";
			this.lbl_nota1.Size = new System.Drawing.Size(88, 35);
			this.lbl_nota1.TabIndex = 4;
			this.lbl_nota1.Text = "Nota1:";
			// 
			// text_box_nota1
			// 
			this.text_box_nota1.Location = new System.Drawing.Point(324, 243);
			this.text_box_nota1.Name = "text_box_nota1";
			this.text_box_nota1.Size = new System.Drawing.Size(265, 20);
			this.text_box_nota1.TabIndex = 5;
			// 
			// lbl_aluno
			// 
			this.lbl_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_aluno.Location = new System.Drawing.Point(244, 180);
			this.lbl_aluno.Name = "lbl_aluno";
			this.lbl_aluno.Size = new System.Drawing.Size(88, 35);
			this.lbl_aluno.TabIndex = 6;
			this.lbl_aluno.Text = "Aluno:";
			// 
			// text_box_nota2
			// 
			this.text_box_nota2.Location = new System.Drawing.Point(324, 297);
			this.text_box_nota2.Name = "text_box_nota2";
			this.text_box_nota2.Size = new System.Drawing.Size(265, 20);
			this.text_box_nota2.TabIndex = 7;
			// 
			// text_box_nota3
			// 
			this.text_box_nota3.Location = new System.Drawing.Point(324, 346);
			this.text_box_nota3.Name = "text_box_nota3";
			this.text_box_nota3.Size = new System.Drawing.Size(265, 20);
			this.text_box_nota3.TabIndex = 8;
			// 
			// text_box_aluno
			// 
			this.text_box_aluno.Location = new System.Drawing.Point(324, 189);
			this.text_box_aluno.Name = "text_box_aluno";
			this.text_box_aluno.Size = new System.Drawing.Size(265, 20);
			this.text_box_aluno.TabIndex = 9;
			// 
			// button_calculo_notas
			// 
			this.button_calculo_notas.Location = new System.Drawing.Point(410, 372);
			this.button_calculo_notas.Name = "button_calculo_notas";
			this.button_calculo_notas.Size = new System.Drawing.Size(82, 41);
			this.button_calculo_notas.TabIndex = 10;
			this.button_calculo_notas.Text = "calculo";
			this.button_calculo_notas.UseVisualStyleBackColor = true;
			this.button_calculo_notas.Click += new System.EventHandler(this.Button_calculo_notasClick);
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_resultado.Location = new System.Drawing.Point(146, 416);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(696, 35);
			this.lbl_resultado.TabIndex = 11;
			this.lbl_resultado.Text = "Resultado:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 587);
			this.Controls.Add(this.lbl_resultado);
			this.Controls.Add(this.button_calculo_notas);
			this.Controls.Add(this.text_box_aluno);
			this.Controls.Add(this.text_box_nota3);
			this.Controls.Add(this.text_box_nota2);
			this.Controls.Add(this.lbl_aluno);
			this.Controls.Add(this.text_box_nota1);
			this.Controls.Add(this.lbl_nota1);
			this.Controls.Add(this.lbl_nota2);
			this.Controls.Add(this.lbl_nota3);
			this.Controls.Add(this.lbl_notas);
			this.Controls.Add(this.lbl_verificação);
			this.Name = "MainForm";
			this.Text = "ATIVIDADE 3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
