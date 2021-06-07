using System.Collections.Generic;
using Classes;

namespace ExercicioProjetoDeProdutos.interfaces
{
    public interface IMarca
    {
        string Cadastrar();
        List<Marca> Listar();
        string Deletar(); 
    }
}