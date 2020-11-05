using Dashboard.Apresentacao;
using Dashboard.Apresentacao.Controllers;
using Dashboard.Infraestrutura;
using Dashboard.Infraestrutura.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dashboard
{
    class Program
    {
        public static IRepositorioMarca repositorioMarcas = new RepositorioArquivoMarca();
        public static IRepositorioCategoria repositorioCategorias = new RepositorioArquivoCategoria();
        public static IRepositorioProduto repositorioProduto = new RepositorioArquivoProduto();


        static void Main(string[] args)
        {

            var marcas = repositorioMarcas.Ler();
            var categorias = repositorioCategorias.Ler();
            var inventario = repositorioProduto.Ler();
            var homeController = new HomeController();
            //Menu
            int op = 1;
            while (op != 0)
            {
                homeController.Index();

                //Console.WriteLine("Escolha uma opção: ");
                //op = Convert.ToInt32(Console.ReadLine());

                //switch (op)
                //{
                //    case 1:
                //        Console.Clear();
                //        Console.WriteLine("Cadastrar Marca \n");
                //        MostrarMarcas();
                //        CadastrarMarca();
                //        break;

                //    case 2:

                //        Console.Clear();
                //        Console.WriteLine("Cadastrar Categoria \n");
                //        MostrarCategorias();
                //        CadastrarCategoria();
                //        break;

                //    case 3:
                //        CadastrarProduto();
                //        break;

                //    case 4:
                //        Console.Clear();
                //        MostrarMarcas();
                //        MostrarCategorias();
                //        Console.ReadKey();
                //        break;

                //    case 5:
                //        Console.Clear();
                //        MostrarInventario();
                //        Console.ReadKey();
                //        break;

                //    case 6:
                //        Console.Clear();

                //        var categoria = LerCategoria();
                //        Console.WriteLine("Mostrar Por CategoriaS\n");
                //        MostrarPor(categoria);
                //        Console.ReadKey();
                //        break;
                //    case 7:
                //        Console.Clear();

                //        var marca = LerMarca();
                //        Console.WriteLine("Mostrar Por Marca\n");
                //        MostrarPor(marca);
                //        Console.ReadKey();
                //        break;

                //    case 8:
                //        Console.Clear();
                //        MostrarCategorias();
                //        DeletarCategoria();
                //        break;

                //    case 9:
                //        MostrarMarcas();
                //        DeletarMarca();
                //        break;

                //    case 10:
                //        Console.Clear();
                //        Console.WriteLine("REMOVER PRODUTO");
                //        MostrarInventario();
                //        DeletarInventario();
                //        break;

                //    case 11:
                //        Console.Clear();
                //        AtualizarCategoria();
                //        break;

                //    case 12:
                //        Console.Clear();
                //        MostrarMarcas();
                //        AtualizarMarca();
                //        break;

                //    case 13:
                //        Console.Clear();
                //        MostrarInventario();
                //        Atualizar();
                //        break;

                //    case 14:
                //        Console.Clear();
                //        CalcularInventario();
                //        Console.ReadKey();
                //        break;

                //    default:
                //        Console.WriteLine("OPÇAO INVALIDA, ESCOLHA SOMENTE OS ITENS ACIMA");
                //        Console.ReadKey();
                //        break;
            }
        }
    }
}

//        private static void MostrarMarcas()
//        {
//            Console.WriteLine("\n\nLista de Marcas\n");
//            foreach (var marca in repositorioMarcas.Ler())
//            {
//                Console.WriteLine(marca.Id + " - " + marca.Nome);
//            }
//        }

//        private static void MostrarCategorias()
//        {
//            Console.WriteLine("Lista de Categoria\n");
//            foreach (var categoria in repositorioCategorias.Ler())
//            {
//                Console.WriteLine(categoria.Id + " - " + categoria.Nome);
//            }
//        }

//        private static void MostrarInventario(IEnumerable<Produto> inventario)
//        {

//            if (!inventario.Any())
//            {
//                Console.WriteLine("Nenhum produto para listar");
//                return;
//            }

