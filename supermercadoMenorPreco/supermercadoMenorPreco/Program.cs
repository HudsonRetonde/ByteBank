using supermercadoMenorPreco;

Produto feijao = new Produto();

feijao.nome = "Grão do Bom";
feijao.fabricante = "Grão Brasil";
feijao.codigoDeBarras = "12365.58745.0.5.54789";
feijao.valorUnitario = 4.59;
feijao.valorDaCompra = 4590.00;
feijao.quantidadeEmEstoque = 1000;

Console.WriteLine($"Compramos o {feijao.nome}, do fabricante {feijao.fabricante}, " +
	$"cujo código de barras é {feijao.codigoDeBarras}, " +
	$"preço unitário de R$ {feijao.valorUnitario}, valor da compra totalizando R$ {feijao.valorDaCompra} " +
	$"com a quantidade no estoque de {feijao.quantidadeEmEstoque} unidades.");