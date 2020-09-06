using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dashboard.Infraestrutura
{
    class RepositorioMarca
    {
        public RepositorioMarca()
        {
            //PopularResitorio();
        }

        private readonly List<Marca> Marcas = new List<Marca>();

        private void PopularResitorio()
        {
            Marcas.Add(new Marca("Generico"));
            Marcas.Add(new Marca("Microsoft"));
            Marcas.Add(new Marca("Nintendo"));
            Marcas.Add(new Marca("LG"));
            Marcas.Add(new Marca("Sony"));

            for (int i = 0; i < Marcas.Count; i++)
            {
                var marca = Marcas[i];
                marca.Id = i+1;
            }
        }
        
        public IEnumerable<Marca> Ler()
        {
            var json = JsonConvert.SerializeObject(Marcas);
            List<Marca> listaSemReferencia = JsonConvert.DeserializeObject<List<Marca>>(json);

            return listaSemReferencia.OrderBy(x => x.Id);
        }

        public Marca Adicionar(Marca marca)
        {
            
            Marcas.Add(marca);
            int maiorId = Marcas.Max(X => X.Id);
            marca.Id = ++maiorId;
            return marca;
        }

        public void Atualizar(Marca marca)
        {
            var item = Marcas.FirstOrDefault(x => x.Id == marca.Id);
            if (item == null)
            {
                throw new Exception("Item Não Encontrado na lista");
            }

            Marcas.Remove(item);
            Marcas.Add(marca);
        }

        public void Remover(Marca marca)
        {
            var item = Marcas.FirstOrDefault(X => X.Id == marca.Id);
            Marcas.Remove(item);
        }

    }
}
