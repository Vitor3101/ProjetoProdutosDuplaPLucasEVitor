using Classes;
using System;
using System.Collections.Generic;
using ExercicioProjetoDeProdutos.interfaces;

namespace Classes
{
    public class Usuario : IUsuario
    {
        private int Codigo;
        private string Nome;
        private string Email;
        private string Senha;
        private DateTime DataDeCadastro;

        public string Cadastrar(Usuario U, List<Usuario> L)
        {
            U.Codigo = 0;
            foreach (Usuario _u in L)
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
            L.Add(U);
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

        public string Deletar(Usuario U, List<Usuario> L)
        {
            L.Remove(L.Find(x => x == U));
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
        public bool Verificacao(Usuario U, List<Usuario> L)
        {
            bool SucessoVerificacao = false;
            Console.WriteLine(@"
            ======================================================
            |                                                    |
            |                                                    |  
            |                      Qual o seu                    |  
            |                        email?                      |
            |                                                    |
            |                                                    |
            ======================================================");
            U.Email = Console.ReadLine();
            Console.WriteLine(@"
            ======================================================
            |                                                    |
            |                                                    |  
            |                      Qual a sua                    |  
            |                        senha?                      |
            |                                                    |
            |                                                    |
            ======================================================");
            U.Senha = Console.ReadLine();
            foreach (Usuario _u in L)
            {
                if (_u.Email == U.Email && _u.Senha == U.Senha)
                {
                    SucessoVerificacao = true;
                }

            }
            if (SucessoVerificacao==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}