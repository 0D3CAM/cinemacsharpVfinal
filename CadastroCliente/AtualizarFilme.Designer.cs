namespace clientecinema
{
    partial class AtualizarFilme
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
            this.CodigoFilme = new System.Windows.Forms.Label();
            this.CategoriaFilme = new System.Windows.Forms.Label();
            this.Categoria = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotaoAtualizar = new System.Windows.Forms.Button();
            this.UploadCapa = new System.Windows.Forms.Button();
            this.Capa = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Capa)).BeginInit();
            this.SuspendLayout();
            // 
            // CodigoFilme
            // 
            this.CodigoFilme.AutoSize = true;
            this.CodigoFilme.BackColor = System.Drawing.Color.Transparent;
            this.CodigoFilme.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoFilme.ForeColor = System.Drawing.Color.Transparent;
            this.CodigoFilme.Location = new System.Drawing.Point(255, 76);
            this.CodigoFilme.Name = "CodigoFilme";
            this.CodigoFilme.Size = new System.Drawing.Size(196, 31);
            this.CodigoFilme.TabIndex = 0;
            this.CodigoFilme.Text = "Código do Filme:";
            // 
            // CategoriaFilme
            // 
            this.CategoriaFilme.AutoSize = true;
            this.CategoriaFilme.BackColor = System.Drawing.Color.Transparent;
            this.CategoriaFilme.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold);
            this.CategoriaFilme.ForeColor = System.Drawing.Color.Transparent;
            this.CategoriaFilme.Location = new System.Drawing.Point(257, 138);
            this.CategoriaFilme.Name = "CategoriaFilme";
            this.CategoriaFilme.Size = new System.Drawing.Size(123, 31);
            this.CategoriaFilme.TabIndex = 1;
            this.CategoriaFilme.Text = "Categoria:";
            // 
            // Categoria
            // 
            this.Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categoria.FormattingEnabled = true;
            this.Categoria.Items.AddRange(new object[] {
            "Título",
            "Gênero",
            "Duração",
            "Descrição",
            "Horários",
            "Capa "});
            this.Categoria.Location = new System.Drawing.Point(386, 147);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(165, 21);
            this.Categoria.TabIndex = 2;
            this.Categoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(451, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(422, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(257, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Novo Campo:";
            // 
            // BotaoAtualizar
            // 
            this.BotaoAtualizar.Location = new System.Drawing.Point(376, 268);
            this.BotaoAtualizar.Name = "BotaoAtualizar";
            this.BotaoAtualizar.Size = new System.Drawing.Size(75, 23);
            this.BotaoAtualizar.TabIndex = 7;
            this.BotaoAtualizar.Text = "Atualizar";
            this.BotaoAtualizar.UseVisualStyleBackColor = true;
            // 
            // UploadCapa
            // 
            this.UploadCapa.Location = new System.Drawing.Point(652, 268);
            this.UploadCapa.Name = "UploadCapa";
            this.UploadCapa.Size = new System.Drawing.Size(75, 23);
            this.UploadCapa.TabIndex = 8;
            this.UploadCapa.Text = "Upload";
            this.UploadCapa.UseVisualStyleBackColor = true;
            this.UploadCapa.Click += new System.EventHandler(this.UploadCapa_Click);
            // 
            // Capa
            // 
            this.Capa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Capa.Location = new System.Drawing.Point(620, 58);
            this.Capa.Name = "Capa";
            this.Capa.Size = new System.Drawing.Size(141, 203);
            this.Capa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Capa.TabIndex = 9;
            this.Capa.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(12, 22);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 23);
            this.Voltar.TabIndex = 10;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // AtualizarFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroCliente.Properties.Resources.cinema_blur___Copia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Capa);
            this.Controls.Add(this.UploadCapa);
            this.Controls.Add(this.BotaoAtualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.CategoriaFilme);
            this.Controls.Add(this.CodigoFilme);
            this.Name = "AtualizarFilme";
            this.Text = "AtualizarFilme";
            ((System.ComponentModel.ISupportInitialize)(this.Capa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CodigoFilme;
        private System.Windows.Forms.Label CategoriaFilme;
        private System.Windows.Forms.ComboBox Categoria;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotaoAtualizar;
        private System.Windows.Forms.Button UploadCapa;
        private System.Windows.Forms.PictureBox Capa;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Voltar;
    }
}