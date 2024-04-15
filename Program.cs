using Ejercicio_clase_9.ClaseHija;
using Ejercicio_clase_9.NewFolder;

static void Main(string[] args)
{
    Nintendo sw = new Nintendo();
    sw.EsPortatil = true;
    sw.AnioLanzamiento = 2017;
    sw.Marca = "Nintendo switch";
    sw.MostrarDetallesNintendo();

    string resultado = sw.MostrarDetallesNintendo();
    
        Console.WriteLine(resultado);

    PlayStation ps= new PlayStation();
    ps.ModeControlador = "Dual Sent";
    ps.AnioLanzamiento = 2016;
    ps.Marca = "Play Station ";


    string resultado1 = ps.MostrarDetallesPS();
    Console.WriteLine(resultado1);

    Xbox xbox = new Xbox();
    xbox.GamePass = true;
    xbox.AnioLanzamiento = 2022;
    xbox.Marca = "Xbox Series X";
    string resultado2= xbox.MostrarDetallesXbox();
    Console.WriteLine(resultado2);
    
}
