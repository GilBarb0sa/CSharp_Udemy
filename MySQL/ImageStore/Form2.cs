using MySql.Data.MySqlClient;
using System.Data;

namespace ImageStore
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            string strConn = "server=localhost; User id=root; password=; database=imagens_db";  //String da base de dados
            MySqlConnection conn = new MySqlConnection(strConn);   // Este obj faz a conexão com a base de dados
            string sql = "SELECT * FROM tabela_imagens";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            try
            {
                DataTable dt = new DataTable();
                conn.Open();

                if (adapter.Fill(dt) < 1)
                {
                    labelResultado.Text = "A base de dados ainda não contém registros";
                    labelResultado.Visible = true;
                }
                else
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        listaImagens.Rows.Add(dr.ItemArray);
                    }

                    btnExcluir.Enabled = true;
                    btnSalvar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                labelResultado.Text = $"Erro ao recuperar os registros. \n {ex.Message}";
                labelResultado.Visible = true;
            }
            finally
            {
                conn.Close();
                adapter.Dispose();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new Form1()));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void listaImagens_SelectionChanged(object sender, EventArgs e)
        {
            labelResultado.Text = "";
            labelResultado.Visible = false;

            string strConn = "server=localhost; User id=root; password=; database=imagens_db";  //String da base de dados
            MySqlConnection conn = new MySqlConnection(strConn);   // Este obj faz a conexão com a base de dados

            try
            {
                string id = listaImagens.SelectedRows[0].Cells[0].Value.ToString()!;
                string sql = $"SELECT * FROM tabela_imagens WHERE id LIKE {id}";
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dt);
                byte[] image = (byte[])dt.Rows[0][2];
                MemoryStream ms = new MemoryStream(image);
                picImagem.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                labelResultado.Text = $"Erro ao recuperar a imagem do registro. \n {ex.Message}";
                labelResultado.Visible = true;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string strConn = "server=localhost; User id=root; password=; database=imagens_db";  //String da base de dados
            MySqlConnection conn = new MySqlConnection(strConn);   // Este obj faz a conexão com a base de dados
            string id = listaImagens.SelectedRows[0].Cells[0].Value.ToString()!;
            string sql = $"DELETE FROM tabela_imagens WHERE id = '{id}'";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    if (listaImagens.Rows.Count > 1)
                    {
                        picImagem.Image = null;
                        listaImagens.Rows.Remove(listaImagens.SelectedRows[0]);
                    }
                    else
                    {
                        btnFechar_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                labelResultado.Text = $"Erro ao recuperar ao excluir imagem do registro. \n {ex.Message}";
                labelResultado.Visible = true;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "";
            labelResultado.Visible = false;

            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Imagem JPG|*.jpg|Imagem PNG|*.png|Imagem GIF|*.gif";
                dialog.FileName = listaImagens.SelectedRows[0].Cells[1].Value.ToString()!;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    picImagem.Image.Save(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                labelResultado.Text = $"Erro ao recuperar ao salvar a imagem em arquivo. \n {ex.Message}";
                labelResultado.Visible = true;
            }
        }
    }
}
