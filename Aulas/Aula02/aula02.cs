using System;

namespace Aula02
{
	class Inicio
	{
		static void Main(string[] args)
		{
		  Console.Write("Voce disse:");
			if(args != null && args.GetLength(0)>0){
                Console.WriteLine(args.GetValue(0));
            }
		}
	}
}
