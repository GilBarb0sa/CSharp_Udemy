namespace ImageStore
{
    partial class Form2
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
            picImagem = new PictureBox();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnFechar = new Button();
            listaImagens = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            labelResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listaImagens).BeginInit();
            SuspendLayout();
            // 
            // picImagem
            // 
            picImagem.BorderStyle = BorderStyle.FixedSingle;
            picImagem.Location = new Point(5, 12);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(791, 440);
            picImagem.SizeMode = PictureBoxSizeMode.Zoom;
            picImagem.TabIndex = 1;
            picImagem.TabStop = false;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(574, 458);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(222, 66);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(574, 547);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(222, 66);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(574, 641);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(222, 66);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // listaImagens
            // 
            listaImagens.AllowUserToAddRows = false;
            listaImagens.AllowUserToDeleteRows = false;
            listaImagens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaImagens.BackgroundColor = SystemColors.Control;
            listaImagens.BorderStyle = BorderStyle.None;
            listaImagens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaImagens.ColumnHeadersVisible = false;
            listaImagens.Columns.AddRange(new DataGridViewColumn[] { id, nome });
            listaImagens.Location = new Point(5, 458);
            listaImagens.MultiSelect = false;
            listaImagens.Name = "listaImagens";
            listaImagens.ReadOnly = true;
            listaImagens.RowHeadersVisible = false;
            listaImagens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listaImagens.Size = new Size(563, 249);
            listaImagens.TabIndex = 7;
            listaImagens.SelectionChanged += listaImagens_SelectionChanged;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // nome
            // 
            nome.HeaderText = "NOME";
            nome.Name = "nome";
            nome.ReadOnly = true;
            // 
            // labelResultado
            // 
            labelResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(12, 27);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(776, 413);
            labelResultado.TabIndex = 8;
            labelResultado.TextAlign = ContentAlignment.MiddleCenter;
            labelResultado.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 719);
            Controls.Add(labelResultado);
            Controls.Add(listaImagens);
            Controls.Add(btnFechar);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(picImagem);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Imagens na base de dados";
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)listaImagens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picImagem;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnFechar;
        private DataGridView listaImagens;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private Label labelResultado;
    }
}