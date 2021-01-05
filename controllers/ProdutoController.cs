using System;
using System.Collections.Generic;
using MVC_Console.models;
using MVC_Console.views;

namespace MVC_Console.controllers
{
    public class ProdutoController
    {

        Produto produto = new Produto();
        ProdutoViews produtoView = new ProdutoViews();
         
        public void MostrarProdutos()
        {
            List<Produto> todos = produto.Ler();
            produtoView.ListarTodos(todos);
        }
    }
}