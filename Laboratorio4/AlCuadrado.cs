using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class AlCuadrado : Maquina
    {
        public AlCuadrado(string etiqueta) : base(etiqueta)
        {

        }

        public override int Calcular(int numero)
        {
            return numero * numero;
        }
    }
}
