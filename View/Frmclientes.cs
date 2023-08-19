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
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }
        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            tabelacliente.DataSource = dao.listarCliente();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //1 PASSO - RECEBER OS DADOS DENTRO OBJETO CLIENTE
            Cliente obj = new Cliente();
            obj.Nome = txtnome.Text;
            obj.Rg=txtrg.Text;
            obj.Cpf=txtcpf.Text;
            obj.Email=txtemail.Text;
            obj.Telefone=txttelefone.Text;
            obj.Celular=txtcelular.Text;
            obj.Cep=txtcep.Text;
            obj.Endereco=txtendereco.Text;
            obj.Cidade=txtcidade.Text;
            obj.Estado = cbuf.Text;
            obj.Bairro=txtbairro.Text;
            obj.Numero = int.Parse(txtnumero.Text);
            

            //2 PASSO - CRIAR UM OBJETO DA CLASSE CLIENTEDAO E CHAMAR O METODO CADASTRACLIENTE

            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            //Salva e lista os novos clientes
            tabelacliente.DataSource = dao.listarCliente();
        }

        private void tabelacliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //1 pegar os dados da linha selecionada
            txtcodigo.Text = tabelacliente.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelacliente.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelacliente.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelacliente.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = tabelacliente.CurrentRow.Cells[4].Value.ToString();
            txttelefone.Text = tabelacliente.CurrentRow.Cells[5].Value.ToString();
            txtcelular.Text = tabelacliente.CurrentRow.Cells[6].Value.ToString();
            txtcep.Text = tabelacliente.CurrentRow.Cells[7].Value.ToString();
            txtendereco.Text = tabelacliente.CurrentRow.Cells[8].Value.ToString();
            txtnumero.Text = tabelacliente.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text = tabelacliente.CurrentRow.Cells[11].Value.ToString();
            txtcidade.Text = tabelacliente.CurrentRow.Cells[12].Value.ToString();
            cbuf.Text = tabelacliente.CurrentRow.Cells[13].Value.ToString();


            tabClientes.SelectedTab = tabPage1;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //botão excluir
            Cliente obj = new Cliente();

            obj.Codigo = int.Parse(txtcodigo.Text);

            ClienteDAO dao = new ClienteDAO(); 
            dao.excluirCliente(obj);

            tabelacliente.DataSource = dao.listarCliente();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            //1 PASSO - RECEBER OS DADOS DENTRO OBJETO CLIENTE
            Cliente obj = new Cliente();
            obj.Nome = txtnome.Text;
            obj.Rg = txtrg.Text;
            obj.Cpf = txtcpf.Text;
            obj.Email = txtemail.Text;
            obj.Telefone = txttelefone.Text;
            obj.Celular = txtcelular.Text;
            obj.Cep = txtcep.Text;
            obj.Endereco = txtendereco.Text;
            obj.Cidade = txtcidade.Text;
            obj.Estado = cbuf.Text;
            obj.Bairro = txtbairro.Text;
            obj.Numero = int.Parse(txtnumero.Text);
            obj.Codigo = int.Parse(txtcodigo.Text);

            //2 PASSO - CRIAR UM OBJETO DA CLASSE CLIENTEDAO E CHAMAR O METODO  ALTERARCLIENTE

            ClienteDAO dao = new ClienteDAO();
            dao.alterarCliente(obj);

            tabelacliente.DataSource = dao.listarCliente();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            //Botão pesquisar

            string nome = txtpesquisa.Text;

            ClienteDAO dao = new ClienteDAO();
            tabelacliente.DataSource = dao.BuscarClPorNome(nome);

            //Rows = linhas Count= contagem 
            if(tabelacliente.Rows.Count == 0)
            {
                tabelacliente.DataSource = dao.listarCliente();
            }
        }

        private void txtpesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";
            ClienteDAO dao = new ClienteDAO();
            tabelacliente.DataSource = dao.ListarClPorNome(nome);

            //Rows = linhas Count= contagem 
            if (tabelacliente.Rows.Count == 0)
            {
                tabelacliente.DataSource = dao.listarCliente();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e) //Buscar o cep pela api
        {
            try
            {
                string cep=txtcep.Text;
                string xml = "https://viacep.com.br/ws/"+cep+"/xml/";

                DataSet dados = new DataSet(); //Recebe e faz a requisição da Api

                dados.ReadXml(xml);//ler a Xml

                //Completar os campos com as informações da api
                txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString(); //Rows = linhas
                txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                cbuf.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Cep não enconstrado");
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            /*Auxiliar ax = new Auxiliar();
            ax.LimparTela(this);*/
            new Auxiliar().LimparTela(this); //This: Especifica qual tela limpar(essa)
        }
    }
}
