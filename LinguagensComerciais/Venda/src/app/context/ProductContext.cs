using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Venda.src.app.models;
using System.Data.SqlClient;

namespace Venda
{
    class ProductContext
    {
        public DataBase db { get; set; }

        public ProductContext()
        {
            db = new DataBase();
        }
        
        public string armazenarProduto(ProductModel product, bool update) {
            string queryString;

            if (!update)
            {//inserir novo produto
                queryString = ("INSERT INTO Produtos(descricao, nome, margem, preco, fabricacao, validade) VALUES (@Descricao, @Nome, @Margem, @Preco, @Fabricacao, @Validade)");
            }
            else
            {//update produto existente
                 queryString = ("SET IDENTITY_INSERT Produtos ON; INSERT INTO Produtos(id, descricao, nome, margem, preco, fabricacao, validade) VALUES (@Id, @Descricao, @Nome, @Margem, @Preco, @Fabricacao, @Validade); SET IDENTITY_INSERT Produtos OFF;");

            }

            SqlCommand cmd = new SqlCommand(queryString,db.getConnection());
            if (update)
            {
                cmd.Parameters.AddWithValue("@Id", product.Id);
            }

            cmd.Parameters.AddWithValue("@Descricao", product.Descricao);
            cmd.Parameters.AddWithValue("@Nome", product.Nome);
            cmd.Parameters.AddWithValue("@Margem", product.Margem);
            cmd.Parameters.AddWithValue("@Preco", product.Preco);
            cmd.Parameters.AddWithValue("@Fabricacao", product.Fabricacao);
            cmd.Parameters.AddWithValue("@Validade", product.Validade);
            cmd.ExecuteNonQuery();
                       
            return ("Produto: "+product.Nome + " inserido com sucesso!");
            
        }
        public SqlDataReader show()
        {
            string queryString = "SELECT * FROM Produtos";
            SqlCommand cmd = new SqlCommand(queryString, db.getConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public ProductModel findById(int id) {
            ProductModel product = new ProductModel();
            string queryString = ("SELECT * FROM Produtos WHERE Id = @id");

            SqlCommand cmd = new SqlCommand(queryString, db.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                product.Id = reader.GetInt32(0);
                product.Nome = reader.GetString(2);
                product.Descricao = reader.GetString(1);
                product.Margem = reader.GetInt32(3);
                product.Preco = reader.GetInt32(4);
                product.Fabricacao = reader.GetString(5);
                product.Validade = reader.GetInt32(6);
                
            }
            reader.Close();
            return product;
            
        }
        public void removeProductById(int id) {
            string queryString = ("DELETE FROM Produtos WHERE id = @Id");

            SqlCommand cmd = new SqlCommand(queryString, db.getConnection());

            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }
        public void editProduct(ProductModel product)
        {
            removeProductById(product.Id);
            armazenarProduto(product, true);
        }      
    }
    }
