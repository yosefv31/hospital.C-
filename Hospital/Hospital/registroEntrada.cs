﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class registroEntrada
    {
        //Atributos 
        public string nombre { get; set; }
        public string entrada { get; set; }
        public int id { get; set; }
        public byte edad { get; set; }

        public List<string> nombres = new List<string>();
        public List<string> entradas = new List<string>();
        public List<int> Id = new List<int>();
        public List<byte> edades = new List<byte>();
        public List<string> salidas = new List<string>();


        //Constructor 
        public registroEntrada(string nombre, string entrada, int id, byte edad) 
        {
            this.nombre = nombre;
            this.entrada = entrada;
            this.id = id;
            this.edad = edad;        
        }

        //Métodos externos 
        public void str() 
        {
            Console.WriteLine($"El usuario: {nombre} fue registrado con exito!!!");
        }

        public void agregarListas(string elemento1, string elemento2, int elemento3, byte elemento4) 
        { 
            nombres.Add (elemento1);
            entradas.Add (elemento2);
            Id.Add (elemento3);
            edades.Add (elemento4);
        }

        public void impresion()
        {
            foreach (string x in nombres)
            {
                Console.WriteLine(x);
            }
            foreach (string x in entradas)
            { 
                Console.WriteLine(x); 
            }
            foreach (int x in Id)
            {
                Console.WriteLine(x);
            }
            foreach(byte x in edades)
            {
                Console.WriteLine(x);
            }

        }


    }
}
