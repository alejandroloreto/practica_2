
using System;

namespace practica2
{
	class Program
	{
		
		public static void Main(string[] args)
		{
			  string pan;
		 string leche;
		 string galletas;
		 double a;
		 double b;
		 double c;
			
			
			Console.WriteLine("Precio del Pan");
			pan=Console.ReadLine();
			Console.WriteLine("Precio del leche");
			leche=Console.ReadLine();
			Console.WriteLine("Precio del galletas");
			galletas=Console.ReadLine();
			
			float apan = float.Parse(pan);
			float bleche = float.Parse(leche);
			float cgalletas = float.Parse(galletas);
			
			 a = apan * 1.16;
			 b = bleche * 1.16;
			 c = cgalletas * 1.16;
 			 	
			Console.Clear();
			Console.WriteLine("Sus datos son los siguientes: ");
			Console.WriteLine("Pan + iva: "+ a);
			Console.WriteLine("leche + iva: " + b);
			Console.WriteLine("galletas + iva: " + c);
			
			Console.ReadKey(true);
		}
	}
}