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
    public partial class frmCategoriaDeUniformes : Form
    {
        public frmCategoriaDeUniformes()
        {
            InitializeComponent();
            AtualizarTabela();
        }
        CategoriasDeUniformesBLL bLL = new CategoriasDeUniformesBLL();
        CategoriasDeUniformesDAL dal = new CategoriasDeUniformesDAL();
        string UsuarioLogado = frmLogin.UsuarioLogado;

        private void AtualizarTabela()
        {
            DataTable dt = dal.Select();
            dgvCategorias.DataSource = dt;
        }
        private void Limpar()
        {
            txt_IdCategoria.Text = "";
            txt_NomeCategoria.Text = "";
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            bLL.nome = txt_NomeCategoria.Text;
            bLL.dataultimamodificacao = DateTime.Now;
            bLL.usuarioultimamodificacao = UsuarioLogado;

            bool success = dal.Insert(bLL);
            if (success == true)
            {
                MessageBox.Show("Categoria registrada com sucesso.", "OPERAÇÃO BEM-SUCEDIDA");
                Limpar();
            }
            else
            {
                MessageBox.Show("Não foi possível adicionar essa categoria.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Limpar();
            AtualizarTabela();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (txt_IdCategoria.Text == "")
            {
                MessageBox.Show("Selecione uma categoria para atualizar.","ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bLL.id = Convert.ToInt32(txt_IdCategoria.Text);
                bLL.nome = txt_NomeCategoria.Text;
                bLL.dataultimamodificacao = DateTime.Now;
                bLL.usuarioultimamodificacao = UsuarioLogado;

            }
            bool success = dal.Update(bLL);
            if (success == true)
            {
                MessageBox.Show("Categoria atualizada com sucesso.", "OPERAÇÃO BEM-SUCEDIDA");
            }
            else
            {
                MessageBox.Show("Não foi possível atualizar essa categoria.", "ERRO",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Limpar();
            AtualizarTabela();
        }

        private void dgvCategorias_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            txt_IdCategoria.Text = dgvCategorias.Rows[rowindex].Cells[0].Value.ToString();
            txt_NomeCategoria.Text = dgvCategorias.Rows[rowindex].Cells[1].Value.ToString();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            if (txt_IdCategoria.Text == "")
            {
                MessageBox.Show("Selecione uma categoria para deletar.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bLL.id = Convert.ToInt32(txt_IdCategoria.Text);

                bool success = dal.Delete(bLL);
                if (success == true)
                {
                    MessageBox.Show("Categoria deletada com sucesso.", "OPERAÇÃO BEM-SUCEDIDA");
                }
                else
                {
                    MessageBox.Show("Não foi possível deletar a categoria.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dgvCategorias.DataSource = dt;
            }
            else
            {
                AtualizarTabela();
            }
        }

        private void frmCategoriaDeUniformes_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
            dgvCategorias.Columns[0].HeaderText = "ID";
            dgvCategorias.Columns[1].HeaderText = "Nome";
            dgvCategorias.Columns[2].HeaderText = "Data da Última Modificação";
            dgvCategorias.Columns[3].HeaderText = "Usuário da Última Modificação";
        }
    }
}
