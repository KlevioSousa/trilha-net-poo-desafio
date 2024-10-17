using DesafioPOO.Models;

// Testando a classe Nokia
Console.WriteLine("Testando Nokia");
Nokia nokia = new Nokia("123852963", "Nokia X", "1111111111111", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

// Testando a classe Iphone
Console.WriteLine("\nTestando Iphone");
Iphone iphone = new Iphone("963852741", "Iphone 15", "2222222222222", 256);
iphone.Ligar();
nokia.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");