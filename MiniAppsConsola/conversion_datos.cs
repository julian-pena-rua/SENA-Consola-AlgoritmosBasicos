using System;

public class conversion_datos {
	
    public static void Main() {
        ///////////////////////////////////////
        // Convirtiendo Tipos de Datos y Conversión de Tipos
        ///////////////////////////////////////
        // Convirtiendo datos
        
        // Convertir String a Integer
        int suma = 123 + int.Parse("123");//retorna una versión entera de "123"
        Console.WriteLine(suma);
        
        // Convertir Integer a String
        string concatenar = "Avenida siempre viva - " + Convert.ToString(123);//retorna una versión string de 123
        Console.WriteLine(concatenar);
        Console.ReadKey();
        
    }
}