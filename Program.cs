using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "123", modelo: "Modelo teste", imei: "112233", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("LinkedIn");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "123", modelo: "Modelo teste", imei: "112233", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("LinkedIn");