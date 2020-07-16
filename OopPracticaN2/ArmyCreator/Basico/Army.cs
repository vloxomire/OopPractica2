using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ArmyCreator.Basico
{
    class Army
    {
        private Soldier[] arrayArmy;
        private int posicion;
        public Army(int indice)
        {
            //inicializar army"funcion"
            arrayArmy = new Soldier[indice];
            IniciarArmy();
        }
        private void IniciarArmy()
        {
            Menu();
        }
        public void AgregarSoldado()
        {
            if (BuscarPosicion())
            {
                arrayArmy[GetPosicion()] = new Soldier();
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
                    SetPosicion( i);
                    Console.WriteLine("Hay Lugar en la posicion {0}", i+1);
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
        public int CalcularFuerza()
        {
            /*Devuelve la sumatoria de las fuerzas de todos los Soldiers en el army */
            int posicion = 0;
            int fuerzaTotal=0;
            for (int i = 0; i < arrayArmy.Length; i++)
            {
                if (arrayArmy[i] == null)
                {
                    posicion = i;
                    break;
                }
            }
            for (int j = 0; j < posicion-1; j++)
            {
                
                fuerzaTotal=+arrayArmy[j].GetFuerza();
            }
            return fuerzaTotal;
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
        public void Menu() 
        {
            int menu;
            do
            {
                Console.WriteLine("opciones:\n1-Agregar soldado.\n2-Ver fuerza\n3-salir");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        AgregarSoldado();
                        break;
                    case 2:
                        CalcularFuerza();
                        Console.WriteLine("La fuerza total del ejercito es {0}",CalcularFuerza());
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("No se a elegido ninguna de las opciones disponibles");
                        break;
                }
            } while (menu>0 && menu <4);
        }
    }
}
