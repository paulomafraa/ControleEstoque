using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ControleEstoque
{
    public partial class EstoqueForm : Form
    {
        public EstoqueForm()
        {
            InitializeComponent();
            InicializarControles();
            cmbProdutos.SelectedIndexChanged += cmbProdutos_SelectedIndexChanged;
        }

        private void InicializarControles()
        {
            // Carrega produtos no ComboBox
            cmbProdutos.Items.Clear();
            if (File.Exists("produtos.txt"))
            {
                foreach (var linha in File.ReadAllLines("produtos.txt"))
                {
                    var partes = linha.Split(';');
                    if (partes.Length >= 2)
                        cmbProdutos.Items.Add($"{partes[0]} - {partes[1]}");
                }
            }
            if (cmbProdutos.Items.Count > 0)
                cmbProdutos.SelectedIndex = 0;

            txtQuantidade.Text = "0";
            txtPrecoCompra.Text = "";

            CarregarEstoqueNoGrid();
        }

        private void cmbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarEstoqueNoGrid();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            int qtd = int.TryParse(txtQuantidade.Text, out qtd) ? qtd : 0;
            txtQuantidade.Text = (qtd + 1).ToString();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int qtd = int.TryParse(txtQuantidade.Text, out qtd) ? qtd : 0;
            if (qtd > 0)
                txtQuantidade.Text = (qtd - 1).ToString();
        }

        private void btnAdicionarEstoque_Click(object sender, EventArgs e)
        {
            if (cmbProdutos.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }

            // Validação de quantidade
            if (!int.TryParse(txtQuantidade.Text, out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Quantidade inválida. Digite apenas números inteiros positivos.");
                txtQuantidade.Focus();
                txtQuantidade.SelectAll();
                return;
            }

            // Validação de preço de compra
            string precoTexto = txtPrecoCompra.Text.Replace("R$", "").Trim().Replace(',', '.');
            if (!decimal.TryParse(precoTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal precoCompra) || precoCompra <= 0)
            {
                MessageBox.Show("Preço de compra inválido. Digite apenas números positivos.");
                txtPrecoCompra.Focus();
                txtPrecoCompra.SelectAll();
                return;
            }

            string produto = cmbProdutos.SelectedItem.ToString();
            string dataCompra = DateTime.Now.ToString("yyyy-MM-dd");
            string novaLinha = $"{produto};{quantidade};{precoCompra.ToString(CultureInfo.InvariantCulture)};{dataCompra}";
            File.AppendAllLines("estoque.txt", new[] { novaLinha });

            // Remove o popup de confirmação
            txtPrecoCompra.Text = ""; // Limpa o campo de preço de compra
            CarregarEstoqueNoGrid();
        }

        private void btnRemoverEstoque_Click(object sender, EventArgs e)
        {
            if (cmbProdutos.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }
            if (!int.TryParse(txtQuantidade.Text, out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Quantidade inválida.");
                txtQuantidade.Focus();
                txtQuantidade.SelectAll();
                return;
            }

            string produto = cmbProdutos.SelectedItem.ToString();
            // Carrega todas as compras do produto
            var linhas = File.Exists("estoque.txt") ? File.ReadAllLines("estoque.txt").ToList() : new List<string>();
            var compras = linhas
                .Select((linha, idx) => new { linha, idx, partes = linha.Split(';') })
                .Where(x => x.partes.Length == 4 && x.partes[0] == produto)
                .OrderBy(x => DateTime.Parse(x.partes[3])) // FIFO
                .ToList();

            int qtdParaRemover = quantidade;
            foreach (var compra in compras)
            {
                int qtdCompra = int.Parse(compra.partes[1]);
                if (qtdCompra >= qtdParaRemover)
                {
                    qtdCompra -= qtdParaRemover;
                    if (qtdCompra == 0)
                        linhas[compra.idx] = null; // Remove a linha
                    else
                        linhas[compra.idx] = $"{compra.partes[0]};{qtdCompra};{compra.partes[2]};{compra.partes[3]}";
                    qtdParaRemover = 0;
                    break;
                }
                else
                {
                    qtdParaRemover -= qtdCompra;
                    linhas[compra.idx] = null; // Remove a linha
                }
            }
            linhas = linhas.Where(l => l != null).ToList();
            File.WriteAllLines("estoque.txt", linhas);

            MessageBox.Show("Produto removido do estoque!");
            CarregarEstoqueNoGrid();
        }

        private void CarregarEstoqueNoGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Produto");
            dt.Columns.Add("Quantidade");
            dt.Columns.Add("Preço Unitário");
            dt.Columns.Add("Total Gasto");
            dt.Columns.Add("Data da Compra");

            string produtoSelecionado = cmbProdutos.SelectedItem?.ToString();
            int totalQtd = 0;
            decimal totalGasto = 0;

            if (File.Exists("estoque.txt") && !string.IsNullOrEmpty(produtoSelecionado))
            {
                foreach (var linha in File.ReadAllLines("estoque.txt"))
                {
                    var partes = linha.Split(';');
                    if (partes.Length == 4 && partes[0] == produtoSelecionado)
                    {
                        int qtd = int.Parse(partes[1]);
                        decimal preco = decimal.Parse(partes[2], CultureInfo.InvariantCulture);
                        string data = partes[3];
                        decimal total = qtd * preco;

                        dt.Rows.Add(partes[0], qtd, "R$ " + preco.ToString("N2"), "R$ " + total.ToString("N2"), data);

                        totalQtd += qtd;
                        totalGasto += total;
                    }
                }
            }
            dataGridViewEstoque.DataSource = dt;

            // Lê os preços tabelado e de venda de produtos.txt
            decimal precoTabelado = 0, precoVenda = 0;
            if (!string.IsNullOrEmpty(produtoSelecionado) && File.Exists("produtos.txt"))
            {
                foreach (var linha in File.ReadAllLines("produtos.txt"))
                {
                    var partes = linha.Split(';');
                    if (partes.Length >= 4 && $"{partes[0]} - {partes[1]}" == produtoSelecionado)
                    {
                        decimal.TryParse(partes[2], NumberStyles.Any, CultureInfo.InvariantCulture, out precoTabelado);
                        decimal.TryParse(partes[3], NumberStyles.Any, CultureInfo.InvariantCulture, out precoVenda);
                        break;
                    }
                }
            }

            decimal media = totalQtd > 0 ? totalGasto / totalQtd : 0;
            decimal lucroTabelado = (precoTabelado - media) * totalQtd;
            decimal percTabelado = (media > 0 && precoTabelado > 0) ? ((precoTabelado - media) / media) * 100 : 0;
            decimal lucroVenda = (precoVenda - media) * totalQtd;
            decimal percVenda = (media > 0 && precoVenda > 0) ? ((precoVenda - media) / media) * 100 : 0;

            string resumo = $"{produtoSelecionado}:\n";
            resumo += $"  {totalQtd} itens, Média: R$ {media:N2}, Total gasto: R$ {totalGasto:N2}\n";
            resumo += $"  Lucro se vender pelo preço tabelado: R$ {lucroTabelado:N2} ({percTabelado:N2}%)\n";
            resumo += $"  Lucro se vender pelo preço de venda: R$ {lucroVenda:N2} ({percVenda:N2}%)\n";
            lblResumoTotal.Text = resumo;
        }
    }
}
