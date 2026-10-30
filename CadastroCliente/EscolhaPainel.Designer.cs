namespace CadastroCliente
{
    partial class EscolhaPainel
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
            this.label1 = new System.Windows.Forms.Label();
            this.PainelAdmin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(288, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acesso aos Paineis:";
            // 
            // PainelAdmin
            // 
            this.PainelAdmin.Location = new System.Drawing.Point(171, 175);
            this.PainelAdmin.Name = "PainelAdmin";
            this.PainelAdmin.Size = new System.Drawing.Size(212, 125);
            this.PainelAdmin.TabIndex = 1;
            this.PainelAdmin.Text = "Painel Admin";
            this.PainelAdmin.UseVisualStyleBackColor = true;
            this.PainelAdmin.Click += new System.EventHandler(this.PainelAdmin_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 125);
            this.button2.TabIndex = 2;
            this.button2.Text = "Painel Funcionário";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EscolhaPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroCliente.Properties.Resources.cinema_blur___Copia;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PainelAdmin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "EscolhaPainel";
            this.Text = "EscolhaPainel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PainelAdmin;
        private System.Windows.Forms.Button button2;
    }
}