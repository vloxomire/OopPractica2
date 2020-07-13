using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightPit.Basico
{
    class ProgramMain
    {
        public static void Main()
        {
        Fighter fighter1 = new Fighter(100, 100);
        Fighter fighter2 = new Fighter(100, 100);
        PitController pit = new PitController(fighter1,fighter2);
        }
        /*No se puede recibir en el main un objeto del tipo Fighter si lo maneja la clase controller*/
    }
}
