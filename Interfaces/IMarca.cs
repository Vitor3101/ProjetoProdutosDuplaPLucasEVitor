using System.Collections.Generic;
using Classes;

namespace ExercicioProjetoDeProdutos.interfaces
{
    public interface IM
    {
        string Cadastrar();
        List<M> Listar();
        string Deletar(); 
    }
}