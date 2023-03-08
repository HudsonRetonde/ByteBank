using byteBanck_ADM.Funcionarios;
using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;

#region
//Funcionario pedro = new Funcionario("112345898745", 2000.00);

//pedro.Nome = "Pedro José";


//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("15987456512");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo Salário do Pedro: " + pedro.Salario);

//Console.WriteLine("Novo Salário do Roberta: " + roberta.Salario);
#endregion

CalcularBonificacao();
void CalcularBonificacao()
{
	GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

	Designer ulisses = new Designer("14785411147");
	ulisses.Nome = "Ulisses Souza";

	Diretor paula = new Diretor("45789631474");
	paula.Nome = "Paula Souza";

	Auxiliar igor = new Auxiliar("372615463627");
	igor.Nome = "Igor Dias";

	GerenteDeContas camila = new GerenteDeContas("13245699999");
	camila.Nome = "Camila Oliveira";

	gerenciador.Registrar(ulisses);
	gerenciador.Registrar(paula);
	gerenciador.Registrar(igor);
	gerenciador.Registrar(camila);

	Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonificacao);
}