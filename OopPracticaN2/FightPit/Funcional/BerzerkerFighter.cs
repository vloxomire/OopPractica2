using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightPit.Funcional
{
    class BerzerkerFighter:Fighter
    {
        public BerzerkerFighter(float modificador,float porcentaje):base(100,100) 
        {

        }
        public override void ReceiveDamage(int dmg)
        {
            base.ReceiveDamage(dmg);
        }
    }
}
