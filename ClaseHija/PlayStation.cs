using Ejercicio_clase_9.Clase_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_clase_9.ClaseHija
{
    internal class PlayStation : ClsConsola
    {
        public string ModeControlador { get; set; }


        public string MostrarDetallesPS ()
        {
            MostrarDetalles();
            return $"Modelo de Controlador: {ModeControlador}";

        }
    }
}
