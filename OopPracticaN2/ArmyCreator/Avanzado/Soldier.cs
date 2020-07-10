using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyCreator.Avanzado
{
    class Soldier
    {
        protected char grafico;
        protected int fuerza;
        protected Random random;
        public Soldier() 
        {
            Console.WriteLine("Constructor clase Padre");//Referencia
            random = new Random();
            MostrarSaludo();
            grafico = 'S';
            fuerza = random.Next(1,10);
        }
        public void VerSoldado() 
        {
            GetFuerza();GetGrafico();
        }
        public void SetGrafico(char grafico)
        {
            this.grafico = grafico;
        }
        public void SetFuerza(int fuerza)
        {
            this.fuerza = fuerza;
        }
        public char GetGrafico()
        {
            return grafico;
        }
        public int GetFuerza()
        {
            return fuerza;
        }
        public void MostrarSaludo()
        {
            //Console.WriteLine("El soladado saluda");
        }
    }
}
