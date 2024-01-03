using ControleDeVendasForm.Dao;
using Google.Protobuf.WellKnownTypes;
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
    public partial class Frmhistorico : Form
    {
        public Frmhistorico()
        {
            InitializeComponent();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            /*DateTime datainicio, datafim;

            datainicio = Convert.ToDateTime(dtInicio.Value.ToString("yyyy-MM-dd"));
            datafim = Convert.ToDateTime(dtFim.Value.ToString("yyyy-MM-dd"));

            VendaDAO dao = new VendaDAO();
            tabelaHistorico.DataSource = dao.HistoricoVenda(datainicio, datafim);*/
            DateTime datainicio, datafim;
            datainicio = Convert.ToDateTime(dtInicio.Value.ToString("yyyy-MM-dd"));
            datafim = Convert.ToDateTime(dtFim.Value.ToString("yyyy-MM-dd"));

            VendaDAO dao = new VendaDAO();
            tabelaHistorico.DataSource = dao.listarVendasPorPeriodo(datainicio, datafim);


        }

        private void Frmhistorico_Load(object sender, EventArgs e)
        {
            //Faz a referencia do nome da coluna no DataGrid com o nome da coluna no Banco de dados
            tabelaHistorico.Columns["colCod"].DataPropertyName = "Código";
            tabelaHistorico.Columns["colData"].DataPropertyName = "Data da venda";
            tabelaHistorico.Columns["colCLiente"].DataPropertyName = "Cliente";
            tabelaHistorico.Columns["colTotal"].DataPropertyName = "Total";
            tabelaHistorico.Columns["colObs"].DataPropertyName = "Obs";

            VendaDAO dao = new VendaDAO();
            tabelaHistorico.DataSource = dao.ListarVendas();
            

           // tabelaHistorico.Columns["ColCliente"].DefaultCellStyle.ForeColor = Color.Blue; 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void tabelaHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Passando o Id da venda
            int idvenda = int.Parse(tabelaHistorico.CurrentRow.Cells[0].Value.ToString());

             Frmdetalhes tela = new Frmdetalhes(idvenda);

            DateTime dataVenda = Convert.ToDateTime(tabelaHistorico.CurrentRow.Cells[1].Value.ToString());

            tela.txtdata.Text = dataVenda.ToString("dd/MM/yyyy");
            tela.txtcliente.Text = tabelaHistorico.CurrentRow.Cells[2].Value.ToString();
            tela.txttotal.Text = tabelaHistorico.CurrentRow.Cells[3].Value.ToString();
            tela.txtobs.Text = tabelaHistorico.CurrentRow.Cells[4].Value.ToString();

            tela.ShowDialog();

        }


    }
}
