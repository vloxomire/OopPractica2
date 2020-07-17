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
        protected string saludo;
        public Soldier(string saludo) 
        {
            Console.WriteLine("Constructor clase Padre");//Referencia
            random = new Random();
            MostrarSaludo();
            grafico = 'S';
            fuerza = random.Next(50,100);
            this.saludo=saludo;
        }
        public void VerSoldado()
        {
            GetFuerza(); GetGrafico(); MostrarSaludo();
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
        public virtual int GetFuerza()
        {
            return fuerza;
        }
        public virtual void MostrarSaludo()
        {
            //Console.WriteLine("El soladado saluda");
            Console.WriteLine("saludo");
        }
    }
}
