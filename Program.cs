using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone iphone = new Iphone(numero: "21111", modelo:"modelo 1", imei: "1111111" , memoria: 256);

Console.WriteLine("Smartphone Iphone: ");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 2", imei: "2222222", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WeChat");

