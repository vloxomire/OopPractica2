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
        public float Modificador { get; set; }
        public float Porcentaje { get; set; }

        public BerzerkerFighter(float modificador,float porcentaje,int hp,int dmg):base(hp,dmg) 
        {
            Modificador = modificador;
            Porcentaje = porcentaje;
            Nombre = "Berzerker";
        }
        public float Probabilidad(int dmg) 
        {
            Random random = new Random();
            float probabilidad=random.Next(1, 100);
            Console.WriteLine("probabilidad {0}, porcentaje{1}",probabilidad,Porcentaje);
            if (probabilidad < Porcentaje) //30<75
            {
                Console.WriteLine("Le entro el critico");
                float dmgF = (float)dmg;
                dmgF = Modificador * dmgF;
                Console.WriteLine("Critico {0}",dmgF);
                return dmgF;
            }
            else 
            {
                return (float)dmg;
            }
        }
    }
}
