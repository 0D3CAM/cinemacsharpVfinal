using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;//Importar os elemento do MYSql
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clientecinema;

namespace cadastro_cliente
{

    internal class DAO // DATA ACCESS OBJECT
    {
        public MySqlConnection conexao;//Armazenar os parâmetros de configuração com o BD
        public int[] codigo;
        public long[] cpf;
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public long[] cartaoCodigo;
        public int i;
        public int contador;
        public string usuario;
        public string senha;
        public string descricao;
        public string titulo;
        public string genero;
        public string duracao;
        public string caminhoImagem = "";

        public DAO()
        {
            this.conexao = new MySqlConnection("server=localhost;Database=clienteCinema;Uid=root;password=");
            try
            {
                this.conexao.Open();//Abrir a conexao com o banco
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!!!!!!\n\n" + erro);
            }
        }//fim do construtor

        public bool TestarConexao()
        {
            try
            {
                if (this.conexao.State == System.Data.ConnectionState.Closed)
                {
                    this.conexao.Open();
                }
                this.conexao.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string Cadastrar(long CPF, string nome, string email, string telefone, string endereco)
        {


            #region cartão
            //cria codigo na tabela cartão para associar com chave estrangeira, recebe 0 e é associado antes do cadastro para evitar erro

            string inserirCartao = "insert into cartao(pontos) values (0)";
            MySqlCommand sqlCartao = new MySqlCommand(inserirCartao, this.conexao);
            sqlCartao.ExecuteNonQuery();
            long cartaoCodigo = sqlCartao.LastInsertedId;

            #endregion

            string inserir = $"insert into cliente(codigo,cpf,nome,email,telefone,endereco, cartaoCodigo) values" +
                             $"('','{CPF}', '{nome}','{email}','{telefone}','{endereco}','{cartaoCodigo}')";

            //Começar a executar no banco
            MySqlCommand sql = new MySqlCommand(inserir, this.conexao);
            string resultado = sql.ExecuteNonQuery() + "Cadastrado!";
            return resultado;
        }

        public void PreencherVetor()
        {
            string consultar;
            consultar = "select * from cliente";

            //Instanciar os vetores

            this.codigo = new int[1000];
            this.cpf = new long[1000];
            this.nome = new string[1000];
            this.telefone = new string[1000];
            this.endereco = new string[1000];
            this.cartaoCodigo = new long[1000];


            //Comandos de relação com o banco
            MySqlCommand sql = new MySqlCommand(consultar, this.conexao);

            //Leitura com o banco

            MySqlDataReader leitura = sql.ExecuteReader();

            this.i = 0; //Organizar preenchimento por posição
            this.contador = 0; //Contar quantidade de dados efetivamente no vetor

            //While
            while (leitura.Read())
            {
                this.codigo[i] = Convert.ToInt32(leitura["codigo"]);
                this.cpf[i] = Convert.ToInt64(leitura["cpf"]);
                this.nome[i] = leitura["nome"] + "";
                this.telefone[i] = leitura["telefone"] + "";
                this.endereco[i] = leitura["endereco"] + "";
                this.cartaoCodigo[i] = Convert.ToInt64(leitura["cartaoCodigo"]);

                this.i++;//percorre o vetor
                this.contador++;//conta quantos dados estão no vetor

            }//fim do while

            //Encerrar o comando DAO
            leitura.Close();

        }//fim preencher vetor


        //Método que mostra a quantidade de dados 

        public int QuantidadeDeDados()
        {
            return this.contador;
        }
        //CADASTRO DO FILME
        public bool CadastrarFilme(string titulo, string genero, string duracao, string descricao, string caminhoImagem, string horarios)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand("cadastrarfilme", this.conexao);
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("tituloP", titulo);
                sql.Parameters.AddWithValue("generoP", genero);
                sql.Parameters.AddWithValue("duracaoP", duracao);
                sql.Parameters.AddWithValue("descricaoP", descricao);
                sql.Parameters.AddWithValue("caminhoImagemP", caminhoImagem);
                sql.Parameters.AddWithValue("horariosP", horarios);

                sql.ExecuteNonQuery();
                return true;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar no banco de dados:\n\n" + erro.Message);
                return false;
            }
        }

        public string Atualizar(long CPF, string nomeCampo, string novoDado)
        {
            string query = $"update cliente set {nomeCampo} = '{novoDado}' where cpf = '{CPF}'";
            MySqlCommand sql = new MySqlCommand(query, this.conexao);
            string resultado = sql.ExecuteNonQuery() + "Atualizado!";
            return resultado;
        }
        public string Excluir(long CPF)
        {
            string query = $"delete from cliente where cpf = '{CPF}'";
            MySqlCommand sql = new MySqlCommand(query, this.conexao);
            string resultado = sql.ExecuteNonQuery() + "Excluído!";
            return resultado;
        }

        public string ExcluirFilme(int codigo)
        {
            string query = $"delete from filme where codigo = {codigo}";
            MySqlCommand sql = new MySqlCommand(query, this.conexao);
            int linhas = sql.ExecuteNonQuery();
            if (linhas > 0)
            {
                return "Filme excluído com sucesso!";
            }
            else
            {
                return "Nenhum filme encontrado com este código.";
            }
        }

        public bool VerificarLogin(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
            try
            {
                MySqlCommand sql = new MySqlCommand("realizarLogin", this.conexao);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("usuarioP", usuario);
                sql.Parameters.AddWithValue("senhaP", senha);

                MySqlDataReader leitura = sql.ExecuteReader();

                if (leitura.Read())
                {
                    leitura.Close();
                    return true;
                }

                leitura.Close();
                return false;
            }

            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!!!!!!\n\n" + erro);
                return false;

            }
        }


        public DataTable ConsultarFilme(string termoBusca) // consulta de filmes
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand sql = new MySqlCommand("consultarFilme", this.conexao);
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("?termoBuscaP", termoBusca);

                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                da.Fill(dt);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao buscar filme no banco de dados:\n\n" + erro.Message);
            }
            return dt;
        }

        public bool AtualizarCampoFilme(int codigo, string nomeCampo, object novoDado)
        {
            try
            {
                if (this.conexao.State == ConnectionState.Closed)
                {
                    this.conexao.Open();
                }

                string query = $"UPDATE filme SET {nomeCampo} = @novoDado WHERE codigo = @codigo";

                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                sql.Parameters.AddWithValue("@novoDado", novoDado);
                sql.Parameters.AddWithValue("@codigo", codigo);

                int linhasAfetadas = sql.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Nenhum filme encontrado com o código informado.");
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar campo no banco de dados:\n\n" + erro.Message);
                return false;
            }
            finally
            {
                if (this.conexao.State == ConnectionState.Open)
                {
                    this.conexao.Close();
                }
            }
        }
    }
}   //FIM da classe
    //fim do projeto