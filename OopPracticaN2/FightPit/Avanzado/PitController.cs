using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightPit.Avanzado
{
    class PitController
    {
        private Random random;
        private bool vivo;
        private Fighter p1;
        private Fighter p2;
        private BerzerkerFighter Bf;
        public PitController(Fighter fighter1,Fighter fighter2) 
        {
            this.p1 = fighter1;
            this.p2 = fighter2;
            random = new Random();
            vivo = true;
            do 
            {
                SecuenciaCombate(Iniciativa());
                Console.ReadLine();
            } while (vivo);
        }
        public void SelectFighter() 
        {
            Console.WriteLine("Fighters:");
            Console.WriteLine("1:fighter/2:Armored fighter/3:Berserker fighter");
            //int valor=Convert.ToInt32(valor);
            /*switch () 
            {

            } */
        }
        public int Iniciativa() 
        {
            Console.WriteLine("Iniciativa");
            int player1 = 10;//random.Next(1, 10);
            Console.WriteLine("p1 ini {0}",player1);
            int player2 = 2;//random.Next(1, 10);
            Console.WriteLine("p2 ini {0}", player2);

            if (player1 > player2)
            {
                Console.WriteLine("{0} ataca primero", p1.GetNombre());
                return 1;
            }
            else if (player1 == player2) 
            {
                Console.WriteLine("Empate:");
                return 0;
            }
            else
            {
                Console.WriteLine("Player2 ataca primero");
                return 2;
            }
        }
        public void SecuenciaCombate(int valor) 
        {
            Console.WriteLine("Combate");
            switch (valor)
            {
                case 0:
                    Empate();
                    break;
                case 1:
                    AtacarP1();
                    
                    //vivo
                    if (p2.GetHp() <= 0)
                    {
                        vivo = false;
                        Console.WriteLine("A muerto el player 2");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("P1 recibe {0} de daño", p2.GetDmg());
                        p1.ReceiveDamage(p2.GetDmg());
                        if (p1.GetHp() <= 0)
                        {
                            vivo = false;
                            Console.WriteLine("A muerto el player 1");
                            break;
                        }
                        else { }
                    }
                    break;
                case 2:
                    //P2Ataca
                    
                    Console.WriteLine("P1 recibe {0} de daño", p2.GetDmg());
                    p1.ReceiveDamage(p2.GetDmg());
                    //vivo
                    if (p1.GetHp() <= 0)
                    {
                        vivo = false;
                        Console.WriteLine("A muerto el player 1");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("P2 recibe {0} de daño", p1.GetDmg());
                        p2.ReceiveDamage(p1.GetDmg());
                        if (p2.GetHp() <= 0)
                        {
                            vivo = false;
                            Console.WriteLine("A muerto el player 1");
                            break;
                        }
                        else { }
                    }
                    break;
                default:
                    break;
            }
        }
        public void AtacarP1()
        {
            int danio = p1.Atacar();
            Console.WriteLine("{0} recibe {1} de daño", p2.GetNombre(),danio);
            p2.ReceiveDamage(danio);
            EstaVivo(p2);
        }
        private void Empate() 
        {
            Console.WriteLine("P1 recibe {0} de daño", p2.GetDmg());
            p1.ReceiveDamage(p2.GetDmg());
            Console.WriteLine("P2 recibe {0} de daño", p1.GetDmg());
            p2.ReceiveDamage(p1.GetDmg());
            EstaVivo(p1);EstaVivo(p2);
        }
        private void EstaVivo(Fighter f) 
        {
            if (f.GetVivo())
            {
                Console.WriteLine("{0} esta vivo",f.GetNombre());
            }
            else 
            {
                Console.WriteLine("{0} esta muerto", f.GetNombre());
            }
        }
    }
}
