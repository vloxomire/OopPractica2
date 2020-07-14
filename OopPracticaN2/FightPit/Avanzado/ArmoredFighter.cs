using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightPit.Avanzado
{
    class ArmoredFighter:Fighter
    {
        private int armor;
        bool armorRota;
        public ArmoredFighter(int armor,int hp,int dmg) : base(hp,dmg) 
        {
            this.armorRota = false;
            nombre = "ArmoredFighter";
            this.armor = armor;
            nombre = "Armored";
            MostrarVida();
        }
        public override void ReceiveDamage(int dmg)
        {
            QuitarArmor(dmg);
        
        }
        public void QuitarArmor(int dmg)
        {
            if (armorRota)
            {
                base.ReceiveDamage(dmg);
            }
            else 
            {
                SetArmor(GetArmor() - dmg);
                if (GetArmor() < 0)
                {
                    Console.WriteLine("Daño traspasado {0}", DañoTraspasado(dmg));
                    SetHp(GetHp()+GetArmor());
                    SetArmor(0);
                    Console.WriteLine("Vida {0}",GetHp());
                }
                else 
                {
                    Console.WriteLine("La armadura redujo el daño");
                    Console.WriteLine("Armadura restante {0}", GetArmor());
                }
            }
        }
        #region Getter&Setter
        public int GetArmor()
        {
            return armor;
        }
        public void SetArmor(int armor) 
        {
            this.armor = armor;
        }
        #endregion
        private int DañoTraspasado(int dmg)
        {
            int dmgSobrante = 0;
            dmgSobrante=GetArmor();
            armorRota = true;
            return dmgSobrante;
        }
        public override void MostrarVida()
        {
            base.MostrarVida();
            Console.WriteLine("Armadura\t{0}", GetArmor());
            Console.WriteLine("********************");
        }
    }
}
