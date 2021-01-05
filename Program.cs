using System;
using MVC_Console.controllers;
using MVC_Console.models;

namespace MVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
          ProdutoController produtoCotroller = new ProdutoController();
          produtoCotroller.MostrarProdutos();
        }
    }
}
