using ByteBank;
using ByteBank.Titular;

Console.WriteLine("Boas vindas ao seu banco, ByteBank!");


ContaCorrente conta4 = new ContaCorrente(233, "123458-X");
ContaCorrente conta5 = new ContaCorrente(234, "323458-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
Console.ReadKey();