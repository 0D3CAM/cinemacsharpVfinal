using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientecinema
{
    public partial class cadastrarFilme : Form
    {
        public cadastrarFilme()
        {
            InitializeComponent();
        }

        private void BotaoProximo_Click(object sender, EventArgs e)
        {
            string titulo = TituloFilme.Text;
            string genero = GeneroFilme.Text;
            string duracao = maskedTextBox1.Text;
            string descricao = textBox4.Text;
            
            

            cadastrarFilme2 cadF2 = new cadastrarFilme2(titulo,genero,duracao, descricao);
            cadF2.Show();
            this.Hide();

        }

        private void TituloFilme_TextChanged(object sender, EventArgs e)
        {

        }

        private void GeneroFilme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            TelaCliente TC = new TelaCliente();
            TC.Show();
            this.Hide();

        }
    }
}
