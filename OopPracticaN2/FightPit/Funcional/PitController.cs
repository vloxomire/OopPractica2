using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightPit.Funcional
{
    class PitController
    {
        private Random random;
        private bool vivo;
        private Fighter p1;
        private Fighter p2;
        public PitController(Fighter fighter1,Fighter fighter2) 
        {
            this.p1 = fighter1;
            this.p2 = fighter2;
            random = new Random();
            vivo = true;
            do 
            {
                AtacarPrimero(Iniciativa());
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
                return 1;
            }
            else if (player1 == player2) 
            {
                return 0;
            }
            else
            {
                return 2;
            }
        }
        public void AtacarPrimero(int valor) 
        {
            Console.WriteLine("AtacarPrimero");
            switch (valor)
            {
                case 0:
                    Console.WriteLine("Empate:");
                    Console.WriteLine("P1 recibe {0} de daño",p2.GetDmg());
                    p1.ReceiveDamage(p2.GetDmg());
                    Console.WriteLine("P2 recibe {0} de daño", p1.GetDmg());
                    p2.ReceiveDamage(p1.GetDmg());
                    break;
                case 1:
                    //P1Ataca
                    Console.WriteLine("Player1 ataca primero");
                    Console.WriteLine("P2 recibe {0} de daño", p1.GetDmg());
                    p2.ReceiveDamage(p1.GetDmg());
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
                    Console.WriteLine("Player2 ataca primero");
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
        //Cambie el MostrarVida() a las clases hijas dde fighter para que me muestren la armadura
    }
}
