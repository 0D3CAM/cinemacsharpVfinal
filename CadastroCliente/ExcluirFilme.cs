using cadastro_cliente;
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
    public partial class ExcluirFilme : Form
    {
        DAO bd = new DAO();
        public ExcluirFilme()
        {
            InitializeComponent();
            
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            {
                int codigo = Convert.ToInt32(codigoFilme.Text);

                string mensagem = bd.ExcluirFilme(codigo);
                MessageBox.Show(mensagem);

                codigoFilme.Clear();
            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaCliente TC = new TelaCliente(); 
            TC.ShowDialog();
            
        }
    }
}
