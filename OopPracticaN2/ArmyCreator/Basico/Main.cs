using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyCreator.Basico
{
    class Pmain 
    {
        public static void Main()
        {
            /*Probar las funciones en el main*/
            Console.WriteLine("De que tamaño  va a ser su ejercito");
            int indice = Convert.ToInt32(Console.ReadLine());
            Army army = new Army(indice);
            Console.ReadLine();
        }
    }
}
