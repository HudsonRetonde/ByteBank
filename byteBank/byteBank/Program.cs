using byteBank;

ContaCorrente contaDoHudson = new ContaCorrente();
contaDoHudson.titular = "Hudson Retonde";
contaDoHudson.numero_agencia = 15;
contaDoHudson.conta = "1010-X";
contaDoHudson.saldo = 100;

Console.WriteLine($"Saldo da conta do Hudson é = {contaDoHudson.saldo} .");

contaDoHudson.Depositar(100);

Console.WriteLine($"Saldo do Hudson após receber R$ 100,00 reais é R$ {contaDoHudson.saldo}");

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Pereira";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-Y";
contaDaMaria.saldo = 350;

Console.WriteLine($"Saldo da conta da Maria é = {contaDaMaria.saldo} .");

contaDoHudson.Transferir(50, contaDaMaria);

Console.WriteLine($"Saldo da conta do Hudson é = {contaDoHudson.saldo} .");
Console.WriteLine($"Saldo da conta da Maria é = {contaDaMaria.saldo} .");
