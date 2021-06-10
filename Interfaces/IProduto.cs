using System.Collections.Generic;
using Classes;

namespace Interfaces
{
    public interface IP
    {
        void Cadastrar(M m);
        List<P> ListarProdutos();
        string Deletar();
    }
}