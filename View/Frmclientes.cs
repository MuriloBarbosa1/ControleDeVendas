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

        }
    }
}
