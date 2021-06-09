using System;
using System.Collections.Generic;
using System.Threading;
using Interfaces;

namespace Classes
{
    public class M : IM
    {
        public int CodigoMarca;
        public string NomeMarca; 
        public DateTime DataCadastroMarca;

        public List<M> ListaMarcas = new List<M>();

        public M()
        {
        }

        public M(int _Codigo, string _NomeMarca, DateTime _DataCadastro)
        {
            CodigoMarca = _Codigo;
            NomeMarca = _NomeMarca;
            DataCadastroMarca = _DataCadastro;
        }
        public void Cadastrar()
        {
            Console.Clear();
            Console.WriteLine("Qual é a quantidade de Nomes que você deseja cadastrar no sistema?");
            int QntNomesC = int.Parse(Console.ReadLine());
            for (int i = 0; i < QntNomesC; i++)
            {
                Console.Clear();
                Console.WriteLine($"Qual é o nome da {(i + 1)}º marca que você deseja cadastrar?");
                string NomeMarcaC = Console.ReadLine();
                DateTime DataAtualC = DateTime.Now;
                ListaMarcas.Add(new M(i, NomeMarcaC, DataAtualC));
                Console.Clear();
                Console.WriteLine("Marca cadastrada com sucesso!");
                Thread.Sleep(1000);
            }
        }

        public void Deletar()
        {
            Console.Clear();
            Console.WriteLine("Quantas marcas você deseja remover?");
            int QntMarcasRemove = int.Parse(Console.ReadLine());
            for (int i = 0; i < QntMarcasRemove; i++)
            {
                Console.WriteLine($"Qual é o {(i + 1)} ºnome da Marca que você deseja remover?");
                string NomeMarcaRemove = Console.ReadLine();
                ListaMarcas.RemoveAll(X => X.NomeMarca == NomeMarcaRemove);
                Console.Clear();
                Console.WriteLine("Marca Removida com sucesso!");
                Thread.Sleep(1000);
            }

        }

        public List<M> ListarMarcas()
        {
            foreach (var P in ListaMarcas)
            {
                Console.WriteLine($"Id: {CodigoMarca} Nome: {NomeMarca}");
            }
            return ListaMarcas;
        }
    }
}