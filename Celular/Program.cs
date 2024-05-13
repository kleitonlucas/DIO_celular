using Celular.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "99997777", modelo: "NK X.2", imei: "1234567890", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("App Teste");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "98883333", modelo: "I.5", imei: "0987654321", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("App Teste");
