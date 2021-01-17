using LojaDeUniforme.ClassesBLL;
using LojaDeUniforme.ClassesDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeUniforme.Telas
{
    public partial class frmAlunos : Form
    {
        public frmAlunos()
        {
            InitializeComponent();
        }
        AlunosBLL bll = new AlunosBLL();
        AlunosDAL dal = new AlunosDAL();
        UsuarioBLL UsuarioBLL = new UsuarioBLL();
        string UsuarioLogado = frmLogin.UsuarioLogado;

        private void Limpar()
        {
            txt_IDAlunos.Text = "";
            txt_Nome.Text = "";
            txt_RA.Text = "";
            txt_Curso.Text = "";
        }

        private void AtualizarTabela()
        {
            DataTable dt = dal.Select();
            dgvAlunos.DataSource = dt;
        }
        private void frmAlunos_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
            dgvAlunos.Columns[0].HeaderText = "ID";
            dgvAlunos.Columns[1].HeaderText = "RA";
            dgvAlunos.Columns[2].HeaderText = "Nome";
            dgvAlunos.Columns[3].HeaderText = "Curso";
            dgvAlunos.Columns[4].HeaderText = "Tipo de Usuário";
            dgvAlunos.Columns[5].HeaderText = "Data da Última Modificação";
        }
    

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            bll.ra = txt_RA.Text;
            bll.nome = txt_Nome.Text;
            bll.curso = txt_Curso.Text;
            bll.dataultimamodificacao = DateTime.Now;
            bll.usuarioultimamodificacao = UsuarioLogado;

            bool success = dal.Insert(bll);
            if (success == true)
            {
                MessageBox.Show("Aluno cadastrado com sucesso.", "OPERAÇÃO BEM-SUCEDIDA");
                Limpar();
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar esse aluno.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarTabela();
            Limpar();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (txt_IDAlunos.Text == "")
            {
                MessageBox.Show("Selecione um aluno para atualizá-lo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bll.id = Convert.ToInt32(txt_IDAlunos.Text);
                bll.nome = txt_Nome.Text;
                bll.ra = txt_RA.Text;
                bll.curso = txt_Curso.Text;
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
                Limpar();
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            if (txt_IDAlunos.Text == "")
            {
                MessageBox.Show("Selecione um usuário para deletá-lo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bll.id = Convert.ToInt32(txt_IDAlunos.Text);

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
                dgvAlunos.DataSource = dt;
            }
            else
            {
                AtualizarTabela();
            }
        }

        private void dgvAlunos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_IDAlunos.Text = dgvAlunos.Rows[rowIndex].Cells[0].Value.ToString();
            txt_RA.Text = dgvAlunos.Rows[rowIndex].Cells[1].Value.ToString();
            txt_Nome.Text = dgvAlunos.Rows[rowIndex].Cells[2].Value.ToString();
            txt_Curso.Text = dgvAlunos.Rows[rowIndex].Cells[3].Value.ToString();
        }
    }
}
