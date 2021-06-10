using System;
using System.Collections.Generic;
using System.Threading;
using ExercicioProjetoDeProdutos.interfaces;

namespace Classes
{
    public class P : IP
    {
        public int CodigoProduto;
        public string NomeProduto;
        public float Preco;
        public DateTime DataCadastroProduto;
        public M Marca;
        public Usuario CadastradoPor;
        public List<P> ListaDeProdutos = new List<P>();

        public P()
        {
        }
        public P(int _Codigo, string _NomeProduto, float _Preco)
        {
            CodigoProduto = _Codigo;
            NomeProduto = _NomeProduto;
            Preco = _Preco;
        }

        public string Cadastrar(M m, Usuario u, List<Usuario> L)
        {
            Console.Clear();
            Console.WriteLine("Qual é a quantidade de produtos que você deseja cadastrar no sistema?");
            int QntNomesC = int.Parse(Console.ReadLine());
            int codigo;
            bool RespostaValida= false;
            string Marca;
            for (int i = 0; i < QntNomesC; i++)
            {
                codigo = 0;
                P p = new P();
                Console.Clear();
                Console.WriteLine($"Qual é o nome do {(i + 1)}º produto que você deseja cadastrar?");
                p.NomeProduto = Console.ReadLine();
                p.DataCadastroProduto = DateTime.Now;
                bool AcheiAMArca;
                do
                {
                    AcheiAMArca = false;
                    Console.WriteLine("Qual é a marca desse produto ?");
                    Marca= Console.ReadLine();
                    foreach (M item in m.ListaMarcas)
                    {
                        if (item.NomeMarca == Marca)
                        {
                            AcheiAMArca = true;
                        }
                    }
                    if (AcheiAMArca == true)
                    {
                        RespostaValida = true;
                        p.Marca = m.ListaMarcas.Find(x => x.NomeMarca == Marca);
                    }
                    else
                    {
                        RespostaValida = false;
                        Console.WriteLine("Marca inválida!!! As marcas disponíveis são:");
                        foreach (M item in m.ListaMarcas)
                        {
                            Console.WriteLine($"{item.NomeMarca}");
                        }
                    }
                } while (RespostaValida==false);
                Console.WriteLine("Qual é o preço desse produto?");
                p.Preco = float.Parse(Console.ReadLine());
                p.CadastradoPor = L.Find(x => x.RetornarNome() == u.RetornarNome());
                foreach (P item in ListaDeProdutos)
                {
                    codigo ++;
                }
                p.CodigoProduto = codigo;
                ListaDeProdutos.Add(p);
                Console.Clear();
                Console.WriteLine("Produto cadastrado com sucesso!");
                Thread.Sleep(1000);
            }
            return "Todos os produtos mencionados foram cadastrados!";
        }

        public string Deletar()
        {
            Console.Clear();
            Console.WriteLine("Quantos produtos você deseja remover?");
            int QntProdutosRemove = int.Parse(Console.ReadLine());
            for (int i = 0; i < QntProdutosRemove; i++)
            {
                Console.WriteLine($"Qual é o nome do {i+1}ª produto que você deseja remover?");
                string NomeProdutoRemove = Console.ReadLine();
                ListaDeProdutos.RemoveAll(X => X.NomeProduto == NomeProdutoRemove);
                Console.Clear();
                Console.WriteLine($"O produto com o nome {NomeProdutoRemove} foi removido com sucesso!");
                Thread.Sleep(1000);
            }
            return "Todos os produtos mencionados foram deletados com sucesso";
        }

        public List<P> ListarProdutos()
        {
            return ListaDeProdutos;
        }
    }
}