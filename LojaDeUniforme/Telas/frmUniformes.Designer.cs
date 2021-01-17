namespace LojaDeUniforme.Telas
{
    partial class frmUniformes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUniformes));
            this.txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvUniformes = new System.Windows.Forms.DataGridView();
            this.txt_IdUniforme = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_PrimeiroNome = new System.Windows.Forms.Label();
            this.txt_PecaDeUniforme = new System.Windows.Forms.TextBox();
            this.txt_Preco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Tamanho = new System.Windows.Forms.ComboBox();
            this.cbx_Categoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniformes)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Location = new System.Drawing.Point(111, 121);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(414, 20);
            this.txt_Pesquisa.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 18);
            this.label11.TabIndex = 70;
            this.label11.Text = "Pesquisar:";
            // 
            // dgvUniformes
            // 
            this.dgvUniformes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUniformes.BackgroundColor = System.Drawing.Color.White;
            this.dgvUniformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUniformes.Location = new System.Drawing.Point(15, 153);
            this.dgvUniformes.Name = "dgvUniformes";
            this.dgvUniformes.ReadOnly = true;
            this.dgvUniformes.Size = new System.Drawing.Size(617, 305);
            this.dgvUniformes.TabIndex = 68;
            this.dgvUniformes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUniformes_RowHeaderMouseClick);
            // 
            // txt_IdUniforme
            // 
            this.txt_IdUniforme.Enabled = false;
            this.txt_IdUniforme.Location = new System.Drawing.Point(121, 10);
            this.txt_IdUniforme.Name = "txt_IdUniforme";
            this.txt_IdUniforme.Size = new System.Drawing.Size(134, 20);
            this.txt_IdUniforme.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(481, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 18);
            this.label10.TabIndex = 63;
            this.label10.Text = "Preço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(270, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 18);
            this.label7.TabIndex = 62;
            this.label7.Text = "Peça de Uniforme:";
            // 
            // lb_PrimeiroNome
            // 
            this.lb_PrimeiroNome.AutoSize = true;
            this.lb_PrimeiroNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PrimeiroNome.Location = new System.Drawing.Point(12, 9);
            this.lb_PrimeiroNome.Name = "lb_PrimeiroNome";
            this.lb_PrimeiroNome.Size = new System.Drawing.Size(103, 18);
            this.lb_PrimeiroNome.TabIndex = 59;
            this.lb_PrimeiroNome.Text = "ID Uniforme:";
            // 
            // txt_PecaDeUniforme
            // 
            this.txt_PecaDeUniforme.Location = new System.Drawing.Point(424, 10);
            this.txt_PecaDeUniforme.Name = "txt_PecaDeUniforme";
            this.txt_PecaDeUniforme.Size = new System.Drawing.Size(208, 20);
            this.txt_PecaDeUniforme.TabIndex = 77;
            // 
            // txt_Preco
            // 
            this.txt_Preco.Location = new System.Drawing.Point(545, 41);
            this.txt_Preco.Name = "txt_Preco";
            this.txt_Preco.Size = new System.Drawing.Size(87, 20);
            this.txt_Preco.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "Tamanho:";
            // 
            // cbx_Tamanho
            // 
            this.cbx_Tamanho.FormattingEnabled = true;
            this.cbx_Tamanho.Items.AddRange(new object[] {
            "PP",
            "P",
            "M",
            "G",
            "GG",
            "Especial"});
            this.cbx_Tamanho.Location = new System.Drawing.Point(370, 41);
            this.cbx_Tamanho.Name = "cbx_Tamanho";
            this.cbx_Tamanho.Size = new System.Drawing.Size(105, 21);
            this.cbx_Tamanho.TabIndex = 69;
            this.cbx_Tamanho.Text = "PP";
            // 
            // cbx_Categoria
            // 
            this.cbx_Categoria.FormattingEnabled = true;
            this.cbx_Categoria.Items.AddRange(new object[] {
            "Usuário Padrão",
            "Administrador"});
            this.cbx_Categoria.Location = new System.Drawing.Point(121, 41);
            this.cbx_Categoria.Name = "cbx_Categoria";
            this.cbx_Categoria.Size = new System.Drawing.Size(134, 21);
            this.cbx_Categoria.TabIndex = 80;
            this.cbx_Categoria.Text = "Camisetas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 79;
            this.label1.Text = "Categoria:";
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Uniformes____Pesquisar;
            this.btn_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Pesquisar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Pesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pesquisar.Location = new System.Drawing.Point(531, 113);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(101, 34);
            this.btn_Pesquisar.TabIndex = 76;
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Uniformes____Excluir;
            this.btn_Deletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Deletar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deletar.Location = new System.Drawing.Point(489, 68);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(143, 43);
            this.btn_Deletar.TabIndex = 75;
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Uniformes____Limpar;
            this.btn_Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Limpar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Limpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpar.Location = new System.Drawing.Point(333, 68);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(143, 43);
            this.btn_Limpar.TabIndex = 74;
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Uniformes____Atualizar;
            this.btn_Atualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Atualizar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atualizar.Location = new System.Drawing.Point(172, 68);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(143, 43);
            this.btn_Atualizar.TabIndex = 73;
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Uniformes____Adicionar;
            this.btn_Cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Location = new System.Drawing.Point(15, 68);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(140, 43);
            this.btn_Cadastrar.TabIndex = 72;
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // frmUniformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 470);
            this.Controls.Add(this.cbx_Categoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Preco);
            this.Controls.Add(this.txt_PecaDeUniforme);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.txt_Pesquisa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbx_Tamanho);
            this.Controls.Add(this.dgvUniformes);
            this.Controls.Add(this.txt_IdUniforme);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_PrimeiroNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(661, 509);
            this.MinimumSize = new System.Drawing.Size(661, 509);
            this.Name = "frmUniformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Uniformes";
            this.Load += new System.EventHandler(this.frmUniformes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniformes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.TextBox txt_Pesquisa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvUniformes;
        private System.Windows.Forms.TextBox txt_IdUniforme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_PrimeiroNome;
        private System.Windows.Forms.TextBox txt_PecaDeUniforme;
        private System.Windows.Forms.TextBox txt_Preco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Tamanho;
        private System.Windows.Forms.ComboBox cbx_Categoria;
        private System.Windows.Forms.Label label1;
    }
}