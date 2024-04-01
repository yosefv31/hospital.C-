using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class consultaCedula : registroEntrada
    {
        //Constructor
        public consultaCedula(string nombre, string entrada, int id, byte edad) : base(nombre, entrada, id, edad)
        { }

        //Metodos externos 
        public void imprimeCedula()
        {
            for (int i = 0; i < Id.Count; i++)
            {
                Console.WriteLine(nombres[i]);
                Console.WriteLine(Id[i]);
                Console.WriteLine(edades[i]);
                Console.WriteLine(entradas[i]);
                if (salidas[i] == "NA")
                {
                    Console.WriteLine("El usuario no a registrado salida!!!");
                }
                else
                {
                    Console.WriteLine(salidas[i]);
                } 
            }
        }
    }
}
