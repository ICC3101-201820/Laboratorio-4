using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    abstract class Persona : ICalcular
    {
        protected string nombre;

        protected Persona(string nombre)
        {
            this.nombre = nombre;
        }

       public virtual int Calcular(int numero)
       {
            return 0;
       }
    }
}
