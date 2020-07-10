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
        public Recluta() : base()
        {
            Console.WriteLine("Constructor recluta");
            estaAsustado = false;
            grafico = 'R';
            Console.WriteLine("fuerza {0}", GetFuerza());
            fuerza =fuerza / 2;
            Console.WriteLine("Mod fuerza {0}",GetFuerza());
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
        new public int GetFuerza()
        {
            return fuerza;
        }
        public bool GetEstaAsustado()
        {
            return estaAsustado;
        }
        #endregion
        public void Miedo(Soldier [] arrayArmy) 
        {
            //Recorrer el array y ver los reclutas
            for (int i = 0; i < arrayArmy.Length; i++)
            {
                if (arrayArmy[i].GetGrafico()=='G')
                {
                    if (arrayArmy[i - 1].GetGrafico() == 'R' && i!=0)
                    {
                        Console.WriteLine("El recluta en la posicion {0}, no supera el chequeo del miedo",i-1);
                        Console.WriteLine("su fuerza merma a {0}", GetFuerza() / 2);
                        arrayArmy[i-1].SetFuerza(GetFuerza()/2);
                    }
                    if (arrayArmy[i + 1].GetGrafico() == 'R'&& i!=arrayArmy.Length)
                    {
                        Console.WriteLine("El recluta en la posicion {0}, no supera el chequeo del miedo", i + 1);
                        Console.WriteLine("su fuerza merma a {0}", GetFuerza() / 2);
                        arrayArmy[i + 1].SetFuerza(GetFuerza() / 2);
                    }
                    else 
                    {
                        Console.WriteLine("No hay reclutas en el ejercito");
                    }
                }
            }
        }
    }
}
