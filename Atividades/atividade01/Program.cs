using System;

namespace FichaCadastral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== FICHA CADASTRAL ===");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Data de Nascimento (DD/MM/AAAA): ");
            DateTime dataNascimento;
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataNascimento))
            {
                Console.WriteLine("Formato de data inválido. Por favor, insira no formato DD/MM/AAAA.");
                Console.Write("Data de Nascimento (DD/MM/AAAA): ");
            }

            Console.Write("Sexo ou Gênero: ");
            string genero = Console.ReadLine();

            Console.Write("CEP: ");
            string cep = Console.ReadLine();

            Console.Write("Rua: ");
            string rua = Console.ReadLine();

            Console.Write("Número: ");
            string numero = Console.ReadLine();

            Console.Write("Bairro: ");
            string bairro = Console.ReadLine();

            Console.Write("Cidade: ");
            string cidade = Console.ReadLine();

            Console.Write("UF: ");
            string uf = Console.ReadLine();

            Console.Write("País: ");
            string pais = Console.ReadLine();

            Console.WriteLine("\n=== FICHA CADASTRAL COMPLETADA ===");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"E-mail: {email}");
            Console.WriteLine($"Data de Nascimento: {dataNascimento.ToShortDateString()}");
            Console.WriteLine($"Sexo ou Gênero: {genero}");
            Console.WriteLine($"CEP: {cep}");
            Console.WriteLine($"Rua: {rua}");
            Console.WriteLine($"Número: {numero}");
            Console.WriteLine($"Bairro: {bairro}");
            Console.WriteLine($"Cidade: {cidade}");
            Console.WriteLine($"UF: {uf}");
            Console.WriteLine($"País: {pais}");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}