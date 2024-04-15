using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_clase_9.Clase_Base
{
    internal class ClsConsola
    {
        public int AnioLanzamiento { get; set;}
        public string Marca { get; set; }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Algo nuevo Marca: {Marca}, año de lanzamiento:{AnioLanzamiento}");

        }
    }
}

