using LojaDeUniforme.ClassesBLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeUniforme.ClassesDAL
{
    class CaixaDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        #region FiltrarPecas
        public DataTable FiltrarPecas(string categoria)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT peca FROM tb_Uniformes WHERE categoria LIKE '%" + categoria + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region FiltrarTamanhos
        public DataTable FiltrarTamanhos(string categoria, string peca)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT tamanho FROM tb_Uniformes WHERE categoria LIKE '%" + categoria + "%' AND peca LIKE '%" + peca + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region VerificarQuantidade
        public int VerificarQuantidade(string categoria,string peca ,string tamanho)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            int estoque = -1;
            try
            {
                String sql = "SELECT quantidade FROM tb_Uniformes WHERE categoria LIKE '%" + categoria + "%' AND peca LIKE '%" + peca + "%' AND tamanho LIKE '%" + tamanho + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                object o = cmd.ExecuteScalar();
                estoque = int.Parse(o.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return estoque;
        }
        #endregion
        #region Abater Quantidade
        public bool AbaterQuantidade(EstoqueBLL bll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE  tb_Uniformes SET peca = @peca, tamanho = @tamanho, quantidade = @quantidade WHERE peca = @peca and tamanho = @tamanho";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@peca", bll.peca);
                cmd.Parameters.AddWithValue("@tamanho", bll.tamanho);
                cmd.Parameters.AddWithValue("@quantidade", bll.quantidade);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
        #region Verificar Preco
        public decimal VerificarPreco(string categoria, string peca, string tamanho)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal preco = -1;
            try
            {
                String sql = "SELECT preco FROM tb_Uniformes WHERE categoria LIKE '%" + categoria + "%' AND peca LIKE '%" + peca + "%' AND tamanho LIKE '%" + tamanho + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                object o = cmd.ExecuteScalar();
                preco = decimal.Parse(o.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return preco;
        }
        #endregion
        #region Registrar Lista
        public bool InsertLista(CaixaBLL bLL)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tb_ListaDeProdutos(nomepeca, tamanhopeca, precopeca, quantidadepeca, valortotalpecaquantidade) VALUES (@nomepeca, @tamanhopeca, @precopeca, @quantidadepeca, @valortotalpecaquantidade)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nomepeca", bLL.peca);
                cmd.Parameters.AddWithValue("@tamanhopeca", bLL.tamanho);
                cmd.Parameters.AddWithValue("@precopeca", bLL.preco);
                cmd.Parameters.AddWithValue("@quantidadepeca", bLL.quantidade);
                cmd.Parameters.AddWithValue("@valortotalpecaquantidade", bLL.total);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }
            return isSuccess;
        }
        #endregion
        #region Selecionar ID da Lista
        public int IdLista(string peca, string tamanho, string preco, string quantidade)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            int id = 0;
            try
            {
                String sql = "SELECT id_lista FROM tb_ListadeProdutos WHERE nomepeca LIKE '%" + peca + "%' AND tamanhopeca LIKE '%" + tamanho + "%' AND precopeca LIKE '%" + preco + "%' AND quantidadepeca LIKE '%" + quantidade + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                object o = cmd.ExecuteScalar();
                id = int.Parse(o.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return id;
        }
        #endregion
        #region Registrar Venda
        public bool RegistrarVenda(CaixaBLL bLL)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tb_Vendas(fk_Lista, fk_RaAluno, fk_NomeAluno, fk_CursoAluno, fk_NomeUsuario, DataVenda, SubTotal, Desconto, ValorPago, Troco, ValorTotal, Observacao) VALUES (@fk_Lista, @fk_RaAluno, @fk_NomeAluno, @fk_CursoAluno, @fk_NomeUsuario, @DataVenda, @SubTotal, @Desconto, @ValorPago, @Troco, @ValorTotal, @Observacao)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@fk_Lista", bLL.fk_Lista);
                cmd.Parameters.AddWithValue("@Fk_RaAluno", bLL.Fk_RaAluno);
                cmd.Parameters.AddWithValue("@Fk_NomeAluno", bLL.Fk_NomeAluno);
                cmd.Parameters.AddWithValue("@Fk_CursoAluno", bLL.Fk_CursoAluno);
                cmd.Parameters.AddWithValue("@Fk_NomeUsuario", bLL.Fk_NomeUsuario);
                cmd.Parameters.AddWithValue("@DataVenda", bLL.DataVenda);
                cmd.Parameters.AddWithValue("@SubTotal", bLL.SubTotal);
                cmd.Parameters.AddWithValue("@Desconto", bLL.Desconto);
                cmd.Parameters.AddWithValue("@ValorPago", bLL.ValorPago);
                cmd.Parameters.AddWithValue("@Troco", bLL.Troco);
                cmd.Parameters.AddWithValue("@ValorTotal", bLL.ValorTotal);
                cmd.Parameters.AddWithValue("@Observacao", bLL.Observacao);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }
            return isSuccess;
        }
        #endregion
        #region Pesquisa por RA do aluno
        public DataTable PesquisarRaAluno(string ra)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT ra, nome, curso FROM tb_Alunos WHERE ra LIKE '%" + ra + "%' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region Pesquisa por nome do aluno
        public DataTable PesquisarNomeAluno(string nome)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT ra, nome, curso  FROM tb_Alunos WHERE nome LIKE '%" + nome + "%' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
    }
}
