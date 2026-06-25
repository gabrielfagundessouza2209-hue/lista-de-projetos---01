/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 22/06/2026
 * Time: 11:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace numeros__negativos_ou_positivos
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_num;
		private System.Windows.Forms.TextBox txt_box_num;
		private System.Windows.Forms.Button button_class;
		private System.Windows.Forms.Label lbl_result;
		
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
			this.lbl_num = new System.Windows.Forms.Label();
			this.txt_box_num = new System.Windows.Forms.TextBox();
			this.button_class = new System.Windows.Forms.Button();
			this.lbl_result = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_num
			// 
			this.lbl_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_num.Location = new System.Drawing.Point(89, 125);
			this.lbl_num.Name = "lbl_num";
			this.lbl_num.Size = new System.Drawing.Size(240, 35);
			this.lbl_num.TabIndex = 0;
			this.lbl_num.Text = "Digite um número:";
			// 
			// txt_box_num
			// 
			this.txt_box_num.Location = new System.Drawing.Point(335, 137);
			this.txt_box_num.Name = "txt_box_num";
			this.txt_box_num.Size = new System.Drawing.Size(213, 20);
			this.txt_box_num.TabIndex = 1;
			// 
			// button_class
			// 
			this.button_class.Location = new System.Drawing.Point(231, 191);
			this.button_class.Name = "button_class";
			this.button_class.Size = new System.Drawing.Size(245, 60);
			this.button_class.TabIndex = 2;
			this.button_class.Text = "aperte aqui para classificar número";
			this.button_class.UseVisualStyleBackColor = true;
			this.button_class.Click += new System.EventHandler(this.Button_classClick);
			// 
			// lbl_result
			// 
			this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_result.Location = new System.Drawing.Point(44, 291);
			this.lbl_result.Name = "lbl_result";
			this.lbl_result.Size = new System.Drawing.Size(746, 35);
			this.lbl_result.TabIndex = 3;
			this.lbl_result.Text = "Resultado:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(835, 445);
			this.Controls.Add(this.lbl_result);
			this.Controls.Add(this.button_class);
			this.Controls.Add(this.txt_box_num);
			this.Controls.Add(this.lbl_num);
			this.Name = "MainForm";
			this.Text = "numeros_ negativos_ou_positivos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
