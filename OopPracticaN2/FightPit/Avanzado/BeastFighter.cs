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
            convertirse = 70;
            MostrarVida();
        }
        public void Transformarse(int convertirse) 
        {
            /*Tiene una chance, configurada mediante su constructor, de que al ser atacado se
            transforma en bestia y a partir de ahora su daño sea x2*/
            if (convertirse < this.convertirse)
            {
                Console.WriteLine("Beast, se ha transformado!!!");
                SetBestia(true);
                SetHp(100);
                SetDmg(GetDmg() * 2);
            }
            else 
            {

            }
        }
        public override void ReceiveDamage(int dmg)
        {
            base.ReceiveDamage(dmg);
            if (!bestia)
            {
                Random random = new Random();
                Transformarse(random.Next(1, 100));
            }
            else 
            {

            }
        }
        public void SetBestia(bool bestia) 
        {
            this.bestia = bestia;
        }
        public bool GetBestia() 
        {
            return bestia;
        }
    }
}
