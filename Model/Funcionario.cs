using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVendasForm.Model
{
    public class Funcionario : Cliente //Herança dos atrbutos de cliente
    {
        public string Senha { get; set; }
        public string Cargo { get; set; }
        public string Nivel_acesso { get; set; }
    }
}
