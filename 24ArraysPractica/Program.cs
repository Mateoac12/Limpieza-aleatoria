using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _24ArraysPractica
{
    class Program
    {
        static void Main(string[] args)
        {
            Instrucciones();
        }

        public static int NumeroRandom(byte jugadores)
        {
            Random num = new Random();

            int numRandom = num.Next(1, jugadores);  // de 1 al numero de jugadores maximo

            return numRandom;
        }

        public static void Instrucciones()
        {
            byte participantes = 0;

            Console.WriteLine("LIMPIEZA ALEATORIA!\n");

            Console.WriteLine("Introduce el número de participantes:");

            do
            {
                try
                {
                    participantes = Byte.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("\nIntroduce un valor numérico por favor:");
                }
                catch(OverflowException e)
                {
                    Console.WriteLine("\nNo puede introducir números negativos.\nVuelva a intentarlo por favor:");
                }
            } while (participantes == 0);

            Console.WriteLine("\n---------------------------------------\n");

            Console.WriteLine("Que empiece el juego!");

            string[] listaParticipantes = new string[participantes];

            byte numeroLista = 0;

            while (numeroLista < participantes)
            {
                numeroLista++;

                Console.WriteLine($"\nParticipante número {numeroLista}: ");

                listaParticipantes[numeroLista - 1] = Console.ReadLine();
            }

            Console.WriteLine("\nLa persona elegida para limpiar es...\n");

            string ganador = listaParticipantes[NumeroRandom(participantes) - 1];

            Console.WriteLine(ganador + "!");

        }
    }
}
