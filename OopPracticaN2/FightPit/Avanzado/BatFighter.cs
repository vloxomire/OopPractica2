using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightPit.Avanzado
{
    class BatFighter:Fighter
    {
        private int dañoTotal;
        private int contador;
        public BatFighter(int hp,int dmg) :base(hp,dmg)
        {
            nombre = "Bat";
            this.dmg = dmg / 2;
            this.dañoTotal = 0;
            this.contador = contador;
            MostrarVida();
        }
        public void RobarVida(bool robar) 
        {
            /*Su daño suele ser más bajo de lo normal pero cada 3 golpes recupera la vida que
            le saca al enemigo*/
            if (robar)
            {
                SetHp(GetHp()+GetDañoTotal());
                Console.WriteLine("{0} robo {1}",GetNombre(),GetDañoTotal());
                SetDañoTotal(0);
                SetContador(0);
            }
        }
        public bool ContadorCombate(int contador) 
        {
            bool robar = false;
            if (contador == 3)
            {
                robar = true;
                return robar;
            }
            else 
            {
                return robar;
            }
        }
        public override int Atacar()
        {
            contador++;
            SetDañoTotal(GetDañoTotal()+base.Atacar());
            RobarVida(ContadorCombate(GetContador()));//Se rompe
            return base.Atacar();
        }
        public void SetDañoTotal(int dañoTotal) 
        {
            this.dañoTotal = dañoTotal;
        }
        public int GetDañoTotal() 
        {
            return dañoTotal;
        }
        public void SetContador(int contador)
        {
            this.contador = contador;
        }
        public int GetContador() 
        {
            return contador;
        }
    }
}
