using System;
using ExercicioProjetoDeProdutos.interfaces;

namespace Classes
{
    public class Usuario : IUsuario
    {
        int Codigo;
        string Nome;
        string Email;
        string Senha;
        DateTime DataDeCadastro;

        public string Cadastrar(Usuario U)
        {
            return "O usuário foi cadastrado com sucesso!";
        }

        public string Deletar(Usuario U)
        {
            U = null;
            return "O usuário foi deletado com sucesso!";
        }
    }
}