//            foreach (var Produto in inventario)
//            {
//                Console.WriteLine("ID: " + Produto.Id);
//                Console.WriteLine("Produto: " + Produto.Nome);
//                Console.WriteLine("Marca: " + Produto.Marca.Nome);
//                Console.WriteLine("Categoria: " + Produto.Categoria?.Nome);
//                Console.WriteLine("Valor: " + Produto.Valor);
//                Console.WriteLine("\n Acessórios: ");
//                if (!Produto.Acessorios.Any())
//                {
//                    Console.WriteLine("Não Há Acessorios Cadastrados\n");
//                    continue;
//                }
//                foreach (var acessorio in Produto.Acessorios)
//                {
//                    Console.WriteLine("\n\tID:" + acessorio.Id);
//                    Console.WriteLine("\tNome:" + acessorio.Nome);
//                    Console.WriteLine("\tMarca:" + acessorio.Marca.Nome);
//                    Console.WriteLine("\tCategoria:" + acessorio.Categoria.Nome);
//                    var valor = acessorio.Valor == 0 ? "Stock Item" : acessorio.Valor.ToString();
//                    Console.WriteLine("\tValor: " + valor);
//                }
//                Console.WriteLine("\n\n");
//            }

//        }

//        private static void MostrarInventario()
//        {
//            var inventario = repositorioProduto.Ler();
//            MostrarInventario(inventario);
//        }

//        private static void CadastrarProduto()
//        {
//            IEnumerable<Marca> marcas = repositorioMarcas.Ler();
//            IEnumerable<Categoria> categorias = repositorioCategorias.Ler();
//            IEnumerable<Produto> inventario = repositorioProduto.Ler();
//            Console.Clear();

//            //titulo
//            Console.WriteLine("1. CADASTRO DE PRODUTO\n");

//            //Imprimir os Itens

//            Console.WriteLine("\nInforme o nome do produto:\n");
//            string nomeProduto = Console.ReadLine();


//            Categoria interCat = LerCategoria();

//            Marca interMarca = LerMarca();

//            float valor = Helper.LerValor();

//            //criando e adicionando um novo Produto ao inventario
//            Produto novoProduto = new Produto(nomeProduto, interCat, interMarca, valor);

//            Console.WriteLine("\nDeseja adicionar acessórios (S para adicionar)");
//            var escolha = Console.ReadLine();
//            escolha = escolha.ToUpper();
//            if (escolha == "S")
//            {
//                var qtd = Helper.LerInteiro("Quantos itens quer cadastrar?");
//                for (int i = 0; i < qtd; i++)
//                {
//                    Console.WriteLine(i + 1 + "º item\n Nome:");
//                    var acessorioNome = Console.ReadLine();
//                    novoProduto.AdicionarAcessorio(acessorioNome);
//                }
//            }


//            if (inventario.Any())
//            {
//                int maiorId = inventario.Max(X => X.Id);
//                novoProduto.Id = ++maiorId;
//            }

//            repositorioProduto.Adicionar(novoProduto);

//        }

//        private static Categoria LerCategoria()
//        {

//            bool eValido = true;
//            int idCategoria = 0;
//            var idsCategoria = repositorioCategorias.Ler().Select(X => X.Id);
//            do
//            {

//                Console.Clear();
//                MostrarCategorias();
//                Console.WriteLine("\nInforme o id da categoria\n");


//                eValido = int.TryParse(Console.ReadLine(), out idCategoria);



//                if (!eValido)
//                {
//                    Console.WriteLine("Escolha apenas os Itens acima");
//                    Console.ReadKey();
//                }
//                if (!idsCategoria.Contains(idCategoria))
//                {
//                    Console.WriteLine("Escolha apenas os Itens acima");
//                    Console.ReadKey();
//                }

//            } while (!idsCategoria.Contains(idCategoria) || !eValido);

//            Categoria categoria = repositorioCategorias.Ler().FirstOrDefault(X => X.Id == idCategoria);

//            return categoria;
//        }

//        private static Marca LerMarca()
//        {
//            var marcas = repositorioMarcas.Ler();
//            var eValido = true;
//            int idMarca;
//            var idsMarca = marcas.Select(X => X.Id);
//            do
//            {
//                Console.Clear();
//                MostrarMarcas();
//                Console.WriteLine("Informe o ID da Marca;\n");

//                eValido = int.TryParse(Console.ReadLine(), out idMarca);
//                if (!eValido)
//                {
//                    Console.WriteLine("É necessário informar um numero da lista");
//                }

//                if (!idsMarca.Contains(idMarca))
//                {
//                    Console.WriteLine("Escolha apenas os Itens acima");
//                    Console.ReadKey();
//                }

//            } while (!idsMarca.Contains(idMarca) || !eValido);
//            var marca = marcas.FirstOrDefault(X => X.Id == idMarca);

//            return marca;
//        }

