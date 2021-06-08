using ExercicioProjetoDeProdutos.interfaces;
using System;

namespace Classes
{
    public class Login : ILogin
    {
        private bool logado;
        public Login()
        {
            string Resposta;
            bool RespostaValida= false;
            do
            {
            Console.WriteLine(@"
            ======================================================
            | Bem vindo! Deseja fazer login ou criar um usuário? |
            ======================================================
            |                                                    |  
            |                  1- Fazer login                    |
            |                  2- Criar um usuário               |
            |                                                    |
            ======================================================");
            Resposta = Console.ReadLine();
            if (Resposta== "1")
            {
                
            }
            else if (Resposta== "2")
            {
                
            }
            else
            {
                
            }
            } while (RespostaValida==false);
        }

        public string Deslogar(Usuario U)
        {
            throw new System.NotImplementedException();
        }

        public string Logar(Usuario U)
        {
            throw new System.NotImplementedException();
        }
    }
}