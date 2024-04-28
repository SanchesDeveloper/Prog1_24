using System;

namespace OperacoesAritmeticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CALCULADORA DE OPERAÇÕES ARITMÉTICAS ===");
            
            // Leitura do primeiro operando
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Leitura do operador aritmético
            Console.Write("Digite o operador aritmético (+, -, *, /): ");
            char operador = Convert.ToChar(Console.ReadLine());

            // Leitura do segundo operando
            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            // Verificação e execução da operação aritmética
            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Erro: divisão por zero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Operador aritmético inválido.");
                    return;
            }

            // Exibição do resultado
            Console.WriteLine($"Resultado: {resultado}");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}