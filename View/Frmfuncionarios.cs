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
        }
    }
}
