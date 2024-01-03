using ControleDeVendasForm.Dao;
using ControleDeVendasForm.Model;
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
    public partial class Frmpagamento : Form
    {
        Cliente Cliente = new Cliente();
        DataTable Carrinho = new DataTable();
        DateTime dataAtual;

        public Frmpagamento(Cliente cliente , DataTable carrinho, DateTime dataatual)
        {
            this.Cliente = cliente;//os objetos recebem os parametros
            this.Carrinho = carrinho;
            this.dataAtual = dataatual;
            InitializeComponent();
            
        }

        private void Frmpagamento_Load(object sender, EventArgs e)
        {
            txtcartao.Text = "0,00";
            txtdinheiro.Text = "0,00";
            txttroco.Text = "0,00";
        }
            
        private void btnfinalizarvenda_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_dinheiro, v_cartao, troco, totalPago, total;
                ProdutoDAO dao_produto = new ProdutoDAO();

                int qtd_estoque, qtd_comprada, qtd_atualizada;
                

                v_dinheiro = decimal.Parse(txtdinheiro.Text);
                v_cartao = decimal.Parse(txtcartao.Text);
                total = decimal.Parse(txttotal.Text);

                totalPago = v_dinheiro + v_cartao;

                if (totalPago < total)
                {
                    MessageBox.Show("O total pago é menor que o valor total da compra");
                }
                else
                {
                    troco = totalPago - total;

                    Venda vendas = new Venda();

                    vendas.client_id = Cliente.Codigo;
                    vendas.data_venda = dataAtual;
                    vendas.total_venda = total;
                    vendas.obs = txtobs.Text;

                    VendaDAO dao = new VendaDAO();
                    txttroco.Text = troco.ToString();
                    dao.CadastrarVenda(vendas);

                    

                    foreach (DataRow linha in Carrinho.Rows)
                    {
                        ItemVenda iv = new ItemVenda();

                        iv.venda_id = dao.UltimoIdVenda();
                        iv.produto_id = int.Parse(linha["Codigo"].ToString());
                        iv.qtd = int.Parse(linha["Qtd"].ToString());
                        iv.subTotal = decimal.Parse(linha["SubTotal"].ToString());

                        qtd_estoque = dao_produto.RetornaEstoqueAtual(iv.produto_id);
                        qtd_comprada = iv.qtd;
                        qtd_atualizada = qtd_estoque - qtd_comprada;
                        dao_produto.BaixaNoEstoque(qtdestoque:qtd_atualizada,iv.produto_id);

                        ItemVendaDAO ivdDAO = new ItemVendaDAO();
                        ivdDAO.CadastrarItemDeVenda(iv);
                    }
                    //MessageBox.Show("Item de venda cadastrado com sucesso");

                    this.Dispose(); //this significa que esta manipulando o Frmpagamento e o dispose fecha ele

                    new Frmvendas().ShowDialog();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ");
            }
           
            

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
