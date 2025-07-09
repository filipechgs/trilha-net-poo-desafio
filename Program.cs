using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia(
    "71889767345",
    "C01 Plus",
    "0934797634",
    128
);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Signal");
Console.WriteLine($@"
Número: {nokia.Numero}
Modelo: {nokia.MemoriaAparelho}
IMEI: {nokia.IMEIAparelho}
Memória: {nokia.MemoriaAparelho}
");

Iphone iphone = new Iphone(
    "71889767345",
    "C01 Plus",
    "0934797634",
    128
);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Signal");
Console.WriteLine($@"
Número: {iphone.Numero}
Modelo: {iphone.MemoriaAparelho}
IMEI: {iphone.IMEIAparelho}
Memória: {iphone.MemoriaAparelho}
");