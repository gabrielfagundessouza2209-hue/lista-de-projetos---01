/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 25/06/2026
 * Time: 10:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_24
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_palavra;
		private System.Windows.Forms.TextBox txt_palavra;
		private System.Windows.Forms.Button button1;
		
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
			this.lbl_palavra = new System.Windows.Forms.Label();
			this.txt_palavra = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_palavra
			// 
			this.lbl_palavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_palavra.Location = new System.Drawing.Point(97, 99);
			this.lbl_palavra.Name = "lbl_palavra";
			this.lbl_palavra.Size = new System.Drawing.Size(147, 23);
			this.lbl_palavra.TabIndex = 0;
			this.lbl_palavra.Text = "Digite uma palavra:";
			// 
			// txt_palavra
			// 
			this.txt_palavra.Location = new System.Drawing.Point(88, 138);
			this.txt_palavra.Name = "txt_palavra";
			this.txt_palavra.Size = new System.Drawing.Size(168, 20);
			this.txt_palavra.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(131, 199);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "verificar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 330);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txt_palavra);
			this.Controls.Add(this.lbl_palavra);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "palavra preenchida";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
