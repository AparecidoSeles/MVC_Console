using System;
using System.Collections.Generic;
using MVC_Console.models;

namespace MVC_Console.views
{
    public class ProdutoViews
    {
        public void ListarTodos(List<Produto> produtos)
        {
            foreach (Produto item in produtos)
            {
                Console.WriteLine($"Código : {item.Codigo}");
                Console.WriteLine($"Nome : {item.Nome}");
                Console.WriteLine($"Preço : {item.Preco}");
                Console.WriteLine();
            }
        }

        public Produto CadsastrarProduto()
        {
            Produto produto = new Produto();

            Console.WriteLine($"Digite o Código do produto:");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome do produto:");
            produto.Nome = Console.ReadLine();

            Console.WriteLine($"Digite o preço do produto:");
            produto.Preco = float.Parse(Console.ReadLine());

            return produto;
            
        }
    }
}