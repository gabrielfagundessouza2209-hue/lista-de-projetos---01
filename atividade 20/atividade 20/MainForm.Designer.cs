/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 25/06/2026
 * Time: 08:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_20
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_RespostadeCompra;
		private System.Windows.Forms.Button btn_ConfirmarCompra;
		private System.Windows.Forms.RadioButton rb_sim;
		private System.Windows.Forms.RadioButton rb_não;
		
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
			this.lbl_RespostadeCompra = new System.Windows.Forms.Label();
			this.btn_ConfirmarCompra = new System.Windows.Forms.Button();
			this.rb_sim = new System.Windows.Forms.RadioButton();
			this.rb_não = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// lbl_RespostadeCompra
			// 
			this.lbl_RespostadeCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_RespostadeCompra.Location = new System.Drawing.Point(12, 25);
			this.lbl_RespostadeCompra.Name = "lbl_RespostadeCompra";
			this.lbl_RespostadeCompra.Size = new System.Drawing.Size(221, 67);
			this.lbl_RespostadeCompra.TabIndex = 0;
			this.lbl_RespostadeCompra.Text = "Deseja comprar o produto?(sim/não):";
			// 
			// btn_ConfirmarCompra
			// 
			this.btn_ConfirmarCompra.Location = new System.Drawing.Point(82, 204);
			this.btn_ConfirmarCompra.Name = "btn_ConfirmarCompra";
			this.btn_ConfirmarCompra.Size = new System.Drawing.Size(75, 23);
			this.btn_ConfirmarCompra.TabIndex = 2;
			this.btn_ConfirmarCompra.Text = "Confirmar";
			this.btn_ConfirmarCompra.UseVisualStyleBackColor = true;
			this.btn_ConfirmarCompra.Click += new System.EventHandler(this.Btn_ConfirmarCompraClick);
			// 
			// rb_sim
			// 
			this.rb_sim.Location = new System.Drawing.Point(53, 109);
			this.rb_sim.Name = "rb_sim";
			this.rb_sim.Size = new System.Drawing.Size(104, 24);
			this.rb_sim.TabIndex = 3;
			this.rb_sim.TabStop = true;
			this.rb_sim.Text = "Sim";
			this.rb_sim.UseVisualStyleBackColor = true;
			// 
			// rb_não
			// 
			this.rb_não.Location = new System.Drawing.Point(53, 139);
			this.rb_não.Name = "rb_não";
			this.rb_não.Size = new System.Drawing.Size(115, 32);
			this.rb_não.TabIndex = 4;
			this.rb_não.TabStop = true;
			this.rb_não.Text = "Não";
			this.rb_não.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(245, 270);
			this.Controls.Add(this.rb_não);
			this.Controls.Add(this.rb_sim);
			this.Controls.Add(this.btn_ConfirmarCompra);
			this.Controls.Add(this.lbl_RespostadeCompra);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Confirmação de compra";
			this.ResumeLayout(false);

		}
	}
}
