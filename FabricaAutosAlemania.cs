using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hoja_6
{
    class FabricaAutosAlemania : FabricaAutos
    {
        public override Auto factoryMethod(int tipo)
        {
            Auto miAuto;
            if (tipo == 1) miAuto = new SedanAlemania();
            else if (tipo == 2) miAuto = new TodoterrenoAlemania();
            else if (tipo == 3) miAuto = new ConvertibleAlemania();
            else if (tipo == 4) miAuto = new FurgonetaAlemania();
            else miAuto = null;
            return miAuto;
        }

    }
}
