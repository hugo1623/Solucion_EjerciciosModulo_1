using System;

namespace EjerciciosModulo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {

           
                try
                {
                    Console.WriteLine("Escriba un Número");
                    int  numero1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba un Número");
                    int numero2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("El Número mayor es : ");
                    if (numero1>numero2)
                    {
                        Console.WriteLine(numero1);
                    }
                    else
                    {
                        Console.WriteLine(numero2);
                    }

                    break;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Asegurese de escribir valores numericos");
                }
             }


        }
    }
}
