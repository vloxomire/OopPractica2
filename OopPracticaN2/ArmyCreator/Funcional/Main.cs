﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyCreator.Funcional
{
    class Pmain 
    {
        public static void Main()
        {
            /*Probar las funciones en el main*/
            Army army = new Army();
            army.AgregarSoldado();
            army.VerArmy();
            Console.ReadLine();
        }
    }
}
