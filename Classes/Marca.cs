using System;
using System.Collections.Generic;
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
        public void Cadastrar(M ListaMarcas)
        {
            Console.WriteLine("Qual é a quantidade de Nomes que você deseja cadastrar no sistema?");
            int QntNomesC = int.Parse(Console.ReadLine());
            for (int i = 0; i < QntNomesC; i++)
            {
                Console.WriteLine("Qual é o nome da marca que você deseja cadastrar?");
                string NomeMarcaC = Console.ReadLine();
                DateTime DataAtualC = DateTime.Now;
                ListaMarcas.Add(new M(i, NomeMarcaC, DataAtualC));
            }
            Console.WriteLine("Marca cadastrada com sucesso!");
        }

        public string Deletar(M ListaMarcas)
        {
            Console.WriteLine("Qual é o nome da Marca que você deseja remover?");
            string NomeMarcaRemove = Console.ReadLine();
            ListaMarcas.RemoveAll(X => X.NomeMarca == NomeMarcaRemove);
            return "Deletado";
        }

        public List<M> Listar()
        {
            throw new NotImplementedException();
        }
    }
}