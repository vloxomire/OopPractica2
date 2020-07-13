using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightPit.Funcional
{
    class ArmoredFighter:Fighter
    {
        private int armor;
        bool armorRota;
        public ArmoredFighter(int armor) 
        {
            this.armor = armor;
        }
        public ArmoredFighter(int armor) : base(100,100) 
        {
            this.armorRota = false;
            nombre = "ArmoredFighter";
        }
        public override void ReceiveDamage(int dmg)
        {
            QuitarArmor(dmg);
        
        }
        public void QuitarArmor(int dmg)
        {
            Console.WriteLine("Quitar Armor");
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
            Console.WriteLine("DañoTraspasado");
            dmgSobrante=GetArmor();
            armorRota = true;
            return dmgSobrante;
        }
        public override void MostrarVida()
        {
            Console.WriteLine("{0}:\nVida\t{1}\ndaño\t{2}\nArmadura\t{3}"
                , GetNombre(), GetHp(), GetDmg(),GetArmor());
        }
    }
}
