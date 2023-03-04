using System;

public class Comando_Leer
{
	public static void Main()
	{
		Console.Write("Digita tu nombre: ");
		string nombre = Console.ReadLine();
		Console.WriteLine("Tu nombre es: " + nombre);
		
	}
}