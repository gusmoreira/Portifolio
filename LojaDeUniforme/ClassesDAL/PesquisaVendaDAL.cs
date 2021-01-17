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
    class PesquisaVendaDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        #region PesquisarRaAluno
        public DataTable PesquisarRaAluno(string raaluno)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dataTable = new DataTable();
            try
            {
                String sql = "SELECT * FROM tb_Vendas WHERE fk_RaAluno LIKE '%" + raaluno + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }
        #endregion

        #region PesquisarNomeAluno
        public DataTable PesquisarNomeAluno(string nomealuno)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dataTable = new DataTable();
            try
            {
                String sql = "SELECT * FROM tb_Vendas WHERE fk_NomeAluno LIKE '%" + nomealuno + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }
        #endregion

        #region PesquisarLista
        public DataTable PesquisarLista(int id)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dataTable = new DataTable();
            try
            {
                String sql = "SELECT * FROM tb_ListadeProdutos WHERE id_lista LIKE '%" + id + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }
        #endregion
    }
}
