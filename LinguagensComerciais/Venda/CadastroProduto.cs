using System;
using System.Windows.Forms;
using Venda.src.app.models;
namespace Venda
{
    public partial class CadastroProduto : Form
    {
        ProductContext productContext = new ProductContext();
        string idProduct;

        //Options: 1 = inserir; 2 = remover; 3 = modificar; 4 = modificar pelo doubleclick;
        public CadastroProduto(int option, int idProduct = 0)
        {           
            InitializeComponent();
            if (idProduct != 0)
            {
                this.idProduct = idProduct.ToString();
                option = 4;

            }

            prepareView(option);            
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            ProductModel product = new ProductModel();
            product.Nome = produtoTextBox.Text;
            product.Descricao = descricaoTextBox.Text;
            product.Preco = precoNumericUpDown.Value;
            product.Margem = margemNumericUpDown.Value;
            product.Fabricacao = fabricacaoDateTimePicker.Value.ToString();
            product.Validade = validadeNumericUpDown.Value;


           // DataBase db = new DataBase();
           // db.openConnection();

                      
            MessageBox.Show(productContext.armazenarProduto(product, false));
            Close();

            //db.closeConnection();
        }

        private void prepareView(int option) {
            if (option == 1 )
            { //inserir
                
            }
            else if (option == 2) { //remover
                this.Text = "Remover Produto";
                salvarButton.Visible = false;
                buscarButton.Visible = true;
                editarButton.Visible = false;
                removerButton.Visible = true;
                preset();
                
            }
            else if (option == 3)
            { //editar
                this.Text = "Editar Produto";
                salvarButton.Visible = false;
                buscarButton.Visible = true;
                editarButton.Visible = true;
                removerButton.Visible = false;
                preset();
            }
            else if (option == 4)
            { //editar doubleclick
                this.Text = "Editar Produto";
                salvarButton.Visible = false;
                buscarButton.Visible = false;
                editarButton.Visible = true;
                removerButton.Visible = false;
                editarButton.Enabled = true;
                limparButton.Visible = false;

                produtoTextBox.ReadOnly = false;
                descricaoTextBox.ReadOnly = false;
                precoNumericUpDown.ReadOnly = false;
                margemNumericUpDown.ReadOnly = false;
                fabricacaoDateTimePicker.Enabled = true;
                validadeNumericUpDown.ReadOnly = false;
                idTextBox.ReadOnly = true;

                idTextBox.Text = idProduct;

                searchProduct();
                
            }
        }

       

        private void removerButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {                
                productContext.removeProductById(Convert.ToInt32(idTextBox.Text));
                Close();
            }
            else
            {
                MessageBox.Show("Digite um ID válido.");
            }

        }
        private void searchProduct()
        {
            if (idTextBox.Text != "")
            {
                ProductModel product = productContext.findById(Convert.ToInt32(idTextBox.Text));
                fillProduct(product);
                idTextBox.Enabled = false;
                removerButton.Enabled = true;
                if (editarButton.Visible)
                {
                    camposEditaveis();
                    editarButton.Enabled = true;
                }
            }

            else
            {
                MessageBox.Show("Digite um ID válido.");
            }
        }
        private void buscarButton_Click(object sender, EventArgs e)
        {
            searchProduct();            
        }

        private void fillProduct(ProductModel product)
        {
            
            produtoTextBox.Text = product.Nome;
            descricaoTextBox.Text = product.Descricao;
            precoNumericUpDown.Value = product.Preco;
            margemNumericUpDown.Value = product.Margem;
            fabricacaoDateTimePicker.Text = product.Fabricacao;
            validadeNumericUpDown.Value = product.Validade;
            
        }
        private void preset()
        {
            produtoTextBox.ReadOnly = true;
            descricaoTextBox.ReadOnly = true;
            precoNumericUpDown.ReadOnly = true;
            margemNumericUpDown.ReadOnly = true;
            fabricacaoDateTimePicker.Enabled = false;
            validadeNumericUpDown.ReadOnly = true;
            idTextBox.ReadOnly = false;
        }
        private void camposEditaveis()
        {
            produtoTextBox.ReadOnly = false;
            descricaoTextBox.ReadOnly = false;
            margemNumericUpDown.ReadOnly = false;
            validadeNumericUpDown.ReadOnly = false;
            fabricacaoDateTimePicker.Enabled = true;
            validadeNumericUpDown.ReadOnly = false;
            precoNumericUpDown.ReadOnly = false;
        }

        private void editProduct()
        {
            ProductModel newProduct = new ProductModel();
            newProduct.Id = Convert.ToInt32(idTextBox.Text);
            newProduct.Nome = produtoTextBox.Text;
            newProduct.Descricao = descricaoTextBox.Text;
            newProduct.Margem = margemNumericUpDown.Value;
            newProduct.Preco = precoNumericUpDown.Value;
            newProduct.Validade = validadeNumericUpDown.Value;
            newProduct.Fabricacao = fabricacaoDateTimePicker.Text;
            productContext.editProduct(newProduct);
            Close();
            MessageBox.Show("Produto: " + newProduct.Nome + " editado com sucesso!");
        }
        private void editarButton_Click(object sender, EventArgs e)
        {
            editProduct();
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            idTextBox.Enabled = true;
            removerButton.Enabled = false;
            editarButton.Enabled = false;
            salvarButton.Enabled = false;
            limparCampos();
        }
        private void limparCampos() {
            idTextBox.Text = "";
            produtoTextBox.Text = "";
            descricaoTextBox.Text = "";
            precoNumericUpDown.Value = 0;
            margemNumericUpDown.Value = 0;
            fabricacaoDateTimePicker.Text = "";
            validadeNumericUpDown.Value = 0;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
