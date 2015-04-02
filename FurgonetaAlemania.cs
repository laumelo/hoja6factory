using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hoja_6
{
    class FurgonetaAlemania : Auto
    {
        public FurgonetaAlemania()
        {
            nombre = "Furgoneta Alemania";
        }


        public override String darNombre()
        {
            return nombre;
        }
    }
}
