using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "12345", modelo:"Modelo 1", imei:"123-CDQ", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");
Console.WriteLine("*************************************");
Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "90876", modelo:"Modelo 2", imei:"127-BED", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");