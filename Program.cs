using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "(11) 98765-4321", modelo: "Modelo 1", imei: "111111111", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

iphone.ReceberLigacao();
Console.WriteLine("");

Nokia nk = new Nokia("(11)997129874", "Nokia G50", "2334567830495823", 256);
nk.Ligar();
nk.InstalarAplicativo("WhatsApp");
nk.ReceberLigacao();