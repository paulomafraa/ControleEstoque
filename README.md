# ControleEstoque

Aplicação desktop de estoque e precificação para colecionáveis e varejo.

![Status](https://img.shields.io/badge/status-finalizado-0f3d36?style=flat-square)
![.NET](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?style=flat-square)
![WinForms](https://img.shields.io/badge/Windows%20Forms-desktop-0078D4?style=flat-square)

## Sobre

Vai além de entrada e saída: calcula margem, custo médio e lucro projetado.  
Persistência em arquivos locais (`.txt`), sem servidor SQL.

Esta é a versão desktop. A evolução web está em [GerenciadorEstoque.v2](https://github.com/paulomafraa/GerenciadorEstoque.v2).

## Stack

| Item | Tecnologia |
| --- | --- |
| Linguagem | C# |
| Interface | Windows Forms |
| Consultas | LINQ |
| Persistência | Arquivos locais (`.txt`) |

## Funcionalidades

### Produtos
- Cadastro com categorias (Blister, ETB, Booster Box, etc.)
- Preço tabelado vs preço de venda real
- Dados locais em `produtos.txt` e `estoque.txt`

### Fluxo
- Entradas com custo unitário
- Saídas com lógica FIFO (desconta do lote mais antigo primeiro)

### Análise
- Preço médio de estoque
- Total investido
- Lucro projetado (R$) e margem (%)

## Como rodar

1. Clone o repositório
2. Abra `ControleEstoque.sln`
3. Compile e execute
4. Na primeira execução, o sistema cria `produtos.txt` e `estoque.txt`

## Autor

[Paulo Mafra Watanabe](https://github.com/paulomafraa) · [LinkedIn](https://www.linkedin.com/in/paulo-watanabe/)
