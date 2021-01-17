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
    public partial class frmPesquisaVenda : Form
    {
        public frmPesquisaVenda()
        {
            InitializeComponent();
        }
        PesquisaVendaDAL dal = new PesquisaVendaDAL();

        private void frmPesquisaVenda_Load(object sender, EventArgs e)
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
                string raaluno = txt_RA.Text;

                DataTable dt = dal.PesquisarRaAluno(raaluno);
                dgvVendas.DataSource = dt;
                dgvVendas.Columns[0].HeaderText = "ID";
                dgvVendas.Columns[1].HeaderText = "Fk_Lista";
                dgvVendas.Columns[2].HeaderText = "RA do Aluno";
                dgvVendas.Columns[3].HeaderText = "Nome do Aluno";
                dgvVendas.Columns[4].HeaderText = "Curso do Aluno";
                dgvVendas.Columns[5].HeaderText = "Usuário da Venda";
                dgvVendas.Columns[6].HeaderText = "Data da Venda";
                dgvVendas.Columns[7].HeaderText = "Subtotal";
                dgvVendas.Columns[8].HeaderText = "Desconto";
                dgvVendas.Columns[9].HeaderText = "Valor Pago";
                dgvVendas.Columns[10].HeaderText = "Troco";
                dgvVendas.Columns[11].HeaderText = "Valor Total";
                dgvVendas.Columns[12].HeaderText = "Observação";

                dgvVendas.Columns[0].Visible = false;
                dgvVendas.Columns[1].Visible = false;
            }
        }

        private void btn_PesquisarNome_Click(object sender, EventArgs e)
        {
            string nomealuno = txt_Nome.Text;

            DataTable dt = dal.PesquisarNomeAluno(nomealuno);
            dgvVendas.DataSource = dt;
            dgvVendas.Columns[0].HeaderText = "ID";
            dgvVendas.Columns[1].HeaderText = "Fk_Lista";
            dgvVendas.Columns[2].HeaderText = "RA do Aluno";
            dgvVendas.Columns[3].HeaderText = "Nome do Aluno";
            dgvVendas.Columns[4].HeaderText = "Curso do Aluno";
            dgvVendas.Columns[5].HeaderText = "Usuário da Venda";
            dgvVendas.Columns[6].HeaderText = "Data da Venda";
            dgvVendas.Columns[7].HeaderText = "Subtotal";
            dgvVendas.Columns[8].HeaderText = "Desconto";
            dgvVendas.Columns[9].HeaderText = "Valor Pago";
            dgvVendas.Columns[10].HeaderText = "Troco";
            dgvVendas.Columns[11].HeaderText = "Valor Total";
            dgvVendas.Columns[12].HeaderText = "Observação";

            dgvVendas.Columns[0].Visible = false;
            dgvVendas.Columns[1].Visible = false;
        }

        private void dgvVendas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int id = int.Parse(dgvVendas.Rows[rowIndex].Cells[0].Value.ToString());

            DataTable dt = dal.PesquisarLista(id);
            dgvLista.DataSource = dt;
            dgvLista.Columns[0].HeaderText = "ID";
            dgvLista.Columns[1].HeaderText = "Peças Vendidas";
            dgvLista.Columns[2].HeaderText = "Tamanhos Vendidas";
            dgvLista.Columns[3].HeaderText = "Preço da Peça";
            dgvLista.Columns[4].HeaderText = "Quantidade Vendida";
            dgvLista.Columns[5].HeaderText = "Usuário da Venda";

            dgvVendas.Columns[0].Visible = false;
        }
    }
}
