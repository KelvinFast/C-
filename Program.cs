using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora"
            Console.WriteLine("/t/t/t/t/tCalculadora de 4 operações");

            double num1 = 0, num2 = 0, resultado, numero;
            string operacao, valorDigitado;
            bool ehNumero;

            Console.WriteLine("Digite o primeiro número:");
            valorDigitado = Console.ReadLine()
            //validação de valor
            ehNumero = double.TryParse(valorDigitado, out numero);
            //teste logico
            if (ehNumero)
            {
                num1 = Math.Round(double.Parse(valorDigitado), 2);
            }
            else
            {
                Console.WriteLine("Eu pedi pra digitar um número!");
            }
            Console.Clear();
            Console.WriteLine("Digite o segundo número:");
            valorDigitado = Console.ReadLine()
           
            ehNumero = double.TryParse(valorDigitado, out numero);
            
            if (ehNumero)
            {
                num2 = Math.Round(double.Parse(valorDigitado), 2);
            }
            else
            {
                Console.WriteLine("Eu pedi pra digitar um número!");
            }

            Console.WriteLine("Digite a operação desejada ( + | - | * | / )");
            operacao = Console.ReadLine();
            switch(operacao)
            {
                case "+":
                    resultado = Math.Round(num1 + num2, 2);
                    Console.WriteLine($"Resultado = {resultado}");
                    break;
                case "-":
                    resultado = Math.Round(num1 - num2, 2);
                    Console.WriteLine($"Resultado = {resultado}");
                    break;
                case "*":
                    resultado = Math.Round(num1 * num2, 2);
                    Console.WriteLine($"Resultado = {resultado}");
                    break;
                case "/":
                    resultado = Math.Round(num1 / num2, 2);
                    Console.WriteLine($"Resultado = {resultado}");
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida");
                    break;
            }
            Console.ReadKey()
        }
    }
}
