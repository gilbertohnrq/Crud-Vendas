using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Venda.src.app.models
{
    class ProductModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Margem { get; set; }
        public decimal Preco { get; set; }
        public string Fabricacao { get; set; }
        public decimal Validade { get; set; }

        public override string ToString() {
            return ("ID: {Id}, Nome: {Nome}, Descrição: {Descricao}, Margem: {Margem}, Preco: {Preco}, Validade: {Validade}, Fabricacao: {Fabricacao}");
        }
        }

}
