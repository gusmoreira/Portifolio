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
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }
        EstoqueBLL bll = new EstoqueBLL();
        EstoqueDAL dal = new EstoqueDAL();
        int QuantidadeAdicionar = 0;
        int QuantidadeAtual = 0;
        public void Limpar()
        {
            txt_IdUniforme.Text = "";
            txt_PecaDeUniforme.Text = "";
            txt_Tamanho.Text = "";
            txt_Quantidade.Text = "";
        }

        public void AtualizarTabela()
        {
            DataTable dt = dal.SelecionarEstoque();
            dgvEstoque.DataSource = dt;
        }
        private void frmEstoque_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
            dgvEstoque.Columns[0].HeaderText = "ID";
            dgvEstoque.Columns[1].HeaderText = "Peça";
            dgvEstoque.Columns[2].HeaderText = "Categoria";
            dgvEstoque.Columns[3].HeaderText = "Quantidade";
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (txt_IdUniforme.Text == "")
            {
                MessageBox.Show("Selecione uma peça para atualizar.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bll.id = Convert.ToInt32(txt_IdUniforme.Text);
                bll.peca = txt_PecaDeUniforme.Text;
                bll.tamanho = txt_Tamanho.Text;
                QuantidadeAdicionar = int.Parse(txt_Quantidade.Text);
                int QuantidadeFinal = QuantidadeAdicionar + QuantidadeAtual;
                bll.quantidade = QuantidadeFinal;


                bool success = dal.AdicionarEstoque(bll);
                if (success == true)
                {
                    MessageBox.Show("Estoque atualizado com sucesso.", "OPERAÇÃO BEM-SUCEDIDA");
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar o estoque.", "ERRO",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                AtualizarTabela();
            }
        }

        private void dgvEstoque_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_IdUniforme.Text = dgvEstoque.Rows[rowIndex].Cells[0].Value.ToString();
            txt_PecaDeUniforme.Text = dgvEstoque.Rows[rowIndex].Cells[1].Value.ToString();
            txt_Tamanho.Text = dgvEstoque.Rows[rowIndex].Cells[2].Value.ToString();
            QuantidadeAtual = int.Parse(dgvEstoque.Rows[rowIndex].Cells[3].Value.ToString());
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
