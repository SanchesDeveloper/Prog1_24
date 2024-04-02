using atv0104.Models;

Console.WriteLine("Hello World");

Customer c1 = new Customer();
c1.CustomerId = 1;
c1.Name = "Jaguara";
c1.EmailAddress = "jaguara@pixote.net";

// Construtor de instanciação.
Customer c2 = new Customer(2);
c1.Name = "Boca-mole";
c1.EmailAddress = "bocamole@pixote.net";

// Contrutor por atribuição.
Customer c3 = new Customer{
    CustomerId = 3,
    Name = "Nerso",
    EmailAddress = "nerso@pixote.net"
};