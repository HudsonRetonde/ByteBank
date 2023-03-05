using byteBanck_ADM.Funcionarios;

Funcionario pedro = new Funcionario();

pedro.Nome = "Pedro José";
pedro.Cpf = "112345898745";
pedro.Salario = 2000;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());