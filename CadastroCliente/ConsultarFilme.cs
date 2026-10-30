using cadastro_cliente;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace clientecinema
{
    public partial class ConsultarFilme : Form
    {
        DAO bd;

        public ConsultarFilme()
        {
            InitializeComponent();
            bd = new DAO();

            this.Load += Consultar_Load;
            PesquisarFilme.Click += PesquisarFilme_Click;
            BuscarTodos.Click += BuscarTodos_Click;
            Voltar.Click += Voltar_Click;
            gridFilmes.SelectionChanged += gridFilmes_SelectionChanged;
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CarregarFilmes("");
        }

        private void ConfigurarGrid()
        {
            gridFilmes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridFilmes.MultiSelect = false;
            gridFilmes.ReadOnly = true;
            gridFilmes.AllowUserToAddRows = false;
            gridFilmes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public void CarregarFilmes(string termo)
        {
            DataTable dt = bd.ConsultarFilme(termo);
            gridFilmes.DataSource = dt;

            if (gridFilmes.Columns.Contains("codigo")) gridFilmes.Columns["codigo"].Visible = true;
            if (gridFilmes.Columns.Contains("caminhoImagem")) gridFilmes.Columns["caminhoImagem"].Visible = false;

            if (gridFilmes.Columns.Contains("titulo")) gridFilmes.Columns["titulo"].HeaderText = "Título";
            if (gridFilmes.Columns.Contains("genero")) gridFilmes.Columns["genero"].HeaderText = "Gênero";
            if (gridFilmes.Columns.Contains("duracao")) gridFilmes.Columns["duracao"].HeaderText = "Duração";
            if (gridFilmes.Columns.Contains("horarios")) gridFilmes.Columns["horarios"].HeaderText = "Horários";

            if (gridFilmes.Columns.Contains("descricao"))
            {
                gridFilmes.Columns["descricao"].HeaderText = "Descrição";
                gridFilmes.Columns["descricao"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                gridFilmes.Columns["descricao"].Width = 250;
            }

            if (gridFilmes.Rows.Count > 0)
            {
                ExibirDetalhesSelecionados();
            }
            else
            {
                LimparDetalhes();
            }
        }

        private void PesquisarFilme_Click(object sender, EventArgs e)
        {
            CarregarFilmes(BuscaFilme.Text.Trim());
        }

        private void BuscarTodos_Click(object sender, EventArgs e)
        {
            BuscaFilme.Clear();
            CarregarFilmes("");
        }

        private void gridFilmes_SelectionChanged(object sender, EventArgs e)
        {
            ExibirDetalhesSelecionados();
        }

        public void ExibirDetalhesSelecionados()
        {
            if (gridFilmes.CurrentRow != null && gridFilmes.CurrentRow.Index >= 0)
            {
                DataRowView linha = (DataRowView)gridFilmes.CurrentRow.DataBoundItem;

                Titulo.Text = linha["titulo"].ToString();
                Genero.Text = "Gênero: " + linha["genero"].ToString();
                Duracao.Text = "Duração: " + linha["duracao"].ToString();
                Horarios.Text = "Horários: " + linha["horarios"].ToString();

                string caminhoFoto = linha["caminhoImagem"].ToString();

                if (!string.IsNullOrEmpty(caminhoFoto) && File.Exists(caminhoFoto))
                {
                    FotoCapa.ImageLocation = caminhoFoto;
                }
                else
                {
                    FotoCapa.Image = null;
                }
            }
        }

        public void LimparDetalhes()
        {
            Titulo.Text = "Nenhum filme selecionado";
            Genero.Text = "Gênero: -";
            Duracao.Text = "Duração: -";
            Horarios.Text = "Horários: -";
            FotoCapa.Image = null;
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            TelaCliente TC = new TelaCliente();
            TC.Show();
            this.Close();
        }

        private void BuscaFilme_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}