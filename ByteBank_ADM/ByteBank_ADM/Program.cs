using byteBanck_ADM.Funcionarios;
using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;

Funcionario pedro = new Funcionario();

pedro.Nome = "Pedro José";
pedro.Cpf = "112345898745";
pedro.Salario = 2000.00;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor();
roberta.Nome = "Roberta Silva";
roberta.Cpf = "15987456512";
roberta.Salario = 5000.00;

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);