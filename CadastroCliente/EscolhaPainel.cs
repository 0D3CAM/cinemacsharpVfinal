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
    public partial class EscolhaPainel : Form
    {
        public EscolhaPainel()
        {
            InitializeComponent();
        }

        private void PainelAdmin_Click(object sender, EventArgs e)
        {
            LoginAdmin LogADM = new LoginAdmin();
            LogADM.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PainelFuncionario PF = new PainelFuncionario();
            PF.Show();
            this.Close();
        }
    }
}
