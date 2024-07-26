﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;


namespace CriptoFile
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			Criptografia.cspp = new CspParameters();
			Criptografia.EncrFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Encrypt\";
			Criptografia.DecrFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Decrypt\";
			Criptografia.SrcFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

		}

		private void btnEncryptFIle_Click(object sender, EventArgs e)
		{
			 if(Criptografia.rsa == null)
			{
				label1.ForeColor = Color.Red;
				label1.Text = "Chave não definida.";
			}
			 else
			{
				//Mostra uma caixa de dialogo para escolher um arquivo para criptografar.
				OpenFileDialog dialog = new OpenFileDialog();
				dialog.InitialDirectory = Criptografia.SrcFolder;
				if (dialog.ShowDialog() == DialogResult.OK) 
				{
					string fName = dialog.FileName;
					FileInfo fInfo = new FileInfo(fName);
					//Passa o nome do arquivo com o caminho.
					string name = fInfo.FullName;
					label1.Text = Criptografia.EncryptFile(name);
				}
			}
		}

		private void btnDecryptFile_Click(object sender, EventArgs e)
		{
			if (Criptografia.rsa == null)
			{
				label1.ForeColor = Color.Red;
				label1.Text = "Chave não definida.";
			}
			else
			{
				//Mostra uma caixa de dialogo para escolher um arquivo para criptografar.
				OpenFileDialog dialog = new OpenFileDialog();
				dialog.InitialDirectory = Criptografia.EncrFolder;
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					string fName = dialog.FileName;
					FileInfo fInfo = new FileInfo(fName);
					//Passa o nome do arquivo com o caminho.
					string name = fInfo.Name;
					label1.Text = Criptografia.DecryptFile(name);
				}
			}
		}

		private void btnCreateAsmKeys_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(txtKey.Text))
			{
				label1.ForeColor= Color.Red;
				label1.Text = "Insira um valor para definir a chave pública.";
				txtKey.Focus();
				return;
			}

			Criptografia.keyName = txtKey.Text;
			label1.ForeColor = Color.DarkBlue;
			label1.Text = Criptografia.CreateAsmKeys();  //Cria a chave
		}

		private void btnExportPublicKeys_Click(object sender, EventArgs e)
		{
			 if(Criptografia.ExportPublicKey())
			{
				label1.ForeColor = Color.DarkBlue;
				label1.Text = "Chave publica exportada.";
			}
			 else
			{
				label1.ForeColor = Color.Red;
				label1.Text = "Chave publica não exportada.";
			}
		}

		private void btnImportPublicKey_Click(object sender, EventArgs e)
		{
			Criptografia.keyName = "Publica";
			label1.ForeColor = Color.DarkBlue;
			label1.Text = Criptografia.ImportPublicKey();
		}

		private void btnGetPrivateKey_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(txtKey.Text))
			{
				label1.ForeColor = Color.Red;
				label1.Text = "Insira um valor para definir a chave privada.";
				txtKey.Focus();
				return;
			}

			Criptografia.keyName = txtKey.Text;
			label1.ForeColor = Color.DarkBlue;
			label1.Text = Criptografia.GetPivateKey();
		}
	}
}