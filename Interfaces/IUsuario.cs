using Classes;
using System.Collections.Generic;

namespace ExercicioProjetoDeProdutos.interfaces
{
    public interface IUsuario
    {
        string Cadastrar(Usuario U, List<Usuario> L);
        string Deletar(Usuario U, List<Usuario> L);
        bool Verificacao(Usuario U, List<Usuario> L);
        string RetornarNome();
    }
}