using Dashboard.Apresentacao.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Apresentacao.Views.MarcaView
{
    class Mensagem<T>
    {
        public void Print(Retorno<T> objeto)
        {
            if (objeto.DeuCerto)
            {
                Console.WriteLine("Deu certo! Parabens =)");
                Console.ReadKey();
                return;
            }
            foreach (var mensagem in objeto.Mensagens)
            {
                Console.WriteLine(mensagem);
            }
            Console.ReadKey();

        }
    }
}
