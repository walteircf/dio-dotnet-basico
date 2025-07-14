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
            //Loop for
            int n = 10;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }

            Console.WriteLine();
            //Loop While
            int cont = 1;
            while (cont <= n)
            {
                Console.WriteLine($"Contador = {cont}");
                cont++;
            }

            Console.WriteLine();
            //Loop Do-while
            do
            {
                Console.WriteLine($"{n} - {cont} = {n - cont}");
                cont--;
            } while (cont >= 5);







            // Classe Math
            /* Calculadora calc = new Calculadora();

             calc.RaizQuadrada(144);
             calc.RaizQuadrada(25);
             */

            /*
            calc.Seno(30);
            calc.Coseno(30);
            calc.Tangente(30);
            */

            /*int a = 10;
            int b = 5;

            calc.Somar(a, b);
            calc.Subtrair(a, b);
            calc.Multiplicar(a, b);
            calc.Dividir(a, b);
            calc.Potencia(a, b);
            */

            /*bool presencaMinima = true;
            double media = 6.9;

            if (presencaMinima && media >= 7.0)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }*/


            /*Console.WriteLine("Digite uma letra: ");
            string letra = Console.ReadLine();

            //utilizando switch-case:
            switch (letra)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("É uma vogal!");
                    break;
                default:
                    Console.WriteLine("Não é uma vogal!");
                    break;
            }*/

            //utilizando operador lógico OU
            /*if (letra == "a" ||
                letra == "e" ||
                letra == "i" ||
                letra == "o" ||
                letra == "u")
            {
                Console.WriteLine("é uma vogal");
            }
            else
            {
                Console.WriteLine("não é uma vogal!");
            }*/

            // aninhando if/else
            /*if (letra == "a")
            {
                Console.WriteLine("é uma vogal");
            }
            else if (letra == "e")
            {
                Console.WriteLine("é uma vogal");
            }
            else if (letra == "i")
            {
                Console.WriteLine("é uma vogal");
            }
            else if (letra == "o")
            {
                Console.WriteLine("é uma vogal");
            }
            else if (letra == "u")
            {
                Console.WriteLine("é uma vogal");
            }
            else
            {
                Console.WriteLine("não é uma vogal!");
            } */

            // int qtdCompra = 4;
            // int qtdEstoque = 10;
            // bool possivelVenda = qtdCompra > 0 && qtdCompra >= qtdEstoque;

            // Console.WriteLine($"Quantidade em estoque: {qtdEstoque}");
            // Console.WriteLine($"Quantidade compra: {qtdCompra}");
            // Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

            // if (qtdCompra == 0)
            // {
            //     Console.WriteLine("Venda inválida");
            // }
            // else if (possivelVenda)
            // {
            //     Console.WriteLine("Venda realizada!");
            // }
            // else
            // {
            //     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque");
            // }















            //casting
            //int a = Convert.ToInt32("5"); //Opção 1 de casting usando a classe "Convert" - preferivel usar devido o tratamento de dados NULL
            //int a = int.Parse("5"); //converte o string para int32

            //Console.WriteLine(a);








            // Pessoa vendedor = new Pessoa();
            // Pessoa comprador = new Pessoa();

            /*Console.Write("Digite o nome do vendedor: ");
            vendedor.Nome = Console.ReadLine();
            Console.Write("Digite a idade do vendedor: ");
            vendedor.Idade = int.Parse(Console.ReadLine());

            vendedor.Apresentar();*/

            // string apresentacao = "Olá, seja bem vindo!";
            // int quantidade = 1;
            // double altura = 1.80;
            // decimal preco = 1.80M;
            // bool condicao = true;

            // Console.WriteLine(apresentacao);
            // Console.WriteLine("Valor da variável quantidade: " + quantidade);
            // Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
            // Console.WriteLine("Valor da variável preço: " + preco);
            // Console.WriteLine("Valor da variável condição: " + condicao);

            // DateTime dataAtual = DateTime.Now;
            // Console.WriteLine(dataAtual);

            // int a = 10;
            // int b = 20;

            // int c = a + b; // sinal de "=" é atribuição

            // Console.WriteLine(c);

            // c += 5; // == c = c  + 5;

            // Console.WriteLine(c);

        }
    }
}