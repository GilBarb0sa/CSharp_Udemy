
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
			toolStrip1 = new ToolStrip();
			toolBarNovo = new ToolStripButton();
			toolBarAbrir = new ToolStripButton();
			toolBarSalvar = new ToolStripButton();
			toolStripSeparator6 = new ToolStripSeparator();
			toolBarFonte = new ToolStripButton();
			toolStripSeparator5 = new ToolStripSeparator();
			toolBarZoom = new ToolStripButton();
			toolBarZoomDiminuir = new ToolStripButton();
			toolBarZoomAumentar = new ToolStripButton();
			toolStripSeparator7 = new ToolStripSeparator();
			toolBarAjuda = new ToolStripButton();
			txtConteudo = new RichTextBox();
			menuBar.SuspendLayout();
			statusBar.SuspendLayout();
			toolStrip1.SuspendLayout();
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
			mArquivoNovo.Image = Properties.Resources.new_document;
			mArquivoNovo.Name = "mArquivoNovo";
			mArquivoNovo.ShortcutKeys = Keys.Control | Keys.N;
			mArquivoNovo.Size = new Size(272, 26);
			mArquivoNovo.Text = "Novo";
			mArquivoNovo.Click += mArquivoNovo_Click;
			// 
			// mArquivoNovaJanela
			// 
			mArquivoNovaJanela.Image = Properties.Resources.notes;
			mArquivoNovaJanela.Name = "mArquivoNovaJanela";
			mArquivoNovaJanela.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
			mArquivoNovaJanela.Size = new Size(272, 26);
			mArquivoNovaJanela.Text = "Nova Janela";
			mArquivoNovaJanela.Click += mArquivoNovaJanela_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(269, 6);
			// 
			// mArquivoAbrir
			// 
			mArquivoAbrir.Image = Properties.Resources.folder;
			mArquivoAbrir.Name = "mArquivoAbrir";
			mArquivoAbrir.ShortcutKeys = Keys.Control | Keys.O;
			mArquivoAbrir.Size = new Size(272, 26);
			mArquivoAbrir.Text = "Abrir";
			mArquivoAbrir.Click += mArquivoAbrir_Click;
			// 
			// mArquivoSalvar
			// 
			mArquivoSalvar.Image = Properties.Resources.save;
			mArquivoSalvar.Name = "mArquivoSalvar";
			mArquivoSalvar.ShortcutKeys = Keys.Control | Keys.S;
			mArquivoSalvar.Size = new Size(272, 26);
			mArquivoSalvar.Text = "Salvar";
			mArquivoSalvar.Click += mArquivoSalvar_Click;
			// 
			// mArquivoSalvarComo
			// 
			mArquivoSalvarComo.Name = "mArquivoSalvarComo";
			mArquivoSalvarComo.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
			mArquivoSalvarComo.Size = new Size(272, 26);
			mArquivoSalvarComo.Text = "Salvar Como";
			mArquivoSalvarComo.Click += mArquivoSalvarComo_Click;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(269, 6);
			// 
			// mArquivoSair
			// 
			mArquivoSair.Image = Properties.Resources.exit;
			mArquivoSair.Name = "mArquivoSair";
			mArquivoSair.ShortcutKeys = Keys.Alt | Keys.Q;
			mArquivoSair.Size = new Size(272, 26);
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
			mEditarDesfazer.ShortcutKeys = Keys.Control | Keys.Z;
			mEditarDesfazer.Size = new Size(236, 26);
			mEditarDesfazer.Text = "Desfazer";
			mEditarDesfazer.Click += mEditarDesfazer_Click;
			// 
			// mEditarRefazer
			// 
			mEditarRefazer.Name = "mEditarRefazer";
			mEditarRefazer.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Z;
			mEditarRefazer.Size = new Size(236, 26);
			mEditarRefazer.Text = "Refazer";
			mEditarRefazer.Click += mEditarRefazer_Click;
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new Size(233, 6);
			// 
			// mEditarRecortar
			// 
			mEditarRecortar.Name = "mEditarRecortar";
			mEditarRecortar.ShortcutKeys = Keys.Control | Keys.X;
			mEditarRecortar.Size = new Size(236, 26);
			mEditarRecortar.Text = "Recortar";
			mEditarRecortar.Click += mEditarRecortar_Click;
			// 
			// mEditarCopiar
			// 
			mEditarCopiar.Name = "mEditarCopiar";
			mEditarCopiar.ShortcutKeys = Keys.Control | Keys.C;
			mEditarCopiar.Size = new Size(236, 26);
			mEditarCopiar.Text = "Copiar";
			mEditarCopiar.Click += mEditarCopiar_Click;
			// 
			// mEditarColar
			// 
			mEditarColar.Name = "mEditarColar";
			mEditarColar.ShortcutKeys = Keys.Control | Keys.V;
			mEditarColar.Size = new Size(236, 26);
			mEditarColar.Text = "Colar";
			mEditarColar.Click += mEditarColar_Click;
			// 
			// mEditarExclui
			// 
			mEditarExclui.Name = "mEditarExclui";
			mEditarExclui.ShortcutKeyDisplayString = "Delete";
			mEditarExclui.Size = new Size(236, 26);
			mEditarExclui.Text = "Excluir";
			mEditarExclui.Click += mEditarExclui_Click;
			// 
			// toolStripSeparator4
			// 
			toolStripSeparator4.Name = "toolStripSeparator4";
			toolStripSeparator4.Size = new Size(233, 6);
			// 
			// mEditarDataHora
			// 
			mEditarDataHora.Name = "mEditarDataHora";
			mEditarDataHora.ShortcutKeys = Keys.F5;
			mEditarDataHora.Size = new Size(236, 26);
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
			mExibirZoomAmpliar.ShortcutKeyDisplayString = "Ctrl + Sinal de Adição";
			mExibirZoomAmpliar.ShortcutKeys = Keys.Control | Keys.Oemplus;
			mExibirZoomAmpliar.Size = new Size(325, 26);
			mExibirZoomAmpliar.Text = "Ampliar";
			mExibirZoomAmpliar.Click += mExibirZoomAmpliar_Click;
			// 
			// mExibirZoomReduzir
			// 
			mExibirZoomReduzir.Name = "mExibirZoomReduzir";
			mExibirZoomReduzir.ShortcutKeyDisplayString = "Ctrl + Sinal de Subtração";
			mExibirZoomReduzir.ShortcutKeys = Keys.Control | Keys.OemMinus;
			mExibirZoomReduzir.Size = new Size(325, 26);
			mExibirZoomReduzir.Text = "Reduzir";
			mExibirZoomReduzir.Click += mExibirZoomReduzir_Click;
			// 
			// mExibirZoomRestaurar
			// 
			mExibirZoomRestaurar.Name = "mExibirZoomRestaurar";
			mExibirZoomRestaurar.ShortcutKeys = Keys.Control | Keys.D0;
			mExibirZoomRestaurar.Size = new Size(325, 26);
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
			mAjudaExibirAjuda.Image = Properties.Resources.help;
			mAjudaExibirAjuda.Name = "mAjudaExibirAjuda";
			mAjudaExibirAjuda.ShortcutKeys = Keys.F1;
			mAjudaExibirAjuda.Size = new Size(218, 26);
			mAjudaExibirAjuda.Text = "Exibir Ajuda";
			mAjudaExibirAjuda.Click += mAjudaExibirAjuda_Click;
			// 
			// mAjudaSobreEditor
			// 
			mAjudaSobreEditor.Name = "mAjudaSobreEditor";
			mAjudaSobreEditor.Size = new Size(218, 26);
			mAjudaSobreEditor.Text = "Sobre o Editor TXT";
			mAjudaSobreEditor.Click += mAjudaSobreEditor_Click;
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
			// toolStrip1
			// 
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolBarNovo, toolBarAbrir, toolBarSalvar, toolStripSeparator6, toolBarFonte, toolStripSeparator5, toolBarZoom, toolBarZoomDiminuir, toolBarZoomAumentar, toolStripSeparator7, toolBarAjuda });
			toolStrip1.Location = new Point(0, 29);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(684, 28);
			toolStrip1.TabIndex = 3;
			toolStrip1.Text = "toolStrip1";
			// 
			// toolBarNovo
			// 
			toolBarNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolBarNovo.Image = Properties.Resources.new_document;
			toolBarNovo.ImageTransparentColor = Color.Magenta;
			toolBarNovo.Name = "toolBarNovo";
			toolBarNovo.Size = new Size(23, 25);
			toolBarNovo.Text = "Novo";
			toolBarNovo.Click += toolBarNovo_Click;
			// 
			// toolBarAbrir
			// 
			toolBarAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolBarAbrir.Image = Properties.Resources.folder;
			toolBarAbrir.ImageTransparentColor = Color.Magenta;
			toolBarAbrir.Name = "toolBarAbrir";
			toolBarAbrir.Size = new Size(23, 25);
			toolBarAbrir.Text = "Abrir";
			toolBarAbrir.Click += mArquivoAbrir_Click;
			// 
			// toolBarSalvar
			// 
			toolBarSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolBarSalvar.Image = Properties.Resources.save;
			toolBarSalvar.ImageTransparentColor = Color.Magenta;
			toolBarSalvar.Name = "toolBarSalvar";
			toolBarSalvar.Size = new Size(23, 25);
			toolBarSalvar.Text = "Salvar";
			toolBarSalvar.Click += mArquivoSalvar_Click;
			// 
			// toolStripSeparator6
			// 
			toolStripSeparator6.Name = "toolStripSeparator6";
			toolStripSeparator6.Size = new Size(6, 28);
			// 
			// toolBarFonte
			// 
			toolBarFonte.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolBarFonte.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			toolBarFonte.Image = (Image)resources.GetObject("toolBarFonte.Image");
			toolBarFonte.ImageTransparentColor = Color.Magenta;
			toolBarFonte.Name = "toolBarFonte";
			toolBarFonte.Size = new Size(23, 25);
			toolBarFonte.Text = "A";
			toolBarFonte.ToolTipText = "Formatar Fonte";
			toolBarFonte.Click += mFormatarFonte_Click;
			// 
			// toolStripSeparator5
			// 
			toolStripSeparator5.Name = "toolStripSeparator5";
			toolStripSeparator5.Size = new Size(6, 28);
			// 
			// toolBarZoom
			// 
			toolBarZoom.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolBarZoom.Image = Properties.Resources.loupe;
			toolBarZoom.ImageTransparentColor = Color.Magenta;
			toolBarZoom.Name = "toolBarZoom";
			toolBarZoom.Size = new Size(23, 25);
			toolBarZoom.Text = "Zoom 100%";
			toolBarZoom.Click += mExibirZoomRestaurar_Click;
			// 
			// toolBarZoomDiminuir
			// 
			toolBarZoomDiminuir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			toolBarZoomDiminuir.ForeColor = Color.Navy;
			toolBarZoomDiminuir.Image = Properties.Resources.loupe;
			toolBarZoomDiminuir.ImageTransparentColor = Color.Magenta;
			toolBarZoomDiminuir.Name = "toolBarZoomDiminuir";
			toolBarZoomDiminuir.Size = new Size(23, 25);
			toolBarZoomDiminuir.Text = "-";
			toolBarZoomDiminuir.TextImageRelation = TextImageRelation.Overlay;
			toolBarZoomDiminuir.ToolTipText = "Zoom Diminuir";
			toolBarZoomDiminuir.Click += mExibirZoomReduzir_Click;
			// 
			// toolBarZoomAumentar
			// 
			toolBarZoomAumentar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			toolBarZoomAumentar.ForeColor = Color.Navy;
			toolBarZoomAumentar.Image = Properties.Resources.loupe;
			toolBarZoomAumentar.ImageTransparentColor = Color.Magenta;
			toolBarZoomAumentar.Name = "toolBarZoomAumentar";
			toolBarZoomAumentar.Size = new Size(25, 25);
			toolBarZoomAumentar.Text = "+";
			toolBarZoomAumentar.TextImageRelation = TextImageRelation.Overlay;
			toolBarZoomAumentar.ToolTipText = "Zoom Aumentar";
			toolBarZoomAumentar.Click += mExibirZoomAmpliar_Click;
			// 
			// toolStripSeparator7
			// 
			toolStripSeparator7.Name = "toolStripSeparator7";
			toolStripSeparator7.Size = new Size(6, 28);
			// 
			// toolBarAjuda
			// 
			toolBarAjuda.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolBarAjuda.Image = Properties.Resources.help;
			toolBarAjuda.ImageTransparentColor = Color.Magenta;
			toolBarAjuda.Name = "toolBarAjuda";
			toolBarAjuda.Size = new Size(23, 25);
			toolBarAjuda.Text = "Ajuda";
			toolBarAjuda.Click += mAjudaExibirAjuda_Click;
			// 
			// txtConteudo
			// 
			txtConteudo.Dock = DockStyle.Fill;
			txtConteudo.Location = new Point(0, 57);
			txtConteudo.Name = "txtConteudo";
			txtConteudo.Size = new Size(684, 371);
			txtConteudo.TabIndex = 4;
			txtConteudo.Text = " ";
			txtConteudo.WordWrap = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(684, 450);
			Controls.Add(txtConteudo);
			Controls.Add(toolStrip1);
			Controls.Add(statusBar);
			Controls.Add(menuBar);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuBar;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Editor TXT";
			menuBar.ResumeLayout(false);
			menuBar.PerformLayout();
			statusBar.ResumeLayout(false);
			statusBar.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
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
		private ToolStrip toolStrip1;
		private ToolStripButton toolBarNovo;
		private RichTextBox txtConteudo;
		private ToolStripButton toolBarAbrir;
		private ToolStripButton toolBarSalvar;
		private ToolStripSeparator toolStripSeparator6;
		private ToolStripButton toolBarFonte;
		private ToolStripSeparator toolStripSeparator5;
		private ToolStripButton toolBarZoom;
		private ToolStripButton toolBarZoomDiminuir;
		private ToolStripButton toolBarZoomAumentar;
		private ToolStripSeparator toolStripSeparator7;
		private ToolStripButton toolBarAjuda;
	}
}
