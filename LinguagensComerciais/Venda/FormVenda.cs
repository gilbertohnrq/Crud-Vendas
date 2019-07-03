using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Venda
{
    public partial class FormVenda : Form
    {

        public FormVenda()
        {
            InitializeComponent();
           
        }

        private void exibirVendasGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
          
        }

       
        
     
private void btnConsultarVendas_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtTabela = new DataTable();
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=TrabalhoLC;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT Clientes.Nome AS Cliente, Clientes.Email AS Email, Produtos.Nome AS Produto FROM Produtos INNER JOIN Clientes ON Clientes.produto = Produtos.Id", con);

                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                exibirVendasGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}

