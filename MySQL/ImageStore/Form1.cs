using MySql.Data.MySqlClient;

namespace ImageStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscolherImagem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Escolha a imagem (*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    picImagem.Image = Image.FromFile(dialog.FileName);
                    txtNomeImagem.Text = dialog.SafeFileName;
                    btnInserirImagem.Enabled = true;
                    txtNomeImagem.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                labelResultado.Text = $"Erro ao tentar carregar a imagem escolhida. \n{ex.Message}";
                labelResultado.ForeColor = Color.Red;
            }
        }

        private void btnInserirImagem_Click(object sender, EventArgs e)
        {
            string strConn = "server=localhost; User id=root; password=; database=imagens_db";  //String da base de dados
            MySqlConnection conn = new MySqlConnection(strConn);   // Este obj faz a conexão com a base de dados
            MySqlCommand command;  //Cria o comando sql que sera executado
            MemoryStream stream = new MemoryStream(); // Cria o espaço em memoria que vai guardar o arquivo que foi selecionado na base de dados

            try
            {
                picImagem.Image.Save(stream, picImagem.Image.RawFormat);
                byte[] data = stream.ToArray();

                string sql = "INSERT INTO tabela_imagens (nome, imagem) Values (@nome, @imagem)";

                conn.Open();

                command = new MySqlCommand(sql, conn);
                command.Parameters.Add("@nome", MySqlDbType.String);
                command.Parameters.Add("@imagem", MySqlDbType.Blob);
                command.Parameters["@nome"].Value = txtNomeImagem.Text;
                command.Parameters["@imagem"].Value = data;

                if (command.ExecuteNonQuery() == 1)
                {
                    labelResultado.Text = "Imagem inserida com sucesso!";
                    labelResultado.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                labelResultado.Text = $"Erro ao conectar. \n{ex.Message}";
                labelResultado.ForeColor = Color.Red;
            }
            finally
            {
                conn.Close();
                stream.Dispose();
            }

            picImagem.Image = null;
            txtNomeImagem.Text = null;
            btnInserirImagem.Enabled = false;
            txtNomeImagem.Enabled = false;
        }

        private void btnRecuperarImagem_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new Form2()));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
