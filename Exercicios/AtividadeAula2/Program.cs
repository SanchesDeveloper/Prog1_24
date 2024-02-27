using System;

string nome = string.Empty;
Console.WriteLine("Qual é o seu nome? ");
nome = Console.ReadLine();

string email = string.Empty;
Console.WriteLine("Qual é o seu email? ");
email = Console.ReadLine();

string nascimento = string.Empty;
Console.WriteLine("Qual a sua data de nascimento? ");
nascimento = Console.ReadLine();

string sexo = string.Empty;
Console.WriteLine("Qual é o seu gênero? ");
sexo = Console.ReadLine();

string cep = string.Empty;
Console.WriteLine("Qual é o cep da sua rua? ");
cep = Console.ReadLine();

string rua = string.Empty;
Console.WriteLine("Qual é o nome da sua rua? ");
rua = Console.ReadLine();

string numCasa = string.Empty;
Console.WriteLine("Qual é o número da sua casa? ");
numCasa = Console.ReadLine();

string bairro = string.Empty;
Console.WriteLine("Qual é o seu bairro? ");
bairro = Console.ReadLine();

string cidade = string.Empty;
Console.WriteLine("Qual é a sua cidade? ");
cidade = Console.ReadLine();

string uniFed = string.Empty;
Console.WriteLine("Qual é a unidade federativa? ");
uniFed = Console.ReadLine();

string pais = string.Empty;
Console.WriteLine("Qual é o seu país? ");
pais = Console.ReadLine();

string concat = nome + "\n" + email + "\n" + nascimento + "\n" +
                sexo + "\n" + cep + "\n" + rua + "\n" + numCasa +
                 "\n" + bairro + "\n"  + cidade + "\n" + uniFed +
                  "\n"  + pais;
Console.WriteLine("Os dados do usuario são os seguintes: \n");
Console.WriteLine(concat);

