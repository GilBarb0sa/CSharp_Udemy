namespace EditorTXT
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		#region Menu Arquivo
		private void mArquivoNovo_Click(object sender, EventArgs e)
		{
			txtConteudo.Clear();
			mArquivoSalvar.Enabled = true;
			Text = Application.ProductName;
		}
		private void mArquivoNovaJanela_Click(object sender, EventArgs e)
		{
			//Form1 f = new Form1();
			//f.Show();

			Thread t = new Thread(() => Application.Run(new Form1())); //Mais eficiente executando a ação com thread
			t.SetApartmentState(ApartmentState.STA);
			t.Start();
		}

		private void mArquivoAbrir_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Title = "Abrir...";
			dialog.Filter = "Rich Text File (*.rtf)|*.rtf|Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";

			DialogResult result = dialog.ShowDialog();

			if (result != DialogResult.Cancel && result != DialogResult.Abort)
			{
				if (File.Exists(dialog.FileName))
				{
					FileInfo file = new FileInfo(dialog.FileName);
					Text = Application.ProductName + " - " + file.Name;

					Gerenciador.FolderPath = file.DirectoryName + "\\";
					Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
					Gerenciador.FileExt = file.Extension;

					StreamReader? stream = null;

					try
					{
						stream = new StreamReader(file.FullName, true);

						txtConteudo.Text = stream.ReadToEnd();

						mArquivoSalvar.Enabled = true;
					}
					catch (Exception ex)
					{
						MessageBox.Show("Formato de arquivo não suportado. \n" + ex.Message);
					}
					finally
					{
						if (stream != null)
						{
							stream.Close();
						}
					}
				}
			}
		}

		private void mArquivoSalvar_Click(object sender, EventArgs e)
		{
			if (File.Exists(Gerenciador.FilePath))
			{
				SalvarArquivo(Gerenciador.FilePath);
			}
			else
			{
				SaveFileDialog dialog = new SaveFileDialog();
				dialog.Title = "Salvar...";
				dialog.Filter = "Rich Text File (*.rtf)|*.rtf|Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
				dialog.CheckFileExists = false;
				dialog.CheckPathExists = true;

				var result = dialog.ShowDialog();

				if (result != DialogResult.Cancel && result != DialogResult.Abort)
				{
					SalvarArquivo(dialog.FileName);
				}
			}
		}

		private void mArquivoSalvarComo_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Title = "Salvar Como...";
			dialog.Filter = "Rich Text File (*.rtf)|*.rtf|Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
			dialog.CheckFileExists = false;
			dialog.CheckPathExists = true;

			var result = dialog.ShowDialog();

			if (result != DialogResult.Cancel && result != DialogResult.Abort)
			{
				SalvarArquivo(dialog.FileName);
			}
		}

		private void SalvarArquivo(string path)
		{
			// Objeto responsavel por escrever o arquivo
			StreamWriter? writer = null;

			try
			{
				writer = new StreamWriter(path, false);  //o false faz com o que sobrescreva o arquivo existente, true acrescenta
				writer.Write(txtConteudo.Text);

				FileInfo file = new FileInfo(path);
				Gerenciador.FolderPath = file.DirectoryName + "\\";
				Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
				Gerenciador.FileExt = file.Extension;

				Text = Application.ProductName + " - " + file.Name;

				mArquivoSalvar.Enabled = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro Salva Arquivo: \n" + ex.Message);
			}
			finally
			{
				// Verifique se o writer não é nulo antes de tentar fechá-lo
				if (writer != null)
				{
					writer.Close();
				}
			}
		}

		private void mArquivoSair_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void txtConteudo_TextChanged(object sender, EventArgs e)
		{
			mArquivoSalvar.Enabled = true;
		}
		#endregion

		#region Menu Editar
		
		private void mEditarDesfazer_Click(object sender, EventArgs e)
		{
			txtConteudo.Undo();
		}

		private void mEditarRefazer_Click(object sender, EventArgs e)
		{
			txtConteudo.Redo();
		}

		private void mEditarRecortar_Click(object sender, EventArgs e)
		{
			txtConteudo.Cut();
		}

		private void mEditarCopiar_Click(object sender, EventArgs e)
		{
			txtConteudo.Copy();
		}

		private void mEditarColar_Click(object sender, EventArgs e)
		{
			txtConteudo.Paste();
		}

		private void mEditarExclui_Click(object sender, EventArgs e)
		{
			txtConteudo.Text = txtConteudo.Text.Remove(txtConteudo.SelectionStart, txtConteudo.SelectedText.Length);
		}

		private void mEditarDataHora_Click(object sender, EventArgs e)
		{
			int index = txtConteudo.SelectionStart;
			string dataHora = DateTime.Now.ToString();

			if (txtConteudo.SelectionStart == txtConteudo.Text.Length)
			{
				txtConteudo.Text = txtConteudo.Text + dataHora;
				txtConteudo.SelectionStart = index + dataHora.Length;
				return;
			}

			string temp = "";
			for (int i = 0; i < txtConteudo.Text.Length; i++)
			{
				if (i == txtConteudo.SelectionStart)
				{
					temp += dataHora;
					temp += txtConteudo.Text[i];
				}
				else
				{
					temp += txtConteudo.Text[i];
				}
			}

			txtConteudo.Text = temp;
			txtConteudo.SelectionStart = index + dataHora.Length;

		}

		#endregion
	}
}
