using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class AlCubo : Maquina
    {
        public AlCubo(string etiqueta) : base(etiqueta)
        {

        }

        public override int Calcular(int numero)
        {
            return (int)Math.Pow(numero, 3);
        }
    }
}
