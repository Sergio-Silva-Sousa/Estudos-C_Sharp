using System;

namespace Aula06{
    class Program{
        
		static void Main(string[] args){
	
	double valor_Compra = 1881.52;
	double valor_Venda;
	double lucro = 0.1;
	string nome_produto = "VR";
	
	valor_Venda = valor_Compra + (valor_Compra * lucro);
	
	Console.WriteLine($"Produto.........:{nome_produto,15}");
	Console.WriteLine($"Valor da Compra.:{valor_Compra,15:c}");
	Console.WriteLine($"Lucro...........:{lucro * 100,14:f2}%");
	Console.WriteLine($"Valor da Venda..:{valor_Venda,15:c}");
	
        }
    }
}