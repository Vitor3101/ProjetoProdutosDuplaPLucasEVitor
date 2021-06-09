using System;
using System.Collections.Generic;
using Interfaces;

namespace Classes
{
    public class P : M, IP
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

        public void Cadastrar()
        {
            List<P> ListaDeProdutos = new List<P>();
            Console.WriteLine("Quantos Produtos você deseja cadastrar?");
            int QntPCadastro = int.Parse(Console.ReadLine());
            for (int i = 0; i < QntPCadastro; i++)
            {
                Console.WriteLine("Qual é o Nome do Produto que você deseja cadastrar?");
                string _NomeProdutoC = Console.ReadLine();
                Console.WriteLine("Qual é o Preço do produto que está sendo cadastrado?");
                float _PrecoC = float.Parse(Console.ReadLine());
                ListaDeProdutos.Add(new P(i, _NomeProdutoC, _PrecoC));
                Console.Clear();
                Console.WriteLine("Produto cadastrado!");
            }
        }

        public string Deletar()
        {
            Console.WriteLine("Qual é o nome do Produto que você deseja remover?");
            string NomeProdutoRemover = (Console.ReadLine());
            ListaDeProdutos.RemoveAll(X => X.NomeProduto == NomeProdutoRemover);
            Console.Clear();
            Console.WriteLine("Produto deletado com sucesso!");
            return "Deletado";
        }

        public List<P> ListaProdutos()
        {
            foreach (var P in ListaDeProdutos)
            {
                Console.WriteLine($"Id: {CodigoProduto}  Preço: {Preco}  Nome: {NomeProduto}");
            }
            return ListaDeProdutos;
        }
    }
}