namespace clientecinema
{
    partial class cadastrarFilme2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrarFilme2));
            this.Voltar = new System.Windows.Forms.Button();
            this.ImagemUpload = new System.Windows.Forms.Label();
            this.NomeFilmeTxt = new System.Windows.Forms.Label();
            this.BotaoProximo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UploadFoto = new System.Windows.Forms.Button();
            this.fotoCapa = new System.Windows.Forms.PictureBox();
            this.RemoverFilme = new System.Windows.Forms.Button();
            this.HorariosSelecionados = new System.Windows.Forms.ListBox();
            this.AddHorarioBtn = new System.Windows.Forms.Button();
            this.HorarioFilme = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // Voltar
            // 
            this.Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Voltar.Location = new System.Drawing.Point(322, 374);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 23);
            this.Voltar.TabIndex = 40;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // ImagemUpload
            // 
            this.ImagemUpload.AutoSize = true;
            this.ImagemUpload.BackColor = System.Drawing.Color.Transparent;
            this.ImagemUpload.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagemUpload.ForeColor = System.Drawing.Color.Gainsboro;
            this.ImagemUpload.Location = new System.Drawing.Point(3, 202);
            this.ImagemUpload.Name = "ImagemUpload";
            this.ImagemUpload.Size = new System.Drawing.Size(245, 30);
            this.ImagemUpload.TabIndex = 37;
            this.ImagemUpload.Text = "Capa do Filme(Upload):";
            // 
            // NomeFilmeTxt
            // 
            this.NomeFilmeTxt.AutoSize = true;
            this.NomeFilmeTxt.BackColor = System.Drawing.Color.Transparent;
            this.NomeFilmeTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeFilmeTxt.ForeColor = System.Drawing.Color.Gainsboro;
            this.NomeFilmeTxt.Location = new System.Drawing.Point(34, 140);
            this.NomeFilmeTxt.Name = "NomeFilmeTxt";
            this.NomeFilmeTxt.Size = new System.Drawing.Size(94, 30);
            this.NomeFilmeTxt.TabIndex = 32;
            this.NomeFilmeTxt.Text = "Horário:";
            // 
            // BotaoProximo
            // 
            this.BotaoProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoProximo.ForeColor = System.Drawing.Color.Black;
            this.BotaoProximo.Location = new System.Drawing.Point(403, 374);
            this.BotaoProximo.Name = "BotaoProximo";
            this.BotaoProximo.Size = new System.Drawing.Size(75, 23);
            this.BotaoProximo.TabIndex = 39;
            this.BotaoProximo.Text = "Confirmar";
            this.BotaoProximo.UseVisualStyleBackColor = true;
            this.BotaoProximo.Click += new System.EventHandler(this.BotaoProximo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.UploadFoto);
            this.panel1.Controls.Add(this.fotoCapa);
            this.panel1.Controls.Add(this.RemoverFilme);
            this.panel1.Controls.Add(this.HorariosSelecionados);
            this.panel1.Controls.Add(this.AddHorarioBtn);
            this.panel1.Controls.Add(this.HorarioFilme);
            this.panel1.Controls.Add(this.ImagemUpload);
            this.panel1.Location = new System.Drawing.Point(27, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 345);
            this.panel1.TabIndex = 41;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UploadFoto
            // 
            this.UploadFoto.Location = new System.Drawing.Point(375, 230);
            this.UploadFoto.Name = "UploadFoto";
            this.UploadFoto.Size = new System.Drawing.Size(75, 23);
            this.UploadFoto.TabIndex = 45;
            this.UploadFoto.Text = "Upload";
            this.UploadFoto.UseVisualStyleBackColor = true;
            this.UploadFoto.Click += new System.EventHandler(this.UploadFoto_Click);
            // 
            // fotoCapa
            // 
            this.fotoCapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.fotoCapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoCapa.Location = new System.Drawing.Point(254, 193);
            this.fotoCapa.Name = "fotoCapa";
            this.fotoCapa.Size = new System.Drawing.Size(100, 107);
            this.fotoCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoCapa.TabIndex = 44;
            this.fotoCapa.TabStop = false;
            // 
            // RemoverFilme
            // 
            this.RemoverFilme.Location = new System.Drawing.Point(256, 116);
            this.RemoverFilme.Name = "RemoverFilme";
            this.RemoverFilme.Size = new System.Drawing.Size(75, 23);
            this.RemoverFilme.TabIndex = 43;
            this.RemoverFilme.Text = "Remover";
            this.RemoverFilme.UseVisualStyleBackColor = true;
            this.RemoverFilme.Click += new System.EventHandler(this.RemoverFilme_Click);
            // 
            // HorariosSelecionados
            // 
            this.HorariosSelecionados.FormattingEnabled = true;
            this.HorariosSelecionados.Location = new System.Drawing.Point(440, 15);
            this.HorariosSelecionados.Name = "HorariosSelecionados";
            this.HorariosSelecionados.Size = new System.Drawing.Size(295, 173);
            this.HorariosSelecionados.TabIndex = 42;
            // 
            // AddHorarioBtn
            // 
            this.AddHorarioBtn.Location = new System.Drawing.Point(131, 116);
            this.AddHorarioBtn.Name = "AddHorarioBtn";
            this.AddHorarioBtn.Size = new System.Drawing.Size(75, 23);
            this.AddHorarioBtn.TabIndex = 41;
            this.AddHorarioBtn.Text = "Adicionar";
            this.AddHorarioBtn.UseVisualStyleBackColor = true;
            this.AddHorarioBtn.Click += new System.EventHandler(this.AddHorarioBtn_Click);
            // 
            // HorarioFilme
            // 
            this.HorarioFilme.CustomFormat = "HH:mm";
            this.HorarioFilme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HorarioFilme.Location = new System.Drawing.Point(131, 90);
            this.HorarioFilme.Name = "HorarioFilme";
            this.HorarioFilme.ShowUpDown = true;
            this.HorarioFilme.Size = new System.Drawing.Size(200, 20);
            this.HorarioFilme.TabIndex = 39;
            this.HorarioFilme.ValueChanged += new System.EventHandler(this.HorarioFilme_ValueChanged);
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            // 
            // cadastrarFilme2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroCliente.Properties.Resources.cinema_blur___Copia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.BotaoProximo);
            this.Controls.Add(this.NomeFilmeTxt);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastrarFilme2";
            this.Text = "cadastrarFilme2";
            this.Load += new System.EventHandler(this.cadastrarFilme2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Label ImagemUpload;
        private System.Windows.Forms.Label NomeFilmeTxt;
        private System.Windows.Forms.Button BotaoProximo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker HorarioFilme;
        private System.Windows.Forms.Button AddHorarioBtn;
        private System.Windows.Forms.ListBox HorariosSelecionados;
        private System.Windows.Forms.Button RemoverFilme;
        private System.Windows.Forms.Button UploadFoto;
        private System.Windows.Forms.PictureBox fotoCapa;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
    }
}