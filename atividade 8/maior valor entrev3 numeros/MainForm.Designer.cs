/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 23/06/2026
 * Time: 09:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace maior_valor_entrev3_numeros
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_num1;
		private System.Windows.Forms.TextBox txt_box_num1;
		private System.Windows.Forms.Label lbl_num2;
		private System.Windows.Forms.TextBox txt_box_num2;
		private System.Windows.Forms.Label lbl_num3;
		private System.Windows.Forms.TextBox txt_box_num3;
		private System.Windows.Forms.Button btn_encrontrarmaior;
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
			this.txt_box_num1 = new System.Windows.Forms.TextBox();
			this.lbl_num2 = new System.Windows.Forms.Label();
			this.txt_box_num2 = new System.Windows.Forms.TextBox();
			this.lbl_num3 = new System.Windows.Forms.Label();
			this.txt_box_num3 = new System.Windows.Forms.TextBox();
			this.btn_encrontrarmaior = new System.Windows.Forms.Button();
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_num1
			// 
			this.lbl_num1.Location = new System.Drawing.Point(47, 52);
			this.lbl_num1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.lbl_num1.Name = "lbl_num1";
			this.lbl_num1.Size = new System.Drawing.Size(222, 42);
			this.lbl_num1.TabIndex = 0;
			this.lbl_num1.Text = "Primeiro número:";
			// 
			// txt_box_num1
			// 
			this.txt_box_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_box_num1.Location = new System.Drawing.Point(271, 63);
			this.txt_box_num1.Multiline = true;
			this.txt_box_num1.Name = "txt_box_num1";
			this.txt_box_num1.Size = new System.Drawing.Size(291, 20);
			this.txt_box_num1.TabIndex = 1;
			// 
			// lbl_num2
			// 
			this.lbl_num2.Location = new System.Drawing.Point(47, 118);
			this.lbl_num2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.lbl_num2.Name = "lbl_num2";
			this.lbl_num2.Size = new System.Drawing.Size(236, 42);
			this.lbl_num2.TabIndex = 2;
			this.lbl_num2.Text = "Segundo número:";
			// 
			// txt_box_num2
			// 
			this.txt_box_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_box_num2.Location = new System.Drawing.Point(271, 127);
			this.txt_box_num2.Multiline = true;
			this.txt_box_num2.Name = "txt_box_num2";
			this.txt_box_num2.Size = new System.Drawing.Size(291, 20);
			this.txt_box_num2.TabIndex = 3;
			// 
			// lbl_num3
			// 
			this.lbl_num3.Location = new System.Drawing.Point(47, 184);
			this.lbl_num3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.lbl_num3.Name = "lbl_num3";
			this.lbl_num3.Size = new System.Drawing.Size(222, 42);
			this.lbl_num3.TabIndex = 4;
			this.lbl_num3.Text = "Terceiro número:";
			// 
			// txt_box_num3
			// 
			this.txt_box_num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_box_num3.Location = new System.Drawing.Point(271, 196);
			this.txt_box_num3.Multiline = true;
			this.txt_box_num3.Name = "txt_box_num3";
			this.txt_box_num3.Size = new System.Drawing.Size(291, 20);
			this.txt_box_num3.TabIndex = 5;
			// 
			// btn_encrontrarmaior
			// 
			this.btn_encrontrarmaior.Location = new System.Drawing.Point(148, 249);
			this.btn_encrontrarmaior.Name = "btn_encrontrarmaior";
			this.btn_encrontrarmaior.Size = new System.Drawing.Size(354, 37);
			this.btn_encrontrarmaior.TabIndex = 6;
			this.btn_encrontrarmaior.Text = "encrontrar maior número";
			this.btn_encrontrarmaior.UseVisualStyleBackColor = true;
			this.btn_encrontrarmaior.Click += new System.EventHandler(this.Btn_encrontrarmaiorClick);
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.Location = new System.Drawing.Point(47, 318);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(541, 56);
			this.lbl_resultado.TabIndex = 7;
			this.lbl_resultado.Text = "Resultado:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1604, 881);
			this.Controls.Add(this.lbl_resultado);
			this.Controls.Add(this.btn_encrontrarmaior);
			this.Controls.Add(this.txt_box_num3);
			this.Controls.Add(this.lbl_num3);
			this.Controls.Add(this.txt_box_num2);
			this.Controls.Add(this.lbl_num2);
			this.Controls.Add(this.txt_box_num1);
			this.Controls.Add(this.lbl_num1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.Name = "MainForm";
			this.Text = "maior valor entrev3 numeros";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
