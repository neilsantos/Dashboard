using Dashboard.Apresentacao.Models;
using Dashboard.Apresentacao.Views.Home;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Apresentacao.Controllers
{
    class HomeController
    {
        public void Index()
        {
            var menu = new Menu();
            menu.Print();
            var opcao = Helper.LerInteiro("MenuPrincipal: Digite a Opção");
            var opcaoDoMenu = (HomeMenu)opcao;
            switch (opcaoDoMenu)
            {
                case HomeMenu.Marca:
                    new MarcaController().Index();
                    break;
                case HomeMenu.Categoria:
                    break;
                case HomeMenu.Produto:
                    break;
                case HomeMenu.Sair:
                    break;
                default:
                    break;
            }
        }
    }
}
