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
    public partial class cadastrarFilme2 : Form
    {
        DAO bd;
        string titulo;
        string genero;
        string duracao;     
        string caminhoImagem = "";
        string descricao;
        public cadastrarFilme2(string titulo, string genero, string duracao, string descricao)
        {
            InitializeComponent();
            bd = new DAO();
            this.titulo = titulo;
            this.genero = genero;
            this.duracao = duracao;
            this.descricao = descricao;
            
            
            
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            cadastrarFilme cadF = new cadastrarFilme();
            cadF.Show();          
            this.Hide();
        }


        //Confirma botão salvar tudo no bd
        private void BotaoProximo_Click(object sender, EventArgs e)  //CONFIRMAR!!!!!!!
        {
            

                string horarios = string.Join(", ", HorariosSelecionados.Items.Cast<string>());

                if (string.IsNullOrEmpty(caminhoImagem))
                {
                    MessageBox.Show("Por favor, selecione uma capa para o filme!");
                    return;
                }

                if (HorariosSelecionados.Items.Count == 0)
                {
                    MessageBox.Show("Por favor, adicione pelo menos um horário de exibição!");
                    return;
                }

                if (bd.CadastrarFilme(this.titulo, this.genero, this.duracao, this.descricao, caminhoImagem, horarios))
                {
                    MessageBox.Show("Filme cadastrado com sucesso!");

                    TelaCliente TC = new TelaCliente();
                    TC.Show();
                    this.Close();
                }
            
        }

        private void cadastrarFilme2_Load(object sender, EventArgs e)
        {

        }

        private void AddHorarioBtn_Click(object sender, EventArgs e)
        {
            string horarioFormatado = HorarioFilme.Value.ToString("HH:mm");

           
            if (!HorariosSelecionados.Items.Contains(horarioFormatado))
            {
                HorariosSelecionados.Items.Add(horarioFormatado);
            }
        }

        private void HorarioFilme_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RemoverFilme_Click(object sender, EventArgs e)
        
        {
            if (HorariosSelecionados.SelectedIndex != -1)
            {
                HorariosSelecionados.Items.RemoveAt(HorariosSelecionados.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione um horário na lista para remover!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UploadFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens (*.jpg; *.png; *.jpeg)|*.jpg;*.png;*.jpeg";
            dialog.Title = "Selecione a capa do filme";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                caminhoImagem = dialog.FileName; 
                fotoCapa.ImageLocation = caminhoImagem; 
            }
        }
    }
}
    


