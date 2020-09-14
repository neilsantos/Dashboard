using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Apresentacao
{
     class Helper
    {
        public static int LerInteiro(string msg)
        {
            int valor;
            bool eValido;
            do
            {

                Console.WriteLine(msg);

                eValido = int.TryParse(Console.ReadLine(), out valor);
                if (!eValido)
                {
                    Console.Clear();
                    Console.WriteLine("É necessário informar um valor Válido");
                    Console.ReadKey();
                }
            } while (!eValido);
            return valor;
        }

        public static float LerValor()
        {
            float valor;
            bool eValido;
            do
            {
                Console.Clear();
                Console.WriteLine("Informe o valor do item;\n");

                eValido = float.TryParse(Console.ReadLine(), out valor);
                if (!eValido)
                {
                    Console.WriteLine("É necessário informar um valor Válido");
                    Console.ReadKey();
                }
            } while (!eValido);
            return valor;
        }


    }
}
