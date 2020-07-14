using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightPit.Avanzado
{
    class BeastFighter:Fighter
    {
        private bool bestia;
        private int convertirse;
        public BeastFighter(int hp,int dmg):base(hp,dmg) 
        {
            nombre = "Beast";
            bestia = false;
            convertirse = 60;
            MostrarVida();
        }
        public void Transformarse(bool bestia,int convertirse) 
        {
            /*Tiene una chance, configurada mediante su constructor, de que al ser atacado se
            transforma en bestia y a partir de ahora su daño sea x2*/
        }
    }
}
