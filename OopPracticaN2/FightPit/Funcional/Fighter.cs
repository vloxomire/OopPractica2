using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace FightPit.Funcional
{
    class Fighter
    {
        public int Hp { get; set; }
        public int Dmg { get; set; }
        public string Nombre { get; set; }
        public bool Vivo { get; set; }

        private int semilla = (int)DateTime.Now.Millisecond;//Semilla para random
        protected Random random;
        public Fighter(int hp,int dmg) 
        {
            random = new Random(semilla);
            Hp = random.Next(1,hp)+140;
            Dmg = random.Next(1,dmg)+60;
            Nombre = "Fighter";
            Vivo = true;
        }
        public virtual void ReceiveDamage(int dmg) 
        {
            int vida;
            //Recibe un entero que es el daño a aplicarse sobre la vida.
            Hp = Hp - dmg;
            if (Hp < 0)
            {
                vida = 0;
            }
            else
            {
                vida = Hp;
            }
            Console.WriteLine("Vida restante {0}", vida);
        }
        virtual public int Atacar() 
        {
            //Devuelve el dmg generado
            return Dmg;
        }
    }
}
