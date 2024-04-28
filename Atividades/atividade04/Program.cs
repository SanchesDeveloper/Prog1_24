using System;
using System.Collections.Generic;

namespace Imobiliaria
{
    // Enum para representar o tipo de localidade (Rural ou Urbano)
    public enum TipoLocalidade
    {
        Rural,
        Urbano
    }

    // Enum para representar o tipo de negócio (Locação ou Venda)
    public enum TipoNegocio
    {
        Locacao,
        Venda
    }

    // Classe para representar um item imobiliário
    public class Imovel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int NumeroComodos { get; set; }
        public TipoLocalidade Localidade { get; set; }
        public TipoNegocio Negocio { get; set; }
        public List<string> Imagens { get; set; }

        public Imovel()
        {
            Imagens = new List<string>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Aqui você pode testar a criação de objetos Imovel e manipular suas propriedades
            // Exemplo:
            var apartamento = new Imovel
            {
                Nome = "Apartamento no centro",
                Descricao = "Apartamento bem localizado no centro da cidade",
                Valor = 200000,
                NumeroComodos = 3,
                Localidade = TipoLocalidade.Urbano,
                Negocio = TipoNegocio.Venda
            };

            // Adicionando imagens ao apartamento
            apartamento.Imagens.Add("foto1.jpg");
            apartamento.Imagens.Add("foto2.jpg");

            // Exibindo informações do apartamento
            Console.WriteLine("Informações do apartamento:");
            Console.WriteLine($"Nome: {apartamento.Nome}");
            Console.WriteLine($"Descrição: {apartamento.Descricao}");
            Console.WriteLine($"Valor: R$ {apartamento.Valor}");
            Console.WriteLine($"Número de cômodos: {apartamento.NumeroComodos}");
            Console.WriteLine($"Localidade: {apartamento.Localidade}");
            Console.WriteLine($"Tipo de negócio: {apartamento.Negocio}");
            Console.WriteLine("Imagens:");
            foreach (var imagem in apartamento.Imagens)
            {
                Console.WriteLine(imagem);
            }
        }
    }
}