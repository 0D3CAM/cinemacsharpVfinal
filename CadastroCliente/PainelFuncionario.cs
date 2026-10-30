using cadastro_cliente;
using clientecinema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    
    public partial class PainelFuncionario : Form
    {
        DAO bd;
        public PainelFuncionario()
        {
            InitializeComponent();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.Show();
            
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            Consultar consul = new Consultar();
            consul.Show();
            
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            Atualizar Att = new Atualizar();
            Att.Show();
            
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            Excluir Exclu = new Excluir();
            Exclu.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EscolhaPainel EP = new EscolhaPainel();
            EP.Show();
            this.Close();
        }
    }
}
