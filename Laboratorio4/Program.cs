using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputadorCentral computadorCentral = new ComputadorCentral();
            computadorCentral.AgregarCalculadora(new AlCubo("R2-D2"));
            computadorCentral.AgregarCalculadora(new AlCuadrado("C-3P0"));
            computadorCentral.AgregarCalculadora(new Factorial("AT-AT"));
            computadorCentral.AgregarCalculadora(new Suma5("Nicolas"));
            computadorCentral.AgregarCalculadora(new Multiplica5("Ignacio"));

            Console.WriteLine("INICIANDO PROCESO DE CALCULO");
            for (int i = 0; i < 42; i++)
            {
                computadorCentral.Calcular();
            }

            Console.WriteLine("PROCESO DE CALCULO TERMINADO");
            Console.WriteLine("RESULTADO DEL CALCULO: {0}", computadorCentral.GetNumero());
            Console.WriteLine("Presiones una tecla para salir...");
            Console.ReadKey();
            
        }
    }
}
