namespace LojaDeUniforme.Telas
{
    partial class frmCaixaAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixaAluno));
            this.btn_PesquisarRA = new System.Windows.Forms.Button();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_RA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_PesquisarNome = new System.Windows.Forms.Button();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
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
            this.btn_PesquisarRA.Location = new System.Drawing.Point(227, 5);
            this.btn_PesquisarRA.Name = "btn_PesquisarRA";
            this.btn_PesquisarRA.Size = new System.Drawing.Size(67, 29);
            this.btn_PesquisarRA.TabIndex = 103;
            this.btn_PesquisarRA.UseVisualStyleBackColor = false;
            this.btn_PesquisarRA.Click += new System.EventHandler(this.btn_PesquisarRA_Click);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(378, 10);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(155, 20);
            this.txt_Nome.TabIndex = 95;
            // 
            // txt_RA
            // 
            this.txt_RA.Location = new System.Drawing.Point(53, 10);
            this.txt_RA.Name = "txt_RA";
            this.txt_RA.Size = new System.Drawing.Size(158, 20);
            this.txt_RA.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 18);
            this.label7.TabIndex = 92;
            this.label7.Text = "RA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 90;
            this.label2.Text = "Nome:";
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
            this.btn_PesquisarNome.TabIndex = 105;
            this.btn_PesquisarNome.UseVisualStyleBackColor = false;
            this.btn_PesquisarNome.Click += new System.EventHandler(this.btn_PesquisarNome_Click);
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlunos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(15, 40);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.Size = new System.Drawing.Size(599, 233);
            this.dgvAlunos.TabIndex = 106;
            this.dgvAlunos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAlunos_RowHeaderMouseClick);
            // 
            // frmCaixaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 285);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.btn_PesquisarNome);
            this.Controls.Add(this.btn_PesquisarRA);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.txt_RA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCaixaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Aluno para Realizar Venda";
            this.Load += new System.EventHandler(this.frmCaixaAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_PesquisarRA;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_RA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_PesquisarNome;
        private System.Windows.Forms.DataGridView dgvAlunos;
    }
}