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
    class CategoriasDeUniformesDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        #region Select
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();

            try
            {
                //Pega os dados do banco
                String sql = "SELECT * FROM tb_CategoriasDeUniforme";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Adicionando o valor do adapter no datatable 
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
        #region Insert
        public bool Insert(CategoriasDeUniformesBLL bll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tb_CategoriasDeUniforme(nome, dataultimamodificacao, usuarioultimamodificacao) VALUES (@nome, @dataultimamodificacao, @usuarioultimamodificacao)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", bll.nome);
                cmd.Parameters.AddWithValue("@dataultimamodificacao", bll.dataultimamodificacao);
                cmd.Parameters.AddWithValue("@usuarioultimamodificacao", bll.usuarioultimamodificacao);

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
        #region Update
        public bool Update(CategoriasDeUniformesBLL bll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE  tb_CategoriasDeUniforme SET nome = @nome, dataultimamodificacao = @dataultimamodificacao , usuarioultimamodificacao = @usuarioultimamodificacao WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", bll.nome);
                cmd.Parameters.AddWithValue("@dataultimamodificacao", bll.dataultimamodificacao);
                cmd.Parameters.AddWithValue("@usuarioultimamodificacao", bll.usuarioultimamodificacao);
                cmd.Parameters.AddWithValue("@id", bll.id);

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
        #region Delete
        public bool Delete(CategoriasDeUniformesBLL bll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM tb_CategoriasDeUniforme WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("id", bll.id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = true;
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
        #region Search
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tb_CategoriasDeUniforme WHERE id LIKE '%" + keywords + "%' OR nome LIKE  '%" + keywords + "%'";
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
        #region Selecionar Atraves Do NomeDoUsuario
        public CategoriasDeUniformesBLL SelecionarAtravesDoNomeDoUsuario(string nomedeusuario)
        {
            CategoriasDeUniformesBLL bll = new CategoriasDeUniformesBLL();
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT nomedeusuario FROM tb_Usuarios WHERE nomedeusuario = '" + nomedeusuario + "' ";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    bll.usuarioultimamodificacao  = dt.Rows[0]["nomedeusuario"].ToString();
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
            return bll;
        }
        #endregion
    }
}
