using ExercicioProjetoDeProdutos.interfaces;
using System;
using System.Collections.Generic;

namespace Classes
{
    public class Login : ILogin
    {
        public List<Usuario> Usuarios = new List<Usuario>();
        private bool Logado;
        public Login()
        {
            Usuario U = new Usuario();
            Usuario UsuarioVerificacao = new Usuario();
            string Resposta;
            bool Desligar = false;
            bool RespostaValida = false;
            do
            {
                if (Logado == true)
                {
                }
                else
                    do
                    {
                        Console.WriteLine(@"
            ======================================================
            | Bem vindo! Deseja fazer login ou criar um usuário? |
            ======================================================
            |                  0- Desligar                       |  
            |                  1- Fazer login                    |
            |                  2- Criar um usuário               |
            |                                                    |
            ======================================================");
                        Resposta = Console.ReadLine();
                        if (Resposta == "1" && Usuarios.Count != 0)
                        {
                            RespostaValida = true;
                            Logar(UsuarioVerificacao);
                        }
                        else if (Resposta == "2" && Usuarios.Count == 0)
                        {
                            RespostaValida = true;
                            Console.WriteLine($"{U.Cadastrar(U, Usuarios)}");
                        }
                        else if (Resposta == "1" && Usuarios.Count == 0)
                        {
                            RespostaValida = false;
                            Console.WriteLine(@"
            ======================================================
            |                                                    |
            |                                                    |  
            |                Não existem usuários                |  
            |                    para o login                    |
            |                                                    |
            |                                                    |
            ======================================================");
                        }
                        else if (Resposta == "2" && Usuarios.Count != 0)
                        {
                            RespostaValida = false;
                            Console.WriteLine(@"
            ======================================================
            |                                                    |
            |                                                    |  
            |               A quantidade de usuários             |  
            |                  atingiu seu limite                |
            |                                                    |
            |                                                    |
            ======================================================");
                        }
                        else if (Resposta == "0")
                        {
                            Desligar = true;
                            RespostaValida = true;
                            Console.WriteLine(@"
            ======================================================
            |                                                    |
            |                                                    |  
            |                       Certo.                       |  
            |                    Desligando...                   |
            |                                                    |
            |                                                    |
            ======================================================");
                        }
                        else
                        {
                            RespostaValida = false;
                            Console.WriteLine(@"
            ======================================================
            |              Resposta inválida, digite:            |
            |                                                    |  
            |            '1' para fazer login                    |  
            |            '2' para criar um usuário               |
            |                                                    |
            |                                                    |
            ======================================================");
                        }
                    } while (RespostaValida == false);
                {

                }
            } while (Desligar == false);
        }

        public string Deslogar(Usuario U)
        {
            throw new System.NotImplementedException();
        }

        public string Logar(Usuario U)
        {
            Logado = U.Verificacao(U, Usuarios);
            if (Logado == true)
            {
                return @"
            ======================================================
            |                                                    |
            |                                                    |
            |                     Login feito                    |
            |                     com sucesso!                   |
            |                                                    |
            |                                                    |
            ======================================================";
            }
            else
            {
                return @"
            ======================================================
            |                                                    |
            |                                                    |
            |                         Email ou                   |
            |                     senha inválidos                |
            |                                                    |
            |                                                    |
            ======================================================";
            }
        }
    }
}