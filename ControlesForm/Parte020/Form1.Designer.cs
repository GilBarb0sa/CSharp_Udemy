﻿namespace Parte020
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.browser = new System.Windows.Forms.WebBrowser();
			this.btnGo = new System.Windows.Forms.Button();
			this.txtURL = new System.Windows.Forms.TextBox();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnAvancar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// browser
			// 
			this.browser.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.browser.Location = new System.Drawing.Point(0, 65);
			this.browser.MinimumSize = new System.Drawing.Size(20, 20);
			this.browser.Name = "browser";
			this.browser.Size = new System.Drawing.Size(756, 398);
			this.browser.TabIndex = 0;
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(694, 14);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(50, 30);
			this.btnGo.TabIndex = 1;
			this.btnGo.Text = "Go";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// txtURL
			// 
			this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtURL.Location = new System.Drawing.Point(117, 13);
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(571, 31);
			this.txtURL.TabIndex = 2;
			// 
			// btnVoltar
			// 
			this.btnVoltar.Location = new System.Drawing.Point(5, 14);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(50, 30);
			this.btnVoltar.TabIndex = 3;
			this.btnVoltar.Text = "<";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// btnAvancar
			// 
			this.btnAvancar.Location = new System.Drawing.Point(61, 14);
			this.btnAvancar.Name = "btnAvancar";
			this.btnAvancar.Size = new System.Drawing.Size(50, 30);
			this.btnAvancar.TabIndex = 4;
			this.btnAvancar.Text = ">";
			this.btnAvancar.UseVisualStyleBackColor = true;
			this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(756, 463);
			this.Controls.Add(this.btnAvancar);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.txtURL);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.browser);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.WebBrowser browser;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Button btnAvancar;
	}
}

