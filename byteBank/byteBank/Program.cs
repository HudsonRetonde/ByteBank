using byteBank;

ContaCorrente contaDoHudson = new ContaCorrente();
contaDoHudson.titular = "Hudson Retonde";
contaDoHudson.numero_agencia = 15;
contaDoHudson.conta = "1010-X";
contaDoHudson.saldo = 100;

Console.WriteLine($"Saldo da conta do Hudson é = {contaDoHudson.saldo} .");
