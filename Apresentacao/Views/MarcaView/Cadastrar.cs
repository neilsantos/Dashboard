using System;

namespace Dashboard.Apresentacao.Views.MarcaView
{
    public class Cadastrar
    {
        
        public Marca Print() {

            Console.WriteLine("Informe a Nova Marca");
            string nomeMarca = Console.ReadLine();
            Marca novaMarca = new Marca(nomeMarca);
            return novaMarca;
        }
        
    }
}
