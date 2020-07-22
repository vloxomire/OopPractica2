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
        public int Hp { get { return hp; } set { hp = value; } }
        private int dmg;
        public int Dmg{get{return dmg;}set{dmg=value;}}
        private Random random;
        private string nombre;
        public string Nombre {get { return nombre; }set { nombre = value; }}
        private bool vivo;
        public bool Vivo {get{ return vivo; }set{ vivo = value; } }
        private int semilla=(int)DateTime.Now.Millisecond;//Semilla para random
        public Fighter(int hp,int dmg) 
        {
            nombre="Luchador";
            random = new Random(semilla);
            this.hp = random.Next(1,hp)+25;
            this.dmg = random.Next(1,dmg)+25;
            this.vivo = true;
        }
        public void ReceiveDamage(int dmg) 
        {
            int vida;
            //Recibe un entero que es el daño a aplicarse sobre la vida.
            Hp=Hp-dmg;
            if (Hp < 0)
            {
                vida = 0;
            }
            else 
            {
                vida = Hp;
            }
            Console.WriteLine("Vida restante {0}",vida);
        }
        public void Attack() 
        {
            //Devuelve el dmg generado
            Console.WriteLine(Dmg);
        }
    }
}
