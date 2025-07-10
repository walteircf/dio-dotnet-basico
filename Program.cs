using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExemploFundamentos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pessoa vendedor = new Pessoa();
            Pessoa comprador = new Pessoa();

            Console.Write("Digite o nome do vendedor: ");
            vendedor.Nome = Console.ReadLine();
            Console.Write("Digite a idade do vendedor: ");
            vendedor.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"O Vendedor {vendedor.Nome} foi cadastrado com sucesso!");

        }
    }
}