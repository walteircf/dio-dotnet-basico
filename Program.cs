using System;
using System.Collections.Generic;
using System.Globalization;
using ExemploFundamentos.Models;

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

            vendedor.Apresentar();

        }
    }
}