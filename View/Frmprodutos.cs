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
    public partial class Frmprodutos : Form
    {
        public Frmprodutos()
        {
            InitializeComponent();
        }

        private void btncep_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void txtdescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabelaproduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelaproduto.CurrentRow.Cells[0].Value.ToString();
            txtdescricao.Text = tabelaproduto.CurrentRow.Cells[1].Value.ToString();
            txtpreco.Text = tabelaproduto.CurrentRow.Cells[2].Value.ToString();
            txtqtdestoque.Text = tabelaproduto.CurrentRow.Cells[3].Value.ToString();
            cbfornecedor.Text = tabelaproduto.CurrentRow.Cells[4].Value.ToString();

            tabProdutos.SelectedTab = tabPage1;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Frmprodutos_Load(object sender, EventArgs e)
        {
            FornecedorDAO f_dao = new FornecedorDAO();
            cbfornecedor.DataSource = f_dao.listarFornecedores();
            Auxiliar ax = new Auxiliar();
            cbfornecedor.DisplayMember = "nome"; //Especifica a coluna do banco de dados que sera mostrada
            cbfornecedor.ValueMember = "id"; //Especifica qual coluna o valor sera armazenado
            ax.LimparTela(this);

            ProdutoDAO dao = new ProdutoDAO();
            tabelaproduto.DataSource = dao.ListarProdutos();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtestoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();
            obj.descricao = txtdescricao.Text;
            obj.preco=decimal.Parse(txtpreco.Text);
            obj.qtdestoque=int.Parse(txtqtdestoque.Text);
            obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());

            ProdutoDAO dao = new ProdutoDAO();
            dao.CadastrarProdutos(obj);
            new Auxiliar().LimparTela(this);

            tabelaproduto.DataSource=dao.ListarProdutos();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Auxiliar().LimparTela(this);
        }

        private void cbfornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();
            obj.id = int.Parse(txtcodigo.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.ExcluirProdutos(obj);

            new Auxiliar().LimparTela(this);
            tabelaproduto.DataSource = dao.ListarProdutos();

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.id = int.Parse(txtcodigo.Text);
            obj.descricao=txtdescricao.Text;
            obj.preco = decimal.Parse(txtpreco.Text);
            obj.qtdestoque = int.Parse(txtqtdestoque.Text);
            obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());

            ProdutoDAO dao = new ProdutoDAO();
            dao.AlterarProdutos(obj);

            new Auxiliar().LimparTela(this);
            tabelaproduto.DataSource = dao.ListarProdutos();

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisar.Text;

            ProdutoDAO dao = new ProdutoDAO();
            tabelaproduto.DataSource = dao.BuscarProdutoPorNome(nome);

            if(tabelaproduto.Rows.Count==0)
            {
                MessageBox.Show("Produto não encostrado");
                tabelaproduto.DataSource = dao.ListarProdutos();
            }
        }

        private void txtpesquisar_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisar.Text + "%";

            ProdutoDAO dao = new ProdutoDAO();
           tabelaproduto.DataSource = dao.BuscarProdutoPorApx(nome);
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
