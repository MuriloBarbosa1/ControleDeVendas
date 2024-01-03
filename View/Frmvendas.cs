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
    public partial class Frmvendas : Form
    {

        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();

        Produto p = new Produto();
        ProdutoDAO pdao = new ProdutoDAO();

        int qtd;
        decimal preco;
        decimal subtotal, total;
        

        DataTable carrinho = new DataTable();
        public Frmvendas()
        {
            InitializeComponent();

            //Quando os dados do DataGridView não vem do banco dados, precisa criar as colunas

            carrinho.Columns.Add("Codigo", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preco", typeof(decimal));
            carrinho.Columns.Add("SubTotal", typeof(decimal));

            tabelaProdutos.DataSource = carrinho;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtqtdestoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            //Botão para adicionar no carrinho
            try
            {
                qtd = int.Parse(txtqtd.Text);
                preco = decimal.Parse(txtpreco.Text);

                subtotal = qtd * preco;
                total += subtotal;

                //Adicionar o produto no carrinho
                carrinho.Rows.Add(int.Parse(txtcodigo.Text), txtdescricao.Text, qtd, preco, subtotal);

                txttotal.Text = total.ToString();

                //limpar os campos
                txtcodigo.Clear();
                txtdescricao.Clear();
                txtqtd.Clear();
                txtpreco.Clear();

                txtcodigo.Focus();

            }
            catch (Exception )
            {

                MessageBox.Show($"Preencha os campos");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //13 significa enter
            {
                cliente = cdao.RetornarClientePorCpf(txtcpf.Text);
                if (cliente!=null)
                {
                    txtnome.Text = cliente.Nome;
                }
                else
                {
                    txtcpf.Clear();
                    txtcpf.Focus();
                }
                
                

            }

        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (e.KeyChar == 13)
                {
                    p = pdao.RetornarProdutoPorCodigo(int.Parse(txtcodigo.Text));
                if (p!=null)
                {
                    txtdescricao.Text = p.descricao;
                    txtpreco.Text = p.preco.ToString();
                }
                else
                {
                    txtcodigo.Clear();
                    txtcodigo.Focus();
                }
                   
                }
            
            
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            string senha_digitada, senha_correta;
            senha_correta = "021104";
            senha_digitada = txtsenhaExcluir.Text;

            if (senha_digitada==senha_correta)
            {
                decimal subproduto = decimal.Parse(tabelaProdutos.CurrentRow.Cells[4].Value.ToString());

                int indice = tabelaProdutos.CurrentRow.Index; // criando o indice
                DataRow linha = carrinho.Rows[indice];//criando a linha

                carrinho.Rows.Remove(linha);
                carrinho.AcceptChanges(); //Metodo que faz as alterações

                total -= subproduto;

                txttotal.Text = total.ToString();
                MessageBox.Show("Item excluido");
                txtsenhaExcluir.Clear();
            }
            else
            {
                MessageBox.Show("Acesso negado");
            }

        }

        private void Frmvendas_Load(object sender, EventArgs e)
        {
            //Pegando data atual

            txtdata.Text = DateTime.Now.ToShortDateString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnpagamento_Click(object sender, EventArgs e)
        {
            DateTime dataatual = DateTime.Parse(txtdata.Text);
            Frmpagamento tela = new Frmpagamento(cliente, carrinho, dataatual);

            tela.txttotal.Text = total.ToString();

            tela.ShowDialog(); //abre o formulario de pagamento, mas não consegue navegar entre os formularios
            //tela.Show(); consegue navegar
        }

        private void txtdata_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsenhaExcluir_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
