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
    public partial class Frmfornecedores : Form
    {
        public Frmfornecedores()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtcelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtbairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncep_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtcep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();
                dados.ReadXml(xml);

                txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString(); //Rows = linhas
                txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                cbuf.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Endereço não encontrado, por favor digite manualmente");
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            Auxiliar ax=new Auxiliar();
            ax.LimparTela(this);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            obj.Nome=txtnome.Text;
            obj.Cnpj=txtcnpj.Text;
            obj.Email=txtemail.Text;
            obj.Telefone=txttelefone.Text;
            obj.Celular=txtcelular.Text;
            obj.Cep=txtcep.Text;
            obj.Endereco=txtendereco.Text;
            obj.Numero = int.Parse(txtnumero.Text);
            obj.Bairro=txtbairro.Text;
            obj.Cidade=txtcidade.Text;
            obj.Estado = cbuf.SelectedItem.ToString();

            FornecedorDAO dao = new FornecedorDAO();
            dao.cadastrarFornecedor(obj);

            new Auxiliar().LimparTela(this);

            tabelafornecedor.DataSource = dao.listarFornecedores();
        }

        private void tabelafornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frmfornecedores_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            tabelafornecedor.DataSource = dao.listarFornecedores();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();
            obj.Codigo = int.Parse(txtcodigo.Text);
            obj.Nome= txtnome.Text;
            obj.Cnpj=txtcnpj.Text;
            obj.Email = txtemail.Text;
            obj.Telefone = txttelefone.Text;
            obj.Celular = txtcelular.Text;
            obj.Cep = txtcep.Text;
            obj.Endereco = txtendereco.Text;
            obj.Cidade = txtcidade.Text;
            obj.Estado = cbuf.SelectedItem.ToString();
            obj.Bairro = txtbairro.Text;
            obj.Numero = int.Parse(txtnumero.Text);
            

            FornecedorDAO dao = new FornecedorDAO();
            dao.alterarFornecedor(obj);

            tabelafornecedor.DataSource = dao.listarFornecedores();
            Auxiliar ax= new Auxiliar();
            ax.LimparTela(this);
        }

        private void tabelafornecedor_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelafornecedor.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelafornecedor.CurrentRow.Cells[1].Value.ToString();
            txtcnpj.Text = tabelafornecedor.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = tabelafornecedor.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text = tabelafornecedor.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = tabelafornecedor.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text = tabelafornecedor.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text = tabelafornecedor.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text = tabelafornecedor.CurrentRow.Cells[8].Value.ToString();
            txtbairro.Text = tabelafornecedor.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text = tabelafornecedor.CurrentRow.Cells[11].Value.ToString();
            cbuf.Text = tabelafornecedor.CurrentRow.Cells[12].Value.ToString();

            tabForcenecedores.SelectedTab = tabPage1;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();
            obj.Codigo = int.Parse(txtcodigo.Text);

            FornecedorDAO dao = new FornecedorDAO();
            dao.ExcluirFornecedor(obj);

            Auxiliar ax =new Auxiliar();
            ax.LimparTela(this);

            tabelafornecedor.DataSource= dao.listarFornecedores();
        }

        private void txtpesquisar_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisar.Text + "%";
            FornecedorDAO dao = new FornecedorDAO();

            tabelafornecedor.DataSource = dao.buscarFornecedorPorNome(nome);
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisar.Text;

            FornecedorDAO dao = new FornecedorDAO();

            tabelafornecedor.DataSource=dao.listarFornecedoresPorNome(nome);

            if(tabelafornecedor.Rows.Count==0) //Rows Count = contagem de linha
            {
                tabelafornecedor.DataSource = dao.listarFornecedores();
            }
        }
    }
}
