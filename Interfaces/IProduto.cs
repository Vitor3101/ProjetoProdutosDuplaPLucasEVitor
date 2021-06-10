using System.Collections.Generic;
using Classes;

namespace ExercicioProjetoDeProdutos.interfaces
{
    public interface IP
    {
        string Cadastrar();
        string Deletar();
        List<P> Listar();
    }
}