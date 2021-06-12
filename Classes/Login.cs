using ExercicioProjetoDeProdutos.interfaces;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Classes
{
    public class Login : ILogin
    {
        private List<Usuario> Usuarios = new List<Usuario>();
        private bool Logado;
        public Login()
        {
            Usuario UsuarioVerificacao = new Usuario();
            M marca1 = new M();
            P produto1 = new P();
            string Resposta;
            bool Desligar = false;
            bool RespostaValida = false;
            bool MenuProdutosEMarcas = false;
            do
            {
                if (Logado == true)
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($@"
|====================================================|
|  Bem vindo {UsuarioVerificacao.RetornarNome()}! O que deseja fazer? |
|====================================================|
|             0- Fazer logoff                        |  
|             1- Menu produtos e marcas              |
|             2- Deletar meu usuário                 |
|====================================================|");
                    Resposta = Console.ReadLine();
                    if (Resposta == "0")
                    {
                        RespostaValida = true;
                        Console.WriteLine($"{Deslogar(UsuarioVerificacao)}");
                    }
                    else if (Resposta == "1")
                    {
                        RespostaValida = true;
                        MenuProdutosEMarcas = true;
                        while (MenuProdutosEMarcas == true)
                        {
                            Thread.Sleep(3000);
                            Console.Clear();
                            Console.WriteLine(@"
|===================================|
|       Menu Produtos e Marcas      |
|===================================|
|       0- Voltar                   |
|       1- Gerenciar Marcas         |
|       2- Gerenciar Produtos       |
|===================================|");
                            Resposta = Console.ReadLine().Substring(0, 1);
                            Console.Clear();
                            switch (Resposta)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine(@"
|===================================|
|           Menu de Marcas          |
|===================================|
|       1- Cadastrar Marcas         |
|       2- Deletar Marcas           |
|       3- Mostrar Marcas atuais    |
|===================================|
");
                                    Resposta = Console.ReadLine().Substring(0, 1);
                                    switch (Resposta)
                                    {
                                        case "1":
                                            Console.WriteLine(marca1.Cadastrar());
                                            break;
                                        case "2":
                                            Console.WriteLine(marca1.Deletar());
                                            break;
                                        case "3":
                                            foreach (M item in marca1.ListarMarcas())
                                            {
                                                Console.WriteLine($"Id: {item.CodigoMarca} Nome: {item.NomeMarca}");
                                            }
                                            break;
                                        default:
                                            Console.WriteLine("Resposta inválida, digite '1' para cadastar uma ou mais marcas, '2' para deletar uma ou mais marcas e '3' para listar as marcas");
                                            break;
                                    }
                                    break;
                                case "2":
                                    if (marca1.ListaMarcas.Count > 0)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine(@"
|====================================|
|           Menu de Produtos         |
|====================================|
|       1- Cadastrar Produtos        |
|       2- Deletar Produtos          |
|       3- Mostrar Produtos Atuais   |
|====================================|");
                                        Resposta = Console.ReadLine().Substring(0, 1);
                                        switch (Resposta)
                                        {
                                            case "1":
                                                Console.WriteLine(produto1.Cadastrar(marca1, UsuarioVerificacao, Usuarios));
                                                break;
                                            case "2":
                                                Console.WriteLine(produto1.Deletar());
                                                break;
                                            case "3":
                                                foreach (P item in produto1.ListarProdutos())
                                                {
                                                    Console.WriteLine($"Id: {item.CodigoProduto}  Preço: {item.Preco}  Nome: {item.NomeProduto} Usuário que cadastrou: {item.CadastradoPor.RetornarNome()}");
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Resposta inválida, digite '1' para cadastar um ou mais produtos, '2' para deletar um ou mais produtos e '3' para listar os produtos");
                                                break;
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Não há marcas suficientes para o cadastro de um produto!");
                                        break;
                                    }
                                case "0":
                                    MenuProdutosEMarcas = false;
                                    break;
                                default:
                                    Console.WriteLine("Resposta inválida, digite '1' para acessar o menu de marcas, '2' para o menu de produtos e '0' para voltar ao menu do usuário");
                                    break;
                            }
                        }
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
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(@"
|====================================================|
|                 Resposta inválida!                 |
|====================================================|
|        Digite algum desses para continuar:         |
|                                                    |           
|        '0' para fazer logoff                       |  
|        '1' para acessar o menu de produtos         |
|        '2' para deletar meu usuário                |
|====================================================|");
                        Thread.Sleep(2000);
                    }
                }
                else
                    do
                    {
                        Thread.Sleep(1500);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(@"
|====================================================|
|              Bem vindo ao Sistema!                 |
|====================================================|
|       Deseja fazer login ou criar um usuário?      |
|       0- Desligar                                  |  
|       1- Fazer login                               |
|       2- Criar um usuário (limite = 2)             |
|====================================================|");
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
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($@"
|====================================================|
|                                                    |  
|               Não existem usuários                 |  
|                   para o login                     |
|                                                    |
|====================================================|");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(1500);
                        }
                        else if (Resposta == "2" && Usuarios.Count >= 2)
                        {
                            RespostaValida = false;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(@"
|====================================================|
|                                                    |  
|             A quantidade de usuários               |  
|                atingiu seu limite!                 |
|                                                    |
|====================================================|");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(1500);
                        }
                        else if (Resposta == "0")
                        {
                            Desligar = true;
                            RespostaValida = true;
                            Console.Clear();
                            Console.WriteLine(@"
|====================================================|
|                                                    |  
|                       Certo.                       |  
|                    Desligando...                   |
|                                                    |
|====================================================|");
                        }
                        else
                        {
                            RespostaValida = false;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(@"
|====================================================|
|                 Resposta inválida!                 |
|====================================================|
|            Digite algum desses para continuar:     |                           
|            '0' para desligar                       |  
|            '2' para criar um usuário               |
|            '1' para fazer login                    |  
|====================================================|");
                            Thread.Sleep(2000);
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
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            return @"
|====================================================|
|                                                    |
|                    Logoff feito                    |
|                    com sucesso!                    |
|                                                    |
|====================================================|";
        }

        public string Logar(Usuario U)
        {
            Console.Clear();
            Logado = U.Verificacao(U, Usuarios);
            if (Logado == true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep(1500);
                return @"
|====================================================|
|                                                    |
|                    Login feito                     |
|                    com sucesso!                    |
|                                                    |
|====================================================|";
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(1500);
                return @"
|====================================================|
|                                                    |
|                    Email ou                        |
|                 senha inválidos!                   |
|                                                    |
|====================================================|";
            }
        }
    }
}