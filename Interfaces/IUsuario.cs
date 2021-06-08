using Classes;

namespace ExercicioProjetoDeProdutos.interfaces
{
    public interface IUsuario
    {
        string Cadastrar(Usuario U, Login L);
        string Deletar(Usuario U);
    }
}