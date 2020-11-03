using Dashboard.Apresentacao.Models;
using Dashboard.Apresentacao.Views.MarcaView;
using Dashboard.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dashboard.Apresentacao.Controllers
{
    public class MarcaController
    {
        public void Index()
        {
            var menu = new Menu();
            menu.Print();
            var opcao = Helper.LerInteiro("Escolha uma opção");
            var opcaoDoMenu = (MarcaMenu)opcao;
            switch (opcaoDoMenu)
            {
                case MarcaMenu.Cadastrar:
                    var cadastrar = new Cadastrar();
                    var marca = cadastrar.Print();
                    var retorno = Cadastrar(marca);
                    new Mensagem<Marca>().Print(retorno);
                    break;
                case MarcaMenu.Exibir:
                    var listaMarcas = Mostrar();
                    new Mostrar().Print(listaMarcas);
                    break;
                case MarcaMenu.Remover:
                    break;
                case MarcaMenu.Atualizar:
                    break;
                case MarcaMenu.Retornar:
                    break;
                default:
                    break;
            }
        }
        
        public Retorno<Marca> Remover()
        {
            var repositorioMarcas = new RepositorioArquivoMarca();
            var marcas = repositorioMarcas.Ler();
            if (!marcas.Any())
            {
                var status = new Retorno<Marca>
                {

                    DeuCerto = false,
                    Mensagens = new List<string> { "Que Pena, não tem nada aqui ainda. Volte e Cadastre uma Marca =)" }
                };
                return status;
            }

            string op = "";
            Console.WriteLine("\nDeseja Excluir? (S / N)");
            op = Console.ReadLine();
            op = op.ToUpper();
            if (op == "S")
            {
                repositorioMarcas.Remover("");
                Console.WriteLine("Ítem Removido com sucesso!");
                Console.ReadKey();

            }
            if (op == "N")
            {
                Console.WriteLine("Operação Cancelada.");
                Console.ReadKey();
                return;
            }
            return;
        }

        public IEnumerable<Marca> Mostrar()
        {
            var Marcas = new RepositorioArquivoMarca();
            return Marcas.Ler();
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
