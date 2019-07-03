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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            exibirClientesDataGridView.DataSource = getData();
        }

        private DataTable getData()
        {
            DataTable dtTabela = new DataTable();
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=TrabalhoLC;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Clientes",con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            dtTabela.Load(dr);
            return dtTabela;
        }

        private void exibirClientesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
