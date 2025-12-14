namespace ControleEstoque
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lblTabelado = new System.Windows.Forms.Label();
            this.txtPrecoTabelado = new System.Windows.Forms.TextBox();
            this.lvlVenda = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.btnVerEstoque = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdicionar.Location = new System.Drawing.Point(30, 265);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(200, 30);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar Produto";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNome.Location = new System.Drawing.Point(30, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(132, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome da coleção";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(30, 123);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(200, 28);
            this.cmbTipo.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(30, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 26);
            this.txtNome.TabIndex = 1;
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTipo.Location = new System.Drawing.Point(30, 98);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(120, 20);
            this.lbTipo.TabIndex = 2;
            this.lbTipo.Text = "Tipo de produto";
            // 
            // lblTabelado
            // 
            this.lblTabelado.AutoSize = true;
            this.lblTabelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTabelado.Location = new System.Drawing.Point(30, 158);
            this.lblTabelado.Name = "lblTabelado";
            this.lblTabelado.Size = new System.Drawing.Size(116, 20);
            this.lblTabelado.TabIndex = 4;
            this.lblTabelado.Text = "Preço tabelado";
            // 
            // txtPrecoTabelado
            // 
            this.txtPrecoTabelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrecoTabelado.Location = new System.Drawing.Point(29, 176);
            this.txtPrecoTabelado.Name = "txtPrecoTabelado";
            this.txtPrecoTabelado.Size = new System.Drawing.Size(200, 26);
            this.txtPrecoTabelado.TabIndex = 5;
            // 
            // lvlVenda
            // 
            this.lvlVenda.AutoSize = true;
            this.lvlVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lvlVenda.Location = new System.Drawing.Point(28, 212);
            this.lvlVenda.Name = "lvlVenda";
            this.lvlVenda.Size = new System.Drawing.Size(169, 20);
            this.lvlVenda.TabIndex = 6;
            this.lvlVenda.Text = "Preço de venda na loja";
            this.lvlVenda.Click += new System.EventHandler(this.lvlVenda_Click);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrecoVenda.Location = new System.Drawing.Point(30, 233);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(200, 26);
            this.txtPrecoVenda.TabIndex = 7;
            // 
            // btnVerEstoque
            // 
            this.btnVerEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVerEstoque.Location = new System.Drawing.Point(30, 301);
            this.btnVerEstoque.Name = "btnVerEstoque";
            this.btnVerEstoque.Size = new System.Drawing.Size(200, 30);
            this.btnVerEstoque.TabIndex = 9;
            this.btnVerEstoque.Text = "Ver Estoque";
            this.btnVerEstoque.UseVisualStyleBackColor = true;
            this.btnVerEstoque.Click += new System.EventHandler(this.btnVerEstoque_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dataGridView1.Location = new System.Drawing.Point(287, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 334);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExcluirProduto.Location = new System.Drawing.Point(30, 337);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(200, 30);
            this.btnExcluirProduto.TabIndex = 10;
            this.btnExcluirProduto.Text = "Excluir Produto Selecionado";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 379);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVerEstoque);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.lvlVenda);
            this.Controls.Add(this.txtPrecoTabelado);
            this.Controls.Add(this.lblTabelado);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "Form1";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lblTabelado;
        private System.Windows.Forms.TextBox txtPrecoTabelado;
        private System.Windows.Forms.Label lvlVenda;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Button btnVerEstoque;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExcluirProduto;

    }
}