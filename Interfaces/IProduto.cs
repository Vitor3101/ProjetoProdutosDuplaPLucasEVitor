using System.Collections.Generic;
using Classes;

namespace ExercicioProjetoDeProdutos.interfaces
{
    public interface IP
    {
        string Cadastrar(M m, Usuario u, List<Usuario> L);
        List<P> ListarProdutos();
        string Deletar();
    }
}