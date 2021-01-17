namespace LojaDeUniforme.Telas
{
    partial class frmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            this.txt_PecaDeUniforme = new System.Windows.Forms.TextBox();
            this.txt_IdUniforme = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_PrimeiroNome = new System.Windows.Forms.Label();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.txt_Tamanho = new System.Windows.Forms.TextBox();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_PecaDeUniforme
            // 
            this.txt_PecaDeUniforme.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_PecaDeUniforme.Enabled = false;
            this.txt_PecaDeUniforme.Location = new System.Drawing.Point(385, 10);
            this.txt_PecaDeUniforme.Name = "txt_PecaDeUniforme";
            this.txt_PecaDeUniforme.Size = new System.Drawing.Size(151, 20);
            this.txt_PecaDeUniforme.TabIndex = 85;
            // 
            // txt_IdUniforme
            // 
            this.txt_IdUniforme.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_IdUniforme.Enabled = false;
            this.txt_IdUniforme.Location = new System.Drawing.Point(121, 10);
            this.txt_IdUniforme.Name = "txt_IdUniforme";
            this.txt_IdUniforme.Size = new System.Drawing.Size(94, 20);
            this.txt_IdUniforme.TabIndex = 83;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(178, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 18);
            this.label10.TabIndex = 82;
            this.label10.Text = "Unidades:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(231, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 18);
            this.label7.TabIndex = 81;
            this.label7.Text = "Peça de Uniforme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 80;
            this.label2.Text = "Tamanho:";
            // 
            // lb_PrimeiroNome
            // 
            this.lb_PrimeiroNome.AutoSize = true;
            this.lb_PrimeiroNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PrimeiroNome.Location = new System.Drawing.Point(12, 9);
            this.lb_PrimeiroNome.Name = "lb_PrimeiroNome";
            this.lb_PrimeiroNome.Size = new System.Drawing.Size(103, 18);
            this.lb_PrimeiroNome.TabIndex = 79;
            this.lb_PrimeiroNome.Text = "ID Uniforme:";
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Quantidade.Location = new System.Drawing.Point(267, 44);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(59, 20);
            this.txt_Quantidade.TabIndex = 86;
            // 
            // txt_Tamanho
            // 
            this.txt_Tamanho.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Tamanho.Enabled = false;
            this.txt_Tamanho.Location = new System.Drawing.Point(101, 44);
            this.txt_Tamanho.Name = "txt_Tamanho";
            this.txt_Tamanho.Size = new System.Drawing.Size(59, 20);
            this.txt_Tamanho.TabIndex = 90;
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEstoque.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(15, 81);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.Size = new System.Drawing.Size(521, 304);
            this.dgvEstoque.TabIndex = 91;
            this.dgvEstoque.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEstoque_RowHeaderMouseClick);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.White;
            this.btn_Limpar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Estoque___Limpar;
            this.btn_Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Limpar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Limpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpar.Location = new System.Drawing.Point(454, 36);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(82, 39);
            this.btn_Limpar.TabIndex = 89;
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.Color.White;
            this.btn_Adicionar.BackgroundImage = global::LojaDeUniforme.Properties.Resources.Estoque___Adicionar;
            this.btn_Adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Adicionar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_Adicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_Adicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adicionar.Location = new System.Drawing.Point(346, 36);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(82, 39);
            this.btn_Adicionar.TabIndex = 88;
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 397);
            this.Controls.Add(this.dgvEstoque);
            this.Controls.Add(this.txt_Tamanho);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.txt_Quantidade);
            this.Controls.Add(this.txt_PecaDeUniforme);
            this.Controls.Add(this.txt_IdUniforme);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_PrimeiroNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Estoque";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_PecaDeUniforme;
        private System.Windows.Forms.TextBox txt_IdUniforme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_PrimeiroNome;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.TextBox txt_Tamanho;
        private System.Windows.Forms.DataGridView dgvEstoque;
    }
}