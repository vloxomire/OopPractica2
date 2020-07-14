using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightPit.Avanzado
{
    class BerzerkerFighter:Fighter
    {
        /*Mediante un modificador (float) y un porcentaje (float) pasados por parámetro, a
          la hora de calcular el daño a realizar existe dicha posibilidad de que el daño sea
          multiplicado por el modificador*/
        private float modificador;
        private float porcentaje;
        public BerzerkerFighter(float modificador,float porcentaje,int hp,int dmg):base(hp,dmg) 
        {
            this.modificador = modificador;
            this.porcentaje = porcentaje;
            nombre = "Berzerker";
            MostrarVida();
        }
        public override int GetDmg()
        {
            /*posibilidad de que el daño sea multiplicado por el modificador*/
            return dmg;
        }
        public float probabilidad(int dmg) 
        {
            Random random = new Random();
            float probabilidad=random.Next(1, 100);
            Console.WriteLine("probabilidad {0}, porcentaje{1}",probabilidad,GetPorcentaje());
            if (probabilidad < porcentaje) //30<75
            {
                Console.WriteLine("Le entro el critico");
                float dmgF = (float)dmg;
                dmgF = modificador * dmgF;
                Console.WriteLine("Critico {0}",dmgF);
                return dmgF;
            }
            else 
            {
                return (float)dmg;
            }
        }
        public override void MostrarVida()
        {
            base.MostrarVida();
            Console.WriteLine("probabilidad de critico:\t{0}",GetPorcentaje());
            Console.WriteLine("Critico:\t{0}", GetModificador());
            Console.WriteLine("********************");
        }
        public override int Atacar() 
        {
            return (int)probabilidad(GetDmg());
        }

        #region Getter&Setter
        public float GetPorcentaje() { return porcentaje; }
        public float GetModificador() { return modificador; }
        public void SetPorcentaje(float porcentaje) { this.porcentaje = porcentaje; }
        public void Setmodificador(float modificador) { this.modificador = modificador; }
        #endregion
    }
}
