
namespace EditorTXT
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
			menuBar = new MenuStrip();
			mArquivo = new ToolStripMenuItem();
			mArquivoNovo = new ToolStripMenuItem();
			mArquivoNovaJanela = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			mArquivoAbrir = new ToolStripMenuItem();
			mArquivoSalvar = new ToolStripMenuItem();
			mArquivoSalvarComo = new ToolStripMenuItem();
			toolStripSeparator2 = new ToolStripSeparator();
			mArquivoSair = new ToolStripMenuItem();
			mEditar = new ToolStripMenuItem();
			mEditarDesfazer = new ToolStripMenuItem();
			mEditarRefazer = new ToolStripMenuItem();
			toolStripSeparator3 = new ToolStripSeparator();
			mEditarRecortar = new ToolStripMenuItem();
			mEditarCopiar = new ToolStripMenuItem();
			mEditarColar = new ToolStripMenuItem();
			mEditarExclui = new ToolStripMenuItem();
			toolStripSeparator4 = new ToolStripSeparator();
			mEditarDataHora = new ToolStripMenuItem();
			mFormatar = new ToolStripMenuItem();
			mFormatarQuebraLinha = new ToolStripMenuItem();
			mFormatarFonte = new ToolStripMenuItem();
			mExibir = new ToolStripMenuItem();
			mExibirZoom = new ToolStripMenuItem();
			mExibirZoomAmpliar = new ToolStripMenuItem();
			mExibirZoomReduzir = new ToolStripMenuItem();
			mExibirZoomRestaurar = new ToolStripMenuItem();
			mExibirBarraStatus = new ToolStripMenuItem();
			mAjuda = new ToolStripMenuItem();
			mAjudaExibirAjuda = new ToolStripMenuItem();
			mAjudaSobreEditor = new ToolStripMenuItem();
			statusBar = new StatusStrip();
			statusBarLabel = new ToolStripStatusLabel();
			txtConteudo = new RichTextBox();
			menuBar.SuspendLayout();
			statusBar.SuspendLayout();
			SuspendLayout();
			// 
			// menuBar
			// 
			menuBar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			menuBar.Items.AddRange(new ToolStripItem[] { mArquivo, mEditar, mFormatar, mExibir, mAjuda });
			menuBar.Location = new Point(0, 0);
			menuBar.Name = "menuBar";
			menuBar.Size = new Size(684, 29);
			menuBar.TabIndex = 0;
			menuBar.Text = "menuStrip1";
			// 
			// mArquivo
			// 
			mArquivo.DropDownItems.AddRange(new ToolStripItem[] { mArquivoNovo, mArquivoNovaJanela, toolStripSeparator1, mArquivoAbrir, mArquivoSalvar, mArquivoSalvarComo, toolStripSeparator2, mArquivoSair });
			mArquivo.Name = "mArquivo";
			mArquivo.Size = new Size(80, 25);
			mArquivo.Text = "Arquivo";
			// 
			// mArquivoNovo
			// 
			mArquivoNovo.Name = "mArquivoNovo";
			mArquivoNovo.Size = new Size(171, 26);
			mArquivoNovo.Text = "Novo";
			mArquivoNovo.Click += mArquivoNovo_Click;
			// 
			// mArquivoNovaJanela
			// 
			mArquivoNovaJanela.Name = "mArquivoNovaJanela";
			mArquivoNovaJanela.Size = new Size(171, 26);
			mArquivoNovaJanela.Text = "Nova Janela";
			mArquivoNovaJanela.Click += mArquivoNovaJanela_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(168, 6);
			// 
			// mArquivoAbrir
			// 
			mArquivoAbrir.Name = "mArquivoAbrir";
			mArquivoAbrir.Size = new Size(171, 26);
			mArquivoAbrir.Text = "Abrir";
			mArquivoAbrir.Click += mArquivoAbrir_Click;
			// 
			// mArquivoSalvar
			// 
			mArquivoSalvar.Name = "mArquivoSalvar";
			mArquivoSalvar.Size = new Size(171, 26);
			mArquivoSalvar.Text = "Salvar";
			mArquivoSalvar.Click += mArquivoSalvar_Click;
			// 
			// mArquivoSalvarComo
			// 
			mArquivoSalvarComo.Name = "mArquivoSalvarComo";
			mArquivoSalvarComo.Size = new Size(171, 26);
			mArquivoSalvarComo.Text = "Salvar Como";
			mArquivoSalvarComo.Click += mArquivoSalvarComo_Click;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(168, 6);
			// 
			// mArquivoSair
			// 
			mArquivoSair.Name = "mArquivoSair";
			mArquivoSair.Size = new Size(171, 26);
			mArquivoSair.Text = "Sair";
			mArquivoSair.Click += mArquivoSair_Click;
			// 
			// mEditar
			// 
			mEditar.DropDownItems.AddRange(new ToolStripItem[] { mEditarDesfazer, mEditarRefazer, toolStripSeparator3, mEditarRecortar, mEditarCopiar, mEditarColar, mEditarExclui, toolStripSeparator4, mEditarDataHora });
			mEditar.Name = "mEditar";
			mEditar.Size = new Size(64, 25);
			mEditar.Text = "Editar";
			// 
			// mEditarDesfazer
			// 
			mEditarDesfazer.Name = "mEditarDesfazer";
			mEditarDesfazer.Size = new Size(166, 26);
			mEditarDesfazer.Text = "Desfazer";
			mEditarDesfazer.Click += mEditarDesfazer_Click;
			// 
			// mEditarRefazer
			// 
			mEditarRefazer.Name = "mEditarRefazer";
			mEditarRefazer.Size = new Size(166, 26);
			mEditarRefazer.Text = "Refazer";
			mEditarRefazer.Click += mEditarRefazer_Click;
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new Size(163, 6);
			// 
			// mEditarRecortar
			// 
			mEditarRecortar.Name = "mEditarRecortar";
			mEditarRecortar.Size = new Size(166, 26);
			mEditarRecortar.Text = "Recortar";
			mEditarRecortar.Click += mEditarRecortar_Click;
			// 
			// mEditarCopiar
			// 
			mEditarCopiar.Name = "mEditarCopiar";
			mEditarCopiar.Size = new Size(166, 26);
			mEditarCopiar.Text = "Copiar";
			mEditarCopiar.Click += mEditarCopiar_Click;
			// 
			// mEditarColar
			// 
			mEditarColar.Name = "mEditarColar";
			mEditarColar.Size = new Size(166, 26);
			mEditarColar.Text = "Colar";
			mEditarColar.Click += mEditarColar_Click;
			// 
			// mEditarExclui
			// 
			mEditarExclui.Name = "mEditarExclui";
			mEditarExclui.Size = new Size(166, 26);
			mEditarExclui.Text = "Excluir";
			mEditarExclui.Click += mEditarExclui_Click;
			// 
			// toolStripSeparator4
			// 
			toolStripSeparator4.Name = "toolStripSeparator4";
			toolStripSeparator4.Size = new Size(163, 6);
			// 
			// mEditarDataHora
			// 
			mEditarDataHora.Name = "mEditarDataHora";
			mEditarDataHora.Size = new Size(166, 26);
			mEditarDataHora.Text = "Data e Hora";
			mEditarDataHora.Click += mEditarDataHora_Click;
			// 
			// mFormatar
			// 
			mFormatar.DropDownItems.AddRange(new ToolStripItem[] { mFormatarQuebraLinha, mFormatarFonte });
			mFormatar.Name = "mFormatar";
			mFormatar.Size = new Size(88, 25);
			mFormatar.Text = "Formatar";
			// 
			// mFormatarQuebraLinha
			// 
			mFormatarQuebraLinha.CheckOnClick = true;
			mFormatarQuebraLinha.Name = "mFormatarQuebraLinha";
			mFormatarQuebraLinha.Size = new Size(239, 26);
			mFormatarQuebraLinha.Text = "Quebra Auto de Linha";
			mFormatarQuebraLinha.Click += mFormatarQuebraLinha_Click;
			// 
			// mFormatarFonte
			// 
			mFormatarFonte.Name = "mFormatarFonte";
			mFormatarFonte.Size = new Size(239, 26);
			mFormatarFonte.Text = "Fonte";
			mFormatarFonte.Click += mFormatarFonte_Click;
			// 
			// mExibir
			// 
			mExibir.DropDownItems.AddRange(new ToolStripItem[] { mExibirZoom, mExibirBarraStatus });
			mExibir.Name = "mExibir";
			mExibir.Size = new Size(62, 25);
			mExibir.Text = "Exibir";
			// 
			// mExibirZoom
			// 
			mExibirZoom.DropDownItems.AddRange(new ToolStripItem[] { mExibirZoomAmpliar, mExibirZoomReduzir, mExibirZoomRestaurar });
			mExibirZoom.Name = "mExibirZoom";
			mExibirZoom.Size = new Size(190, 26);
			mExibirZoom.Text = "Zoom";
			// 
			// mExibirZoomAmpliar
			// 
			mExibirZoomAmpliar.Name = "mExibirZoomAmpliar";
			mExibirZoomAmpliar.Size = new Size(149, 26);
			mExibirZoomAmpliar.Text = "Ampliar";
			mExibirZoomAmpliar.Click += mExibirZoomAmpliar_Click;
			// 
			// mExibirZoomReduzir
			// 
			mExibirZoomReduzir.Name = "mExibirZoomReduzir";
			mExibirZoomReduzir.Size = new Size(149, 26);
			mExibirZoomReduzir.Text = "Reduzir";
			mExibirZoomReduzir.Click += mExibirZoomReduzir_Click;
			// 
			// mExibirZoomRestaurar
			// 
			mExibirZoomRestaurar.Name = "mExibirZoomRestaurar";
			mExibirZoomRestaurar.Size = new Size(149, 26);
			mExibirZoomRestaurar.Text = "Restaurar";
			mExibirZoomRestaurar.Click += mExibirZoomRestaurar_Click;
			// 
			// mExibirBarraStatus
			// 
			mExibirBarraStatus.Checked = true;
			mExibirBarraStatus.CheckOnClick = true;
			mExibirBarraStatus.CheckState = CheckState.Checked;
			mExibirBarraStatus.Name = "mExibirBarraStatus";
			mExibirBarraStatus.Size = new Size(190, 26);
			mExibirBarraStatus.Text = "Barra de Status";
			mExibirBarraStatus.Click += mExibirBarraStatus_Click;
			// 
			// mAjuda
			// 
			mAjuda.DropDownItems.AddRange(new ToolStripItem[] { mAjudaExibirAjuda, mAjudaSobreEditor });
			mAjuda.Name = "mAjuda";
			mAjuda.Size = new Size(64, 25);
			mAjuda.Text = "Ajuda";
			// 
			// mAjudaExibirAjuda
			// 
			mAjudaExibirAjuda.Name = "mAjudaExibirAjuda";
			mAjudaExibirAjuda.Size = new Size(218, 26);
			mAjudaExibirAjuda.Text = "Exibir Ajuda";
			// 
			// mAjudaSobreEditor
			// 
			mAjudaSobreEditor.Name = "mAjudaSobreEditor";
			mAjudaSobreEditor.Size = new Size(218, 26);
			mAjudaSobreEditor.Text = "Sobre o Editor TXT";
			// 
			// statusBar
			// 
			statusBar.Items.AddRange(new ToolStripItem[] { statusBarLabel });
			statusBar.Location = new Point(0, 428);
			statusBar.Name = "statusBar";
			statusBar.Size = new Size(684, 22);
			statusBar.TabIndex = 1;
			statusBar.Text = "statusStrip1";
			// 
			// statusBarLabel
			// 
			statusBarLabel.Name = "statusBarLabel";
			statusBarLabel.Size = new Size(38, 17);
			statusBarLabel.Text = "100 %";
			// 
			// txtConteudo
			// 
			txtConteudo.Dock = DockStyle.Fill;
			txtConteudo.Location = new Point(0, 29);
			txtConteudo.Name = "txtConteudo";
			txtConteudo.Size = new Size(684, 399);
			txtConteudo.TabIndex = 2;
			txtConteudo.Text = "";
			txtConteudo.WordWrap = false;
			txtConteudo.TextChanged += txtConteudo_TextChanged;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(684, 450);
			Controls.Add(txtConteudo);
			Controls.Add(statusBar);
			Controls.Add(menuBar);
			MainMenuStrip = menuBar;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Editor TXT";
			menuBar.ResumeLayout(false);
			menuBar.PerformLayout();
			statusBar.ResumeLayout(false);
			statusBar.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		private void mFormatarQuebraAutoLinha_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private MenuStrip menuBar;
		private ToolStripMenuItem mArquivo;
		private ToolStripMenuItem mArquivoNovo;
		private ToolStripMenuItem mArquivoNovaJanela;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem mArquivoAbrir;
		private ToolStripMenuItem mArquivoSalvar;
		private ToolStripMenuItem mArquivoSalvarComo;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem mArquivoSair;
		private ToolStripMenuItem mEditar;
		private ToolStripMenuItem mFormatar;
		private ToolStripMenuItem mExibir;
		private ToolStripMenuItem mAjuda;
		private ToolStripMenuItem mEditarDesfazer;
		private ToolStripMenuItem mEditarRefazer;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripMenuItem mEditarRecortar;
		private ToolStripMenuItem mEditarCopiar;
		private ToolStripMenuItem mEditarColar;
		private ToolStripMenuItem mEditarExclui;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripMenuItem mEditarDataHora;
		private ToolStripMenuItem mFormatarQuebraLinha;
		private ToolStripMenuItem mFormatarFonte;
		private ToolStripMenuItem mExibirZoom;
		private ToolStripMenuItem mExibirZoomAmpliar;
		private ToolStripMenuItem mExibirZoomReduzir;
		private ToolStripMenuItem mExibirZoomRestaurar;
		private ToolStripMenuItem mExibirBarraStatus;
		private ToolStripMenuItem mAjudaExibirAjuda;
		private ToolStripMenuItem mAjudaSobreEditor;
		private StatusStrip statusBar;
		private ToolStripStatusLabel statusBarLabel;
		private RichTextBox txtConteudo;
	}
}
