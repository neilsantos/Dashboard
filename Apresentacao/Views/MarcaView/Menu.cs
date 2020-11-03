using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Apresentacao.Views.MarcaView
{
    public class Menu
    {
        public void Print()
        {
            Console.Clear();
            Console.WriteLine("\n\n1 - Cadastrar Marca\n");
            Console.WriteLine("2 - Exibir Marcas\n");
            Console.WriteLine("3 - Remover Marca\n");
            Console.WriteLine("4 - Atualizar Marca\n");
            Console.WriteLine("5 - Retornar ao Menu");
        }
    }
}
