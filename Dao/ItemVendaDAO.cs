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
    public class ItemVendaDAO
    {
        private MySqlConnection conexao;
        public ItemVendaDAO()
        {
            this.conexao = new Connection().GetConnection();
        }
        #region Metodo Cadastrar Item
        public void CadastrarItemDeVenda(ItemVenda obj)
        {
            try
            {
                string sql = @"insert into tb_itensvendas(venda_id, produto_id, qtd, subtotal)
                          values (@venda_id, @produto_id, @qtd, @subtotal )";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@venda_id", obj.venda_id);
                executacmd.Parameters.AddWithValue("@produto_id", obj.produto_id);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtd);
                executacmd.Parameters.AddWithValue("@subtotal", obj.subTotal);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MessageBox.Show("Venda cadastrada com sucesso ");
                conexao.Close();                
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro " + e);
            }


        }
        #endregion

        #region Metodo que lista todos os itens por venda
        public DataTable ListarItensPorVenda(int venda_id)
        {
            try
            {
                DataTable tabelaItens = new DataTable();
                string sql = @"select 	i.id 		as 'Código',
		                                p.descricao as 'Descrição',
		                                i.qtd       as 'Quantidade',
                                        p.preco     as 'Preço',
                                        i.subtotal  as 'Subtotal'

                                from tb_itensvendas as i join
                                tb_produtos as p on(i.produto_id = p.id) where venda_id = @venda_id";

                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);
                executacmdsql.Parameters.AddWithValue("@venda_id", venda_id);

                conexao.Open();
                executacmdsql.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                da.Fill(tabelaItens);

                return tabelaItens;


            }
            catch (Exception e)
            {

                MessageBox.Show("Erro: " + e);
                return null;
            }
        }


        #endregion
    }
}
