using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Dashboard.Infraestrutura
{
    class RepositorioArquivoCategoria
    {
        private readonly List<Categoria> Categorias = new List<Categoria>();
        const string folder = "D:\\databaseDashboard\\Categorias.txt";
        public RepositorioArquivoCategoria()
        {
            StreamReader file = new StreamReader(folder);
            string line = file.ReadToEnd();
            file.Close();

            if (line == "")
            {
                PopularCategoria();
                return;
            }
            
            Categorias = JsonConvert.DeserializeObject<List<Categoria>>(line);
        }
        
        private void SalvarParaArquivo()
        {
            var ListaCategorias = JsonConvert.SerializeObject(Categorias);

            //Gravando no arquivo de texto
            TextWriter txt = new StreamWriter(folder);
            txt.Write(ListaCategorias);
            txt.Close();
        }
       
        private void PopularCategoria()
        {
            
                Categorias.Add(new Categoria("Demo-Eletrônico"));
                Categorias.Add(new Categoria("Demo-Móveis"));
                Categorias.Add(new Categoria("Demo-Eletrodoméstico"));
                Categorias.Add(new Categoria("Demo-Colecionaveis"));

                for (int i = 0; i < Categorias.Count; i++)
                {
                    var Categoria = Categorias[i];
                    Categoria.Id = i + 1;
                }

            SalvarParaArquivo();
            
        }

        public IEnumerable<Categoria> Ler()
        {
            var json = JsonConvert.SerializeObject(Categorias);
            List<Categoria> listaSemReferencia = JsonConvert.DeserializeObject<List<Categoria>>(json);

            return listaSemReferencia.OrderBy(x => x.Id);
        }

        public Categoria Adicionar(Categoria categoria)
        {

            Categorias.Add(categoria);
            int maiorId = Categorias.Max(X => X.Id);
            categoria.Id = ++maiorId;
            SalvarParaArquivo();
            return categoria;
        }

        public void Atualizar(Categoria categoria)
        {
            var item = Categorias.FirstOrDefault(x => x.Id == categoria.Id);
            if (item == null)
            {
                throw new Exception("Item Não Encontrado");
            }
            Categorias.Remove(item);
            Categorias.Add(categoria);
            SalvarParaArquivo();

        }

        public void Remover(Categoria categoria)
        {
            var item = Categorias.FirstOrDefault(x => x.Id == categoria.Id);
            Categorias.Remove(item);
            SalvarParaArquivo();

        }
    }
}

