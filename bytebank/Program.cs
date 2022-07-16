using ByteBank;
using ByteBank.Titular;

Console.WriteLine("Boas vindas ao seu banco, ByteBank!");

Cliente sarah = new Cliente();


ContaCorrente conta4 = new ContaCorrente();

conta4.Saldo = 100;
conta4.Titular = sarah;
Console.WriteLine($"Saldo: {conta4.Saldo}");

Console.ReadKey();