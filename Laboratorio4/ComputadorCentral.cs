using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class ComputadorCentral
    {
        private static Random random = new Random();
        private ICalcular[] calculadoras;
        private static int numero = 0;

        public ComputadorCentral()
        {
            calculadoras = new ICalcular[] { };
        }


        public void Calcular()
        {
            int maquinaCalculadora = random.Next(0, calculadoras.Length);
            numero = calculadoras[maquinaCalculadora].Calcular(numero);
        }

        public void AgregarCalculadora(ICalcular calculadora)
        {
            Array.Resize(ref calculadoras, calculadoras.Length + 1);
            calculadoras[calculadoras.Length - 1] = calculadora;
        }

        public int GetNumero()
        {
            return numero; 
        }
    }
}
