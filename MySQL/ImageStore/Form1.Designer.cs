namespace ImageStore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picImagem = new PictureBox();
            txtNomeImagem = new TextBox();
            labelResultado = new Label();
            btnEscolherImagem = new Button();
            btnInserirImagem = new Button();
            btnRecuperarImagem = new Button();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            SuspendLayout();
            // 
            // picImagem
            // 
            picImagem.BorderStyle = BorderStyle.FixedSingle;
            picImagem.Location = new Point(12, 12);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(791, 453);
            picImagem.SizeMode = PictureBoxSizeMode.Zoom;
            picImagem.TabIndex = 0;
            picImagem.TabStop = false;
            // 
            // txtNomeImagem
            // 
            txtNomeImagem.Enabled = false;
            txtNomeImagem.Location = new Point(11, 477);
            txtNomeImagem.Name = "txtNomeImagem";
            txtNomeImagem.Size = new Size(792, 23);
            txtNomeImagem.TabIndex = 1;
            // 
            // labelResultado
            // 
            labelResultado.BorderStyle = BorderStyle.FixedSingle;
            labelResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(12, 525);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(1029, 106);
            labelResultado.TabIndex = 2;
            labelResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEscolherImagem
            // 
            btnEscolherImagem.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEscolherImagem.Location = new Point(819, 12);
            btnEscolherImagem.Name = "btnEscolherImagem";
            btnEscolherImagem.Size = new Size(222, 66);
            btnEscolherImagem.TabIndex = 3;
            btnEscolherImagem.Text = "Escolher Imagem";
            btnEscolherImagem.UseVisualStyleBackColor = true;
            btnEscolherImagem.Click += btnEscolherImagem_Click;
            // 
            // btnInserirImagem
            // 
            btnInserirImagem.Enabled = false;
            btnInserirImagem.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserirImagem.Location = new Point(819, 99);
            btnInserirImagem.Name = "btnInserirImagem";
            btnInserirImagem.Size = new Size(222, 66);
            btnInserirImagem.TabIndex = 4;
            btnInserirImagem.Text = "Inserir Imagem";
            btnInserirImagem.UseVisualStyleBackColor = true;
            btnInserirImagem.Click += btnInserirImagem_Click;
            // 
            // btnRecuperarImagem
            // 
            btnRecuperarImagem.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecuperarImagem.Location = new Point(819, 456);
            btnRecuperarImagem.Name = "btnRecuperarImagem";
            btnRecuperarImagem.Size = new Size(222, 66);
            btnRecuperarImagem.TabIndex = 5;
            btnRecuperarImagem.Text = "Recuperar Imagem";
            btnRecuperarImagem.UseVisualStyleBackColor = true;
            btnRecuperarImagem.Click += btnRecuperarImagem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 650);
            Controls.Add(btnRecuperarImagem);
            Controls.Add(btnInserirImagem);
            Controls.Add(btnEscolherImagem);
            Controls.Add(labelResultado);
            Controls.Add(txtNomeImagem);
            Controls.Add(picImagem);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inserir Imagem na Base de Dados";
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picImagem;
        private TextBox txtNomeImagem;
        private Label labelResultado;
        private Button btnEscolherImagem;
        private Button btnInserirImagem;
        private Button btnRecuperarImagem;
    }
}
