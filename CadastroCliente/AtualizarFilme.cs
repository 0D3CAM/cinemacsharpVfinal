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

namespace clientecinema
{
    public partial class AtualizarFilme : Form
    {
        private DAO bd = new DAO();
        public string caminhoImagemNova = "";

        public AtualizarFilme()
        {
            InitializeComponent();
            CarregarCategorias();
            BotaoAtualizar.Click += new EventHandler(BotaoAtualizar_Click);
        }

        public void CarregarCategorias()
        {
            Categoria.Items.Clear();
            Categoria.Items.Add("Título");
            Categoria.Items.Add("Gênero");
            Categoria.Items.Add("Duração");
            Categoria.Items.Add("Descrição");
            Categoria.Items.Add("Horários");
            Categoria.Items.Add("Capa (Caminho da Imagem)");

            Categoria.SelectedIndex = 0;
        }

        public void Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Categoria.SelectedItem.ToString() == "Capa (Caminho da Imagem)")
            {
                UploadCapa.Visible = true;
            }
            else
            {
                UploadCapa.Visible = false;
            }
        }



        public void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, digite o Código do Filme!");
                textBox1.Focus();
                return;
            }

            int codigoFilme;
            if (!int.TryParse(textBox1.Text, out codigoFilme))
            {
                MessageBox.Show("O código do filme deve ser um número inteiro válido!");
                textBox1.Focus();
                return;
            }
        }

        public void BotaoAtualizar_Click(object sender, EventArgs e)
        {

            {
                int codigo = Convert.ToInt32(textBox1.Text);
                string novoValor = textBox2.Text;
                string campoBD = "";

                string opcaoSelecionada = Categoria.SelectedItem.ToString();

                if (opcaoSelecionada == "Título") campoBD = "titulo";
                else if (opcaoSelecionada == "Gênero") campoBD = "genero";
                else if (opcaoSelecionada == "Duração") campoBD = "duracao";
                else if (opcaoSelecionada == "Descrição") campoBD = "descricao";
                else if (opcaoSelecionada == "Horários") campoBD = "horarios";
                else if (opcaoSelecionada == "Capa (Caminho da Imagem)") campoBD = "caminhoimagem";

                bool resultado = bd.AtualizarCampoFilme(codigo, campoBD, novoValor);

                if (resultado)
                {
                    MessageBox.Show("Atualizado com sucesso!");
                    textBox2.Clear();
                }
            }
        }
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public void Voltar_Click(object sender, EventArgs e)
        {
            TelaCliente TC = new TelaCliente();
            TC.Show();
            this.Hide();
        }


        //arrumei botao upload que nao ia
        public void UploadCapa_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Arquivos de Imagem|*.jpg;*.png;";
            openFileDialog1.Title = "Selecione a nova capa do filme";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                caminhoImagemNova = openFileDialog1.FileName;

                textBox2.Text = caminhoImagemNova;

                if (Capa != null)
                {
                    Capa.ImageLocation = caminhoImagemNova;
                    Capa.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
    }
}
    

