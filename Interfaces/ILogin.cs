using System.Collections.Generic;
using Classes;

namespace ExercicioProjetoDeProdutos.interfaces
{
    public interface ILogin 
    {
        string Logar(Usuario U);
        string Deslogar(Usuario U);
    }
}