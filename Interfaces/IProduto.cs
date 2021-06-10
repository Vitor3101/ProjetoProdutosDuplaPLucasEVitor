using System.Collections.Generic;
using Classes;

namespace ExercicioProjetoDeProdutos.interfaces
{
    public interface IP
    {
        string Cadastrar(M m);
        List<P> ListarProdutos();
        string Deletar();
    }
}