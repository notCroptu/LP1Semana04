using System;

namespace ValuesAndReferences
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Variables
            //cria variaveis int e int array, em que x1 e y1 sao iguais ás anteriores
            int x0 = 9;
            int[] y0 = new int[] { 2, 3, 4 };
            int x1 = x0;
            int[] y1 = y0;

            // Show x0 and y0 contents
            //mostra os contents originais das variabeis x0 e y0
            Console.WriteLine("Original contents:");
            ShowVars(x0, y0);

            // Change x1 and y1
            //muda a variavel x1 para 1, e a referencia y1 de (2, 3, 4) para (2, 1, 4)
            x1 = 1;
            y1[1] = 1;

            // Check what happened to x0 and y0
            //mostra as variaveis x0 e yo, em que so y0 foi mudada, uma linha depois da outra
            Console.WriteLine("After changing x1 and y1 values:");
            ShowVars(x0, y0);

            // Change y1 again and check what happens to y0
            //mostra as variaveis x0 e yo, que nao foram mudadas, uma linha depois da outra
            y1 = new int[] { -5, -4, -3 };
            Console.WriteLine("After changing y1 reference:");
            ShowVars(x0, y0);
        }

        private static void ShowVars(int a, int[] b)
        {
            Console.WriteLine($"\tx0 = {a}");
            Console.Write("\ty0 = [ ");
            foreach (int n in b) Console.Write($"{n} ");
            Console.WriteLine("]");
        }
    }
}
