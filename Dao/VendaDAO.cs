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
    public class VendaDAO
    {
        private MySqlConnection conexao;

        public VendaDAO()
        {
            this.conexao = new Connection().GetConnection();
        }

        #region Metodo Cadastrar Venda
        public void CadastrarVenda(Venda obj)
        {
            try
            {
                string sql= @"insert into tb_vendas(cliente_id, data_venda, total_venda, observacoes)
                              values(@cliente_id, @data_venda, @total_venda, @obs)";

                MySqlCommand executacmd =new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cliente_id",obj.client_id);
                executacmd.Parameters.AddWithValue("@data_venda", obj.data_venda);
                executacmd.Parameters.AddWithValue("@total_venda", obj.total_venda);
                executacmd.Parameters.AddWithValue("@obs", obj.obs);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Venda feita com sucesso");
                conexao.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro: " + e);
            }
        }
        #endregion
        #region Metodo para retornar o ultimo Id de venda
        public int UltimoIdVenda()
        {
            try
            {
                int idvenda =0;
                string sql = @"select max(id) id from tb_vendas";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();
                if (rs.Read()) 
                {
                    idvenda = rs.GetInt32("id");
                    
                    
                }
                conexao.Close();
                return idvenda;

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro: " + e );
                conexao.Close();
                return 0;

            }
            

        }

        #endregion
        #region Metodo historico de venda
        /*public DataTable HistoricoVenda(DateTime datainicio, DateTime datafim)
        {
            try
            {
                // criar o comando sql
                DataTable tabelaHistorico = new DataTable();
                string sql = @"SELECT v.id          as 'Código',
	                                  v.data_venda  as 'Data da venda',
                                      c.nome        as 'Cliente',
                                      v.total_venda as 'Total',
                                      v.observacoes as 'Observações'

                              FROM tb_vendas as v join tb_clientes as c on (v.cliente_id = c.id)

                              WHERE v.data_venda between @datainicio and @datafim";

                //organizar e executar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@datainicio", datainicio);
                executacmd.Parameters.AddWithValue("@datafim", datafim);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySqlApter para preencher os dados no Datatable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaHistorico);

                
                
                return tabelaHistorico;
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro: " + e);
                return null;
            }
        }*/
        public DataTable listarVendasPorPeriodo(DateTime datainicio, DateTime datafim)
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();
                string sql = @"SELECT v.id          as 'Código',
	                                  v.data_venda  as 'Data da venda',
                                      c.nome        as 'Cliente',
                                      v.total_venda as 'Total',
                                      v.observacoes as 'Obs'

                              FROM tb_vendas as v join tb_clientes as c on (v.cliente_id = c.id)

                              WHERE v.data_venda between @datainicio and @datafim";

                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);
                executacmdsql.Parameters.AddWithValue("@datainicio", datainicio);
                executacmdsql.Parameters.AddWithValue("@datafim", datafim);

                conexao.Open();
                executacmdsql.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                da.Fill(tabelaHistorico);

                return tabelaHistorico;
                

            }
            catch (Exception e )
            {

                MessageBox.Show("Erro: " + e);
                return null;
            }
        }

        #endregion
        #region Metodo Listar Vendas
        /*public DataTable ListarVendas()
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();
                string sql = @"SELECT v.id as 'Código',
	                                  v.data_venda as 'Data da venda',
                                      c.nome as 'Cliente',
                                      v.total_venda as 'Total',
                                      v.observacoes as 'Observações'
                              FROM tb_vendas as v join tb_clientes as c on (v.cliente_id=c.id)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaHistorico);

                conexao.Close();
                

                return tabelaHistorico;

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro: " + e);
                return null;
            }
        }*/
        public DataTable ListarVendas()
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();
                string sql = @"SELECT v.id          as 'Código',
	                                  v.data_venda  as 'Data da venda',
                                      c.nome        as 'Cliente',
                                      v.total_venda as 'Total',
                                      v.observacoes as 'Obs'

                              FROM tb_vendas as v join tb_clientes as c on (v.cliente_id = c.id)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                // Remova a linha abaixo, pois ExecuteNonQuery não é necessário para consultas SELECT.
                // executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaHistorico);

                conexao.Close();

                return tabelaHistorico;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
                return null;
            }
        }

        #endregion 
    }
}
