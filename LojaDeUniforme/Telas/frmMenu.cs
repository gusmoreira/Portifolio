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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.Show();
        }

        private void btn_Categorias_Click(object sender, EventArgs e)
        {
            frmCategoriaDeUniformes frmCategoriaDeUniformes = new frmCategoriaDeUniformes();
            frmCategoriaDeUniformes.Show();
        }

        private void btn_Uniformes_Click(object sender, EventArgs e)
        {
            frmUniformes frmUniformes = new frmUniformes();
            frmUniformes.Show();
        }

        private void btn_Estoque_Click(object sender, EventArgs e)
        {
            frmEstoque frmEstoque = new frmEstoque();
            frmEstoque.Show();
        }

        private void btn_Caixa_Click(object sender, EventArgs e)
        {
            frmCaixaAluno frmCaixaAluno = new frmCaixaAluno();
            frmCaixaAluno.Show();
        }

        private void btn_Alunos_Click(object sender, EventArgs e)
        {
            frmAlunos frmAlunos = new frmAlunos();
            frmAlunos.Show();
        }

        private void btn_PesquisarVendas_Click(object sender, EventArgs e)
        {
            frmPesquisaVenda frmPesquisaVenda = new frmPesquisaVenda();
            frmPesquisaVenda.Show();
        }
    }
}
