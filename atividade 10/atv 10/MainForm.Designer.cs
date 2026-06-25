/*
 * Created by SharpDevelop.
 * User: Gabriel
 * Date: 23/06/2026
 * Time: 22:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atv_10
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_idade_nadador;
		private System.Windows.Forms.TextBox txt_box_idade;
		private System.Windows.Forms.Button btn_clasaificar_categoria;
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
			this.lbl_idade_nadador = new System.Windows.Forms.Label();
			this.txt_box_idade = new System.Windows.Forms.TextBox();
			this.btn_clasaificar_categoria = new System.Windows.Forms.Button();
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_idade_nadador
			// 
			this.lbl_idade_nadador.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_idade_nadador.Location = new System.Drawing.Point(111, 89);
			this.lbl_idade_nadador.Name = "lbl_idade_nadador";
			this.lbl_idade_nadador.Size = new System.Drawing.Size(418, 47);
			this.lbl_idade_nadador.TabIndex = 0;
			this.lbl_idade_nadador.Text = "Idade do nadador:";
			// 
			// txt_box_idade
			// 
			this.txt_box_idade.Location = new System.Drawing.Point(551, 104);
			this.txt_box_idade.Name = "txt_box_idade";
			this.txt_box_idade.Size = new System.Drawing.Size(238, 22);
			this.txt_box_idade.TabIndex = 1;
			// 
			// btn_clasaificar_categoria
			// 
			this.btn_clasaificar_categoria.Location = new System.Drawing.Point(468, 194);
			this.btn_clasaificar_categoria.Name = "btn_clasaificar_categoria";
			this.btn_clasaificar_categoria.Size = new System.Drawing.Size(194, 77);
			this.btn_clasaificar_categoria.TabIndex = 2;
			this.btn_clasaificar_categoria.Text = "Classificar categoria ";
			this.btn_clasaificar_categoria.UseVisualStyleBackColor = true;
			this.btn_clasaificar_categoria.Click += new System.EventHandler(this.Btn_clasaificar_categoriaClick);
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_resultado.Location = new System.Drawing.Point(142, 369);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(961, 47);
			this.lbl_resultado.TabIndex = 3;
			this.lbl_resultado.Text = "Categoria:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1251, 557);
			this.Controls.Add(this.lbl_resultado);
			this.Controls.Add(this.btn_clasaificar_categoria);
			this.Controls.Add(this.txt_box_idade);
			this.Controls.Add(this.lbl_idade_nadador);
			this.Name = "MainForm";
			this.Text = "atv 10";
			this.Load += new System.EventHandler(this.MainFormload);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
