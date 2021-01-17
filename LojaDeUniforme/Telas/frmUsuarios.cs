using LojaDeUniforme.ClassesBLL;
using LojaDeUniforme.ClassesDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeUniforme.Telas
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        UsuarioBLL bll = new UsuarioBLL();
        UsuarioDAL dal = new UsuarioDAL();
        string UsuarioLogado = frmLogin.UsuarioLogado;
        private void Limpar()
        {
            txt_IdUsuario.Text = "";
            txt_Nome.Text = "";
            txt_NomeDeUsuario.Text = "";
            txt_Senha.Text = "";          
        }
        private void AtualizarTabela()
        {
            DataTable dt = dal.Select();
            dgvUsuarios.DataSource = dt;
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
            dgvUsuarios.Columns[0].HeaderText = "ID";
            dgvUsuarios.Columns[1].HeaderText = "Nome Completo";
            dgvUsuarios.Columns[2].HeaderText = "Nome De Usuário";
            dgvUsuarios.Columns[3].HeaderText = "Senha";
            dgvUsuarios.Columns[4].HeaderText = "Data da Última Modificação";
            dgvUsuarios.Columns[5].HeaderText = "Usuario da Última Modificação";

            dgvUsuarios.Columns[3].Visible = false;
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            bll.nome = txt_Nome.Text;
            bll.nomedeusuario = txt_NomeDeUsuario.Text;
            bll.senha = txt_Senha.Text;
            bll.dataultimamodificacao = DateTime.Now;
            bll.usuarioultimamodificacao = UsuarioLogado;

            bool success = dal.Insert(bll);
            if (success == true)
            {
                MessageBox.Show("Usuário cadastrado com sucesso.", "OPERAÇÃO BEM-SUCEDIDA");
                Limpar();
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar esse usuário.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarTabela();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (txt_IdUsuario.Text == "")
            {
                MessageBox.Show("Selecione um usuário para atualizá-lo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bll.id = Convert.ToInt32(txt_IdUsuario.Text);
                bll.nome = txt_Nome.Text;
                bll.nomedeusuario = txt_NomeDeUsuario.Text;
                bll.senha = txt_Senha.Text;
                bll.dataultimamodificacao = DateTime.Now;
                bll.usuarioultimamodificacao = UsuarioLogado;

                bool Success = dal.Update(bll);
                if (Success == true)
                {
                    MessageBox.Show("Usuário atualizado com sucesso.", "OPERAÇÃO BEM-SUCEDIDA");
                }
                else
                {
                    MessageBox.Show("Não foi possivel atualizar esse usuário.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                AtualizarTabela();
            }
        }

        private void dgvUsuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_IdUsuario.Text = dgvUsuarios.Rows[rowIndex].Cells[0].Value.ToString();
            txt_Nome.Text = dgvUsuarios.Rows[rowIndex].Cells[1].Value.ToString();
            txt_NomeDeUsuario.Text = dgvUsuarios.Rows[rowIndex].Cells[2].Value.ToString();
            txt_Senha.Text = dgvUsuarios.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            if (txt_IdUsuario.Text == "")
            {
                MessageBox.Show("Selecione um usuário para deletá-lo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bll.id = Convert.ToInt32(txt_IdUsuario.Text);

                bool Success = dal.Delete(bll);
                if (Success == true)
                {
                    MessageBox.Show("Usuário deletado com sucesso.", "OPERAÇÃO BEM-SUCEDIDA");
                }
                else
                {
                    MessageBox.Show("Não foi possivel deletar esse usuário", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Limpar();
                AtualizarTabela();
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            string keywords = txt_Pesquisa.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvUsuarios.DataSource = dt;
            }
            else
            {
                AtualizarTabela();
            }
        }
    }
}
