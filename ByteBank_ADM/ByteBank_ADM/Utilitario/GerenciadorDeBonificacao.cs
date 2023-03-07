using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using byteBanck_ADM.Funcionarios;
using ByteBank_ADM.Funcionarios;

namespace ByteBank_ADM.Utilitario
{
	public class GerenciadorDeBonificacao
	{
		public double TotalDeBonificacao { get; private set; }
		public void Registrar(Diretor diretor)
		{
			this.TotalDeBonificacao += diretor.GetBonificacao();
		}

		public void Registrar(Funcionario funcionario)
		{
			this.TotalDeBonificacao += funcionario.GetBonificacao();
		}

	}
}
