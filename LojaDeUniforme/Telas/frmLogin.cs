using LojaDeUniforme.ClassesBLL;
using LojaDeUniforme.ClassesDAL;
using LojaDeUniforme.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeUniforme
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        LoginBLL bll = new LoginBLL();
        LoginDAL dal = new LoginDAL();
        public static string UsuarioLogado;

        private void btn_Login_Click(object sender, EventArgs e)
        {
            bll.nomedeusuario = txt_NomeDeUsuario.Text.Trim();
            bll.senha = txt_Senha.Text.Trim();

            bool Success = dal.loginCheck(bll);
            if (Success == true)
            {
                UsuarioLogado = bll.nomedeusuario;
                MessageBox.Show("Usuário logado com sucesso.", "BEM-VINDO, " + UsuarioLogado + "!", MessageBoxButtons.OK);
                frmMenu frmMenu = new frmMenu();
                frmMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Não foi possível logar com este usuário. Verifique o nome de usuário e senha.", "ERRO", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }
    }
}
