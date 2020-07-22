using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightPit.Funcional
{
    class ArmoredFighter:Fighter
    {
        public int Armor {get;set;}
        public bool ArmorRota {get;set;}
        public ArmoredFighter(int armor,int hp,int dmg) : base(hp,dmg) 
        {
            ArmorRota = false;
            Armor = armor;
            Nombre = "Armored";
        }
        public override void ReceiveDamage(int dmg)
        {
            QuitarArmor(dmg);
        }
        public void QuitarArmor(int dmg)
        {
            if (ArmorRota)
            {
                base.ReceiveDamage(dmg);
            }
            else 
            {
                Armor=Armor - dmg;
                if (Armor < 0)
                {
                    Console.WriteLine("Daño traspasado {0}", DañoTraspasado(dmg));
                    Hp=Hp+Armor;
                    Armor=0;
                    Console.WriteLine("Vida {0}",Hp);
                }
                else 
                {
                    Console.WriteLine("La armadura redujo el daño");
                    Console.WriteLine("Armadura restante {0}", Armor);
                }
            }
        }
        private int DañoTraspasado(int dmg)
        {
            int dmgSobrante = 0;
            dmgSobrante=Armor;
            ArmorRota = true;
            return dmgSobrante;
        }
    }
}
