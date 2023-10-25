using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVendasForm.Model
{
    public  class Produto
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public int qtdestoque { get; set; }
        public int for_id { get; set; } //chave estrangeira (relacionando o id do fornecedor com o produto cadastrado)

    }
}
