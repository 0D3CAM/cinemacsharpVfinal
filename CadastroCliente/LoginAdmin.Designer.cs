namespace clientecinema
{
    partial class LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.logar = new System.Windows.Forms.Button();
            this.senha_id = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Voltar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Painel Admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(301, 172);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(206, 20);
            this.login.TabIndex = 1;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(301, 237);
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(206, 20);
            this.senha.TabIndex = 2;
            this.senha.TextChanged += new System.EventHandler(this.senha_TextChanged);
            // 
            // logar
            // 
            this.logar.Location = new System.Drawing.Point(297, 313);
            this.logar.Name = "logar";
            this.logar.Size = new System.Drawing.Size(210, 23);
            this.logar.TabIndex = 3;
            this.logar.Text = "Entrar";
            this.logar.UseVisualStyleBackColor = true;
            this.logar.Click += new System.EventHandler(this.logar_Click);
            // 
            // senha_id
            // 
            this.senha_id.AutoSize = true;
            this.senha_id.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha_id.Location = new System.Drawing.Point(379, 217);
            this.senha_id.Name = "senha_id";
            this.senha_id.Size = new System.Drawing.Size(46, 17);
            this.senha_id.TabIndex = 4;
            this.senha_id.Text = "Senha";
            this.senha_id.Click += new System.EventHandler(this.senha_id_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(383, 149);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(41, 17);
            this.id.TabIndex = 5;
            this.id.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Voltar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 6;
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(352, 356);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(100, 23);
            this.Voltar.TabIndex = 7;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // LoginAdmin
            // 
            this.AcceptButton = this.logar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.id);
            this.Controls.Add(this.senha_id);
            this.Controls.Add(this.logar);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginAdmin";
            this.Text = "LoginAdmin";
            this.Load += new System.EventHandler(this.LoginAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Button logar;
        public System.Windows.Forms.Label senha_id;
        public System.Windows.Forms.Label id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Voltar;
    }
}