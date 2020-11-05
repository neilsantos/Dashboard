using Dashboard.Apresentacao.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dashboard.Apresentacao;

namespace Dashboard.Apresentacao.Views.MarcaView
{
    class Remover
    {
        public void Print(IEnumerable<Marca> marcas)
        {

            if (!marcas.Any())
            {
                Console.WriteLine("Que Pena, não tem nada aqui ainda. Volte e Cadastre uma Marca =)");
            }
            Console.WriteLine("\n\nLista de Marcas\n");
            foreach (var marca in marcas)
            {
                Console.WriteLine(marca.Id + " - " + marca.Nome);
            }

        }
        public void Confirmar()
        {
            Console.WriteLine("Confirma a remoção do Item acima? S/N");
        }
        
    }
}
