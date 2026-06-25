/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 10:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atv_18
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_açucar;
		private System.Windows.Forms.TextBox txt_box_açucar;
		private System.Windows.Forms.Label lbl_leite;
		private System.Windows.Forms.TextBox txt_box_leite;
		private System.Windows.Forms.Button btn_preparar_cafe;
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
			this.lbl_açucar = new System.Windows.Forms.Label();
			this.txt_box_açucar = new System.Windows.Forms.TextBox();
			this.lbl_leite = new System.Windows.Forms.Label();
			this.txt_box_leite = new System.Windows.Forms.TextBox();
			this.btn_preparar_cafe = new System.Windows.Forms.Button();
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_açucar
			// 
			this.lbl_açucar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_açucar.Location = new System.Drawing.Point(37, 53);
			this.lbl_açucar.Name = "lbl_açucar";
			this.lbl_açucar.Size = new System.Drawing.Size(390, 42);
			this.lbl_açucar.TabIndex = 0;
			this.lbl_açucar.Text = "Deseja adicionar açúcar ?(sim/não):";
			// 
			// txt_box_açucar
			// 
			this.txt_box_açucar.Location = new System.Drawing.Point(397, 53);
			this.txt_box_açucar.Multiline = true;
			this.txt_box_açucar.Name = "txt_box_açucar";
			this.txt_box_açucar.Size = new System.Drawing.Size(172, 29);
			this.txt_box_açucar.TabIndex = 1;
			// 
			// lbl_leite
			// 
			this.lbl_leite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_leite.Location = new System.Drawing.Point(37, 125);
			this.lbl_leite.Name = "lbl_leite";
			this.lbl_leite.Size = new System.Drawing.Size(333, 42);
			this.lbl_leite.TabIndex = 2;
			this.lbl_leite.Text = "Deseja adicionar leite ?(sim/não):";
			// 
			// txt_box_leite
			// 
			this.txt_box_leite.Location = new System.Drawing.Point(376, 125);
			this.txt_box_leite.Multiline = true;
			this.txt_box_leite.Name = "txt_box_leite";
			this.txt_box_leite.Size = new System.Drawing.Size(172, 27);
			this.txt_box_leite.TabIndex = 3;
			// 
			// btn_preparar_cafe
			// 
			this.btn_preparar_cafe.Location = new System.Drawing.Point(298, 187);
			this.btn_preparar_cafe.Name = "btn_preparar_cafe";
			this.btn_preparar_cafe.Size = new System.Drawing.Size(129, 42);
			this.btn_preparar_cafe.TabIndex = 4;
			this.btn_preparar_cafe.Text = "Preparar café";
			this.btn_preparar_cafe.UseVisualStyleBackColor = true;
			this.btn_preparar_cafe.Click += new System.EventHandler(this.Btn_preparar_cafeClick);
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_resultado.Location = new System.Drawing.Point(37, 272);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(678, 42);
			this.lbl_resultado.TabIndex = 5;
			this.lbl_resultado.Text = "Resultado:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(860, 476);
			this.Controls.Add(this.lbl_resultado);
			this.Controls.Add(this.btn_preparar_cafe);
			this.Controls.Add(this.txt_box_leite);
			this.Controls.Add(this.lbl_leite);
			this.Controls.Add(this.txt_box_açucar);
			this.Controls.Add(this.lbl_açucar);
			this.Name = "MainForm";
			this.Text = "atv 18";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
