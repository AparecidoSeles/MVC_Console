using System;
using System.IO;
using System.Collections.Generic;

namespace MVC_Console.models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        
        public float Preco { get; set; }
        
        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            string pasta = PATH.Split("/")[0];

            //verificamos se a pasta Database não existe e criamos nesta condição

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //verifcamos se a  arquivo Produto.csv não existe e criamos
            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Produto> Ler()
            {
                List<Produto> produtos = new List<Produto>();
            
            //pega informações csv
            string[] linhas = File.ReadAllLines(PATH);

            //separar atributos pelo ;
            foreach (string item in linhas)
            {
                string [] atributos = item.Split(";");
                //cramos um protudo vazio para poder colocar a lista final de produtos
                Produto prod =  new Produto();
                prod.Codigo  = int.Parse(atributos [0]);
                prod.Nome    = atributos[1];
                prod.Preco   = float.Parse(atributos[2]);

                produtos.Add(prod);
            }
 
              return produtos;
            }
         
    }
}