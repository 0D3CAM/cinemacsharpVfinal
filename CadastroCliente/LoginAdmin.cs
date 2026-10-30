using cadastro_cliente;
using CadastroCliente;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace clientecinema


{

    public partial class LoginAdmin : Form
    {
        DAO bd;

        public MySqlConnection conexao;
        public LoginAdmin()
        {
            InitializeComponent();
            bd = new DAO();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logar_Click(object sender, EventArgs e)
        {

           
            string usuario = login.Text; 
            string senhaTxt = senha.Text;   

            if (bd.VerificarLogin(usuario, senhaTxt))
            {
                MessageBox.Show("Login realizado com sucesso!");

                TelaCliente painel = new TelaCliente();
                painel.Show();
                this.Hide();        
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
                LimparTelaLogin();
            }
        }
        public void LimparTelaLogin()
        {
             senha.Text = "";
        }
        private void senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_TextChanged(object sender, EventArgs e)
        {
            
        
        }

        private void senha_id_Click(object sender, EventArgs e)
        {

        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            EscolhaPainel Painel = new EscolhaPainel();
            Painel.Show();
            this.Close();
        }
    }
}
