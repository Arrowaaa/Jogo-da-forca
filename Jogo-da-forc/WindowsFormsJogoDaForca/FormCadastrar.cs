using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsJogoDaForca
{
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {

            string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {

                string scriptSQL = "SELECT id, palavra FROM tb_palavras";

                using (MySqlCommand comando = new MySqlCommand(scriptSQL, conexao))
                {

                    conexao.Open();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            int id = reader.GetInt32(0);
                            string palavra = reader.GetString(1);

                            ListViewItem lista = new ListViewItem(id.ToString() + " - " + palavra);
                            listViewCadastro.Items.Add(lista);


                        }
                    }

                    conexao.Close();

                }

            }

        }

        private void FormCadastrar_Load(object sender, EventArgs e)
        {

            listViewCadastro.View = View.Details;
            listViewCadastro.Columns.Add("palavras", 255);

            CarregarDados();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            string palavraEscolhida = txbCadastro.Text;

            if (palavraEscolhida.Trim() != "")
            {

                CadastrarDados(palavraEscolhida);

            }

            txbCadastro.Text = "";
            listViewCadastro.Items.Clear();
            CarregarDados() ;



        }

        private void CadastrarDados(string palavra)
        {

            string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {

                    string scriptSQL = "INSERT INTO tb_palavras (palavra) VALUEs (@valorPalavra)";

                    using (MySqlCommand comando = new MySqlCommand(scriptSQL, conexao))
                    {

                        conexao.Open();

                        comando.Parameters.AddWithValue("@valorPalavra", palavra.ToLower());

                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {

                            MessageBox.Show("Palavra cadastrar com suesso");

                        }

                    }

                    conexao.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar informação: " + ex.Message);
            }
        }

        private void RemoverDados(int id)
        {
            string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    string scriptSQL = "DELETE FROM tb_palavras WHERE id = @id";

                    using (MySqlCommand comando = new MySqlCommand(scriptSQL, conexao))
                    {
                        conexao.Open();

                        comando.Parameters.AddWithValue("@id", id);

                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Palavra removida com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível encontrar a palavra com o ID fornecido.");
                        }
                    }

                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover informação: " + ex.Message);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Verifica se foi digitado algum texto no TextBox
            if (!string.IsNullOrEmpty(txbRemover.Text))
            {
                // Obtém o ID digitado pelo usuário no TextBox
                if (int.TryParse(txbRemover.Text.Trim(), out int id))
                {
                    // Chama a função para remover a palavra do banco de dados
                    RemoverDados(id);

                    // Limpa o TextBox
                    txbRemover.Text = "";

                    // Atualiza a lista de palavras na interface
                    listViewCadastro.Items.Clear();
                    CarregarDados();
                }
                else
                {
                    MessageBox.Show("Digite um ID válido para remover.");
                }
            }
            else
            {
                MessageBox.Show("Digite o ID da palavra a ser removida.");
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listViewCadastro.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCadastro.SelectedItems[0];
                string[] parts = selectedItem.Text.Split('-');
                int id = int.Parse(parts[0].Trim());

                // criei uma string para obtém a nova palavra do TextBox
                string novaPalavra = txbEditar.Text.Trim();

                if (!string.IsNullOrEmpty(novaPalavra))
                {
                    // Atualiza os dados no banco de dados com a nova palavra
                    AtualizarDados(id, novaPalavra);

                    // Limpa o TextBox
                    txbEditar.Text = "";

                    // Atualiza a lista de palavras na interface
                    listViewCadastro.Items.Clear();
                    CarregarDados();
                }
                else
                {
                    MessageBox.Show("Digite a nova palavra.");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma palavra para editar.");
            }
        }
        private void AtualizarDados(int id, string novaPalavra)
        {
            string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    string scriptSQL = "UPDATE tb_palavras SET palavra = @novaPalavra WHERE id = @id";

                    using (MySqlCommand comando = new MySqlCommand(scriptSQL, conexao))
                    {
                        conexao.Open();

                        comando.Parameters.AddWithValue("@novaPalavra", novaPalavra.ToLower());
                        comando.Parameters.AddWithValue("@id", id);

                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Palavra atualizada com sucesso.");
                        }
                    }

                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar informação: " + ex.Message);
            }
        }

    }
}
