namespace CadastroCliente
{
    partial class PainelFuncionario
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
            this.Excluir = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Opcao = new System.Windows.Forms.Label();
            this.TituloPagina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Excluir
            // 
            this.Excluir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Excluir.Location = new System.Drawing.Point(305, 388);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(188, 60);
            this.Excluir.TabIndex = 9;
            this.Excluir.Text = "Excluir Cliente";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Atualizar.Location = new System.Drawing.Point(305, 307);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(188, 60);
            this.Atualizar.TabIndex = 8;
            this.Atualizar.Text = "Atualizar Cliente";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // Consultar
            // 
            this.Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Consultar.Location = new System.Drawing.Point(305, 226);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(188, 60);
            this.Consultar.TabIndex = 7;
            this.Consultar.Text = "Consultar Cliente";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Cadastrar
            // 
            this.Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Cadastrar.Location = new System.Drawing.Point(305, 145);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(188, 60);
            this.Cadastrar.TabIndex = 6;
            this.Cadastrar.Text = "Cadastrar Cliente";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Opcao
            // 
            this.Opcao.AutoSize = true;
            this.Opcao.BackColor = System.Drawing.Color.Transparent;
            this.Opcao.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcao.ForeColor = System.Drawing.Color.Transparent;
            this.Opcao.Location = new System.Drawing.Point(255, 97);
            this.Opcao.Name = "Opcao";
            this.Opcao.Size = new System.Drawing.Size(314, 28);
            this.Opcao.TabIndex = 12;
            this.Opcao.Text = "Escolha uma das opções abaixo:";
            // 
            // TituloPagina
            // 
            this.TituloPagina.AutoSize = true;
            this.TituloPagina.BackColor = System.Drawing.Color.Transparent;
            this.TituloPagina.Cursor = System.Windows.Forms.Cursors.Default;
            this.TituloPagina.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloPagina.ForeColor = System.Drawing.Color.Transparent;
            this.TituloPagina.Location = new System.Drawing.Point(31, 66);
            this.TituloPagina.Name = "TituloPagina";
            this.TituloPagina.Padding = new System.Windows.Forms.Padding(300, 0, 300, 0);
            this.TituloPagina.Size = new System.Drawing.Size(743, 31);
            this.TituloPagina.TabIndex = 11;
            this.TituloPagina.Text = "Bem-Vindo!";
            this.TituloPagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PainelFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroCliente.Properties.Resources.Gemini_Generated_Image_m9i5t1m9i5t1m9i5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Opcao);
            this.Controls.Add(this.TituloPagina);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Cadastrar);
            this.Name = "PainelFuncionario";
            this.Text = "PainelFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Opcao;
        private System.Windows.Forms.Label TituloPagina;
    }
}