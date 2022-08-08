using System;
using System.Globalization;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Pessoa pessoa = new Pessoa(nome, idade);

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());
            Pessoa pessoa2 = new Pessoa(nome, idade);

            if (pessoa.Idade > pessoa2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);
            }
        }
    }
}