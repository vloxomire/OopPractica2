using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightPit.Funcional
{
    class Fighter
    {
        protected int hp;
        protected int dmg;
        protected string nombre;
        protected Random random;
        public Fighter(int hp,int dmg) 
        {
            Console.WriteLine("Constructor Padre Fighter");
            //random = new Random();
            this.hp = 140;//random.Next(1,hp);
            this.dmg = 60;//random.Next(1,dmg);
            this.nombre = "Fighter";
            //MostrarVida();
        }
        #region Getter&Setter
        public int GetHp() {return hp;}
        virtual public int GetDmg() {return dmg;}
        public string GetNombre() { return nombre;}
        public void SetHp(int hp) {this.hp = hp;}
        public void SetDmg(int dmg) {this.dmg = dmg;}
        public void SetNombre(string nombre) {this.nombre=nombre; }
        #endregion
        public virtual void ReceiveDamage(int dmg) 
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
            Console.WriteLine("Le queda {0} de vida",vida);
        }
        public void Attack() 
        {
            //Devuelve el dmg generado
            Console.WriteLine(GetDmg());
            GetDmg();
        }
        virtual public void MostrarVida()
        {
            Console.WriteLine("Padre MostrarVida");
            Console.WriteLine("{0}:\nVida\t{1}\ndaño\t{2}"
                ,GetNombre(),GetHp(),GetDmg());
        }
    }
}
