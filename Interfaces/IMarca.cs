using System.Collections.Generic;
using Classes;

namespace Interfaces
{
    public interface IM
    {
        string Cadastrar();
        List<M> ListarMarcas();
        string Deletar();
    }
}