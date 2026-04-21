using Microsoft.AspNetCore.Mvc;
using Recursividade.Models;
using System.Diagnostics;

namespace Recursividade.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public double Factorial(int number)
        {
            if (number == 0)
                return 1;
            
            double factorial = 1;
            for(int i = number; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        public double Recursivefactorial(int number)
        {
            //Caso Base: O fatorial de 0 é 1
            if (number == 0)
                return 1;

            //chamada Recursiva
            return number * Recursivefactorial(number - 1);
        }

        [HttpGet]

        public string PrintNaturalRecursion(int count = 10)
        {
            return NaturalNumberRecursion(1, count);
        }

        public string NaturalNumberRecursion(
            int n,
            int count
            )
        {
            string ret = string.Empty;

            // Caso Base: Se o contador for menor que 1
            if (count <= 1)
                return $" {n}";

            ret += $" {n}";
            count--; // Decrmenta count

            //Chamada Recursiva: Incremeta n e Decrementa count
            // Pra imprimir o número
            ret += NaturalNumberRecursion(n + 1, count);

            return ret;
        }

        public string PrintNaturalNumbers(int count = 10)
        {
            return NaturalNumbers(1, count);
        }

        public string NaturalNumbers(int n, int count) 
        {
            string ret = string.Empty;

            for (int i = n; i <= count; i++)
            {
                ret += $" {i}";
            }

            return ret;
        }

        public string PrintFibonacciSequence(int n = 15)
        {
            return FibonacciSequence(n);
        }
        public string FibonacciSequence(int n)
        {
            string fibonacci = string.Empty;
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                // 1. Guarda o valor atual na string
                fibonacci = fibonacci + a + " ";

                // 2. Calcula o próximo número
                int proximo = a + b;

                // 3. Avança as posições
                a = b;
                b = proximo;
            }

            return fibonacci;
        }

        public string PrintFibonacciRecursion(int n = 15)
        {
            string resultado = "";

            // Precisamos percorrer de 0 até n para montar a sequência
            for (int i = 0; i < n; i++)
            {
                // Chama o método recursivo para cada posição 'i'
                resultado = resultado + FibonacciRecursion(i) + " ";
            }

            return resultado;
        }

        public int FibonacciRecursion(int n)
        {
            // Caso Base: O fatorial de 0 é 1
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            //chamada Recursiva
            return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
        }
    }
}
