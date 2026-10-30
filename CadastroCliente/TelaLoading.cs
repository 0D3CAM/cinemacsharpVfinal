using CadastroCliente;
using clientecinema;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Windows.Forms;

namespace cadastro_cliente
{

    public partial class TelaLoading : Form
    {
        DAO bd = new DAO();
        bool conexaoTestada = false;

        public TelaLoading()
        {
            InitializeComponent();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 2;

                if (progressBar1.Value < 30)
                {
                    Status.Text = "Carregando componentes...";
                }
                else if (progressBar1.Value >= 30 && progressBar1.Value < 70)
                {
                    Status.Text = "Conectando ao banco de dados...";

                    if (!conexaoTestada)
                    {
                        conexaoTestada = true;

                        if (!bd.TestarConexao())
                        {
                            timer1.Stop();
                            Status.Text = "Erro na conexão!";
                            MessageBox.Show("Não foi possível conectar ao banco de dados!", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                            return;
                        }
                    }
                }
                else if (progressBar1.Value >= 70)
                {
                    Status.Text = "Finalizando configurações...";
                }
            }
            else
            {
                timer1.Stop();
                Status.Text = "Concluído!";


                EscolhaPainel Painel = new EscolhaPainel();
                Painel.Show();
                this.Hide();
            }
        }

        private void TelaLoading_Load(object sender, EventArgs e)
        {

        }
    }
}