using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyCreator.Avanzado
{
    class Recluta:Soldier
    {
        private bool estaAsustado;
        public Recluta(string saludo) : base(saludo)
        {
            Console.WriteLine("Constructor recluta");
            estaAsustado = false;
            grafico = 'R';
            //Console.WriteLine("fuerza {0}", GetFuerza());
            fuerza =fuerza / 2;
            //Console.WriteLine("Mod fuerza {0}",GetFuerza());
            Console.WriteLine(GetFuerza());
        }
        #region Getter&Setter
        public void SetEstaAsustado(bool asustado)
        {
            this.estaAsustado = asustado;
        }
        new public void SetFuerza(int fuerza)
        {
            this.fuerza = fuerza;
        }
        public override int GetFuerza()
        {
            if (GetEstaAsustado())
            {
                return fuerza / 2;
            }
            else 
            {
                return fuerza;
            }
            
        }
        public bool GetEstaAsustado()
        {
            return estaAsustado;
        }
        #endregion
    }
}
