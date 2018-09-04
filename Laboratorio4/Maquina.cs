using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    abstract class Maquina : ICalcular
    {
        protected string etiqueta;

        protected Maquina(string etiqueta)
        {
            this.etiqueta = etiqueta;
        }

        public virtual int Calcular(int numero)
        {
            return 0;
        }
    }
}
