﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard
{
    class Marca:EntidadeBase
    {
        public string Nome { get; set; }

        public Marca(string nome)
        {
            Nome = nome;
        }

    }
}
