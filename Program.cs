using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia; ");
Smartphone nokia = new Nokia("34567", "modelo 02", "28k9fhf0f", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Duolingo");

Console.WriteLine("=====================================");

Console.WriteLine("Smartphone Iphone; ");
Smartphone iphone = new Iphone("890879", "modelo i90", "90okbhy57", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Google Gemíní");
