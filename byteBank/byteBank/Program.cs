using byteBank.Contas;
using byteBank.Titular;

//ContaCorrente contaDoHudson = new ContaCorrente();
//contaDoHudson.titular = "Hudson Retonde";
//contaDoHudson.numero_agencia = 15;
//contaDoHudson.conta = "1010-X";
//contaDoHudson.saldo = 100;

//Console.WriteLine($"Saldo da conta do Hudson é = {contaDoHudson.saldo} .");

//contaDoHudson.Depositar(100);

//Console.WriteLine($"Saldo do Hudson após receber R$ 100,00 reais é R$ {contaDoHudson.saldo}");

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Pereira";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-Y";
//contaDaMaria.saldo = 350;

//Console.WriteLine($"Saldo da conta da Maria é = {contaDaMaria.saldo} .");

//contaDoHudson.Transferir(50, contaDaMaria);

//Console.WriteLine($"Saldo da conta do Hudson é = {contaDoHudson.saldo} .");
//Console.WriteLine($"Saldo da conta da Maria é = {contaDaMaria.saldo} .");

//ContaCorrente contaDoPedro = new ContaCorrente();
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.saldo);

//Cliente cliente = new Cliente();
//cliente.nome = "Hudson Retonde";
//cliente.cpf = "12345678948";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissão = " + conta.titular.profissao);
//Console.WriteLine("Conta = " + conta.conta);
//Console.WriteLine("Agência = " + conta.numero_agencia);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Tester";
//conta2.titular.cpf = "14785478965";
//conta2.conta = "9999-X";
//conta2.numero_agencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_agencia= 18;
//conta3.Conta = "1011-H";
//conta3.SetSaldo(200);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_agencia);

//ContaCorrente conta4 = new ContaCorrente(18, "1010-T");
//conta4.SetSaldo(500);
//conta4.titular = new Cliente();
//Console.WriteLine(conta4.GetSaldo());
//cw.WriteLine(conta4.Numero_agencia);

ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente(2834, "1457-Y");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);