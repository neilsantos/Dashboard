﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Dashboard.Infraestrutura
{
    public class RepositorioArquivoMarca : RepositorioArquivo<Marca>,IRepositorioMarca
    {
        //private readonly List<Marca> Marcas = new List<Marca>();
        const string folder = "D:\\databaseDashboard\\Marcas.txt";



        public RepositorioArquivoMarca() : base(folder)
        {
            
            
        }

        
       
        //private void PopularMarca()
        //{

        //    Marcas.Add(new Marca("Demo-Genérico"));
        //    Marcas.Add(new Marca("Demo-Microsoft"));
        //    Marcas.Add(new Marca("Demo-Nintendo"));
        //    Marcas.Add(new Marca("Demo-LG"));

        //    for (int i = 0; i < Marcas.Count; i++)
        //    {
        //        var Marca = Marcas[i];
        //        Marca.Id = i + 1;
        //    }

        //}





        //public IEnumerable<Marca> Ler()
        //{
        //    var json = JsonConvert.SerializeObject(Marcas);
        //    List<Marca> listaSemReferencia = JsonConvert.DeserializeObject<List<Marca>>(json);

        //    return listaSemReferencia.OrderBy(x => x.Id);
        //}

        //public Marca Adicionar(Marca Marca)
        //{

        //    Marcas.Add(Marca);
        //    int maiorId = Marcas.Max(X => X.Id);
        //    Marca.Id = ++maiorId;
        //    SalvarParaArquivo();
        //    return Marca;
        //}

        //public void Atualizar(Marca Marca)
        //{
        //    var item = Marcas.FirstOrDefault(x => x.Id == Marca.Id);
        //    if (item == null)
        //    {
        //        throw new Exception("Item Não Encontrado");
        //    }
        //    Marcas.Remove(item);
        //    Marcas.Add(Marca);
        //    SalvarParaArquivo();

        //}

        //public void Remover(Marca Marca)
        //{
        //    var item = Marcas.FirstOrDefault(x => x.Id == Marca.Id);
        //    Marcas.Remove(item);
        //    SalvarParaArquivo();
        //}
    }
}
