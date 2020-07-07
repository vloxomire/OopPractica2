using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyCreator.Funcional
{
    class Soldier
    {
        private char grafico;
        private int fuerza;
        public Soldier() 
        {
            MostrarSaludo();
            grafico = 'S';
            fuerza = 1;
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
            Console.WriteLine("El soladado saluda");
        }
    }
}