//        private static Produto LerProduto()
//        {
//            var inventario = repositorioProduto.Ler();
//            var eValido = true;
//            int idProduto;
//            var idsInventario = inventario.Select(X => X.Id);
//            do
//            {
//                Console.Clear();
//                MostrarInventario(inventario);
//                Console.WriteLine("Informe o ID do Produto:\n");

//                eValido = int.TryParse(Console.ReadLine(), out idProduto);
//                if (!eValido)
//                {
//                    Console.WriteLine("É necessário informar um numero da lista");
//                }

//                if (!idsInventario.Contains(idProduto))
//                {
//                    Console.WriteLine("Escolha apenas os Itens acima");
//                    Console.ReadKey();
//                }

//            } while (!idsInventario.Contains(idProduto) || !eValido);
//            var produto = inventario.FirstOrDefault(X => X.Id == idProduto);
//            return produto;
//        }

//        private static void MostrarPor(Categoria categoriaSelecionada)
//        {
//            var inventario = repositorioProduto.Ler();
//            var print = inventario.Where(X => X.Categoria == categoriaSelecionada);
//            MostrarInventario(print);
//        }

//        private static void MostrarPor(Marca marcaSelecionada)
//        {

//            var inventario = repositorioProduto.Ler();
//            var print = inventario.Where(X => X.Marca == marcaSelecionada);

//            MostrarInventario(print);
//        }

//        private static void CadastrarMarca()
//        {
//            Console.WriteLine("Informe a Nova Marca");
//            string nomeMarca = Console.ReadLine();
//            bool Existe = repositorioMarcas.Ler()
//                .Any(X => X.Nome == nomeMarca);

//            if (Existe)
//            {
//                Console.WriteLine("ESSA MARCA JA EXISTE, ADICIONE UMA DIFERENTE");
//                Console.ReadKey();
//                return;
//            }

//            Marca novaMarca = new Marca(nomeMarca);

//            repositorioMarcas.Adicionar(novaMarca);

//        }

//        private static void CadastrarCategoria()
//        {


//            Console.WriteLine("\nInforme a Nova Categoria");
//            string nomeCategoria = Console.ReadLine();
//            bool Existe = repositorioCategorias.Ler().Any(x => x.Nome == nomeCategoria);

//            if (Existe)
//            {
//                Console.WriteLine("ESSA CATEGORIA JA EXISTE, ADICIONE UMA DIFERENTE");
//                Console.ReadKey();
//                return;
//            }

//            var novaCategoria = new Categoria(nomeCategoria);
//            repositorioCategorias.Adicionar(novaCategoria);

//        }

//        private static void DeletarCategoria()
//        {
//            var categorias = repositorioCategorias.Ler();

//            if (!categorias.Any())
//            {
//                Console.WriteLine("Nenhum item em categoria");
//                return;
//            }
//            Console.WriteLine("\nInforme o ID a ser deletado");
//            bool eValido = int.TryParse(Console.ReadLine(), out int id);
//            if (!eValido)
//            {
//                Console.WriteLine("ID Não Encontrado, escolha um item da lista");
//                Console.ReadKey();
//                return;
//            }
//            var confirmar = categorias.FirstOrDefault(X => X.Id == id);

//            Console.WriteLine("\nID: " + confirmar.Id);
//            Console.WriteLine("Nome: " + confirmar.Nome);

//            string op = "";
//            Console.WriteLine("\nDeseja Excluir? (S / N)");
//            op = Console.ReadLine();
//            op = op.ToUpper();
//            if (op == "S")
//            {
//                repositorioCategorias.Remover(confirmar);
//                Console.WriteLine("Ítem Removido com sucesso!");
//                Console.ReadKey();

//            }
//            if (op == "N")
//            {
//                Console.WriteLine("Operação Cancelada");
//                Console.ReadKey();

//                return;
//            }


//        }

//        private static void DeletarMarca()
//        {
//            var marcas = repositorioMarcas.Ler();
//            if (!marcas.Any())
//            {
//                Console.WriteLine("Nenhum item em categoria");
//                return;
//            }
//            var confirmar = LerMarca();

//            Console.WriteLine("\nID: " + confirmar.Id);
//            Console.WriteLine("Nome: " + confirmar.Nome);

//            string op = "";
//            Console.WriteLine("\nDeseja Excluir? (S / N)");
//            op = Console.ReadLine();
//            op = op.ToUpper();
//            if (op == "S")
//            {
//                repositorioMarcas.Remover(confirmar);
//                Console.WriteLine("Ítem Removido com sucesso!");
//                Console.ReadKey();

