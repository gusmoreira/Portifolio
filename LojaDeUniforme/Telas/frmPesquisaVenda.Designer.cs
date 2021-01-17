namespace LojaDeUniforme.Telas
{
    partial class frmPesquisaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaVenda));
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.txt_RA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_PesquisarRA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.btn_PesquisarNome = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVendas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Location = new System.Drawing.Point(6, 19);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.Size = new System.Drawing.Size(587, 188);
            this.dgvVendas.TabIndex = 113;
            this.dgvVendas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVendas_RowHeaderMouseClick);
            // 
            // txt_RA
            // 
            this.txt_RA.Location = new System.Drawing.Point(53, 10);
            this.txt_RA.Name = "txt_RA";
            this.txt_RA.Size = new System.Drawing.Size(149, 20);
            this.txt_RA.TabIndex = 109;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 18);
            this.label7.TabIndex = 108;
            this.label7.Text = "RA:";
            // 
            // btn_PesquisarRA
            // 
            this.btn_PesquisarRA.BackColor = System.Drawing.Color.White;
            this.btn_PesquisarRA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_PesquisarRA.BackgroundImage")));
            this.btn_PesquisarRA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_PesquisarRA.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_PesquisarRA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_PesquisarRA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_PesquisarRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PesquisarRA.Location = new System.Drawing.Point(221, 5);
            this.btn_PesquisarRA.Name = "btn_PesquisarRA";
            this.btn_PesquisarRA.Size = new System.Drawing.Size(67, 29);
            this.btn_PesquisarRA.TabIndex = 111;
            this.btn_PesquisarRA.UseVisualStyleBackColor = false;
            this.btn_PesquisarRA.Click += new System.EventHandler(this.btn_PesquisarRA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 107;
            this.label2.Text = "Nome:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(379, 10);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(149, 20);
            this.txt_Nome.TabIndex = 110;
            // 
            // btn_PesquisarNome
            // 
            this.btn_PesquisarNome.BackColor = System.Drawing.Color.White;
            this.btn_PesquisarNome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_PesquisarNome.BackgroundImage")));
            this.btn_PesquisarNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_PesquisarNome.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_PesquisarNome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.btn_PesquisarNome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btn_PesquisarNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PesquisarNome.Location = new System.Drawing.Point(547, 5);
            this.btn_PesquisarNome.Name = "btn_PesquisarNome";
            this.btn_PesquisarNome.Size = new System.Drawing.Size(67, 29);
            this.btn_PesquisarNome.TabIndex = 112;
            this.btn_PesquisarNome.UseVisualStyleBackColor = false;
            this.btn_PesquisarNome.Click += new System.EventHandler(this.btn_PesquisarNome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVendas);
            this.groupBox1.Location = new System.Drawing.Point(15, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 213);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes da venda";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLista.BackgroundColor = System.Drawing.Color.White;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(6, 19);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(587, 183);
            this.dgvLista.TabIndex = 113;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLista);
            this.groupBox2.Location = new System.Drawing.Point(15, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 211);
            this.groupBox2.TabIndex = 115;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos vendidos";
            // 
            // frmPesquisaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_PesquisarNome);
            this.Controls.Add(this.btn_PesquisarRA);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.txt_RA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 528);
            this.MinimumSize = new System.Drawing.Size(640, 528);
            this.Name = "frmPesquisaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa das Vendas";
            this.Load += new System.EventHandler(this.frmPesquisaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Button btn_PesquisarRA;
        private System.Windows.Forms.TextBox txt_RA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Button btn_PesquisarNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}