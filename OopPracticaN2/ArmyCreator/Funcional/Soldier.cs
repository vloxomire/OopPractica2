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
        private string saludo;
        public Soldier(string saludo)
        {
            grafico = 'S';
            fuerza = 1;
            this.saludo = saludo;
        }
        public void VerSoldado()
        {
            GetFuerza(); GetGrafico();
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
        public string GetSaludo()
        {
            return saludo;
        }
        public void MostrarSaludo()
        {
            Console.WriteLine(GetSaludo());
        }
    }
}
