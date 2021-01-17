namespace LojaDeUniforme.Telas
{
    partial class frmCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.gb_Valores = new System.Windows.Forms.GroupBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txt_Observacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Troco = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_Desconto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_TotalGeral = new System.Windows.Forms.TextBox();
            this.txt_TotalPago = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_SubTotal = new System.Windows.Forms.TextBox();
            this.gb_ListaProdutos = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.gb_Produto = new System.Windows.Forms.GroupBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.cbx_Tamanho = new System.Windows.Forms.ComboBox();
            this.cbx_Peca = new System.Windows.Forms.ComboBox();
            this.cbx_Categoria = new System.Windows.Forms.ComboBox();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gb_Aluno = new System.Windows.Forms.GroupBox();
            this.btn_PesquisarAluno = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Curso = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_RA = new System.Windows.Forms.TextBox();
            this.gb_Valores.SuspendLayout();
            this.gb_ListaProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gb_Produto.SuspendLayout();
            this.gb_Aluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Valores
            // 
            this.gb_Valores.Controls.Add(this.btn_Salvar);
            this.gb_Valores.Controls.Add(this.btn_Calcular);
            this.gb_Valores.Controls.Add(this.txt_Observacao);
            this.gb_Valores.Controls.Add(this.label2);
            this.gb_Valores.Controls.Add(this.txt_Troco);
            this.gb_Valores.Controls.Add(this.label17);
            this.gb_Valores.Controls.Add(this.txt_Desconto);
            this.gb_Valores.Controls.Add(this.label15);
            this.gb_Valores.Controls.Add(this.label14);
            this.gb_Valores.Controls.Add(this.txt_TotalGeral);
            this.gb_Valores.Controls.Add(this.txt_TotalPago);
            this.gb_Valores.Controls.Add(this.label10);
            this.gb_Valores.Controls.Add(this.txt_SubTotal);
            this.gb_Valores.Location = new System.Drawing.Point(461, 187);
            this.gb_Valores.Name = "gb_Valores";
            this.gb_Valores.Size = new System.Drawing.Size(224, 314);
            this.gb_Valores.TabIndex = 68;
            this.gb_Valores.TabStop = false;
            this.gb_Valores.Text = "Valores";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.BackColor = System.Drawing.Color.White;
            this.btn_Salvar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Caixa___Finalizar;
            this.btn_Salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Salvar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar.Location = new System.Drawing.Point(72, 277);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(94, 31);
            this.btn_Salvar.TabIndex = 75;
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.Color.White;
            this.btn_Calcular.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Caixa___Calcular;
            this.btn_Calcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Calcular.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Calcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Calcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calcular.Location = new System.Drawing.Point(72, 240);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(94, 31);
            this.btn_Calcular.TabIndex = 73;
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txt_Observacao
            // 
            this.txt_Observacao.Location = new System.Drawing.Point(25, 155);
            this.txt_Observacao.Multiline = true;
            this.txt_Observacao.Name = "txt_Observacao";
            this.txt_Observacao.Size = new System.Drawing.Size(178, 79);
            this.txt_Observacao.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 72;
            this.label2.Text = "Total Pago:";
            // 
            // txt_Troco
            // 
            this.txt_Troco.Enabled = false;
            this.txt_Troco.Location = new System.Drawing.Point(129, 129);
            this.txt_Troco.Name = "txt_Troco";
            this.txt_Troco.Size = new System.Drawing.Size(74, 20);
            this.txt_Troco.TabIndex = 71;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(22, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 18);
            this.label17.TabIndex = 66;
            this.label17.Text = "Desconto %:";
            // 
            // txt_Desconto
            // 
            this.txt_Desconto.Location = new System.Drawing.Point(129, 48);
            this.txt_Desconto.Name = "txt_Desconto";
            this.txt_Desconto.Size = new System.Drawing.Size(74, 20);
            this.txt_Desconto.TabIndex = 67;
            this.txt_Desconto.Leave += new System.EventHandler(this.txt_Desconto_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 18);
            this.label15.TabIndex = 62;
            this.label15.Text = "Troco:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 18);
            this.label14.TabIndex = 60;
            this.label14.Text = "Total Geral:";
            // 
            // txt_TotalGeral
            // 
            this.txt_TotalGeral.Enabled = false;
            this.txt_TotalGeral.Location = new System.Drawing.Point(129, 77);
            this.txt_TotalGeral.Name = "txt_TotalGeral";
            this.txt_TotalGeral.Size = new System.Drawing.Size(74, 20);
            this.txt_TotalGeral.TabIndex = 61;
            // 
            // txt_TotalPago
            // 
            this.txt_TotalPago.Location = new System.Drawing.Point(129, 103);
            this.txt_TotalPago.Name = "txt_TotalPago";
            this.txt_TotalPago.Size = new System.Drawing.Size(74, 20);
            this.txt_TotalPago.TabIndex = 59;
            this.txt_TotalPago.Leave += new System.EventHandler(this.txt_TotalPago_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 18);
            this.label10.TabIndex = 56;
            this.label10.Text = "Sub Total:";
            // 
            // txt_SubTotal
            // 
            this.txt_SubTotal.Location = new System.Drawing.Point(129, 20);
            this.txt_SubTotal.Name = "txt_SubTotal";
            this.txt_SubTotal.Size = new System.Drawing.Size(74, 20);
            this.txt_SubTotal.TabIndex = 57;
            this.txt_SubTotal.Tag = "";
            // 
            // gb_ListaProdutos
            // 
            this.gb_ListaProdutos.Controls.Add(this.dgvLista);
            this.gb_ListaProdutos.Location = new System.Drawing.Point(12, 187);
            this.gb_ListaProdutos.Name = "gb_ListaProdutos";
            this.gb_ListaProdutos.Size = new System.Drawing.Size(443, 318);
            this.gb_ListaProdutos.TabIndex = 67;
            this.gb_ListaProdutos.TabStop = false;
            this.gb_ListaProdutos.Text = "LISTA DE PRODUTOS";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.BackgroundColor = System.Drawing.Color.White;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(6, 19);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(431, 289);
            this.dgvLista.TabIndex = 0;
            // 
            // gb_Produto
            // 
            this.gb_Produto.Controls.Add(this.btn_Adicionar);
            this.gb_Produto.Controls.Add(this.btn_Deletar);
            this.gb_Produto.Controls.Add(this.cbx_Tamanho);
            this.gb_Produto.Controls.Add(this.cbx_Peca);
            this.gb_Produto.Controls.Add(this.cbx_Categoria);
            this.gb_Produto.Controls.Add(this.txt_Quantidade);
            this.gb_Produto.Controls.Add(this.label6);
            this.gb_Produto.Controls.Add(this.label1);
            this.gb_Produto.Controls.Add(this.label7);
            this.gb_Produto.Controls.Add(this.label12);
            this.gb_Produto.Location = new System.Drawing.Point(12, 72);
            this.gb_Produto.Name = "gb_Produto";
            this.gb_Produto.Size = new System.Drawing.Size(673, 100);
            this.gb_Produto.TabIndex = 66;
            this.gb_Produto.TabStop = false;
            this.gb_Produto.Text = "DETALHES DO PRODUTO";
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.Color.White;
            this.btn_Adicionar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Caixa___Adicionar;
            this.btn_Adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Adicionar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Adicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Adicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adicionar.Location = new System.Drawing.Point(462, 24);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(94, 59);
            this.btn_Adicionar.TabIndex = 73;
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.Color.White;
            this.btn_Deletar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Caixa___Deletar;
            this.btn_Deletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Deletar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deletar.Location = new System.Drawing.Point(573, 24);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(94, 59);
            this.btn_Deletar.TabIndex = 72;
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // cbx_Tamanho
            // 
            this.cbx_Tamanho.FormattingEnabled = true;
            this.cbx_Tamanho.Location = new System.Drawing.Point(373, 24);
            this.cbx_Tamanho.Name = "cbx_Tamanho";
            this.cbx_Tamanho.Size = new System.Drawing.Size(67, 21);
            this.cbx_Tamanho.TabIndex = 71;
            // 
            // cbx_Peca
            // 
            this.cbx_Peca.FormattingEnabled = true;
            this.cbx_Peca.Location = new System.Drawing.Point(100, 62);
            this.cbx_Peca.Name = "cbx_Peca";
            this.cbx_Peca.Size = new System.Drawing.Size(146, 21);
            this.cbx_Peca.TabIndex = 70;
            this.cbx_Peca.TextChanged += new System.EventHandler(this.cbx_Peca_TextChanged);
            // 
            // cbx_Categoria
            // 
            this.cbx_Categoria.FormattingEnabled = true;
            this.cbx_Categoria.Location = new System.Drawing.Point(100, 24);
            this.cbx_Categoria.Name = "cbx_Categoria";
            this.cbx_Categoria.Size = new System.Drawing.Size(146, 21);
            this.cbx_Categoria.Sorted = true;
            this.cbx_Categoria.TabIndex = 69;
            this.cbx_Categoria.TextChanged += new System.EventHandler(this.cbx_Categoria_TextChanged);
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Location = new System.Drawing.Point(373, 62);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(67, 20);
            this.txt_Quantidade.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 56;
            this.label6.Text = "Quantidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Categoria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 48;
            this.label7.Text = "Peça:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(269, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 18);
            this.label12.TabIndex = 49;
            this.label12.Text = "Tamanho:";
            // 
            // gb_Aluno
            // 
            this.gb_Aluno.Controls.Add(this.btn_PesquisarAluno);
            this.gb_Aluno.Controls.Add(this.label11);
            this.gb_Aluno.Controls.Add(this.label3);
            this.gb_Aluno.Controls.Add(this.label5);
            this.gb_Aluno.Controls.Add(this.txt_Curso);
            this.gb_Aluno.Controls.Add(this.txt_Nome);
            this.gb_Aluno.Controls.Add(this.txt_RA);
            this.gb_Aluno.Location = new System.Drawing.Point(12, 12);
            this.gb_Aluno.Name = "gb_Aluno";
            this.gb_Aluno.Size = new System.Drawing.Size(673, 54);
            this.gb_Aluno.TabIndex = 65;
            this.gb_Aluno.TabStop = false;
            this.gb_Aluno.Text = "DETALHES DO ALUNO";
            // 
            // btn_PesquisarAluno
            // 
            this.btn_PesquisarAluno.BackColor = System.Drawing.Color.White;
            this.btn_PesquisarAluno.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Caixa___Pesquisar;
            this.btn_PesquisarAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_PesquisarAluno.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_PesquisarAluno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_PesquisarAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_PesquisarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PesquisarAluno.Location = new System.Drawing.Point(605, 12);
            this.btn_PesquisarAluno.Name = "btn_PesquisarAluno";
            this.btn_PesquisarAluno.Size = new System.Drawing.Size(62, 29);
            this.btn_PesquisarAluno.TabIndex = 104;
            this.btn_PesquisarAluno.UseVisualStyleBackColor = false;
            this.btn_PesquisarAluno.Click += new System.EventHandler(this.btn_PesquisarAluno_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 18);
            this.label11.TabIndex = 54;
            this.label11.Text = "RA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 49;
            this.label5.Text = "Curso:";
            // 
            // txt_Curso
            // 
            this.txt_Curso.Enabled = false;
            this.txt_Curso.Location = new System.Drawing.Point(462, 17);
            this.txt_Curso.Name = "txt_Curso";
            this.txt_Curso.Size = new System.Drawing.Size(137, 20);
            this.txt_Curso.TabIndex = 53;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Enabled = false;
            this.txt_Nome.Location = new System.Drawing.Point(254, 17);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(137, 20);
            this.txt_Nome.TabIndex = 52;
            // 
            // txt_RA
            // 
            this.txt_RA.Enabled = false;
            this.txt_RA.Location = new System.Drawing.Point(47, 17);
            this.txt_RA.Name = "txt_RA";
            this.txt_RA.Size = new System.Drawing.Size(137, 20);
            this.txt_RA.TabIndex = 55;
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 513);
            this.Controls.Add(this.gb_Valores);
            this.Controls.Add(this.gb_ListaProdutos);
            this.Controls.Add(this.gb_Produto);
            this.Controls.Add(this.gb_Aluno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(714, 552);
            this.MinimumSize = new System.Drawing.Size(714, 552);
            this.Name = "frmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Vendas";
            this.Load += new System.EventHandler(this.FrmCaixa_Load);
            this.gb_Valores.ResumeLayout(false);
            this.gb_Valores.PerformLayout();
            this.gb_ListaProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gb_Produto.ResumeLayout(false);
            this.gb_Produto.PerformLayout();
            this.gb_Aluno.ResumeLayout(false);
            this.gb_Aluno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Valores;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_Desconto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_TotalGeral;
        private System.Windows.Forms.TextBox txt_TotalPago;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_SubTotal;
        private System.Windows.Forms.GroupBox gb_ListaProdutos;
        private System.Windows.Forms.GroupBox gb_Produto;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gb_Aluno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Curso;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_RA;
        private System.Windows.Forms.ComboBox cbx_Peca;
        private System.Windows.Forms.ComboBox cbx_Categoria;
        private System.Windows.Forms.ComboBox cbx_Tamanho;
        private System.Windows.Forms.Button btn_PesquisarAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Troco;
        private System.Windows.Forms.TextBox txt_Observacao;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.DataGridView dgvLista;
    }
}