//            }
//            if (op == "N")
//            {
//                Console.WriteLine("Operação Cancelada.");
//                Console.ReadKey();
//                return;
//            }

//        }

//        private static void DeletarInventario()
//        {
//            var inventario = repositorioProduto.Ler();
//            if (!inventario.Any())
//            {
//                Console.WriteLine("Nenhum item na lista");
//                return;
//            }
//            var confirmar = LerProduto();

//            Console.WriteLine("\nID: " + confirmar.Id);
//            Console.WriteLine("Nome: " + confirmar.Nome);

//            string op = "";
//            Console.WriteLine("\nDeseja Excluir?(S / N)");
//            op = Console.ReadLine();
//            op = op.ToUpper();
//            if (op == "S")
//            {
//                repositorioProduto.Remover(confirmar);
//                Console.WriteLine("Ítem Removido com sucesso!");
//                Console.ReadKey();
//            }
//            if (op == "N")
//            {
//                Console.WriteLine("Operação Cancelada.");
//                Console.ReadKey();
//                return;
//            }

//        }

//        private static void AtualizarCategoria()
//        {
//            var categorias = repositorioCategorias.Ler();
//            if (!categorias.Any())
//            {
//                Console.WriteLine("Primeiro faça o cadastro");
//                Console.ReadKey();
//                return;
//            }
//            var item = LerCategoria();
//            Console.WriteLine("Informe o Novo nome: ");
//            item.Nome = Console.ReadLine();
//            Console.WriteLine("Atualizar:\n");
//            Console.WriteLine("ID " + item.Id);
//            Console.WriteLine("Nome " + item.Nome + "\n");
//            Console.WriteLine("CONFIRMA? (S / N) \n");
//            string opcao = Console.ReadLine();
//            opcao = opcao.ToUpper();
//            if (opcao == "N")
//            {
//                return;
//            }
//            if (opcao == "S")
//            {
//                repositorioCategorias.Atualizar(item);
//                Console.WriteLine("Alterado com sucesso!");
//                Console.ReadKey();

//            }
//        }

//        private static void AtualizarMarca()
//        {
//            var marcas = repositorioMarcas.Ler();
//            if (!marcas.Any())
//            {
//                Console.WriteLine("Primeiro faça o cadastro");
//                Console.ReadKey();
//                return;
//            }

//            var item = LerMarca();
//            Console.WriteLine("Informe o Novo nome: ");
//            item.Nome = Console.ReadLine();
//            Console.WriteLine("Atualizar:\n");
//            Console.WriteLine("ID " + item.Id);
//            Console.WriteLine("Nome " + item.Nome + "\n");
//            Console.WriteLine("CONFIRMA? (S / N) \n");

//            string opcao = Console.ReadLine().ToUpper();
//            if (opcao != "S")
//            {
//                return;
//            }

//            repositorioMarcas.Atualizar(item);
//            Console.WriteLine("Alterado com sucesso!");
//            Console.ReadKey();

//        }

//        private static void Atualizar()
//        {

//            IEnumerable<Produto> inventario = repositorioProduto.Ler();

//            static void AtualizarProduto(Produto item)
//            {
//                Console.WriteLine("Informe o Novo nome: ");
//                item.Nome = Console.ReadLine();
//                item.Marca = LerMarca();
//                item.Valor = Helper.LerValor();
//                Console.WriteLine("Atualizar:\n");
//                Console.WriteLine("ID " + item.Id);
//                Console.WriteLine("Nome " + item.Nome);
//                Console.WriteLine("Nome " + item.Marca.Nome);
//                Console.WriteLine("Nome " + item.Valor);
//                Console.WriteLine("CONFIRMA? (S / N) \n");
//                string opcao2 = Console.ReadLine();
//                opcao2 = opcao2.ToUpper();

//                if (opcao2 != "S")
//                {
//                    Console.WriteLine("Operação Cancelada!");
//                    return;
//                }
//                repositorioProduto.Atualizar(item);
//                Console.WriteLine("Alterado com sucesso!");
//                Console.ReadKey();
//            }

//            static void RemoverAcessorios(Produto item)
//            {
//                var listaAcessorios = item.Acessorios;
//                if (!item.Acessorios.Any())
//                {
//                    Console.WriteLine("Não há acessorios cadastrados");
//                    Console.ReadKey();
//                    return;
//                }
//                var id = Helper.LerInteiro("\nInforme o ID do Acessorio: ");
//                var acessorio = listaAcessorios.FirstOrDefault(x => x.Id == id);
//                item.RemoverAcessorio(acessorio);
//                repositorioProduto.Atualizar(item);
//                Console.ReadKey();
//            }

