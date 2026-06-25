/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 22/06/2026
 * Time: 09:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace numero_negativo_ou_positivo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_num;
		private System.Windows.Forms.TextBox txt_num;
		private System.Windows.Forms.Button btn_ver_num;
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
			this.txt_num = new System.Windows.Forms.TextBox();
			this.btn_ver_num = new System.Windows.Forms.Button();
			this.lbl_result = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_num
			// 
			this.lbl_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_num.Location = new System.Drawing.Point(261, 72);
			this.lbl_num.Name = "lbl_num";
			this.lbl_num.Size = new System.Drawing.Size(287, 55);
			this.lbl_num.TabIndex = 0;
			this.lbl_num.Text = "Digite um Número:";
			// 
			// txt_num
			// 
			this.txt_num.Location = new System.Drawing.Point(217, 157);
			this.txt_num.Name = "txt_num";
			this.txt_num.Size = new System.Drawing.Size(391, 20);
			this.txt_num.TabIndex = 1;
			// 
			// btn_ver_num
			// 
			this.btn_ver_num.Location = new System.Drawing.Point(340, 215);
			this.btn_ver_num.Name = "btn_ver_num";
			this.btn_ver_num.Size = new System.Drawing.Size(141, 42);
			this.btn_ver_num.TabIndex = 2;
			this.btn_ver_num.Text = "aperte aqui para verificar";
			this.btn_ver_num.UseVisualStyleBackColor = true;
			this.btn_ver_num.Click += new System.EventHandler(this.Btn_ver_numClick);
			// 
			// lbl_result
			// 
			this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_result.Location = new System.Drawing.Point(114, 299);
			this.lbl_result.Name = "lbl_result";
			this.lbl_result.Size = new System.Drawing.Size(561, 115);
			this.lbl_result.TabIndex = 3;
			this.lbl_result.Text = "Resultado:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1037, 454);
			this.Controls.Add(this.lbl_result);
			this.Controls.Add(this.btn_ver_num);
			this.Controls.Add(this.txt_num);
			this.Controls.Add(this.lbl_num);
			this.Name = "MainForm";
			this.Text = "numero_maior_que_20";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
