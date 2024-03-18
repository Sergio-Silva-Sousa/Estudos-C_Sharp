using System;

namespace Aula02
{
	class Inicio
	{
		static void Main(string[] args)
		{
			Console.Write("kkk");
			if(args != null && args.GetLength(0)>0){
                Console.Write(args.GetValue(0));
            }
		}
	}
}
