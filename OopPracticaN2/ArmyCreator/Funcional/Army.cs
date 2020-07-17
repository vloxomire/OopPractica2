using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ArmyCreator.Funcional
{
    class Army
    {
        private Soldier[] arrayArmy = new Soldier[5];
        private int posicion;
        public Army()
        {
            //inicializar army"funcion"
            IniciarArmy();
        }
        private void IniciarArmy()
        {
            int cont = 0;
            do
            {
                AgregarSoldado();
                cont++;
            } while (cont != arrayArmy.Length);
            CalcularFuerza();
        }
        public void AgregarSoldado()
        {
            if (BuscarPosicion())
            {
                arrayArmy[GetPosicion()] = new Soldier("saludo");
            }

            /*Ingresa un nuevo soldado a la primera posición disponible 
             encontrada. De no haber ninguna, no es posible ingresarlo*/
            /*1)Buscar en el array una posicion disponible,
             * 2)si no hay ninguna no se puede ingresar*/
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
            Console.WriteLine("\nNo hay lugar en el ejercito");
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
            Console.WriteLine("La fuerza total del ejercito es {0}", fuerzaArmy);
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
            Console.WriteLine();
            for (int i = 0; i < arrayArmy.Length; i++)
            {
                Console.Write(arrayArmy[i].GetSaludo());
                Console.Write("-");
            }
        }
    }
}
