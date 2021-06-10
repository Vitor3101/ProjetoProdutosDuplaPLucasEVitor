using ExercicioProjetoDeProdutos.interfaces;
using System;
using System.Collections.Generic;

namespace Classes
{
    public class Login : ILogin
    {
        private List<Usuario> Usuarios = new List<Usuario>();
        private bool Logado;
        public Login()
        {
            Usuario UsuarioVerificacao = new Usuario();
            string Resposta;
            bool Desligar = false;
            bool RespostaValida = false;
            bool RespostaValidaProdutos = false;
            do
            {
                if (Logado == true)
                {
                    Console.WriteLine($@"
            ======================================================
            |  Bem vindo {UsuarioVerificacao.RetornarNome()}! O que deseja fazer? |
            ======================================================
            |                  0- Fazer logoff                   |  
            |                  1- Menu produtos                  |
            |                  2- Deletar meu usuário            |
            |                                                    |
            ======================================================");
                    Resposta = Console.ReadLine();
                    if (Resposta == "0")
                    {
                        RespostaValida = true;
                        Console.WriteLine($"{Deslogar(UsuarioVerificacao)}");
                    }
                    else if (Resposta == "1")
                    {
                        RespostaValida = true;
                        do
                        {
                            Console.WriteLine($@"
            ======================================================
            |                   Menu de produtos                 |
            ======================================================
            |                  0- Voltar                         |  
            |                  1- Cadastrar um produto           |
            |                  2- Listar os produtos             |
            |                  3- Deletar um produto             |
            ======================================================");
                            Resposta = Console.ReadLine();
                        } while (RespostaValidaProdutos == false);
                    }
                    else if (Resposta == "2")
                    {
                        RespostaValida = true;
                        Console.WriteLine($"{UsuarioVerificacao.Deletar(UsuarioVerificacao, Usuarios)}");
                        Deslogar(UsuarioVerificacao);
                    }
                    else
                    {
                        RespostaValida = false;
                        Console.WriteLine(@"
            ======================================================
            |              Resposta inválida, digite:            |
            |                                                    |  
            |            '0' para fazer logoff                   |  
            |            '1' para acessar o menu de produtos     |
            |            '2' para deletar meu usuário            |
            |                                                    |
            ======================================================");
                    }
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
            |                  2- Criar um usuário (limite = 2)  |
            |                                                    |
            ======================================================");
                        Resposta = Console.ReadLine();
                        if (Resposta == "1" && Usuarios.Count != 0)
                        {
                            RespostaValida = true;
                            Console.WriteLine(Logar(UsuarioVerificacao));
                        }
                        else if (Resposta == "2" && Usuarios.Count <= 1)
                        {
                            RespostaValida = true;
                            Usuario User = new Usuario();
                            Console.WriteLine($"{User.Cadastrar(User, Usuarios)}");
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
                        else if (Resposta == "2" && Usuarios.Count >=2)
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
            |            '0' para desligar                       |  
            |            '2' para criar um usuário               |
            |            '1' para fazer login                    |  
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
            U = null;
            Logado = false;
            return @"
            ======================================================
            |                                                    |
            |                                                    |
            |                     Logoff feito                   |
            |                     com sucesso!                   |
            |                                                    |
            |                                                    |
            ======================================================";
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