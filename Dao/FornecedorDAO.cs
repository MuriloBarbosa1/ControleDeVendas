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
    public class FornecedorDAO
    {
        private MySqlConnection conexao;
        public FornecedorDAO() //construtor para fazer a conexao
        {
            this.conexao = new Connection().GetConnection();
        }

        #region Metodo Cadastrar Fornecedor
        public void cadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                //1- Definir o comando sql - insert into
                string sql = @"insert into tb_fornecedores(nome,cnpj,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                 values(@nome, @cnpj, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade,
                                 @estado)";
                //2- Organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.Cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.Celular);
                executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.Numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.Estado);
                executacmd.Parameters.AddWithValue("@cep", obj.Cep);

                //3- Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com sucesso");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Error: " + erro);
            }
        }
        #endregion
        #region Metodo Listar Fornecedores
        public DataTable listarFornecedores()
        {
            try
            {
                DataTable tabelaFornecedor = new DataTable();
                string sql = "select * from tb_fornecedores";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedor);

                conexao.Close();
                return tabelaFornecedor;
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro na listagem " + e);
                return null;
            }
        }
        #endregion
        #region Metodo Buscar Fornecedor por nome
        public DataTable buscarFornecedorPorNome(string nome)
        {
            try
            {
                DataTable tabelaFornecedor = new DataTable();
                string sql = "select * from tb_fornecedores where nome=@nome";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedor);

                conexao.Close();
                return tabelaFornecedor;
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro na busca de fornecedores " + e);
                return null;
            }
        }
        #endregion
        #region Metodo Listar Fornecedores por apx
        public DataTable listarFornecedoresPorNome(string nome)
        {
            try
            {
                DataTable tabelaFornecedor = new DataTable();
                string sql = "select * from tb_fornecedores where nome like @nome";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedor);

                conexao.Close();
                return tabelaFornecedor;
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro na listagem por nome " + e);
                return null;
            }
        }
        #endregion
        #region Metodo Alterar Fornecedor
        public void alterarFornecedor(Fornecedor obj)
        {
            try
            {
                //1- Definir o comando sql - insert into
                string sql = @"update tb_fornecedores set nome=@nome,cnpj=@cnpj,email=@email,telefone=@telefone,celular=@celular,cep=@cep,endereco=@endereco,
                             numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado where id=@codigo";

                //2- Organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.Cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.Celular);
                executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.Numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.Estado);
                executacmd.Parameters.AddWithValue("@cep", obj.Cep);
                executacmd.Parameters.AddWithValue("@codigo", obj.Codigo);

                //3- Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();//utilizado para executar instruções SQL que não retornam dados, como Insert,Update,Delete e Set.

                MessageBox.Show("Fornecedor alterado com sucesso");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Error na alterarção: " + erro);
            }
        }
        #endregion
        #region Metodo Excluir Fornecedor
        public void ExcluirFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"delete from tb_fornecedores where id=@codigo";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@codigo", obj.Codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor excluido com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro para excluir funcionario {erro}");
            }
        }
        #endregion
    }
}
