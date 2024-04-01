using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class cedulaEspecif : registroEntrada
    {
        //Atributos
        public int idValue { get; set; }

        //Constructor 
        public cedulaEspecif(string nombre, string entrada, int id, byte edad, int idValue) : base(nombre, entrada, id, edad)
        {
            this.idValue = idValue;
        }

        //Metodo externo
        public void cedulaEspeci()
        {
            try
            {
                int indice = Id.IndexOf(idValue);
                Console.WriteLine(nombres[indice]);
                Console.WriteLine(Id[indice]);
                Console.WriteLine(edades[indice]);
                Console.WriteLine(entradas[indice]);
                if (salidas[indice] == "NA")
                {
                    Console.WriteLine("El usuario no a registrado salida!!!");
                }
                else
                {
                    Console.WriteLine(salidas[indice]);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("El usuario no existe en el registro");
                Console.WriteLine("Porfavor digite un usuario valido");
            }

        }

    }
}
