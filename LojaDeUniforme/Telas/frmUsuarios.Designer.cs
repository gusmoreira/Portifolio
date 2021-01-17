namespace LojaDeUniforme.Telas
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_IdUsuario = new System.Windows.Forms.TextBox();
            this.txt_NomeDeUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_PrimeiroNome = new System.Windows.Forms.Label();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Location = new System.Drawing.Point(111, 141);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(449, 20);
            this.txt_Pesquisa.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 18);
            this.label11.TabIndex = 52;
            this.label11.Text = "Pesquisar:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(15, 171);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 30;
            this.dgvUsuarios.Size = new System.Drawing.Size(618, 227);
            this.dgvUsuarios.TabIndex = 49;
            this.dgvUsuarios.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsuarios_RowHeaderMouseClick);
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(433, 38);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '•';
            this.txt_Senha.Size = new System.Drawing.Size(200, 20);
            this.txt_Senha.TabIndex = 48;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(433, 10);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(200, 20);
            this.txt_Nome.TabIndex = 45;
            // 
            // txt_IdUsuario
            // 
            this.txt_IdUsuario.Enabled = false;
            this.txt_IdUsuario.Location = new System.Drawing.Point(164, 10);
            this.txt_IdUsuario.Name = "txt_IdUsuario";
            this.txt_IdUsuario.Size = new System.Drawing.Size(190, 20);
            this.txt_IdUsuario.TabIndex = 44;
            // 
            // txt_NomeDeUsuario
            // 
            this.txt_NomeDeUsuario.Location = new System.Drawing.Point(164, 38);
            this.txt_NomeDeUsuario.Name = "txt_NomeDeUsuario";
            this.txt_NomeDeUsuario.Size = new System.Drawing.Size(190, 20);
            this.txt_NomeDeUsuario.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nome de Usuário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(367, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nome:";
            // 
            // lb_PrimeiroNome
            // 
            this.lb_PrimeiroNome.AutoSize = true;
            this.lb_PrimeiroNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PrimeiroNome.Location = new System.Drawing.Point(12, 9);
            this.lb_PrimeiroNome.Name = "lb_PrimeiroNome";
            this.lb_PrimeiroNome.Size = new System.Drawing.Size(93, 18);
            this.lb_PrimeiroNome.TabIndex = 31;
            this.lb_PrimeiroNome.Text = "ID Usuário:";
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.BackColor = System.Drawing.Color.White;
            this.btn_Pesquisar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Usuario__Limpar;
            this.btn_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Pesquisar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Pesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pesquisar.Location = new System.Drawing.Point(566, 136);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(67, 29);
            this.btn_Pesquisar.TabIndex = 58;
            this.btn_Pesquisar.UseVisualStyleBackColor = false;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.Color.White;
            this.btn_Deletar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Usuario___Deletar;
            this.btn_Deletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Deletar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deletar.Location = new System.Drawing.Point(527, 67);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(87, 59);
            this.btn_Deletar.TabIndex = 57;
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.White;
            this.btn_Limpar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Usuario___Limpar;
            this.btn_Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Limpar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Limpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpar.Location = new System.Drawing.Point(370, 67);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(87, 59);
            this.btn_Limpar.TabIndex = 56;
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.White;
            this.btn_Atualizar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Usuario___Atualizar;
            this.btn_Atualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Atualizar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atualizar.Location = new System.Drawing.Point(205, 67);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(87, 59);
            this.btn_Atualizar.TabIndex = 55;
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.White;
            this.btn_Cadastrar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Usuario___Adicionar;
            this.btn_Cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Location = new System.Drawing.Point(48, 67);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(87, 59);
            this.btn_Cadastrar.TabIndex = 54;
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(643, 408);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.txt_Pesquisa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.txt_IdUsuario);
            this.Controls.Add(this.txt_NomeDeUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_PrimeiroNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Usuários";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.TextBox txt_Pesquisa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_IdUsuario;
        private System.Windows.Forms.TextBox txt_NomeDeUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_PrimeiroNome;
        private System.Windows.Forms.Button btn_Pesquisar;
    }
}