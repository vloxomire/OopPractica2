using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ArmyCreator.Avanzado
{
    class Army
    {
        private static int indice = 5;
        private Soldier[] arrayArmy;
        private int posicion;
        private Recluta recluta;
        public Army()
        {
            arrayArmy = new Soldier[indice];
            recluta = new Recluta();
        }
        public void Menu()
        {
            //Son opciones a elegir switch
            CreacionArmy();
            VerArmy();
            CalcularFuerza();
            ChequeoMiedo();
            VerArmy();
            CalcularFuerza();
        }
        public void CreacionArmy()
        {
            int valor = 0;
            Console.WriteLine("Su ejercito tiene {0} lugares", indice);
            do
            {
                Console.WriteLine("Asigne sus tropas");
                do
                {
                    Console.WriteLine("1-recluta/2-soldado/3-General");
                    valor = Convert.ToInt32(Console.ReadLine());
                } while (valor < 1 || valor > 3);
                Opciones(valor);
            } while (BuscarPosicion());
            Console.WriteLine("Ejercito Completo");
        }
        public void AgregarSoldado()
        {
            if (BuscarPosicion())
            {
                //No puedo sumar el valor del getposition +1
                arrayArmy[GetPosicion()] = new Soldier();
                Console.WriteLine("Asignado a la posicion {0}", GetPosicion());
            }
        }
        public void AgregarRecluta()
        {
            if (BuscarPosicion())
            {
                arrayArmy[GetPosicion()] = new Recluta();
                Console.WriteLine("Asignado a la posicion {0}", GetPosicion());
            }
        }
        public void AgregarGeneral()
        {
            if (BuscarPosicion())
            {
                arrayArmy[GetPosicion()] = new General();
                Console.WriteLine("Asignado a la posicion {0}", GetPosicion());
            }
        }
        private bool BuscarPosicion()
        {
            for (int i = 0; i < arrayArmy.Length; i++)
            {
                if (arrayArmy[i] == null)
                {
                    //getPosicion
                    SetPosicion(i);
                    //Console.WriteLine("Hay Lugar en la posicion {0}", i+1);
                    return true;
                }
            }
            return false;
        }
        public void SetPosicion(int posicion)
        {
            this.posicion = posicion;
        }
        public int GetPosicion()
        {
            return posicion;
        }
        public void CalcularFuerza()
        {
            int fuerzaArmy = 0;
            /*Devuelve la sumatoria de las fuerzas de todos los Soldiers en el army */
            for (int i = 0; i < arrayArmy.Length; i++)
            {
                fuerzaArmy += arrayArmy[i].GetFuerza();
            }
            Console.WriteLine("\nLa fuerza total del ejercito es {0}", fuerzaArmy);
        }
        public void VerArmy()
        {
            /*Muestra una fila de soldados, indicando para cada uno de forma
            vertical su gráfico, vida y fuerza)
            10 - 32 - 45
            S - S - S*/
            for (int i = 0; i < arrayArmy.Length; i++)
            {
                Console.Write(arrayArmy[i].GetFuerza());
                Console.Write("-");
            }
            Console.WriteLine();
            for (int i = 0; i < arrayArmy.Length; i++)
            {
                Console.Write(arrayArmy[i].GetGrafico());
                Console.Write("-");
            }
        }
        public void ChequeoMiedo()
        {
            //Se podra usar el objeto general o recluta para comparar?
            for (int i = 0; i < arrayArmy.Length; i++)
            {
                if (arrayArmy[i].GetGrafico() == 'G')
                {
                    if (arrayArmy[i + 1].GetGrafico() == 'R')
                    {
                        recluta.Miedo(true);
                    }
                    if (arrayArmy[i - 1].GetGrafico() == 'R')
                    {
                        recluta.Miedo(true);
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
        }
        public void Opciones(int valor)
        {
            switch (valor)
            {
                case 1:
                    AgregarRecluta();
                    Console.WriteLine("Se a agregado con exito el \"recluta\"");
                    break;
                case 2:
                    AgregarSoldado();
                    Console.WriteLine("Se a agregado con exito el \"soldado\"");
                    break;
                case 3:
                    AgregarGeneral();
                    Console.WriteLine("Se a agregado con exito el \"general\"");
                    break;
                default:
                    break;
            }
        }
    }
    class prueba
    {
        private General general;
        public prueba()
        {
            general = new General();
        }
        public void Demo()
        {
            Console.Write("sin modificador {0}", general.GetFuerza());
            Console.Write("con modificador {0}", general.GetFuerza()*20) ;
        }
    }
}