using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using Hospital.Hospital;

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
                            break;

                        case 2:
                            registroSalida logout = new registroSalida("", "", 0, 0, "", 0);
                            Console.WriteLine("Digite la cédula para el registro de salida: ");
                            logout.idValue = Convert.ToInt32(Console.ReadLine());
                            logout.salida = Convert.ToString(DateTime.Now);
                            logout.agregarSalidas(logout.salida);
                            logout.imprimi();
                            break;

                        case 3:
                            consultaCedula question = new consultaCedula("","",0, 0);
                            Console.WriteLine("Las cédulas registradas son: ");
                            question.imprimeCedula();
                            break;

                        case 4:
                            cedulaEspecif question2 = new cedulaEspecif("", "", 0, 0, 0);
                            Console.WriteLine("Digite el número de cédula a consultar: ");
                            question2.idValue = Convert.ToInt32(Console.ReadLine());
                            question2.cedulaEspeci();
                            break;
                        case 5:
                            Console.WriteLine("Gracias por utilizar el programa :)");
                            booleano = false;
                            break;
                    }
                }
                catch (FormatException)
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
