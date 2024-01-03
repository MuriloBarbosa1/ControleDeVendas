using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVendasForm.Model
{
    public class Venda
    {
        public int id { get; set; }
        public int client_id { get; set; }
        public DateTime data_venda { get; set; }
        public decimal total_venda { get; set; }
        public string obs { get; set; }
    }
}
