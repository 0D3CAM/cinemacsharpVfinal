namespace clientecinema
{
    partial class ExcluirFilme
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
            this.codigoFilme = new System.Windows.Forms.TextBox();
            this.Excluir = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(174, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o código do filme que deseja excluir:";
            // 
            // codigoFilme
            // 
            this.codigoFilme.Location = new System.Drawing.Point(355, 227);
            this.codigoFilme.Name = "codigoFilme";
            this.codigoFilme.Size = new System.Drawing.Size(100, 22);
            this.codigoFilme.TabIndex = 1;
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(367, 255);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 2;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(12, 12);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 23);
            this.Voltar.TabIndex = 3;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // ExcluirFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroCliente.Properties.Resources.cinema_blur___Copia;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.codigoFilme);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ExcluirFilme";
            this.Text = "ExcluirFilme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigoFilme;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Voltar;
    }
}