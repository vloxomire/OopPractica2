using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyCreator.Avanzado
{
    class General:Soldier
    {
        public General() 
        {
            grafico = 'G';
            fuerza = random.Next(1,10);
        }
        new public void MostrarSaludo() 
        {
            base.MostrarSaludo();
            Insultar();
        }
        public void Insultar() 
        {
            Console.WriteLine("Insulta");
        }
        new public void SetFuerza(int fuerza) 
        {
            this.fuerza = fuerza;
        }
        new public int GetFuerza() 
        {
            return fuerza;
        }
    }
}
