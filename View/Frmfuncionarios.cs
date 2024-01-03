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
    public partial class Frmfuncionarios : Form
    {
        public Frmfuncionarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Auxiliar().LimparTela(this);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            obj.Nome = txtnome.Text;
            obj.Rg = txtrg.Text;
            obj.Cpf = txtcpf.Text;
            obj.Email = txtemail.Text;
            obj.Senha = txtsenha.Text;
            obj.Cargo = cbcargo.SelectedItem.ToString();
            obj.Nivel_acesso = cbnivel.SelectedItem.ToString();
            obj.Telefone = txttelefone.Text;
            obj.Celular = txtcelular.Text;
            obj.Cep = txtcep.Text;
            obj.Endereco = txtendereco.Text;
            obj.Cidade = txtcidade.Text;
            obj.Estado = cbuf.SelectedItem.ToString();
            obj.Bairro = txtbairro.Text;
            obj.Numero = int.Parse(txtnumero.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.CadastrarFuncionario(obj);

            new Auxiliar().LimparTela(this);
           tabelafuncionario.DataSource =dao.ListarFuncionarios();
        }

        private void Frmfuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dAO = new FuncionarioDAO();
            tabelafuncionario.DataSource = dAO.ListarFuncionarios();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            obj.Codigo = int.Parse(txtcodigo.Text);

            FuncionarioDAO dAO = new FuncionarioDAO();
            dAO.ExcluirFuncionarios(obj);

            new Auxiliar().LimparTela(this);

            tabelafuncionario.DataSource = dAO.ListarFuncionarios();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            obj.Codigo = int.Parse(txtcodigo.Text);
            obj.Nome = txtnome.Text;
            obj.Rg = txtrg.Text;
            obj.Cpf = txtcpf.Text;
            obj.Email = txtemail.Text;
            obj.Senha = txtsenha.Text;
            obj.Cargo = cbcargo.SelectedItem.ToString();
            obj.Nivel_acesso = cbnivel.SelectedItem.ToString();
            obj.Telefone = txttelefone.Text;
            obj.Celular = txtcelular.Text;
            obj.Cep = txtcep.Text;
            obj.Endereco = txtendereco.Text;
            obj.Bairro = txtbairro.Text;
            obj.Cidade = txtcidade.Text;
            obj.Numero = int.Parse(txtnumero.Text);
            obj.Estado = cbuf.SelectedItem.ToString();
            
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.AlterarFuncionario(obj);

            tabelafuncionario.DataSource = dao.ListarFuncionarios();

        }

        private void tabelafuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelafuncionario.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelafuncionario.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelafuncionario.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelafuncionario.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = tabelafuncionario.CurrentRow.Cells[4].Value.ToString();
            txtsenha.Text = tabelafuncionario.CurrentRow.Cells[5].Value.ToString();
            cbcargo.Text = tabelafuncionario.CurrentRow.Cells[6].Value.ToString();
            cbnivel.Text = tabelafuncionario.CurrentRow.Cells[7].Value.ToString();
            txttelefone.Text = tabelafuncionario.CurrentRow.Cells[8].Value.ToString();
            txtcelular.Text = tabelafuncionario.CurrentRow.Cells[9].Value.ToString();  
            txtcep.Text = tabelafuncionario.CurrentRow.Cells[10].Value.ToString();
            txtendereco.Text = tabelafuncionario.CurrentRow.Cells[11].Value.ToString();
            txtnumero.Text = tabelafuncionario.CurrentRow.Cells[12].Value.ToString();
            txtbairro.Text = tabelafuncionario.CurrentRow.Cells[14].Value.ToString();
            txtcidade.Text = tabelafuncionario.CurrentRow.Cells[15].Value.ToString();         
            cbuf.Text = tabelafuncionario.CurrentRow.Cells[16].Value.ToString();



            tabFuncionarios.SelectedTab = tabPage1;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisar.Text;

            FuncionarioDAO dao = new FuncionarioDAO();
            tabelafuncionario.DataSource = dao.BuscarFuncionarioPorNome(nome);

            if(tabelafuncionario.Rows.Count==0)
            {
                MessageBox.Show("Funcionário não encontrado");
                tabelafuncionario.DataSource = dao.ListarFuncionarios();
            }
        }

        private void txtpesquisar_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisar.Text + "%";

            FuncionarioDAO dao = new FuncionarioDAO();
            tabelafuncionario.DataSource= dao.BuscarFuncionarioPorApx(nome);
        }

        private void btncep_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtcep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

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

        private void cbnivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
