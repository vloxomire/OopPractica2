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
            //Fighter fighter = new Fighter(100, 100);
           // BerzerkerFighter fighter1 = new BerzerkerFighter(12.5f,50.8f,100,50);
        ArmoredFighter fighter2 = new ArmoredFighter(100,100,100);
            //PitController pit = new PitController(fighter1,fighter2);
            Console.ReadLine();
        }
        /*No se puede recibir en el main un objeto del tipo Fighter si lo maneja la clase controller*/
    }
}
