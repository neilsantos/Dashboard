using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;



namespace Dashboard
{
    
    class Classe1
    {

        public Classe1()
        {
            NossaLista<Marca> Nome = new NossaLista<Marca>();
            Marca objmarca = new Marca("Dajuda");
            Nome.Add(objmarca);

            NossaLista<string> Nome2 = new NossaLista<string>();
            string objmarca2 = "Dajuda";
            Nome2.Add(objmarca2);

        }

        
        
    }

    public class NossaLista<T>
    {
        private List<T> lista;
        public NossaLista()
        {
            lista = new List<T>();
        }

        public void Add(T itemdalista)
        {
            lista.Add(itemdalista);
        }

    }

}
