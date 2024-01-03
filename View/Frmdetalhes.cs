using ControleDeVendasForm.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeVendasForm.View
{
    public partial class Frmdetalhes : Form
    {
        int venda_id;
        public Frmdetalhes(int idvenda)
        {
            venda_id = idvenda;
            InitializeComponent();
        }

        private void txtcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdata_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtobs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabelaDetalhes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frmdetalhes_Load(object sender, EventArgs e)
        {
            //Carrega tela de detalhes

            ItemVendaDAO dao = new ItemVendaDAO();
            tabelaDetalhes.DataSource = dao.ListarItensPorVenda(venda_id);
        }
    }
}
