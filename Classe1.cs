using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;



namespace Dashboard
{
    class Classe1
    {

        public Classe1()
        {
            List<Produto> Inventario = new List<Produto>();

            Categoria eletronico = new Categoria("Eletrônico");
            Categoria categoriaDoAcessorio = new Categoria("Generico");

            Marca microsoft = new Marca("Microsoft");
            Produto xBox = new Produto("Xbox360",eletronico,microsoft,500);

            

             xBox.AdicionarAcessorio("Controle Original");
            //Console.WriteLine(xBox.Nome + " "+ xBox.Categoria.Nome + " "+ xBox.Marca.Nome);
           
            
            var json = JsonConvert.SerializeObject(xBox);

            //Gravando no arquivo de texto
            TextWriter txt = new StreamWriter("D:\\arquivo.txt");
            txt.Write(json);
            txt.Close();


            Console.ReadKey();

            //Lendo do arquivo de texto
            StreamReader file =  new StreamReader("D:\\arquivo.txt");
            string line = file.ReadToEnd();
            file.Close();

            Produto nProduto = JsonConvert.DeserializeObject<Produto>(line);

            
                Console.WriteLine(nProduto.Id);
                Console.WriteLine(nProduto.Nome);
                Console.WriteLine(nProduto.Marca.Nome);
                Console.WriteLine(nProduto.Categoria.Nome);
                Console.WriteLine(nProduto.Valor);
            

            //foreach (var item in xBox.Acessorios)
            //{
            //Console.WriteLine(item.Nome + " "+ item.Categoria.Nome + " "+ item.Marca.Nome);
            //}
            //foreach (var item in xBox.Acessorios)
            //{
            //    item.Categoria = eletronico;
            //    item.Nome = "Novo";
            //}
            //foreach (var item in xBox.Acessorios)
            //{
            //Console.WriteLine(item.Nome + " "+ item.Categoria.Nome + " "+ item.Marca.Nome);
            //}
        }
    }
}
