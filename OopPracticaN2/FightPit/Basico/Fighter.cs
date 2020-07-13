using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightPit.Basico
{
    class Fighter
    {
        private int hp;
        private int dmg;
        private Random random;
        public Fighter(int hp,int dmg) 
        {
            Console.WriteLine("Constructor Fighter");
            random = new Random();
            this.hp = random.Next(1,hp);
            Console.WriteLine("Hp {0}", GetHp()) ;
            this.dmg = random.Next(1,dmg);
            Console.WriteLine("Dmg {0}",GetDmg());
        }
        #region Getter&Setter
        public int GetHp() {return hp;}
        public int GetDmg() {return dmg;}
        public void SetHp(int hp) {this.hp = hp;}
        public void SetDmg(int dmg) {this.dmg = dmg;}
        #endregion
        public void ReceiveDamage(int dmg) 
        {
            int vida;
            //Recibe un entero que es el daño a aplicarse sobre la vida.
            SetHp(GetHp()-dmg);
            if (GetHp() < 0)
            {
                vida = 0;
            }
            else 
            {
                vida = GetHp();
            }
            Console.WriteLine("Vida restante {0}",vida);
        }
        public void Attack() 
        {
            //Devuelve el dmg generado
            Console.WriteLine(GetDmg());
            GetDmg();
        }
    }
}
