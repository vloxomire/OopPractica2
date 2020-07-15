using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightPit.Avanzado
{
    class ProgramMain
    {
        public static void Main()
        {
           Fighter fighter = new Fighter(200, 100);
            //BerzerkerFighter fighter1 = new BerzerkerFighter(2.5f,50.8f,100,50);
            //ArmoredFighter fighter2 = new ArmoredFighter(100,100,100);
            //BeastFighter beast = new BeastFighter(100,100);
            BatFighter bat = new BatFighter(350, 100);
            PitController pit = new PitController(fighter,bat);
            Console.ReadLine();
        }
        /*No se puede recibir en el main un objeto del tipo Fighter si lo maneja la clase controller*/
    }
}
