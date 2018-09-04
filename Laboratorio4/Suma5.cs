using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Suma5 : Persona
    {
        public Suma5(string nombre) : base(nombre)
        {

        }

        public override int Calcular(int numero)
        {
            return numero + 5;
        }
    }
}
