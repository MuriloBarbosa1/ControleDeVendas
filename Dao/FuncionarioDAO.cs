using ControleDeVendasForm.Conexao;
using ControleDeVendasForm.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeVendasForm.Dao
{
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;
        public FuncionarioDAO() 
        {
            this.conexao = new Connection().GetConnection();
        }

        #region Cadastro de Funcionarios
        public void CadastrarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"insert into tb_funcionarios(nome,rg,cpf,email,senha,cargo,nivel_acesso,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                            values(@nome,@rg,@cpf,@email,@senha,@cargo,@nivel,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@rg", obj.Rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@senha", obj.Senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                executacmd.Parameters.AddWithValue("@nivel", obj.Nivel_acesso);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.Celular);
                executacmd.Parameters.AddWithValue("@cep", obj.Cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.Numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.Estado);
                

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario cadastrado com sucesso");
                conexao.Clone();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro:" + erro );
            }
        }

        #endregion
    }
}
