﻿namespace ProjectAsync
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
			this.listaResultado = new System.Windows.Forms.ListBox();
			this.btnExecutar = new System.Windows.Forms.Button();
			this.btnExecutarAsync = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listaResultado
			// 
			this.listaResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listaResultado.FormattingEnabled = true;
			this.listaResultado.ItemHeight = 25;
			this.listaResultado.Location = new System.Drawing.Point(13, 13);
			this.listaResultado.Name = "listaResultado";
			this.listaResultado.Size = new System.Drawing.Size(445, 404);
			this.listaResultado.TabIndex = 0;
			// 
			// btnExecutar
			// 
			this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExecutar.Location = new System.Drawing.Point(483, 13);
			this.btnExecutar.Name = "btnExecutar";
			this.btnExecutar.Size = new System.Drawing.Size(207, 51);
			this.btnExecutar.TabIndex = 1;
			this.btnExecutar.Text = "Executar";
			this.btnExecutar.UseVisualStyleBackColor = true;
			this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
			// 
			// btnExecutarAsync
			// 
			this.btnExecutarAsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExecutarAsync.Location = new System.Drawing.Point(483, 85);
			this.btnExecutarAsync.Name = "btnExecutarAsync";
			this.btnExecutarAsync.Size = new System.Drawing.Size(207, 51);
			this.btnExecutarAsync.TabIndex = 2;
			this.btnExecutarAsync.Text = "Executar Async";
			this.btnExecutarAsync.UseVisualStyleBackColor = true;
			this.btnExecutarAsync.Click += new System.EventHandler(this.btnExecutarAsync_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(483, 152);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(207, 51);
			this.btnLimpar.TabIndex = 3;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(702, 450);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnExecutarAsync);
			this.Controls.Add(this.btnExecutar);
			this.Controls.Add(this.listaResultado);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listaResultado;
		private System.Windows.Forms.Button btnExecutar;
		private System.Windows.Forms.Button btnExecutarAsync;
		private System.Windows.Forms.Button btnLimpar;
	}
}

