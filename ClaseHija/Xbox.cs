using Ejercicio_clase_9.Clase_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_clase_9.ClaseHija
{
    internal class Xbox : ClsConsola
    {
        public bool GamePass { get; set; }

        public string MostrarDetallesXbox ()
        {
            MostrarDetalles();
            return $"Tiene Game Pass: {GamePass}";
        }
    }
}
