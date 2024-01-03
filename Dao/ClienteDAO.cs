using ControleDeVendasForm.Model;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System.Collections.Concurrent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ControleDeVendasForm.Conexao;
using System.Data;

namespace ControleDeVendasForm.Dao
{
    public class ClienteDAO
    {
        private MySqlConnection conexao;

        public object MysqlDatareader { get; private set; }

        public ClienteDAO() //construtor para fazer a conexao
        {
            this.conexao = new Connection().GetConnection();
        }


        //Cadastrar cliente
        #region CadastrarCliente
        public void cadastrarCliente(Cliente obj)
        {
            try
            {
                //1- Definir o comando sql - insert into
                string sql = @"insert into tb_clientes(nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                 values(@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade,
                                 @estado)";
                //2- Organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@rg", obj.Rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.Cpf);
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

                MessageBox.Show("Cliente cadastrado com sucesso");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Error: " + erro);
            }
        }
        #endregion
        #region AlterarCliente
        public void alterarCliente(Cliente obj)
        {
            try
            {
                //1- Definir o comando sql - insert into
                string sql = @"update tb_clientes set nome=@nome,rg=@rg,cpf=@cpf,email=@email,telefone=@telefone,celular=@celular,cep=@cep,
                endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado where id=@id";

                //2- Organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@rg", obj.Rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.Cpf);
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
                executacmd.Parameters.AddWithValue("@id", obj.Codigo);

                //3- Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente alterado com sucesso");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Error: " + erro);
            }
        }

        #endregion
        #region ExcluiCliente
        public void excluirCliente(Cliente obj)
        {
            try
            {
                //1- Definir o comando sql - insert into
                string sql = @"delete from tb_clientes where id=@id";

                //2- Organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.Codigo);

                //3- Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente excluido com sucesso");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Error: " + erro);
            }
        }
        #endregion
        #region listarCliente
        public DataTable listarCliente() //usar o DataTable quando trabalhar com lista no Sql
        {
            try
            {   //1- Criar o DataTable e o comando sql
                DataTable tabelaCliente = new DataTable();
                string sql = "select * from tb_clientes";

                //2- Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();
                //3 criar o MysqlDataAdpter para preencher o DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCliente); //fill=preencher
                conexao.Close();

                return tabelaCliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro na listagem: " + erro);
                return null;
            }
        }
        #endregion
        #region BuscasClientePorNome
        public DataTable BuscarClPorNome(string nome) //usar o DataTable quando trabalhar com lista no Sql
        {
            try
            {   //1- Criar o DataTable e o comando sql
                DataTable tabelaCliente = new DataTable();
                string sql = "select * from tb_clientes where nome = @nome";

                //2- Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                //Onde tem @nome substitui pela variavel nome
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                //3 criar o MysqlDataAdpter para preencher o DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCliente); //fill=preencher
                conexao.Close();

                return tabelaCliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro: " + erro);
                return null;
            }
        }

        #endregion
        #region ListarClientePorNome
        public DataTable ListarClPorNome(string nome) //usar o DataTable quando trabalhar com lista no Sql
        {
            try
            {   //1- Criar o DataTable e o comando sql
                DataTable tabelaCliente = new DataTable();
                string sql = "select * from tb_clientes where nome like @nome";

                //2- Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                //Onde tem @nome substitui pela variavel nome
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                //3 criar o MysqlDataAdpter para preencher o DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCliente); //fill=preencher
                conexao.Close();

                return tabelaCliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro: " + erro);
                return null;
            }
        }

        #endregion
        #region Retornar Cliente por Cpf
        public Cliente RetornarClientePorCpf(string cpf)
        {
            try
            {
                Cliente obj = new Cliente();
                string sql = @"select * from tb_clientes where cpf= @cpf";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cpf", cpf);

                conexao.Open(); 

                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    obj.Codigo = rs.GetInt32("id");
                    obj.Nome = rs.GetString("nome");
                    conexao.Close();

                    return obj;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado");
                    conexao.Close();
                    return null;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro na buscar " + e);
                conexao.Close();
                return null;
            }

        }
        #endregion

    }
}
