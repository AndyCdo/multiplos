using System;

namespace multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Ingrese un numero: ");
         int numerodeTabla= Convert.ToInt32(Console.ReadLine());

         for (int numero= 1; numero <= 9; numero ++)
         {
            int resultado= numerodeTabla * numero;
            Console.WriteLine(numerodeTabla + "X" + numero + "=" + resultado);
         }
         
          





        }
    }
}
