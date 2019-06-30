using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Margem { get; set; }
        public decimal Preco { get; set; }
        public DateTime Fabricacao { get; set; }
        public int Validade { get; set; }

        /// <summary>
        /// Construtora
        /// </summary>
        public Produto()
        {
            Fabricacao = DateTime.MinValue;
        }

        public Produto(int id, string des, decimal margem, decimal preco, DateTime fab, int val)
        {
            Id = id;
            Descricao = des;
            Margem = margem;
            Preco = preco;
            Fabricacao = fab;
            Validade = val;
        }

        public decimal ObterPreco()
        {
            return Preco + (Preco * (Margem/100));
        }

        public DateTime ObterValidade()
        {
            return Fabricacao.AddMonths(Validade);
        }
    }
}
