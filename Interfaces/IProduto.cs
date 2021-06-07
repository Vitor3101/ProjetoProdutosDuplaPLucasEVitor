using System.Collections.Generic;
using Classes;

namespace ExercicioProjetoDeProdutos.interfaces
{
    public interface IProduto 
    {
        string Cadastrar();
        string Deletar();
        List<Produto> Listar();
    }
}