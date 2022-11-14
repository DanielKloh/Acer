namespace exibicaoWEB
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exibicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulo,
            this.postagem,
            this.exibicao,
            this.resposta,
            this.link});
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 358);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            this.titulo.Width = 250;
            // 
            // postagem
            // 
            this.postagem.HeaderText = "Postagem";
            this.postagem.Name = "postagem";
            this.postagem.Width = 150;
            // 
            // exibicao
            // 
            this.exibicao.HeaderText = "Exibição";
            this.exibicao.Name = "exibicao";
            // 
            // resposta
            // 
            this.resposta.HeaderText = "Resposta";
            this.resposta.Name = "resposta";
            // 
            // link
            // 
            this.link.HeaderText = "Link";
            this.link.Name = "link";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(344, 12);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(116, 31);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Buscar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Exibição Web";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn postagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn exibicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn resposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn link;
        private System.Windows.Forms.Button btnAtualizar;
    }
}

