using System;

namespace Dashboard.Apresentacao.Views.Home
{
    public class Menu
    {
        public void Print()
        {
            Console.Clear();
            Console.WriteLine("\n\n1 - Marca\n");
            Console.WriteLine("2 - Categoria\n");
            Console.WriteLine("3 - Produto\n ");
            Console.WriteLine("0 - Sair\n ");
            
        }
    }
}
