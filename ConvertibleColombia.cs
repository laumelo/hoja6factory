using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hoja_6
{
    class ConvertibleColombia : Auto
    {
        public ConvertibleColombia()
        {
            nombre = "Convertible Colombia";
        }


        public override String darNombre()
        {
            return nombre;
        }
    }
}
