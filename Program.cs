using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hoja_6
{
    class Program
    {
        static void Main(string[] args)
        {
            crearAuto(1);
        }

        public static void crearAuto(int tipo)
        {
            FabricaAutos fabrica = new FabricaAutosColombia();
            Auto miAuto = fabrica.factoryMethod(tipo);
            System.Console.WriteLine("tipo: " + miAuto.darNombre());
        }
    }
}
