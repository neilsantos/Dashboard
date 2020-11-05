using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Apresentacao.Views.MarcaView
{
    public class Mostrar
    {
        public void Print(IEnumerable<Marca> marcas)
        {
            Console.WriteLine("\n\nLista de Marcas\n");
            foreach (var marca in marcas)
            {
                Console.WriteLine(marca.Id + " - " + marca.Nome);
            }
            Console.ReadKey();
        }
    }
}
