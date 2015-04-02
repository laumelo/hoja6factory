using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hoja_6
{
    class ConvertibleAlemania : Auto
    {
        public ConvertibleAlemania()
        {
            nombre = "Convertible Alemania";
        }


        public override String darNombre()
        {
            return nombre;
        }
    }
}
