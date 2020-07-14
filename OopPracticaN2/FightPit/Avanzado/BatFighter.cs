using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightPit.Avanzado
{
    class BatFighter:Fighter
    {
        public BatFighter(int hp,int dmg) :base(hp,dmg)
        {
            nombre = "Bat";
            this.dmg = dmg / 2;
            MostrarVida();
        }
        public void RobarVida() 
        {
            /*Su daño suele ser más bajo de lo normal pero cada 3 golpes recupera la vida que
            le saca al enemigo*/
        }
    }
}
