using Desafio_IBID.Models;
using System;
using System.Collections.Generic;



List<Produto> produtos = new List<Produto>();
int proximoId = 1;


bool sair = false;

while (!sair)
{

    ExibeMenu();
    Console.Write("Escolha uma opção: ");
    int opcao = Convert.ToInt32(Console.ReadLine());
    EscolhaMenu(opcao);

}
 
void ExibeMenu()
{
    Console.WriteLine("========== Gerenciamento de Produtos ==========");
    Console.WriteLine("1. Adicionar Produto");
    Console.WriteLine("2. Remover Produto");
    Console.WriteLine("3. Editar Nome do Produto");
    Console.WriteLine("4. Visualizar Todos os Produtos");
    Console.WriteLine("5. Sair");
    Console.WriteLine("===============================================");

}

void VoltaAoMenu()
{
    Console.WriteLine("Aperte uma tecla para voltar ao menu");
    Console.ReadKey();
}

void EscolhaMenu(int opcao)
{
    switch (opcao)
    {
        case 1:
            AdicionarProduto();
            VoltaAoMenu();
            break;
        case 2:
            RemoverProduto();
            VoltaAoMenu();
            break;
        case 3:
            EditarNomeProduto();
            VoltaAoMenu();
            break;
        case 4:
            VisualizarProdutos();
            VoltaAoMenu();
            break;
        case 5:
            sair = true;
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}
void AdicionarProduto()
{
    Console.Write("Digite o nome do produto: ");
    string nome = Console.ReadLine();

    Produto produto = new Produto
    {
        Id = proximoId++,
        Nome = nome
    };

    produtos.Add(produto);
    Console.WriteLine("Produto adicionado com sucesso!");
}

 void RemoverProduto()
{
    Console.Write("Digite o ID do produto a ser removido: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Produto produto = produtos.Find(p => p.Id == id);

    if (produto != null)
    {
        produtos.Remove(produto);
        Console.WriteLine("Produto removido com sucesso!");
    }
    else
    {
        Console.WriteLine("Produto não encontrado.");
    }
}

void EditarNomeProduto()
{
    Console.Write("Digite o ID do produto a ser editado: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Produto produto = produtos.Find(p => p.Id == id);

    if (produto != null)
    {
        Console.Write("Digite o novo nome do produto: ");
        string novoNome = Console.ReadLine();

        produto.Nome = novoNome;
        Console.WriteLine("Nome do produto atualizado com sucesso!");
    }
    else
    {
        Console.WriteLine("Produto não encontrado.");
    }
}

 void VisualizarProdutos()
{
    Console.WriteLine("========== Lista de Produtos ==========");
    foreach (var produto in produtos)
    {
        Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}");
    }
    Console.WriteLine("=======================================");
}

