namespace LojaDeUniforme.Telas
{
    partial class frmCategoriaDeUniformes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoriaDeUniformes));
            this.txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.txt_NomeCategoria = new System.Windows.Forms.TextBox();
            this.txt_IdCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_PrimeiroNome = new System.Windows.Forms.Label();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Location = new System.Drawing.Point(108, 95);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(252, 20);
            this.txt_Pesquisa.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 18);
            this.label11.TabIndex = 46;
            this.label11.Text = "Pesquisar:";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(15, 127);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.Size = new System.Drawing.Size(433, 346);
            this.dgvCategorias.TabIndex = 45;
            this.dgvCategorias.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCategorias_RowHeaderMouseClick);
            // 
            // txt_NomeCategoria
            // 
            this.txt_NomeCategoria.Location = new System.Drawing.Point(366, 10);
            this.txt_NomeCategoria.Name = "txt_NomeCategoria";
            this.txt_NomeCategoria.Size = new System.Drawing.Size(82, 20);
            this.txt_NomeCategoria.TabIndex = 42;
            // 
            // txt_IdCategoria
            // 
            this.txt_IdCategoria.Enabled = false;
            this.txt_IdCategoria.Location = new System.Drawing.Point(125, 10);
            this.txt_IdCategoria.Name = "txt_IdCategoria";
            this.txt_IdCategoria.Size = new System.Drawing.Size(73, 20);
            this.txt_IdCategoria.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nome da Categoria:";
            // 
            // lb_PrimeiroNome
            // 
            this.lb_PrimeiroNome.AutoSize = true;
            this.lb_PrimeiroNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PrimeiroNome.Location = new System.Drawing.Point(12, 9);
            this.lb_PrimeiroNome.Name = "lb_PrimeiroNome";
            this.lb_PrimeiroNome.Size = new System.Drawing.Size(107, 18);
            this.lb_PrimeiroNome.TabIndex = 39;
            this.lb_PrimeiroNome.Text = "ID Categoria:";
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.BackColor = System.Drawing.Color.White;
            this.btn_Pesquisar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Categoria___Pesquisar;
            this.btn_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Pesquisar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Pesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pesquisar.Location = new System.Drawing.Point(366, 90);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(82, 29);
            this.btn_Pesquisar.TabIndex = 52;
            this.btn_Pesquisar.UseVisualStyleBackColor = false;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.Color.White;
            this.btn_Deletar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Categoria___Excluir;
            this.btn_Deletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Deletar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deletar.Location = new System.Drawing.Point(366, 38);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(82, 46);
            this.btn_Deletar.TabIndex = 51;
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.White;
            this.btn_Limpar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Categoria___Limpar;
            this.btn_Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Limpar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Limpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpar.Location = new System.Drawing.Point(246, 38);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(82, 46);
            this.btn_Limpar.TabIndex = 50;
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.White;
            this.btn_Atualizar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Categoria___Atualizar;
            this.btn_Atualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Atualizar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atualizar.Location = new System.Drawing.Point(134, 38);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(82, 46);
            this.btn_Atualizar.TabIndex = 49;
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.White;
            this.btn_Cadastrar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Categoria___Adicionar;
            this.btn_Cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Location = new System.Drawing.Point(15, 38);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(82, 46);
            this.btn_Cadastrar.TabIndex = 48;
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // frmCategoriaDeUniformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 484);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.txt_Pesquisa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.txt_NomeCategoria);
            this.Controls.Add(this.txt_IdCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_PrimeiroNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCategoriaDeUniformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Categorias de Uniforme";
            this.Load += new System.EventHandler(this.frmCategoriaDeUniformes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.TextBox txt_NomeCategoria;
        private System.Windows.Forms.TextBox txt_IdCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_PrimeiroNome;
    }
}