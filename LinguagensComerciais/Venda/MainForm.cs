using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Venda
{
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
        

            InitializeComponent();
        }
                
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExibir formExibirTodos = new FormExibir();
            formExibirTodos.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string conexao = "";
            timerToolStripStatusLabel.Text = DateTime.Now.ToString();
            
            DataBase db = new DataBase();
            //conexao = db.getConnection() != null ? "OK" : "Erro em conectar ao banco";
            string textoConexao = ("Banco de dados conectado        "+conexao);
            toolStripStatusLabel1.Text = textoConexao;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //FormExibir formExibirTodos = new FormExibir();
           // formExibirTodos.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.ShowDialog();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastrarClientes = new CadastroCliente();
            cadastrarClientes.ShowDialog();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormVenda formVenda = new FormVenda();
            formVenda.ShowDialog();
        }
    }
}
