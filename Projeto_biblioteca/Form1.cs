using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Biblioteca;Integrated Security=True";
            InitializeComponent();
        }

        private void button2_Livros_Click(object sender, EventArgs e)
        {
            this.Hide();
            Livros form2 = new Livros();
            form2.Show();
        }

        private void button5_Membros_Click(object sender, EventArgs e)
        {
            this.Hide();
            Membros form3 = new Membros();
            form3.Show();
        }

        private void button6_Emprestimo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
