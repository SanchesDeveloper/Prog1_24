// TRABALHANDO COM VARIAVEIS C#
using System;
// STRINGS
// DECLARANDO VARIAVEL SEM INICIALIZACAO
string message1 = null;
// INICIALIZAR A VARIAVEL COM NULO
string message2 = null;
// INICIALIZAR STRING VAZIA
string message3 = System.String.Empty;
// DECLARAR UMA STRING COM VALOR IMPLICITO
var message4 = "Uma mensagem aleatoria";

Console.WriteLine( message4 );

// CONCATENANDO STRINGS
string concat = (message1 == null ? "" : message1) + " " + message2 + " " +
                message3 + " " + message4;

Console.WriteLine("\n" + concat );

Console.WriteLine(
     "A temperatura hoje {0:D} é {1}°C"
    , DateTime.Now
    , 23
);

string nome = string.Empty;
Console.WriteLine("Qual é o seu nome? ");
nome = Console.ReadLine();
string resultado = $"Oi, {nome}! Pare de jaguarice!";
Console.WriteLine(resultado);
