using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyCreator.Avanzado
{
    class General:Soldier
    {
        public General() : base()
        {

            Console.WriteLine("Constructor General");
            grafico = 'G';
            Console.WriteLine("fuerza {0}", GetFuerza());
            fuerza = fuerza * 2;
            Console.WriteLine("Mod fuerza {0}", GetFuerza());
        }
        new public void MostrarSaludo() 
        {
            base.MostrarSaludo();
            Insultar();
        }
        public void Insultar() 
        {
            //Console.WriteLine("Insulta");
        }
        #region Getter&Setter
        new public void SetFuerza(int fuerza) 
        {
            this.fuerza = fuerza;
        }
        new public int GetFuerza() 
        {
            return fuerza;
        }
        #endregion
    }
}
