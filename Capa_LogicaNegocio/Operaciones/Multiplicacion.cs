using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_LogicaNegocio.Operaciones
{
    public class Multiplicacion:Operacion
    {
        public double Multiplique_Dos_Numeros(int val1, int val2)
        {
            Resultado = val1 * val2;
            return Resultado;
        }

    }
}
