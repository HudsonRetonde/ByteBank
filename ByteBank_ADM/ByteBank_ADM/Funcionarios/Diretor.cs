﻿using byteBanck_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
	public class Diretor : Funcionario
	{	
		public double GetBonificacao()
		{
			return this.Salario * 0.10;
		}
	}
}