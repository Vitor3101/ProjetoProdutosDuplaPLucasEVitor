using Classes;

namespace ExercicioProjetoDeProdutos.interfaces
{
    public interface IUsuario
    {
        string Cadastrar(Usuario U);
        string Deletar(Usuario U);
    }
}