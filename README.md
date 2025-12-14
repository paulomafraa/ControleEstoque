# Controle de Estoque & Precificação 📦

![Status](https://img.shields.io/badge/STATUS-FINALIZADO-green?style=for-the-badge)
![.NET](https://img.shields.io/badge/.NET%20Framework-4.8-purple?style=for-the-badge)

Aplicação Desktop para gerenciamento de inventário focada em nichos de colecionáveis e varejo. O sistema vai além do simples "entrada e saída", oferecendo ferramentas de análise financeira para cálculo de margem de lucro e custo médio de aquisição.

## 📋 Funcionalidades Principais

### 📦 Gestão de Produtos
- Cadastro completo com categorização (ex: Blister, ETB, Booster Box).
- Definição de **Preço Tabelado** vs. **Preço de Venda Real**.
- Persistência de dados leve utilizando arquivos locais (`.txt`), sem necessidade de servidor SQL.

### 📉 Controle de Fluxo (FIFO)
- **Entradas:** Registro de compras com custo unitário variável no tempo.
- **Saídas:** O sistema utiliza lógica **FIFO (First-In, First-Out)**. Ao vender um item, ele desconta do lote mais antigo primeiro, garantindo um cálculo de lucro mais preciso.

### 💲 Análise Financeira Automatizada
- Cálculo automático do **Preço Médio** de estoque.
- Relatório em tempo real mostrando:
  - Total investido em estoque.
  - Lucro projetado (R$) e Margem (%) baseada no preço de venda atual.

## 💻 Tecnologias

- **C#**: Lógica de negócio e manipulação de arquivos (I/O).
- **Windows Forms**: Front-end desktop.
- **LINQ**: Utilizado para consultas e filtros eficientes nos dados em memória.

## 🚀 Instalação e Uso

1. Faça o clone do repositório.
2. Abra a solução `ControleEstoque.sln`.
3. Compile e execute.
4. O sistema criará automaticamente os arquivos de banco de dados (`produtos.txt` e `estoque.txt`) na pasta de execução na primeira utilização.

---
Desenvolvido por **[Seu Nome]**
