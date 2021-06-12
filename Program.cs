using System;
using System.Collections.Generic;
using System.Threading;
using Classes;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio();
            Login L = new Login();
            // string Resposta;
            // bool MenuProdutosEMarcas = true;
            // M marca1 = new M();
            // P produto1 = new P();
            // Usuario UsuarioVerificacao = new Usuario();
//             while (MenuProdutosEMarcas == true)
//             {
//                 Console.WriteLine(@"
// gi|===================================|
// gi|      Menu Produtos e Marcas       |
// gi|                                   |
// gi|     0 -  Voltar                   |
// gi|                                   |  
// gi|     1 -  Gerenciar Marcas         |
// gi|                                   |
// gi|     2 -  Gerenciar Produtos       |
// gi|                                   |
// gi|                                   |
// gi|                                   |  
// gi|===================================|");
//                 Resposta = Console.ReadLine().Substring(0, 1);
//                 Console.Clear();
//                 switch (Resposta)
//                 {
//                     case "1":
//                         Console.WriteLine(@"
// |===================================|
// |           Menu de Marcas          |
// |                                   |
// |     1 -  Cadastrar Marcas         |
// |                                   |
// |     2 -  Deletar Marcas           |
// |                                   |
// |     3 -  Mostrar Marcas atuais    |
// |                                   |
// |===================================|
// ");
//                         Resposta = Console.ReadLine().Substring(0, 1);
//                         switch (Resposta)
//                         {
//                             case "1":
//                                 Console.WriteLine(marca1.Cadastrar());
//                                 break;
//                             case "2":
//                                 Console.WriteLine(marca1.Deletar());
//                                 break;
//                             case "3":
//                                 foreach (M item in marca1.ListarMarcas())
//                                 {
//                                     Console.WriteLine($"Id: {item.CodigoMarca} Nome: {item.NomeMarca}");
//                                 }
//                                 break;
//                             default:
//                                 Console.WriteLine("Resposta inválida, digite '1' para cadastar uma ou mais marcas, '2' para deletar uma ou mais marcas e '3' para listar as marcas");
//                                 break;
//                         }
//                         break;
//                     case "2":
//                         Console.WriteLine(@"
// |====================================|
// |           Menu de Produtos         |
// |                                    | 
// |     1 -  Cadastrar Produtos        |
// |                                    |
// |     2 -  Deletar Produtos          |
// |                                    |
// |     3 -  Mostrar Produtos Atuais   |
// |                                    |
// |====================================|");
//                         Resposta = Console.ReadLine().Substring(0, 1);
//                         switch (Resposta)
//                         {
//                             case "1":
//                                 Console.WriteLine(produto1.Cadastrar(marca1, UsuarioVerificacao));
//                                 break;
//                             case "2":
//                                 Console.WriteLine(produto1.Deletar());
//                                 break;
//                             case "3":
//                                 foreach (P item in produto1.ListarProdutos())
//                                 {
//                                     Console.WriteLine($"Id: {item.CodigoProduto}  Preço: {item.Preco}  Nome: {item.NomeProduto} Usuário que cadastrou: {item.CadastradoPor.RetornarNome()}");
//                                 }
//                                 break;
//                             default:
//                                 Console.WriteLine("Resposta inválida, digite '1' para cadastar um ou mais produtos, '2' para deletar um ou mais produtos e '3' para listar os produtos");
//                                 break;
//                         }
//                         break;
//                     case "0":
//                         MenuProdutosEMarcas = false;
//                         break;
//                     default:
//                         Console.WriteLine("Resposta inválida, digite '1' para acessar o menu de marcas, '2' para o menu de produtos e '0' para voltar ao menu do usuário");
//                         break;
//                 }
//             }
        }
        static void Inicio()
        {
            Console.Clear();
            for (int a = 0; a < 2; a++)
            {
                Console.WriteLine("Bem Vindo ao Sistema de Produtos!");
                Console.Write("Iniciando Sistema");
                for (int b = 0; b < 5; b++)
                {
                    Console.Write(".");
                    Thread.Sleep(250);
                }
                Console.Clear();
            }
            Console.Clear();
            Thread.Sleep(700);
        }
    }
}