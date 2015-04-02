using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hoja_6
{
    class SedanAlemania: Auto
    {
        public SedanAlemania()
        {
            nombre = "Sedan Alemania";
        }


        public override String darNombre()
        {
            return nombre;
        }
    }
}
