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
                            registroEntrada login = new registroEntrada("", "", 0, 0);
                            Console.WriteLine("Digite el nombre del usuario a registrar: ");
                            login.nombre = Console.ReadLine();
                            login.entrada = Convert.ToString(DateTime.Now);
                            Console.WriteLine("Digite el ID del usuario: ");
                            login.id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite la edad del usuario: ");
                            login.edad = Convert.ToByte(Console.ReadLine());

                            login.str();
                            login.agregarListas(login.nombre, login.entrada, login.id, login.edad);
                            login.impresion();

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

                catch (OverflowException e) 
                {
                    Console.WriteLine($"Error: {e}");
                }

            }
        }
    }
}
