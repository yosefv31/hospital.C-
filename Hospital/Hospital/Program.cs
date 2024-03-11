using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace Hospital
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool booleano = true;
            while (booleano)
            {
                Console.WriteLine("Menú");
                Console.WriteLine("1) Registrar entrada");
                Console.WriteLine("2) Registrar salida");
                Console.WriteLine("3) Consultar cédulas");
                Console.WriteLine("4) Consultar cédula especifica");
                Console.WriteLine("5) Salir");
                try
                {
                    Console.WriteLine("Digite una opcion: ");
                    byte opcionUsuario = Convert.ToByte(Console.ReadLine());
                    switch (opcionUsuario)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            Console.WriteLine("Gracias por utilizar el programa :)");
                            booleano = false;
                            break;
                    }
                }
                catch (SyntaxErrorException)
                {
                    Console.WriteLine("Opcion invalida!!!");
                    Console.WriteLine("Porfavor digite una opcion valida ");
                }
            }
        }
    }
}
