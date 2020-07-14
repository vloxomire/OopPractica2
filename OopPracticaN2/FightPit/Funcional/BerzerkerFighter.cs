using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightPit.Funcional
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
            Console.WriteLine("ConstructorHijo Berzerker");
            this.modificador = modificador;
            this.porcentaje = porcentaje;
        }
        public override int GetDmg()
        {
            /*posibilidad de que el daño sea multiplicado por el modificador*/
            return ((int)probabilidad(GetPorcentaje(),GetModificador(),dmg));
        }
        private float probabilidad(float porcentaje,float modificador,int dmg) 
        {
            Console.WriteLine("F: probabilidad");
            Random random = new Random();
            float probabilidad=random.Next(1, 100);
            if (probabilidad < porcentaje) //30<75
            {
                Console.WriteLine("Le entro el critico");
                float dmgF = (float)dmg;
                dmgF = modificador * dmgF;
                return dmgF;
            }
            else 
            {
                return (float)dmg;
            }
        }
        #region Getter&Setter
        public float GetPorcentaje() { return porcentaje; }
        public float GetModificador() { return modificador; }
        public void SetPorcentaje(float porcentaje) { this.porcentaje = porcentaje; }
        public void Setmodificador(float modificador) { this.modificador = modificador; }
        #endregion
    }
}
