using System.Collections.Generic;
using Classes;

namespace Interfaces
{
    public interface IM
    {
        void Cadastrar();
        List<M> ListarMarcas();
        void Deletar();
    }
}