using System;

    public class mientras_o_doWhile
    {
        public static void Main()
        {
            // Ciclos 'do while' o mientras
            int mientras = 0;
            do
            {
                //Console.WriteLine(mientras);
                //Incrementar el contador
                //Iteró 99 veces, mientras 0->99
                mientras++;
            }
            while (mientras < 100);
            Console.WriteLine("Valor mientras: " + mientras);

        }
    }