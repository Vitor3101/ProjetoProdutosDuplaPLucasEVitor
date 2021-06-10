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
            // Login L = new Login();
            string OpcaoMenuInicial;
            string OpcaoMenuProdutos;
            string OpcaoMenuMarcas;
            bool vMenuInicial = true;
            M marca1 = new M();
            P produto1 = new P();
            Inicio();
            while (vMenuInicial == true)
            {
                Console.WriteLine(@"
gi|===================================|
gi|            Menu Inicial           |
gi|                                   |
gi|     1 -  Gerenciar Usuário        |
gi|                                   |  
gi|     2 -  Gerenciar Marcas         |
gi|                                   |
gi|     3 -  Gerenciar Produtos       |
gi|                                   |
gi|     0 -  Fechar Programa          |
gi|                                   |  
gi|===================================|");
                OpcaoMenuInicial = Console.ReadLine().Substring(0, 1);
                Console.Clear();
                switch (OpcaoMenuInicial)
                {
                    case "1":
                        // Colocar o sistema de usuarios aqui
                        break;
                    case "2":
                        Console.WriteLine(@"
|===================================|
|           Menu de Marcas          |
|                                   |
|     1 -  Cadastrar Marcas         |
|                                   |
|     2 -  Deletar Marcas           |
|                                   |
|     3 -  Mostrar Marcas atuais    |
|                                   |
|===================================|
");
                        OpcaoMenuMarcas = Console.ReadLine().Substring(0, 1);
                        switch (OpcaoMenuMarcas)
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
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine(@"
|====================================|
|           Menu de Produtos         |
|                                    | 
|     1 -  Cadastrar Produtos        |
|                                    |
|     2 -  Deletar Produtos          |
|                                    |
|     3 -  Mostrar Produtos Atuais   |
|                                    |
|====================================|");
                        OpcaoMenuProdutos = Console.ReadLine().Substring(0, 1);
                        switch (OpcaoMenuProdutos)
                        {
                            case "1":
                                Console.WriteLine(produto1.Cadastrar(marca1));
                                break;
                            case "2":
                                Console.WriteLine(produto1.Deletar());
                                break;
                            case "3":
                                foreach (P item in produto1.ListarProdutos())
                                {
                                    Console.WriteLine($"Id: {item.CodigoProduto}  Preço: {item.Preco}  Nome: {item.NomeProduto} Usuário que cadastrou: {item}");
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case "0":
                        vMenuInicial = false;
                        break;
                    default:
                        break;
                }
            }
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
        }
    }
}