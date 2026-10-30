namespace clientecinema
{
    partial class ConsultarFilme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BuscaFilme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PesquisarFilme = new System.Windows.Forms.Button();
            this.BuscarTodos = new System.Windows.Forms.Button();
            this.gridFilmes = new System.Windows.Forms.DataGridView();
            this.FotoCapa = new System.Windows.Forms.PictureBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.Genero = new System.Windows.Forms.Label();
            this.Duracao = new System.Windows.Forms.Label();
            this.Horarios = new System.Windows.Forms.Label();
            this.Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridFilmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscaFilme
            // 
            this.BuscaFilme.AcceptsReturn = true;
            this.BuscaFilme.Location = new System.Drawing.Point(39, 48);
            this.BuscaFilme.Name = "BuscaFilme";
            this.BuscaFilme.Size = new System.Drawing.Size(339, 20);
            this.BuscaFilme.TabIndex = 0;
            this.BuscaFilme.TextChanged += new System.EventHandler(this.BuscaFilme_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(135, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Filme:";
            // 
            // PesquisarFilme
            // 
            this.PesquisarFilme.Location = new System.Drawing.Point(140, 74);
            this.PesquisarFilme.Name = "PesquisarFilme";
            this.PesquisarFilme.Size = new System.Drawing.Size(141, 23);
            this.PesquisarFilme.TabIndex = 2;
            this.PesquisarFilme.Text = "Pesquisar";
            this.PesquisarFilme.UseVisualStyleBackColor = true;
            // 
            // BuscarTodos
            // 
            this.BuscarTodos.Location = new System.Drawing.Point(12, 12);
            this.BuscarTodos.Name = "BuscarTodos";
            this.BuscarTodos.Size = new System.Drawing.Size(102, 23);
            this.BuscarTodos.TabIndex = 3;
            this.BuscarTodos.Text = "Buscar Todos ";
            this.BuscarTodos.UseVisualStyleBackColor = true;
            // 
            // gridFilmes
            // 
            this.gridFilmes.AllowUserToAddRows = false;
            this.gridFilmes.AllowUserToDeleteRows = false;
            this.gridFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFilmes.Location = new System.Drawing.Point(458, 12);
            this.gridFilmes.MultiSelect = false;
            this.gridFilmes.Name = "gridFilmes";
            this.gridFilmes.ReadOnly = true;
            this.gridFilmes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFilmes.Size = new System.Drawing.Size(330, 426);
            this.gridFilmes.TabIndex = 4;
            // 
            // FotoCapa
            // 
            this.FotoCapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoCapa.Location = new System.Drawing.Point(244, 116);
            this.FotoCapa.Name = "FotoCapa";
            this.FotoCapa.Size = new System.Drawing.Size(208, 322);
            this.FotoCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoCapa.TabIndex = 5;
            this.FotoCapa.TabStop = false;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(42, 181);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(40, 13);
            this.Titulo.TabIndex = 6;
            this.Titulo.Text = "Titulo:";
            // 
            // Genero
            // 
            this.Genero.AutoSize = true;
            this.Genero.BackColor = System.Drawing.Color.Transparent;
            this.Genero.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Genero.ForeColor = System.Drawing.Color.White;
            this.Genero.Location = new System.Drawing.Point(42, 236);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(48, 13);
            this.Genero.TabIndex = 7;
            this.Genero.Text = "Genero:";
            // 
            // Duracao
            // 
            this.Duracao.AutoSize = true;
            this.Duracao.BackColor = System.Drawing.Color.Transparent;
            this.Duracao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Duracao.ForeColor = System.Drawing.Color.Transparent;
            this.Duracao.Location = new System.Drawing.Point(42, 291);
            this.Duracao.Name = "Duracao";
            this.Duracao.Size = new System.Drawing.Size(53, 13);
            this.Duracao.TabIndex = 8;
            this.Duracao.Text = "Duracao:";
            // 
            // Horarios
            // 
            this.Horarios.AutoSize = true;
            this.Horarios.BackColor = System.Drawing.Color.Transparent;
            this.Horarios.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Horarios.ForeColor = System.Drawing.Color.White;
            this.Horarios.Location = new System.Drawing.Point(42, 375);
            this.Horarios.Name = "Horarios";
            this.Horarios.Size = new System.Drawing.Size(54, 13);
            this.Horarios.TabIndex = 9;
            this.Horarios.Text = "Horarios:";
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(12, 415);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 23);
            this.Voltar.TabIndex = 10;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            // 
            // ConsultarFilme
            // 
            this.AcceptButton = this.PesquisarFilme;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroCliente.Properties.Resources.cinema_blur___Copia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Horarios);
            this.Controls.Add(this.Duracao);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.FotoCapa);
            this.Controls.Add(this.gridFilmes);
            this.Controls.Add(this.BuscarTodos);
            this.Controls.Add(this.PesquisarFilme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuscaFilme);
            this.Name = "ConsultarFilme";
            this.Text = "ConsultarFilme";
            ((System.ComponentModel.ISupportInitialize)(this.gridFilmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BuscaFilme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PesquisarFilme;
        private System.Windows.Forms.Button BuscarTodos;
        private System.Windows.Forms.DataGridView gridFilmes;
        private System.Windows.Forms.PictureBox FotoCapa;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Genero;
        private System.Windows.Forms.Label Duracao;
        private System.Windows.Forms.Label Horarios;
        private System.Windows.Forms.Button Voltar;
    }
}