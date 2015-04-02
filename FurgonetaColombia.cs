using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hoja_6
{
    class FurgonetaColombia : Auto
    {
        public FurgonetaColombia()
        {
            nombre = "Furgoneta Colombia";
        }


        public override String darNombre()
        {
            return nombre;
        }
    }
}
