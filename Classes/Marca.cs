using ExercicioProjetoDeProdutos.interfaces;
using System;
using System.Collections.Generic;
using System.Threading;

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
        public string Cadastrar()
        {
            Console.Clear();
            Console.WriteLine("Qual é a quantidade de marcas que você deseja cadastrar no sistema?");
            int QntNomesC = int.Parse(Console.ReadLine());
            int codigo;
            for (int i = 0; i < QntNomesC; i++)
            {
                codigo = 0;
                M m = new M();
                Console.Clear();
                Console.WriteLine($"Qual é o nome da {(i + 1)}º marca que você deseja cadastrar?");
                m.NomeMarca = Console.ReadLine();
                m.DataCadastroMarca = DateTime.Now;
                foreach (M item in ListaMarcas)
                {
                    codigo ++;
                }
                m.CodigoMarca = codigo;
                ListaMarcas.Add(m);
                Console.Clear();
                Console.WriteLine("Marca cadastrada com sucesso!");
                Thread.Sleep(1000);
            }
            return "Todas as marcas mencionadas foram cadastradas!";
        }

        public string Deletar()
        {
            Console.Clear();
            Console.WriteLine("Quantas marcas você deseja remover?");
            int QntMarcasRemove = int.Parse(Console.ReadLine());
            for (int i = 0; i < QntMarcasRemove; i++)
            {
                Console.WriteLine($"Qual é o nome da {i+1}ª Marca que você deseja remover?");
                string NomeMarcaRemove = Console.ReadLine();
                ListaMarcas.RemoveAll(X => X.NomeMarca == NomeMarcaRemove);
                Console.Clear();
                Console.WriteLine($"A marca com o nome {NomeMarcaRemove} foi removida com sucesso!");
                Thread.Sleep(1000);
            }
            return "Todas as marcas mencionadas foram deletadas!";
        }

        public List<M> ListarMarcas()
        {
            return ListaMarcas;
        }
    }
}