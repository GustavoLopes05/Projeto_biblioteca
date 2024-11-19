namespace Projeto_biblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2_Livros = new System.Windows.Forms.Button();
            this.button5_Membros = new System.Windows.Forms.Button();
            this.button6_Emprestimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2_Livros
            // 
            this.button2_Livros.Location = new System.Drawing.Point(240, 104);
            this.button2_Livros.Name = "button2_Livros";
            this.button2_Livros.Size = new System.Drawing.Size(145, 52);
            this.button2_Livros.TabIndex = 1;
            this.button2_Livros.Text = "Livros";
            this.button2_Livros.UseVisualStyleBackColor = true;
            this.button2_Livros.Click += new System.EventHandler(this.button2_Livros_Click);
            // 
            // button5_Membros
            // 
            this.button5_Membros.Location = new System.Drawing.Point(240, 202);
            this.button5_Membros.Name = "button5_Membros";
            this.button5_Membros.Size = new System.Drawing.Size(145, 50);
            this.button5_Membros.TabIndex = 4;
            this.button5_Membros.Text = "Membros";
            this.button5_Membros.UseVisualStyleBackColor = true;
            this.button5_Membros.Click += new System.EventHandler(this.button5_Membros_Click);
            // 
            // button6_Emprestimo
            // 
            this.button6_Emprestimo.Location = new System.Drawing.Point(240, 306);
            this.button6_Emprestimo.Name = "button6_Emprestimo";
            this.button6_Emprestimo.Size = new System.Drawing.Size(145, 50);
            this.button6_Emprestimo.TabIndex = 5;
            this.button6_Emprestimo.Text = "Empréstimos";
            this.button6_Emprestimo.UseVisualStyleBackColor = true;
            this.button6_Emprestimo.Click += new System.EventHandler(this.button6_Emprestimo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(627, 444);
            this.Controls.Add(this.button6_Emprestimo);
            this.Controls.Add(this.button5_Membros);
            this.Controls.Add(this.button2_Livros);
            this.Name = "Form1";
            this.Text = "Biblioteca ";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2_Livros;
        private System.Windows.Forms.Button button5_Membros;
        private System.Windows.Forms.Button button6_Emprestimo;
    }
}

