using System;

namespace averiguaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int numAle = num.Next(0, 100);
            int attempts = 5;

            Console.WriteLine("Juego: Adivina el numero del 0 al 100");
            Console.WriteLine("Ingrese numero:");
            int myNum = int.Parse(Console.ReadLine());
            while (myNum != numAle) 
            {
                
                if (myNum > numAle)
                {
                    Console.WriteLine("El numero ingresado es mayor al aleatorio, vuelve a ingresar otro numero:");
                } else
                {
                    Console.WriteLine("el numero ingresado es menor al aleatorio, vuelve a ingresar otro numero:");
                }
                attempts--;
                Console.WriteLine($"le quedan: {attempts} intentos");

                 myNum = int.Parse(Console.ReadLine());

                if (attempts == 1)
                {
                    Console.WriteLine("se acabaron tus intentos, el juego a terminado");
                    break;
                }

                if (myNum == numAle) Console.WriteLine("Felicitaciones has adivinado el numero");

            } 
        }
    }
}
