using LojaDeUniforme.ClassesBLL;
using LojaDeUniforme.ClassesDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeUniforme.Telas
{
    public partial class frmCaixa : Form
    {
        CaixaDAL dal = new CaixaDAL();
        CaixaBLL bll = new CaixaBLL();
        EstoqueBLL EstoqueBLL = new EstoqueBLL();
        CategoriasDeUniformesDAL CategoriasDeUniformesDAL = new CategoriasDeUniformesDAL();
        frmCaixaAluno frmCaixaAluno = new frmCaixaAluno();
        string UsuarioLogado = frmLogin.UsuarioLogado;

        string categoria = null;
        string peca = null;
        string tamanho = null;
        int quantidade = 0;
        decimal preco = 0;
        decimal total = 0;
        decimal subTotal = 0;
        int quantidadeatual = 0;
        DataTable produto = new DataTable();
        public frmCaixa()
        {
            InitializeComponent();
        }
        public frmCaixa(string raaluno, string nomealuno, string cursoaluno)
        {
            InitializeComponent();
            txt_RA.Text = raaluno;
            txt_Nome.Text = nomealuno;
            txt_Curso.Text = cursoaluno;
        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {
            DataTable categorias = CategoriasDeUniformesDAL.Select();
            cbx_Categoria.DataSource = categorias;
            cbx_Categoria.DisplayMember = "nome";
            cbx_Categoria.ValueMember = "nome";
            cbx_Categoria.Text = null;
            cbx_Peca.Text = null;
            cbx_Tamanho.Text = null;

            cbx_Peca.DataSource = null;
            cbx_Tamanho.DataSource = null;

            produto.Columns.Add("Categoria Uniforme");
            produto.Columns.Add("Nome Uniforme");
            produto.Columns.Add("Tamanho");
            produto.Columns.Add("Preço");
            produto.Columns.Add("Quantidade");
            produto.Columns.Add("Total");

            dgvLista.DataSource = produto;
        }
        private void btn_PesquisarAluno_Click_1(object sender, EventArgs e)
        {
            frmCaixaAluno.Show();
            this.Close();
        }
        #region Produtos
        private void cbx_Categoria_TextChanged(object sender, EventArgs e)
        {
            categoria = cbx_Categoria.Text;
            DataTable pecas = dal.FiltrarPecas(categoria);
            cbx_Peca.DataSource = pecas;
            cbx_Peca.DisplayMember = "peca";
            cbx_Peca.ValueMember = "peca";

            cbx_Peca.Text = null;
            cbx_Tamanho.DataSource = null;
        }
        private void cbx_Peca_TextChanged(object sender, EventArgs e)
        {
            categoria = cbx_Categoria.Text;
            peca = cbx_Peca.Text;
            DataTable tamanhos = dal.FiltrarTamanhos(categoria, peca);
            cbx_Tamanho.DataSource = tamanhos;
            cbx_Tamanho.DisplayMember = "tamanho";
            cbx_Tamanho.ValueMember = "tamanho";

            cbx_Tamanho.Text = null;
        }
        #endregion
        #region Lista de Produtos
        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (tamanho == "")
            {
                MessageBox.Show("Favor selecione o produto corretamente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txt_Quantidade.Text == "")
            {
                MessageBox.Show("Favor selecione a quantidade corretamente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                      
            
            else
            {
                categoria = cbx_Categoria.Text;
                peca = cbx_Peca.Text;
                tamanho = cbx_Tamanho.Text;
                preco = dal.VerificarPreco(categoria, peca, tamanho);
                quantidade = int.Parse(txt_Quantidade.Text);
                quantidadeatual = dal.VerificarQuantidade(categoria, peca, tamanho);
                if (quantidade > quantidadeatual)
                {
                    MessageBox.Show("A quantidade inserida para a peça " + peca + " excede a presente no estoque.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                int quantidadeFinal = quantidadeatual - quantidade;
                total = preco * quantidade;

                produto.Rows.Add(categoria, peca, tamanho, preco, quantidade, total);
                dgvLista.DataSource = produto;

                txt_SubTotal.Text = subTotal.ToString();

                cbx_Categoria.Text = null;
                cbx_Peca.Text = null;
                cbx_Tamanho.Text = null;

                cbx_Peca.DataSource = null;
                cbx_Tamanho.DataSource = null;


                CalcularSubtotal();
            }
        }
        public int VerificarQuantidade()
        {
            categoria = cbx_Categoria.Text;
            peca = cbx_Peca.Text;
            tamanho = cbx_Tamanho.Text;
            return dal.VerificarQuantidade(categoria, peca, tamanho);
        }
        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            dgvLista.Rows.Remove(dgvLista.CurrentRow);
            CalcularSubtotal();
        }
        public int ArmazenarLista()
        {
            string[] vs = new string[dgvLista.Rows.Count];
            List<string> lista = new List<string>();
            StringBuilder builder = new StringBuilder();

            #region Armazena a categoria das peças
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                foreach (DataGridViewColumn col in dgvLista.Columns)
                {
                    vs[row.Index] = dgvLista.Rows[row.Index].Cells[0].Value.ToString();
                }
            }
            #endregion
            #region Armazena o nome das peças
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                foreach (DataGridViewColumn col in dgvLista.Columns)
                {
                    vs[row.Index] = dgvLista.Rows[row.Index].Cells[1].Value.ToString();
                }
            }
            lista.Clear();
            foreach (string item in vs)
            {
                lista.Add(item);
            }

            foreach (string item in lista)
            {
                builder.Append(item).Append(" | ");
            }
            string peca = builder.ToString();
            bll.peca = peca;
            #endregion

            #region Armazena os tamanhos
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                foreach (DataGridViewColumn col in dgvLista.Columns)
                {
                    vs[row.Index] = dgvLista.Rows[row.Index].Cells[2].Value.ToString();
                }
            }
            lista.Clear();
            foreach (string item in vs)
            {
                lista.Add(item);
            }

            builder = new StringBuilder();
            foreach (string item in lista)
            {
                builder.Append(item).Append(" | ");
            }
            string tamanho = builder.ToString();
            bll.tamanho = tamanho;
            #endregion

            #region Armazena os valores/unidade
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                foreach (DataGridViewColumn col in dgvLista.Columns)
                {
                    vs[row.Index] = dgvLista.Rows[row.Index].Cells[3].Value.ToString();
                }
            }
            lista.Clear();
            foreach (string item in vs)
            {
                lista.Add(item);
            }

            builder = new StringBuilder();
            foreach (string item in lista)
            {
                builder.Append(item).Append(" | ");
            }
            string preco = builder.ToString();
            bll.preco = preco;
            #endregion

            #region Armazena a quantidade
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                foreach (DataGridViewColumn col in dgvLista.Columns)
                {
                    vs[row.Index] = dgvLista.Rows[row.Index].Cells[4].Value.ToString();
                }
            }
            lista.Clear();
            foreach (string item in vs)
            {
                lista.Add(item);
            }

            builder = new StringBuilder();
            foreach (string item in lista)
            {
                builder.Append(item).Append(" | ");
            }
            string quantidade = builder.ToString();
            bll.quantidade = quantidade;

            #endregion

            #region Armazena o valor total da preco/unidade * quantidade
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                foreach (DataGridViewColumn col in dgvLista.Columns)
                {
                    vs[row.Index] = dgvLista.Rows[row.Index].Cells[5].Value.ToString();
                }
            }
            lista.Clear();

            foreach (string item in vs)
            {
                lista.Add(item);
            }

            builder = new StringBuilder();
            foreach (string item in lista)
            {
                builder.Append(item).Append(" | ");
            }
            string valortotal = builder.ToString();
            bll.total = valortotal;
            #endregion

            bool success = dal.InsertLista(bll);

            int id = dal.IdLista(peca, tamanho, preco, quantidade);
            return id;
        }
        public void AbaterQuantidade()
        {
            string[,] vs = new string[dgvLista.Rows.Count, dgvLista.Columns.Count];
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                foreach (DataGridViewColumn col in dgvLista.Columns)
                {
                    vs[row.Index, col.Index] = dgvLista.Rows[row.Index].Cells[col.Index].Value.ToString();
                }
            }

            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                categoria = vs[row.Index, 0];
                peca = vs[row.Index, 1];
                tamanho = vs[row.Index, 2];
                quantidadeatual = dal.VerificarQuantidade(categoria, peca, tamanho);
                quantidade = int.Parse(vs[row.Index, 4]);
                try
                {
                    if (quantidade > quantidadeatual)
                    {
                        MessageBox.Show("A quantidade inserida para a peça " + peca + " excede a presente no estoque.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EstoqueBLL.peca = peca;
                        EstoqueBLL.tamanho = tamanho;
                        int quantidadeFinal = quantidadeatual - quantidade;
                        EstoqueBLL.quantidade = quantidadeFinal;

                        bool success = dal.AbaterQuantidade(EstoqueBLL);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
        #region Valores
        public decimal CalcularSubtotal()
        {
            subTotal = 0;
            foreach (DataGridViewRow linha in dgvLista.Rows)
            {
                subTotal += Convert.ToDecimal(linha.Cells[5].Value);

            }
            txt_SubTotal.Text = subTotal.ToString("F");
            txt_TotalGeral.Text = subTotal.ToString("F");
            return subTotal;
        }
        public void CalcularDesconto()
        {
            CalcularSubtotal();
            decimal subTotal = CalcularSubtotal();
            if (txt_Desconto.Text != "")
            {
                decimal desconto = decimal.Parse(txt_Desconto.Text);
                decimal totalgeral = ((100 - desconto) / 100) * subTotal;
                txt_TotalGeral.Text = totalgeral.ToString("F");
            }
            else
            {
                txt_TotalGeral.Text = subTotal.ToString("F");
            }
        }
        private void CalcularTroco()
        {
            decimal totalgeral = decimal.Parse(txt_TotalGeral.Text);
            decimal totalpago = decimal.Parse(txt_TotalPago.Text);
            if (totalpago < totalgeral)
            {
                MessageBox.Show("O valor inserido referente ao valor pago é menor que o valor total dos produtos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal troco = totalpago - totalgeral;
                txt_Troco.Text = troco.ToString("F");
            }
        }

        #endregion
        #region Finalizar venda
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            int idlista = ArmazenarLista();

            bll.fk_Lista = idlista;
            bll.Fk_RaAluno = txt_RA.Text;
            bll.Fk_NomeAluno = txt_Nome.Text;
            bll.Fk_CursoAluno = txt_Curso.Text;
            bll.Fk_NomeUsuario = UsuarioLogado;
            bll.DataVenda = DateTime.Now;
            CalcularSubtotal();
            bll.SubTotal = decimal.Parse(txt_SubTotal.Text);
            if (txt_Desconto.Text != "")
            {
                bll.Desconto = int.Parse(txt_Desconto.Text);
                CalcularDesconto();
            }
            else
            {
                bll.Desconto = 0;
            }
            bll.ValorTotal = decimal.Parse(txt_TotalGeral.Text);
            if (txt_TotalPago.Text != "")
            {
                bll.ValorPago = decimal.Parse(txt_TotalPago.Text);
                CalcularTroco();
                bll.Troco = decimal.Parse(txt_Troco.Text);
                bll.Observacao = txt_Observacao.Text;

                bool success = dal.RegistrarVenda(bll);
                if (success == true)
                {
                    AbaterQuantidade();
                    dgvLista.DataSource = null;
                    MessageBox.Show("Venda registrada com sucesso.", "OPERAÇÂO BEM-SUCEDIDO");
                }
                else
                {
                    MessageBox.Show("Não foi possível registrar essa venda.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Insira o valor pago pelo aluno", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            CalcularSubtotal();
            if (txt_Desconto.Text != "")
            {
                CalcularDesconto();
            }
            else
            {
                bll.Desconto = 0;
            }
            try
            {
                if (txt_TotalPago.Text != "")
                {
                    CalcularTroco();
                }
                else
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Insira o valor pago valido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txt_TotalPago_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_TotalPago.Text != "")
                {
                    CalcularTroco();
                }
                else
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Insira o valor pago valido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Desconto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_TotalGeral.Text != "")
                {
                    CalcularDesconto();
                }
                else
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Insira o valor pago valido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
