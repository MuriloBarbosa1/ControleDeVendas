using ControleDeVendasForm.Conexao;
using ControleDeVendasForm.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

        #region Metodo Cadastrar funcionarios
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
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro:" + erro);
            }
        }

        #endregion
        #region Metodo Alterar funcionarios
        public void AlterarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"update tb_funcionarios set nome=@nome,rg=@rg,cpf=@cpf,email=@email,senha=@senha,cargo=@cargo,nivel_acesso=@nivel,telefone=@telefone,
                             celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado where id=@codigo";

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
                executacmd.Parameters.AddWithValue("@codigo", obj.Codigo);


                conexao.Open();
                executacmd.ExecuteNonQuery(); //é utilizado para executar instruções SQL que não retornam dados, como Insert,Update,Delete e Set.

                MessageBox.Show("Funcionario editado com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro na alteração de funcionario {erro}");
            }
        }
        #endregion
        #region Metodo Excluir funcionarios
        public void ExcluirFuncionarios(Funcionario obj)
        {
            try
            {
                string sql = @"delete from tb_funcionarios where id=@codigo";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@codigo", obj.Codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario excluido com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro para excluir funcionario {erro}");
            }
        }
        #endregion
        #region Metodo Buscar funcionarios por nome

        public DataTable BuscarFuncionarioPorNome(string nome)
        {
            try
            {
                DataTable tabelaFuncionario = new DataTable();
                string sql = "select * from tb_funcionarios where nome=@nome";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncionario);
                conexao.Close();

                return tabelaFuncionario;
            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro na busca de funcionarios: {erro}");
                return null;
            }

        }
        #endregion
        #region Metodo buscar funcionarios por apx
        public DataTable BuscarFuncionarioPorApx(string nome)
        {
            try
            {
                DataTable tabelaFuncionario = new DataTable();
                string sql = "select * from tb_funcionarios where nome like @nome";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncionario);
                conexao.Close();

                return tabelaFuncionario;
            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro na listagem: {erro}");
                return null;
            }
        }
            #endregion
        #region Metodo Listar funcionarios
            public DataTable ListarFuncionarios()
        {
            try
            {
                DataTable tabelaFuncionario = new DataTable();
                string sql = "select * from tb_funcionarios";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncionario);
                conexao.Close();

                return tabelaFuncionario;
            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro na listagem: {erro}");
                return null;
            }
        }

        #endregion
    }
}
