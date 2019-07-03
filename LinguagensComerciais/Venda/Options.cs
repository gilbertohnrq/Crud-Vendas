using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Venda.src.app.models;

namespace Venda
{
    public partial class Options : Form
    {
        ProductModel product;
        ProductContext context = new ProductContext();

        public Options(int id)
        {
            InitializeComponent();
            product = context.findById(id);

        }

        private void Options_Load(object sender, EventArgs e)
        {
            if (product.Id == 0)
            {
                Close();
            }

            nomeLabel.Text = ("Produto: "+product.Nome);
        }

        private void removerButton_Click(object sender, EventArgs e)
        {
            context.removeProductById(product.Id);
            Close();
            MessageBox.Show("Produto: " + product.Nome + " removido com sucesso!");
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            CadastroProduto cp = new CadastroProduto(3, product.Id);
            cp.ShowDialog();
            Close();
           
        }

        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
