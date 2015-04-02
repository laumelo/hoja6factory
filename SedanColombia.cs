using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hoja_6
{
    class SedanColombia : Auto
    {
        public SedanColombia()
        {
            nombre = "Sedan Colombia";
        }


        public override String darNombre()
        {
            return nombre;
        }
    }
}
