using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Dashboard
{
    public class RepositorioArquivo<T> : IRepositorio<T> where T : EntidadeBase
    {
        string Folder;

        List<T> itens = new List<T>();
        public RepositorioArquivo(string folder)
        {
            Folder = folder;
            StreamReader file = new StreamReader(folder);
            string line = file.ReadToEnd();
            file.Close();

            if (line == "")
            {
                return;
            }

            itens = JsonConvert.DeserializeObject<List<T>>(line);
        }

        private void SalvarParaArquivo()
        {
            var Lista = JsonConvert.SerializeObject(itens);

            //Gravando no arquivo de texto
            TextWriter txt = new StreamWriter(Folder);
            txt.Write(Lista);
            txt.Close();
        }

        public IEnumerable<T> Ler()
        {
            var json = JsonConvert.SerializeObject(itens);
            List<T> listaSemReferencia = JsonConvert.DeserializeObject<List<T>>(json);
            return listaSemReferencia.OrderBy(x => x.Id);
        }

        public T Adicionar(T item)
        {
            itens.Add(item);
            int maiorId = itens.Max(X => X.Id);
            item.Id = ++maiorId;
            return item;

        }

        public void Atualizar(T item)
        {
            var obj = itens.FirstOrDefault(x => x.Id == item.Id);
            if (obj == null)
            {
                throw new Exception("Item Não Encontrado na lista");
            }

            itens.Remove(obj);
            itens.Add(item);
        }

        public void Remover(T item)
        {
            var obj = itens.FirstOrDefault(X => X.Id == item.Id);
            itens.Remove(obj);
        }
    }
}
