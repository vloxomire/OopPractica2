using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyCreator.Avanzado
{
    class Recluta:Soldier
    {
        private bool estaAsustado;
        public Recluta() 
        {
            estaAsustado = false;
            grafico = 'R';
            fuerza = random.Next(2, 10)/2;
        }
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

        public void Miedo(bool estaAsutado) 
        {
            if (!estaAsustado)
            {
                SetEstaAsustado(estaAsustado);
                SetFuerza(GetFuerza() / 2);
                Console.WriteLine("El \"Miedo\" reduce la fuerza {0} del recluta", GetFuerza());
            }
            else 
            {

            }
        }
    }
}
