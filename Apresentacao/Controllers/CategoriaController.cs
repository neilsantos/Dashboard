using Dashboard.Apresentacao.Models;
using Dashboard.Apresentacao.Views.MarcaView;
using Dashboard.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dashboard.Apresentacao.Controllers
{
    public class CategoriaController
    {
        public void Index()
        {
            var menu = new Menu();
            menu.Print();
            var opcao = Helper.LerInteiro("Escolha uma opção");
            var opcaoDoMenu = (CategoriaMenu)opcao;
            switch (opcaoDoMenu)
            {
                case CategoriaMenu.Cadastrar:
                    break;
                case CategoriaMenu.Exibir:
                    break;
                case CategoriaMenu.Remover:
                    break;
                case CategoriaMenu.Atualizar:
                    break;
                case CategoriaMenu.Retornar:
                    break;
                default:
                    break;
            }
        }
        
        public Retorno<Marca> Cadastrar(Marca marca)
        {
            var repositorioMarcas = new RepositorioArquivoMarca();
            bool Existe = repositorioMarcas.Ler()
               .Any(X => X.Nome == marca.Nome) ;

            if (Existe)
            {
                var status = new Retorno<Marca> {

                    DeuCerto = false,
                    Mensagens = new List<string> { "ESSA MARCA JA EXISTE, ADICIONE UMA DIFERENTE" }
                };
                
                return status;
            }
            repositorioMarcas.Adicionar(marca);
            return new Retorno<Marca>(marca);
        }
    }
}
