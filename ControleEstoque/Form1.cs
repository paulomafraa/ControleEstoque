using System;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Data;
using System.Linq;

namespace ControleEstoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Blister unitário");
            cmbTipo.Items.Add("Triple pack");
            cmbTipo.Items.Add("Quadri pack");
            cmbTipo.Items.Add("ETB");
            cmbTipo.Items.Add("Booster Box");
            cmbTipo.Items.Add("Mini Display");

            CarregarProdutosNoGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string tipo = cmbTipo.SelectedItem?.ToString() ?? "";
            string precoTabelado = txtPrecoTabelado.Text.Trim();
            string precoVenda = txtPrecoVenda.Text.Trim();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(tipo) ||
                string.IsNullOrEmpty(precoTabelado) || string.IsNullOrEmpty(precoVenda))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            string linha = $"{nome};{tipo};{precoTabelado};{precoVenda}";
            File.AppendAllText("produtos.txt", linha + Environment.NewLine);

            MessageBox.Show("Produto cadastrado com sucesso!");
            LimparCampos();
            CarregarProdutosNoGrid();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            cmbTipo.SelectedIndex = -1;
            txtPrecoTabelado.Clear();
            txtPrecoVenda.Clear();
        }

        private void CarregarProdutosNoGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nome");
            dt.Columns.Add("Tipo");
            dt.Columns.Add("Preço Tabelado");
            dt.Columns.Add("Preço de Venda");

            if (File.Exists("produtos.txt"))
            {
                foreach (var linha in File.ReadAllLines("produtos.txt"))
                {
                    var partes = linha.Split(';');
                    if (partes.Length == 4)
                    {
                        decimal precoTabeladoDecimal, precoVendaDecimal;
                        string precoTabelado = "Inválido";
                        string precoVenda = "Inválido";

                        if (decimal.TryParse(partes[2], NumberStyles.Any, CultureInfo.InvariantCulture, out precoTabeladoDecimal))
                            precoTabelado = "R$ " + precoTabeladoDecimal.ToString("N2");

                        if (decimal.TryParse(partes[3], NumberStyles.Any, CultureInfo.InvariantCulture, out precoVendaDecimal))
                            precoVenda = "R$ " + precoVendaDecimal.ToString("N2");

                        dt.Rows.Add(partes[0], partes[1], precoTabelado, precoVenda);
                    }
                }
            }

            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoResizeRows();
        }

        private void btnVerEstoque_Click(object sender, EventArgs e)
        {
            EstoqueForm estoqueForm = new EstoqueForm();
            estoqueForm.ShowDialog();
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para excluir.");
                return;
            }

            // Pega o nome e tipo do produto selecionado
            var row = dataGridView1.SelectedRows[0];
            string nome = row.Cells["Nome"].Value?.ToString();
            string tipo = row.Cells["Tipo"].Value?.ToString();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Produto inválido.");
                return;
            }

            // Confirmação
            var result = MessageBox.Show($"Deseja realmente excluir o produto '{nome} - {tipo}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            // Remove do arquivo
            if (File.Exists("produtos.txt"))
            {
                var linhas = File.ReadAllLines("produtos.txt")
                    .Where(l =>
                    {
                        var partes = l.Split(';');
                        return !(partes.Length >= 2 && partes[0] == nome && partes[1] == tipo);
                    })
                    .ToArray();
                File.WriteAllLines("produtos.txt", linhas);
            }

            CarregarProdutosNoGrid();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void lvlVenda_Click(object sender, EventArgs e)
        {

        }
    }
}