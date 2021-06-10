using System;
using System.Collections.Generic;
using System.Threading;
using Interfaces;

namespace Classes
{
    public class P : IP
    {
        public int CodigoProduto;
        public string NomeProduto;
        public float Preco;
        public DateTime DataCadastroProduto;
        public M Marca;
        public U CadastradoPor;
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

        public void Cadastrar(M m)
        {
            Console.Clear();
            Console.WriteLine("Qual é a quantidade de produtos que você deseja cadastrar no sistema?");
            int QntNomesC = int.Parse(Console.ReadLine());
            int codigo;
            for (int i = 0; i < QntNomesC; i++)
            {
                codigo = 0;
                P p = new P();
                Console.Clear();
                Console.WriteLine($"Qual é o nome da {(i + 1)}º marca que você deseja cadastrar?");
                p.NomeProduto = Console.ReadLine();
                p.DataCadastroProduto = DateTime.Now;
                Console.WriteLine("Qual a marca desse produto (necessário estar cadastrada)");
                p.Marca = m.ListaMarcas.Find(x => x.NomeMarca == Console.ReadLine());
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
                Console.WriteLine($"A marca com o nome {NomeProdutoRemove} foi removida com sucesso!");
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