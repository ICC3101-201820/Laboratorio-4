using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Factorial : Maquina
    {
        public Factorial(string etiqueta): base(etiqueta)
        {

        }

        public override int Calcular(int numero)
        {
            int resultado = numero;

            for(int i = numero-1; i>0; i--)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
