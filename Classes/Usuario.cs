using Classes;
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

        public string Cadastrar(Usuario U, Login L)
        {
            U.Codigo = 0;
            foreach (Usuario _u in L.Usuarios)
            {
                U.Codigo++;
            };
            Console.WriteLine(@"
            ======================================================
            |                                                    |
            |                                                    |
            |                   Qual o nome                      |  
            |                   do usuário?                      |
            |                                                    |
            |                                                    |
            ======================================================");
            U.Nome = Console.ReadLine();
            Console.WriteLine(@"
            ======================================================
            |                                                    |
            |                                                    |
            |                   Qual o email                     |  
            |                   do usuário?                      |
            |                                                    |
            |                                                    |
            ======================================================");
            U.Email = Console.ReadLine();
            Console.WriteLine(@"
            ======================================================
            |                                                    |
            |                                                    |
            |                   Qual a senha                     |
            |                   do usuário?                      |
            |                                                    |
            |                                                    |
            ======================================================");
            U.Senha = Console.ReadLine();
            return @"
            ======================================================
            |                                                    |
            |                                                    |
            |               O usuário foi cadastrado             |
            |                   com sucesso!!!                   |
            |                                                    |
            |                                                    |
            ======================================================";
        }

        public string Deletar(Usuario U)
        {
                U = null;
                return @"
            ======================================================
            |                                                    |
            |                                                    |
            |                   Usuário deletado                 |
            |                     com sucesso!                   |
            |                                                    |
            |                                                    |
            ======================================================";
        }
    }
}