//            static void EditarAcessorios(Produto item)
//            {
//                if (!item.Acessorios.Any())
//                {
//                    Console.WriteLine("Não Há Acessorios Cadastrados");
//                    Console.ReadKey();
//                    return;
//                }
//                ;
//                var listaAcessorios = item.LerAcessorios();
//                var escolha = Helper.LerInteiro("Informe o ID do Acessorio a ser alterado");
//                var acessorio = listaAcessorios.FirstOrDefault(x => x.Id == escolha);
//                if (acessorio == null)
//                {
//                    Console.WriteLine("Item Não Encontrado");
//                    Console.ReadKey();
//                    return;
//                }
//                Console.Clear();
//                Console.WriteLine("\tATENÇÃO!");
//                Console.WriteLine("\nNão é possivel alterar a Categoria de um acessório.\nSe este Item não pertence a esta Categoria,\nexclua e crie dentro do produto em questão");

//                Console.WriteLine("\nInforme o Novo Nome: ");
//                acessorio.Nome = Console.ReadLine();
//                Console.WriteLine("Informe o Nova Marca: ");
//                acessorio.Marca = LerMarca();
//                Console.WriteLine("Informe a Novo Valor: ");
//                acessorio.Valor = Helper.LerValor();

//                Console.Clear();
//                Console.WriteLine("Nome: " + acessorio.Nome);
//                Console.WriteLine("Categoria: " + item.Categoria.Nome);
//                Console.WriteLine("Marca: " + acessorio.Marca.Nome);
//                Console.WriteLine("Valor: " + acessorio.Valor);
//                Console.WriteLine("\n Deseja mesmo Alterar?(S/N)");
//                var opcao = Console.ReadLine().ToUpper();

//                if (opcao != "S")
//                {
//                    Console.WriteLine("Operação Cancelada!");
//                    return;
//                }

//                repositorioProduto.Atualizar(item);
//                Console.WriteLine("Acessorio alterado com Sucesso");

//            }

//            static void AdicionarAcessorios(Produto item)
//            {

//                Console.WriteLine("\nInforme o nome do novo acessório: ");

//                var nomeAcessorio = Console.ReadLine();
//                var marcaAcessorio = LerMarca();
//                var valorAcessorio = Helper.LerValor();


//                Console.WriteLine("Nome: " + nomeAcessorio);
//                Console.WriteLine("Marca: " + marcaAcessorio);
//                Console.WriteLine("Valor: " + valorAcessorio);
//                Console.WriteLine("Confirmar? (S / N)");
//                string confirmar = Console.ReadLine().ToUpper();
//                if (confirmar != "S")
//                {
//                    Console.WriteLine("Operação Cancelada!");
//                    return;
//                }
//                item.AdicionarAcessorio(nomeAcessorio, valorAcessorio, marcaAcessorio);
//                repositorioProduto.Atualizar(item);
//            }

//            if (!inventario.Any())
//            {
//                Console.WriteLine("Primeiro faça o cadastro");
//                Console.ReadKey();
//                return;
//            }
//            var item = LerProduto();

//            int op = 1;
//            while (op != 0)
//            {
//                Console.WriteLine("\t1 - Alterar dados do produto\n\t2 - Adicionar Acessório\n\t3 - Remover Acessório\n\t4 - Editar Acessório\n\t0 - Voltar");
//                op = Helper.LerInteiro("\nEscolha uma Opção: ");
//                switch (op)
//                {
//                    case 1:
//                        AtualizarProduto(item);
//                        break;
//                    case 2:
//                        AdicionarAcessorios(item);
//                        break;
//                    case 3:
//                        RemoverAcessorios(item);
//                        break;
//                    case 4:
//                        EditarAcessorios(item);
//                        break;
//                    default:
//                        break;
//                }
//            }
//        }

//        private static void CalcularInventario()
//        {
//            var inventario = repositorioProduto.Ler();
            
//            float soma = 0;
//            foreach (var item in inventario)
//            {
//                soma += item.Valor;
//                foreach (var item2 in item.Acessorios)
//                {
//                    soma += item2.Valor;
//                }
//            }
//            Console.WriteLine(soma);
//        }
//    }
//}
