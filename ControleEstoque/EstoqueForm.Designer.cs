namespace ControleEstoque
{
    partial class EstoqueForm
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
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnMenos = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnMais = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPrecoCompra = new System.Windows.Forms.Label();
            this.txtPrecoCompra = new System.Windows.Forms.TextBox();
            this.btnAdicionarEstoque = new System.Windows.Forms.Button();
            this.btnRemoverEstoque = new System.Windows.Forms.Button();
            this.dataGridViewEstoque = new System.Windows.Forms.DataGridView();
            this.lblResumoTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Location = new System.Drawing.Point(159, 18);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(300, 28);
            this.cmbProdutos.TabIndex = 0;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProduto.Location = new System.Drawing.Point(30, 18);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(69, 20);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto:";
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMenos.Location = new System.Drawing.Point(159, 72);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(30, 30);
            this.btnMenos.TabIndex = 2;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantidade.Location = new System.Drawing.Point(208, 74);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(50, 26);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.Text = "0";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMais
            // 
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMais.Location = new System.Drawing.Point(279, 72);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(30, 30);
            this.btnMais.TabIndex = 4;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuantidade.Location = new System.Drawing.Point(26, 72);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(96, 20);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblPrecoCompra
            // 
            this.lblPrecoCompra.AutoSize = true;
            this.lblPrecoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrecoCompra.Location = new System.Drawing.Point(30, 138);
            this.lblPrecoCompra.Name = "lblPrecoCompra";
            this.lblPrecoCompra.Size = new System.Drawing.Size(133, 20);
            this.lblPrecoCompra.TabIndex = 6;
            this.lblPrecoCompra.Text = "Preço de compra:";
            // 
            // txtPrecoCompra
            // 
            this.txtPrecoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrecoCompra.Location = new System.Drawing.Point(165, 135);
            this.txtPrecoCompra.Name = "txtPrecoCompra";
            this.txtPrecoCompra.Size = new System.Drawing.Size(130, 26);
            this.txtPrecoCompra.TabIndex = 7;
            // 
            // btnAdicionarEstoque
            // 
            this.btnAdicionarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdicionarEstoque.Location = new System.Drawing.Point(309, 135);
            this.btnAdicionarEstoque.Name = "btnAdicionarEstoque";
            this.btnAdicionarEstoque.Size = new System.Drawing.Size(181, 30);
            this.btnAdicionarEstoque.TabIndex = 8;
            this.btnAdicionarEstoque.Text = "Adicionar ao estoque";
            this.btnAdicionarEstoque.UseVisualStyleBackColor = true;
            this.btnAdicionarEstoque.Click += new System.EventHandler(this.btnAdicionarEstoque_Click);
            // 
            // btnRemoverEstoque
            // 
            this.btnRemoverEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRemoverEstoque.Location = new System.Drawing.Point(496, 135);
            this.btnRemoverEstoque.Name = "btnRemoverEstoque";
            this.btnRemoverEstoque.Size = new System.Drawing.Size(188, 30);
            this.btnRemoverEstoque.TabIndex = 9;
            this.btnRemoverEstoque.Text = "Remover do estoque";
            this.btnRemoverEstoque.UseVisualStyleBackColor = true;
            this.btnRemoverEstoque.Click += new System.EventHandler(this.btnRemoverEstoque_Click);
            // 
            // dataGridViewEstoque
            // 
            this.dataGridViewEstoque.AllowUserToAddRows = false;
            this.dataGridViewEstoque.AllowUserToDeleteRows = false;
            this.dataGridViewEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dataGridViewEstoque.Location = new System.Drawing.Point(30, 190);
            this.dataGridViewEstoque.Name = "dataGridViewEstoque";
            this.dataGridViewEstoque.ReadOnly = true;
            this.dataGridViewEstoque.Size = new System.Drawing.Size(691, 200);
            this.dataGridViewEstoque.TabIndex = 10;
            // 
            // lblResumoTotal
            // 
            this.lblResumoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResumoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResumoTotal.Location = new System.Drawing.Point(30, 400);
            this.lblResumoTotal.Name = "lblResumoTotal";
            this.lblResumoTotal.Size = new System.Drawing.Size(691, 98);
            this.lblResumoTotal.TabIndex = 11;
            // 
            // EstoqueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 507);
            this.Controls.Add(this.lblResumoTotal);
            this.Controls.Add(this.dataGridViewEstoque);
            this.Controls.Add(this.btnRemoverEstoque);
            this.Controls.Add(this.btnAdicionarEstoque);
            this.Controls.Add(this.txtPrecoCompra);
            this.Controls.Add(this.lblPrecoCompra);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.cmbProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "EstoqueForm";
            this.Text = "Controle de Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProdutos;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPrecoCompra;
        private System.Windows.Forms.TextBox txtPrecoCompra;
        private System.Windows.Forms.Button btnAdicionarEstoque;
        private System.Windows.Forms.Button btnRemoverEstoque;
        private System.Windows.Forms.DataGridView dataGridViewEstoque;
        private System.Windows.Forms.Label lblResumoTotal;
    }
}