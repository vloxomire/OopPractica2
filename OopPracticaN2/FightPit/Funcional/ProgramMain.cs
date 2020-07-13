using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightPit.Funcional
{
    class ProgramMain
    {
        public static void Main()
        {
        Fighter fighter = new Fighter(100, 100);
        ArmoredFighter ArmFight = new ArmoredFighter(100);
        PitController pit = new PitController(fighter,ArmFight);
        }
        /*No se puede recibir en el main un objeto del tipo Fighter si lo maneja la clase controller*/
    }
}
