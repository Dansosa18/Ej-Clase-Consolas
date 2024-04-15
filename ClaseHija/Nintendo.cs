using Ejercicio_clase_9.Clase_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_clase_9.NewFolder
{
    internal class Nintendo : ClsConsola
    {
        public bool EsPortatil {  get; set; }

        public string MostrarDetallesNintendo()
        {
            MostrarDetalles();
            return $"Es portatil: {EsPortatil}";
        }
    }
}
