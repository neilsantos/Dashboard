using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard
{
    public interface IRepositorio<T> where T:EntidadeBase
    {
        IEnumerable<T> Ler();

        T Adicionar(T item);

        void Atualizar(T item);

        void Remover(T item);
    }
}
