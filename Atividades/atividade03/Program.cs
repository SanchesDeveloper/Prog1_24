using System;

namespace TabuadaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obter operador do usuário
            Console.Write("Digite o operador aritmético (+, -, *, /): ");
            string operador = Console.ReadLine();

            // Validar operador
            while (!ValidaOperador(operador))
            {
                Console.Write("Operador inválido. Digite novamente (+, -, *, /): ");
                operador = Console.ReadLine();
            }

            // Gerar e imprimir tabuada
            Console.WriteLine("\nTabuada do {0}:", operador);
            for (int numero = 1; numero <= 9; numero++)
            {
                int resultado = CalcularResultado(numero, operador);
                Console.WriteLine("{0} {1} {2} = {3}", numero, operador, numero, resultado);
            }
        }

        static bool ValidaOperador(string operador)
        {
            return operador.Equals("+") || operador.Equals("-") || operador.Equals("*") || operador.Equals("/");
        }

        static int CalcularResultado(int numero, string operador)
        {
            switch (operador)
            {
                case "+":
                    return numero + numero;
                case "-":
                    return numero - numero;
                case "*":
                    return numero * numero;
                case "/":
                    return numero / numero;
                default:
                    return 0;
            }
        }
    }
}