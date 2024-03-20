using System;

namespace Aula09
{

	class Program
	{

		static void Main(string[] args)
		{

			int num = 20, num2 = 10;
			// << Dobra 
			// >> Metade

			num = num >> 1;
			num2 = num2 << 1;

			Console.WriteLine(num);
			Console.WriteLine(num2);

		}
	}
}

