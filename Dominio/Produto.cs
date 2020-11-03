using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Dashboard
{
    public class Produto:EntidadeBase
    {
        public string Nome { get; set; }
       
        private Categoria categoria;
        
        public Categoria Categoria 
        { 
           get => categoria; 
           set
            {
                if (ProdutoPai != null && value != ProdutoPai.Categoria)
                    throw new Exception("A Categoria Deve Ser " + ProdutoPai.Categoria.Nome);
                categoria = value;
            }
        
        }
        
        public Marca Marca{ get; set; }
        
        public float Valor { get; set; }
        
        private readonly List<Produto> acessorios;
      
        public IEnumerable<Produto> Acessorios => acessorios;

        private Produto ProdutoPai { get; set; }


        public Produto(string nome, Categoria categoria, Marca marca, float valor)
        {
            Nome = nome;
            Categoria = categoria ?? throw new Exception("É Obrigatório Ter uma Categoria");
            Marca = marca ?? throw new Exception("É Obrigatório Ter uma Marca");
            Valor = valor;
            acessorios = new List<Produto>();
        }

        public IEnumerable<Produto> LerAcessorios()
        {
            return Acessorios;
        }
        
        public void AdicionarAcessorio(string nome, float valor = 0)
        {
            var acessorio = new Produto(nome, Categoria, Marca, valor);
            acessorio.ProdutoPai = this;
            acessorios.Add(acessorio);
            var maxId = acessorios.Max(x => x.Id);
            acessorio.Id = ++maxId;
        }
        
        public void AdicionarAcessorio(string nome, float valor, Marca marca)
        {
            var acessorio = new Produto(nome, Categoria, marca, valor);
            acessorios.Add(acessorio);
            var maxId = acessorios.Max(x => x.Id);
            acessorio.Id = ++maxId;
        }
        
        public void AtualizarAcessorio(Produto acessorio)
        {
            var item = acessorios.FirstOrDefault(x => x.Id == acessorio.Id);
            if (item == null)
            {
                throw new Exception("Item Não Encontrado");
            }
            acessorios.Remove(item);
            acessorios.Add(acessorio);
        }
       
        public void RemoverAcessorio(Produto acessorio)
        {
            var item = acessorios.FirstOrDefault(x => x.Id == acessorio.Id);
            acessorios.Remove(item);
       
        }

        public float Total => Acessorios.Sum(x => x.Valor) + Valor;

    }

}
