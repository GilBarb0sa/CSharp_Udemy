﻿namespace ChatCliente
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
			this.txtServidorIP = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.btnConectar = new System.Windows.Forms.Button();
			this.numPortaHost = new System.Windows.Forms.NumericUpDown();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.txtMensagem = new System.Windows.Forms.TextBox();
			this.btnEnviar = new System.Windows.Forms.Button();
			this.labelStatus = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numPortaHost)).BeginInit();
			this.SuspendLayout();
			// 
			// txtServidorIP
			// 
			this.txtServidorIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtServidorIP.Location = new System.Drawing.Point(13, 13);
			this.txtServidorIP.Name = "txtServidorIP";
			this.txtServidorIP.Size = new System.Drawing.Size(457, 38);
			this.txtServidorIP.TabIndex = 0;
			this.txtServidorIP.Text = "127.0.0.1";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(12, 57);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(457, 38);
			this.txtUsuario.TabIndex = 1;
			// 
			// btnConectar
			// 
			this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConectar.ForeColor = System.Drawing.Color.Red;
			this.btnConectar.Location = new System.Drawing.Point(490, 57);
			this.btnConectar.Name = "btnConectar";
			this.btnConectar.Size = new System.Drawing.Size(180, 38);
			this.btnConectar.TabIndex = 2;
			this.btnConectar.Text = "Conectar";
			this.btnConectar.UseVisualStyleBackColor = true;
			this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
			// 
			// numPortaHost
			// 
			this.numPortaHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numPortaHost.Location = new System.Drawing.Point(490, 13);
			this.numPortaHost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numPortaHost.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numPortaHost.Name = "numPortaHost";
			this.numPortaHost.Size = new System.Drawing.Size(180, 38);
			this.numPortaHost.TabIndex = 3;
			this.numPortaHost.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// txtLog
			// 
			this.txtLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLog.Location = new System.Drawing.Point(13, 114);
			this.txtLog.Margin = new System.Windows.Forms.Padding(4);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ReadOnly = true;
			this.txtLog.Size = new System.Drawing.Size(657, 302);
			this.txtLog.TabIndex = 4;
			// 
			// txtMensagem
			// 
			this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMensagem.Location = new System.Drawing.Point(13, 438);
			this.txtMensagem.Name = "txtMensagem";
			this.txtMensagem.Size = new System.Drawing.Size(457, 38);
			this.txtMensagem.TabIndex = 5;
			this.txtMensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMensagem_KeyPress);
			// 
			// btnEnviar
			// 
			this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEnviar.ForeColor = System.Drawing.Color.Blue;
			this.btnEnviar.Location = new System.Drawing.Point(490, 438);
			this.btnEnviar.Name = "btnEnviar";
			this.btnEnviar.Size = new System.Drawing.Size(180, 38);
			this.btnEnviar.TabIndex = 6;
			this.btnEnviar.Text = "Conectar";
			this.btnEnviar.UseVisualStyleBackColor = true;
			this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
			// 
			// labelStatus
			// 
			this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelStatus.Location = new System.Drawing.Point(13, 479);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(657, 52);
			this.labelStatus.TabIndex = 7;
			this.labelStatus.Text = "não conectado";
			this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(682, 540);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.btnEnviar);
			this.Controls.Add(this.txtMensagem);
			this.Controls.Add(this.txtLog);
			this.Controls.Add(this.numPortaHost);
			this.Controls.Add(this.btnConectar);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.txtServidorIP);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.numPortaHost)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtServidorIP;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Button btnConectar;
		private System.Windows.Forms.NumericUpDown numPortaHost;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.TextBox txtMensagem;
		private System.Windows.Forms.Button btnEnviar;
		private System.Windows.Forms.Label labelStatus;
	}
}

