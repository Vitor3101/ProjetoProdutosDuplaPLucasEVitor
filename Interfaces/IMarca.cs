using System.Collections.Generic;
using Classes;

namespace Interfaces
{
    public interface IM
    {
        void Cadastrar(M ListaMarcas);
        List<M> Listar();
        string Deletar(M ListaMarcas);
    }
}