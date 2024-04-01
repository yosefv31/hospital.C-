using Hospital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class registroSalida : registroEntrada
    {
        //Atributos
        public string salida { get; set; }
        public int idValue { get; set; }

        //Constructor 
        public registroSalida(string nombre, string entrada, int id, byte edad, string salida, int idValue) : base(nombre, entrada, id, edad)
        {
            this.salida = salida;
            this.idValue = idValue;
        }

        //Métodos externos 
        public void agregarSalidas(string elemento1)
        {
            byte i = 0;
            foreach (int x in Id)
            {
                if (idValue == x)
                {
                    int indice = Id.IndexOf(x);
                    salidas.RemoveAt(indice);
                    salidas.Insert(indice, elemento1);
                    Console.WriteLine("La salida del usuario fue registrada con éxito!!!");
                    break;
                }
                else if (i >= Id.Count && x != idValue)
                {
                    Console.WriteLine("El usuario no fue encontrado!!!");
                    break;
                }
                i++;
            } 
        }
        public void imprimi()
        {
            foreach (string x in salidas)
            {
                Console.WriteLine(x);
            }
        }

    }
}
