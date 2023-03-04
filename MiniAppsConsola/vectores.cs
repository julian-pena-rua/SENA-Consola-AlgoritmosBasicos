using System;

public class Vectores_ArrayDeNombres {

    public static void Main() {

        string[ ] nombre = new string[4];

        nombre[0] = "Luis";

        nombre[1] = "María";

        nombre[2] = "Carlos";

        nombre[3] = "Jose";
        
		for (int i = 0; i < nombre.Length; i++)
        {
            Console.WriteLine(nombre[i]);
        }
    }
}