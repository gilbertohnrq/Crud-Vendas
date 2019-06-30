using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Venda.src.app.models;
namespace Venda
{
    public partial class FormExibir : Form
    {
        ProductContext context = new ProductContext();

        public FormExibir()
        {
            InitializeComponent();
            fillDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Deu Certo");
        }

        private void FormExibir_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'trabalhoLCDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.trabalhoLCDataSet.Produtos);

        }
        private void clearDataGridView()
        {
            exibirTodosDataGridView.Rows.Clear();
        }
        private void incluirButton_Click(object sender, EventArgs e)
        {
            CadastroProduto cp = new CadastroProduto(1);
            cp.ShowDialog();
            fillDataGridView();
        }
        private void insertIntoGridView(ProductModel product) {
            exibirTodosDataGridView.Rows.Add(product.Id, product.Nome, product.Descricao,product.Margem, product.Preco, product.Fabricacao, product.Validade);
        }

        private void fillDataGridView() {
            ProductContext productContext = new ProductContext();
            SqlDataReader reader = productContext.show();
            ProductModel product = new ProductModel();
            //id, descricao, nome, margem, preco, fabricacao, validade
            clearDataGridView();

            while (reader.Read())
            {

                product.Id = reader.GetInt32(0);
                product.Nome = reader.GetString(2);
                product.Descricao = reader.GetString(1);
                product.Margem = reader.GetInt32(3);
                product.Preco = reader.GetInt32(4);
                product.Fabricacao = reader.GetString(5);
                product.Validade = reader.GetInt32(6);
                insertIntoGridView(product);

            }
        }

        private void removerButton_Click(object sender, EventArgs e)
        {
            CadastroProduto cp = new CadastroProduto(2);
            cp.ShowDialog();
            fillDataGridView();
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            CadastroProduto cp = new CadastroProduto(3);
            cp.ShowDialog();
            fillDataGridView();
        }

        private void exibirTodosDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void exibirTodosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int tempId = Convert.ToInt32(exibirTodosDataGridView.Rows[e.RowIndex].Cells[0].Value);
            if (tempId != 0)
            {
                Options op = new Options(tempId);
                op.ShowDialog();
            }
            else
            {
                CadastroProduto cp = new CadastroProduto(1);
                cp.ShowDialog();
            }

            fillDataGridView();
        }

        private void exibirTodosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
