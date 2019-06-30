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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
            txtPesquisarNome.Enabled = false;
            txtNome.Enabled = false;
            mskTelefone.Enabled = false;
            mskCelular.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtRg.Enabled = false;
            txtCpf.Enabled = false;
        }
        SqlConnection sqlCon = null;
        private string strCon = "Data Source=localhost;Initial Catalog=TrabalhoLC;Integrated Security=True";
        private string strSql = string.Empty;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtPesquisarNome.Enabled = false;
            txtNome.Enabled = true;
            mskTelefone.Enabled = true;
            mskCelular.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtRg.Enabled = true;
            txtCpf.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strSql = "INSERT INTO Clientes (Nome, Telefone, Celular, Email, Endereco, Numero, Bairro, RG, CPF)  VALUES (@Nome, @Telefone, @Celular, @Email, @Endereco, @Numero, @Bairro, @RG, @CPF)";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = mskTelefone.Text;
            comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = mskCelular.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txtEndereco.Text;
            comando.Parameters.Add("@Numero", SqlDbType.VarChar).Value = txtNumero.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txtBairro.Text;
            comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = txtRg.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txtCpf.Text;

            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro Efetuado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlCon.Close();
            }

            txtPesquisarNome.Enabled = true;
            txtNome.Clear();
            mskTelefone.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtRg.Clear();
            txtCpf.Clear();
            mskCelular.Clear();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            strSql = "SELECT * FROM Clientes WHERE Nome = @pesquisa";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = txtPesquisarNome.Text;

            try
            {
                if (txtPesquisarNome.Text == string.Empty)
                {
                    MessageBox.Show("Digite um nome para a pesquisa");
                }
                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("Este nome não está cadastrado");
                }

                dr.Read();

                txtNome.Text = Convert.ToString(dr["Nome"]);
                mskTelefone.Text = Convert.ToString(dr["Telefone"]);
                mskCelular.Text = Convert.ToString(dr["Celular"]);
                txtEmail.Text = Convert.ToString(dr["Email"]);
                txtEndereco.Text = Convert.ToString(dr["Endereco"]);
                txtNumero.Text = Convert.ToString(dr["Numero"]);
                txtBairro.Text = Convert.ToString(dr["Bairro"]);
                txtRg.Text = Convert.ToString(dr["RG"]);
                txtCpf.Text = Convert.ToString(dr["CPF"]);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            txtPesquisarNome.Clear();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            strSql = "UPDATE Clientes SET Nome = @Nome, Telefone = @Telefone, Celular = @Celular, Email = @Email, Endereco = @Endereco, Numero = @Numero, Bairro = @Bairro, RG = @RG, CPF = @CPF";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = mskTelefone.Text;
            comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = mskCelular.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txtEndereco.Text;
            comando.Parameters.Add("@Numero", SqlDbType.VarChar).Value = txtNumero.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txtBairro.Text;
            comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = txtRg.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txtCpf.Text;


            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro Atualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }

            finally
            {
                sqlCon.Close();
            }

            txtNome.Clear();
            mskTelefone.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtRg.Clear();
            txtCpf.Clear();
            mskCelular.Clear();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            strSql = "DELETE FROM Clientes WHERE Nome = @Nome";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente Removido");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            finally
            {
                sqlCon.Close();
            }
            txtNome.Clear();
            mskTelefone.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtRg.Clear();
            txtCpf.Clear();
            mskCelular.Clear();
        }
    }
}
