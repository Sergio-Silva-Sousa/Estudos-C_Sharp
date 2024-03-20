using System;
using System.Globalization;

namespace Aula07{
    
	class Program{
        
		static void Main(string[] args){
            double weight,height,imc;
			string name;
			
			Console.WriteLine("Calculadora de IMC");
			
			Console.Write("Digite seu nome: ");
			name=Console.ReadLine();
			Console.Write("Digite seu peso: ");
			weight=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
			Console.Write("Digite sua altura: ");
			height=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
			imc= weight / (height * height);
			Console.WriteLine("A tabela abaixo terá seus resultados:");
			Console.WriteLine($"Nome:{name,22}\nPeso:{weight,22:f2}\nAltura:{height,20:f2}\nIMC:{imc,23:f2}");
        }
    }
}