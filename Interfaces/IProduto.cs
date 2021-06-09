using System.Collections.Generic;
using Classes;

namespace Interfaces
{
    public interface IP
    {
        void Cadastrar();
        List<P> ListarProdutos();
        string Deletar();
    }
}