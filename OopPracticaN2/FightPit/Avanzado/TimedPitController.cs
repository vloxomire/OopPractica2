using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightPit.Avanzado
{
    class TimedPitController:PitController
    {
        private int turnos;
        private Fighter f1;
        private Fighter f2;
        public TimedPitController(int turnos,Fighter f1,Fighter f2) : base(f1,f2) 
        {
            this.turnos = turnos;
            this.f1=f1;
            this.f2 = f2;
            Combate();
        }
        public bool FinTurnos(int turnos,int contador) 
        {
            if (turnos == contador)
            {
                Console.WriteLine("El combate excedio la cantidad de turnos");
                /*Seteo la vida de los player pasados por parametro
                 * en el const4ructor a  el booleano a muerto*/
                f1.SetVivo(false);
                f1.SetVivo(false);
                return true;
            }
            else 
            {
                Console.WriteLine("Turno {0}:",turnos);
                return false;
            }
        }
        public override void Combate()
        {
            int conta = GetContador();
            do
            {
                if (!FinTurnos(turnos, GetContador()))
                {
                    conta++;
                    SetContador(conta);
                    SecuenciaCombate(Iniciativa());
                    Console.ReadLine();
                }
            } while (f1.GetVivo() && f2.GetVivo());
        }
    }
}
