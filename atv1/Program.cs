using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultado;
            string operacao;

            Console.WriteLine("Calculadora Simples em C# usando switch");
            Console.Write("Digite o primeiro número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a operação (+, -, *, /, %: ): ");
            operacao = Console.ReadLine();

            switch (operacao)
            {
                case "+":
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;

                case "-":
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;

                case "*":
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Resultado: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero.");
                    }
                    break;

                case "%":
                    if (num2 != 0)
                    {
                        resultado = num1 % num2;
                        Console.WriteLine($"Resultado: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero.");
                    }
                    break;

                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}