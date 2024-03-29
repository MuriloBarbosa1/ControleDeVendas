﻿using ControleDeVendasForm.Conexao;
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
    public class ProdutoDAO
    {
        private MySqlConnection conexao;

        public ProdutoDAO()
        {
            this.conexao = new Connection().GetConnection();
        }

        #region Metodo Cadastrar Produto
        public void CadastrarProdutos(Produto obj)
        {
            try
            {
                string sql = @"insert into tb_produtos(descricao, preco, qtd_estoque, for_id)
                             values(@descricao, @preco, @qtd_estoque, @for_id)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.qtdestoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso");
                conexao.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro no cadastro de produto: " + e);
            }
        }
        #endregion
        #region Metodo Listar Produtos
        public DataTable ListarProdutos()
        {
            try
            {
                //criar o comando sql
                DataTable tabelaProduto = new DataTable();
                string sql = @"select tb_produtos.id as 'Codigo',
                             tb_produtos.descricao as 'Descrição',
                             tb_produtos.preco as 'Preço',
                             tb_produtos.qtd_estoque as 'Estoque',
                             tb_fornecedores.nome as 'Fornecedor' from tb_produtos join tb_fornecedores on (tb_produtos.for_id = tb_fornecedores.id)";

                //organizar e executar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySqlApter para preencher os dados no Datatable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

                conexao.Close();
                return tabelaProduto;
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro na listagem de produto " + e);
                return null;
            }
        }
        #endregion
        #region Metodo Excluir Produtos
        public void ExcluirProdutos(Produto obj)
        {
            try
            {
                string str = "delete from tb_produtos where id=@id";
                MySqlCommand executecmd = new MySqlCommand(str, conexao);

                executecmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executecmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluido com sucesso");
                conexao.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro na exclusão do item: " + e);
            }

        }
        #endregion
        #region Metodo Alterar Produtos
        public void AlterarProdutos(Produto obj)
        {
            try
            {
                string str = "update tb_produtos set descricao=@descricao, preco=@preco, qtd_estoque=@qtd_estoque,for_id=@for_id where id=@id";
                MySqlCommand executecmd = new MySqlCommand(str, conexao);
                executecmd.Parameters.AddWithValue("@id", obj.id);
                executecmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executecmd.Parameters.AddWithValue("@preco", obj.preco);
                executecmd.Parameters.AddWithValue("@qtd_estoque", obj.qtdestoque);
                executecmd.Parameters.AddWithValue("@for_id", obj.for_id);

                conexao.Open();
                executecmd.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucesso");
                conexao.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro na alteração do produto: " + e);
            }
        }
        #endregion
        #region Metodo Buscar Produtos por nome
        public DataTable BuscarProdutoPorNome(string nome)
        {
            try
            {
                DataTable nomeprodutos = new DataTable();
                string str = @"select tb_produtos.id as 'Codigo',
                             tb_produtos.descricao as 'Descrição',
                             tb_produtos.preco as 'Preço',
                             tb_produtos.qtd_estoque as 'Estoque',
                             tb_fornecedores.nome as 'Fornecedor' from tb_produtos join tb_fornecedores on (tb_produtos.for_id = tb_fornecedores.id)
                             where tb_produtos.descricao=@nome";

                MySqlCommand executecmd = new MySqlCommand(str, conexao);
                executecmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executecmd.ExecuteNonQuery();


                MySqlDataAdapter da = new MySqlDataAdapter(executecmd); //DataAdapter aumento o desempenho ao se conectar com o data base
                da.Fill(nomeprodutos);//preenche todos os valores do array a partir do índice inicial a um índice final com um valor estático
                conexao.Close();

                return nomeprodutos;

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro na busca de produto: " + e);
                return null;
            }

        }
        #endregion
        #region Metodo Buscar Produtos por Apx    
        public DataTable BuscarProdutoPorApx(string nome)
        {
            try
            {
                DataTable nomeprodutos = new DataTable();
                string str = @"select tb_produtos.id as 'Codigo',
                             tb_produtos.descricao as 'Descrição',
                             tb_produtos.preco as 'Preço',
                             tb_produtos.qtd_estoque as 'Estoque',
                             tb_fornecedores.nome as 'Fornecedor' from tb_produtos join tb_fornecedores on (tb_produtos.for_id = tb_fornecedores.id)
                             where tb_produtos.descricao like @nome";

                MySqlCommand executecmd = new MySqlCommand(str, conexao);
                executecmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executecmd.ExecuteNonQuery();


                MySqlDataAdapter da = new MySqlDataAdapter(executecmd); //DataAdapter aumento o desempenho ao se conectar com o data base
                da.Fill(nomeprodutos);//preenche todos os valores do array a partir do índice inicial a um índice final com um valor estático
                conexao.Close();

                return nomeprodutos;

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro na busca de produto: " + e);
                return null;
            }
        }
        #endregion 
        #region Metodo Retornar Produto por codigo
        public Produto RetornarProdutoPorCodigo(Int64 id)
        {
            try
            {
                string sql = @"select * from tb_produtos where id = @id";

                MySqlCommand executecmd = new MySqlCommand(sql, conexao);
                executecmd.Parameters.AddWithValue("@id", id);
                conexao.Open();

                MySqlDataReader rs = executecmd.ExecuteReader();

                if (rs.Read())
                {
                    Produto p = new Produto();
                    p.id = rs.GetInt32("id");
                    p.descricao = rs.GetString("descricao");
                    p.preco = rs.GetDecimal("preco");
                    conexao.Close();
                    return p;
                }
                else
                {
                    MessageBox.Show("Produto não enconstrado");
                    conexao.Close();
                    return null;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro na busca: " + e);
                conexao.Close();
                return null;
            }
        }
        #endregion
        #region Metodo Baixa no estoque
        public void BaixaNoEstoque(int qtdestoque, int idproduto)
        {
            try
            {
                string sql = @"update tb_produtos set qtd_estoque = @qtd where id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                  
                executacmd.Parameters.AddWithValue("@qtd", qtdestoque);
                executacmd.Parameters.AddWithValue("@id", idproduto);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                 
                conexao.Close();
            }
            catch (Exception e )
            {

                MessageBox.Show("Erro " + e);
                conexao.Close();
            }
        }
        #endregion
        #region Metodo Retorna o Estoque atual
        public int RetornaEstoqueAtual(int idProduto)
        {
            try
            {
                string sql = @"select qtd_estoque from tb_produtos where id =@id";
                int qtd_estoque = 0;

                MySqlCommand exeutacmd = new MySqlCommand (sql, conexao);
                exeutacmd.Parameters.AddWithValue("@id", idProduto);

                conexao.Open();

                MySqlDataReader rs = exeutacmd.ExecuteReader();

                if (rs.Read())
                {
                    qtd_estoque = rs.GetInt32("qtd_estoque");
                    conexao.Close();
                }
                return qtd_estoque;

                
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro" + e);
                return 0;
            }
            
        }

        #endregion

    }
}
