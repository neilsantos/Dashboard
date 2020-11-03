using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Apresentacao.Models
{
    public class Retorno<T>
    {

        public Retorno()
        {
            DeuCerto = true;
            Mensagens = new List<string>();
        }
        public Retorno(T objeto):this()
        {
            Objeto = objeto;
        }
        
        public bool DeuCerto { get; set; }

        public List<string> Mensagens { get; set; }

        public T Objeto { get; set; }
        

    }

}
