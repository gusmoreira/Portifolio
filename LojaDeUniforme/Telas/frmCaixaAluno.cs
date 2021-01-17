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
    public partial class frmCaixaAluno : Form
    {
        public frmCaixaAluno()
        {
            InitializeComponent();
        }
        CaixaBLL bll = new CaixaBLL();
        CaixaDAL dal = new CaixaDAL();

        private void frmCaixaAluno_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_PesquisarRA_Click(object sender, EventArgs e)
        {
            if (txt_RA.Text == "")
            {
                MessageBox.Show("Digite algo no campo corresponde para realizar uma consulta.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ra = txt_RA.Text;

                DataTable dt = dal.PesquisarRaAluno(ra);
                dgvAlunos.DataSource = dt;
                dgvAlunos.Columns[0].HeaderText = "RA";
                dgvAlunos.Columns[1].HeaderText = "Nome";
                dgvAlunos.Columns[2].HeaderText = "Curso";
            }
        }

        private void btn_PesquisarNome_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text == "")
            {
                MessageBox.Show("Digite algo no campo corresponde para realizar uma consulta.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nome = txt_Nome.Text;

                DataTable dt = dal.PesquisarNomeAluno(nome);
                dgvAlunos.DataSource = dt;
                dgvAlunos.Columns[0].HeaderText = "RA";
                dgvAlunos.Columns[1].HeaderText = "Nome";
                dgvAlunos.Columns[2].HeaderText = "Curso";
            }
        }

        private void dgvAlunos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            
            string raaluno = dgvAlunos.Rows[rowIndex].Cells[0].Value.ToString();
            string nomealuno = dgvAlunos.Rows[rowIndex].Cells[1].Value.ToString();
            string cursoaluno = dgvAlunos.Rows[rowIndex].Cells[2].Value.ToString();
            frmCaixa frmCaixa = new frmCaixa(raaluno, nomealuno, cursoaluno);
            frmCaixa.Show();
            this.Close();
        }
    }
}
