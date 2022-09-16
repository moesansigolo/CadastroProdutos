using System;

namespace CadastroProdutos.Models
{
    public class Produto
    {

        public int id { get; set; }
        public string nomeProduto { get; set; }
        public int quantUnitaria { get; set; }
        public double preco { get; set; }
        public double peso { get; set; }
        public DateTime dataValidade { get; set; }
        public DateTime dataInclusao { get; set; }
    }
}
