using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hoja_6
{
    class FabricaAutosColombia : FabricaAutos
    {
        public override Auto factoryMethod(int tipo)
        {
            Auto miAuto;
            if (tipo == 1) miAuto = new SedanColombia();
            else if (tipo == 2) miAuto = new ConvertibleColombia();
            else if (tipo == 3) miAuto = new FurgonetaColombia();
            else if (tipo == 4) miAuto = new TodoterrenoColombia();
            else miAuto = null;
            return miAuto;
        }
    }
}
