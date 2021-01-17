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
    public partial class frmUniformes : Form
    {
        public frmUniformes()
        {
            InitializeComponent();
        }
        UniformesBLL bll = new UniformesBLL();
        UniformesDAL dal = new UniformesDAL();
        CategoriasDeUniformesDAL CategoriasDeUniformesDAL = new CategoriasDeUniformesDAL();
        string UsuarioLogado = frmLogin.UsuarioLogado;

        private void frmUniformes_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
            dgvUniformes.Columns[0].HeaderText = "ID";
            dgvUniformes.Columns[1].HeaderText = "Peça";
            dgvUniformes.Columns[2].HeaderText = "Categoria";
            dgvUniformes.Columns[3].HeaderText = "Tamanho";
            dgvUniformes.Columns[4].HeaderText = "Preço";
            dgvUniformes.Columns[5].HeaderText = "Quantidade";
            dgvUniformes.Columns[6].HeaderText = "Data da Última Modificação";
            dgvUniformes.Columns[7].HeaderText = "Usuário da Última Modificação";
            DataTable categorias = CategoriasDeUniformesDAL.Select();
            cbx_Categoria.DataSource = categorias;
            cbx_Categoria.DisplayMember = "nome";
            cbx_Categoria.ValueMember = "nome";
        }

        public void Limpar()
        {
            txt_IdUniforme.Text = "";
            txt_PecaDeUniforme.Text = "";
            cbx_Tamanho.Text = "";
            txt_Preco.Text = "";
        }
        public void AtualizarTabela()
        {
            DataTable dt = dal.Select();
            dgvUniformes.DataSource = dt;
        }
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            bll.peca = txt_PecaDeUniforme.Text;
            bll.categoria = cbx_Categoria.Text;
            bll.preco = decimal.Parse(txt_Preco.Text);
            bll.tamanho = cbx_Tamanho.Text;
            bll.quantidade = 0;
            bll.dataultimamodificacao = DateTime.Now;
            bll.usuarioultimamodificacao = UsuarioLogado;

            bool success = dal.Insert(bll);
            if (success == true)
            {
                MessageBox.Show("Peça registrada com sucesso.", "OPERAÇÂO BEM-SUCEDIDO");
                Limpar();
            }
            else
            {
                MessageBox.Show("Não foi possível adicionar esse peça.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarTabela();
        }


        private void dgvUniformes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_IdUniforme.Text = dgvUniformes.Rows[rowIndex].Cells[0].Value.ToString();
            txt_PecaDeUniforme.Text = dgvUniformes.Rows[rowIndex].Cells[1].Value.ToString();
            cbx_Categoria.Text = dgvUniformes.Rows[rowIndex].Cells[2].Value.ToString();
            cbx_Tamanho.Text = dgvUniformes.Rows[rowIndex].Cells[3].Value.ToString();
            txt_Preco.Text = dgvUniformes.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (txt_IdUniforme.Text == "")
            {
                MessageBox.Show("Selecione uma peça para atualizar.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bll.id = Convert.ToInt32(txt_IdUniforme.Text);
                bll.peca = txt_PecaDeUniforme.Text;
                bll.categoria = cbx_Categoria.Text;
                bll.tamanho = cbx_Tamanho.Text;
                bll.preco = decimal.Parse(txt_Preco.Text);
                bll.quantidade = 0;
                bll.dataultimamodificacao = DateTime.Now;
                bll.usuarioultimamodificacao = UsuarioLogado;

                bool success = dal.Update(bll);
                if (success == true)
                {
                    MessageBox.Show("Peça atualizada com sucesso.", "OPERAÇÂO BEM-SUCEDIDO");
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar essa peça.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                AtualizarTabela();
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            if (txt_IdUniforme.Text == "")
            {
                MessageBox.Show("Selecione uma peça para deletar.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bll.id = Convert.ToInt32(txt_IdUniforme.Text);

                bool success = dal.Delete(bll);
                if (success == true)
                {
                    MessageBox.Show("Peça deletada com sucesso.", "OPERAÇÂO BEM-SUCEDIDO");
                }
                else
                {
                    MessageBox.Show("Não foi possível deletar a peça.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Limpar();
            AtualizarTabela();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            string keywords = txt_Pesquisa.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvUniformes.DataSource = dt;
            }
            else
            {
                AtualizarTabela();
            }
        }
    }
}
