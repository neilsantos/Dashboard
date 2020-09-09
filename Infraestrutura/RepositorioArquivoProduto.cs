using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Dashboard.Infraestrutura
{
    class RepositorioArquivoProduto
    {
        private readonly List<Produto> Produtos = new List<Produto>();

        const string folder = "D:\\databaseDashboard\\Inventario.txt";

        public RepositorioArquivoProduto()
        {
            StreamReader file = new StreamReader(folder);
            string line = file.ReadToEnd();
            file.Close();
            if (line != "")
            {
                Produtos = JsonConvert.DeserializeObject<List<Produto>>(line);

            }
        }

        private void SalvarParaArquivo()
        {
            var ListaProdutos = JsonConvert.SerializeObject(Produtos);

            //Gravando no arquivo de texto
            TextWriter txt = new StreamWriter(folder);
            txt.Write(ListaProdutos);
            txt.Close();
        }

        public IEnumerable<Produto> Ler()
        {

            var json = JsonConvert.SerializeObject(Produtos);
            List<Produto> listaSemReferencia = JsonConvert.DeserializeObject<List<Produto>>(json);

            return listaSemReferencia.OrderBy(x => x.Id);
        }

        public Produto Adicionar(Produto Produto)
        {

            Produtos.Add(Produto);
            int maiorId = Produtos.Max(X => X.Id);
            Produto.Id = ++maiorId;
            SalvarParaArquivo();
            return Produto;
        }

        public void Atualizar(Produto Produto)
        {
            var item = Produtos.FirstOrDefault(x => x.Id == Produto.Id);
            if (item == null)
            {
                throw new Exception("Item Não Encontrado");
            }
            Produtos.Remove(item);
            Produtos.Add(Produto);
            SalvarParaArquivo();

        }

        public void Remover(Produto Produto)
        {
            var item = Produtos.FirstOrDefault(x => x.Id == Produto.Id);
            Produtos.Remove(item);
            SalvarParaArquivo();
        }


    }
}
