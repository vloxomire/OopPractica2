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
        private Fighter p1;
        private Fighter p2;
        public PitController(Fighter fighter1, Fighter fighter2)
        {
            int contador = 1;
            this.p1 = fighter1;
            this.p2 = fighter2;
            random = new Random();
            do
            {
                Console.WriteLine("Ronda {0}", contador);
                MostrarVida(fighter1); MostrarVida(fighter2);
                SecuenciaCombate(Iniciativa(),p1,p2);
                contador++;
                Console.ReadLine();
            }while(p1.Vivo && p2.Vivo);
        }
        private void SelectFighter()
        {
            Console.WriteLine("Fighters:");
            Console.WriteLine("1:fighter/2:Armored fighter/3:Berserker fighter");
        }
        private int Iniciativa()
        {
            Console.WriteLine("Inicio del combate");
            int player1 = random.Next(1, 10);
            Console.WriteLine("{0}1 ini {1}", p1.Nombre, player1);
            int player2 = random.Next(1, 10);
            Console.WriteLine("{0}2 ini {1}", p2.Nombre, player2);
            Console.WriteLine("***********");

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
        private void SecuenciaCombate(int valor,Fighter f1, Fighter f2)
        {
            switch (valor)
            {
                case 0:
                    Empate(f1,f2);
                    break;
                case 1:
                    Ataca(f1,f2);
                    EstaVivo(p2);
                    if (!p2.Vivo)
                    {
                        return;
                    }
                    Ataca(f2,f1);
                    EstaVivo(p1);
                    if (!p1.Vivo)
                    {
                        return;
                    }
                    break;
                case 2:
                    Ataca(f2,f1);
                    EstaVivo(p1);
                    if (!p1.Vivo)
                    {
                        return;
                    }
                    Ataca(f1,f2);
                    EstaVivo(p2);
                    if (!p2.Vivo)
                    {
                        return;
                    }
                    break;
                default:
                    break;
            }
        }
        private void Ataca(Fighter f1,Fighter f2)
        {
            //BerzerkerFighter b = new BerzerkerFighter(3.5f, 60.8f, 100, 50);
            //if (f==b)
            Console.WriteLine("{0} ataca", f1.Nombre);
            //if (f1.Nombre == "Berzerker")
            if(f1 is BerzerkerFighter)
            {
                ((BerzerkerFighter)f1).Probabilidad(f1.Dmg);
            }
            Console.WriteLine("{0} recibe {1} de daño", f2.Nombre, f1.Dmg);
            f2.ReceiveDamage(f1.Dmg);
        }
        private void Empate(Fighter f1,Fighter f2)
        {
            Console.WriteLine("Empate:");
            Ataca(f1,f2); Ataca(f2,f1);
            //Chequeo si alguno quedo vivo
            Console.WriteLine("Player 1:");
            EstaVivo(f1);
            Console.WriteLine("Player 2:");
            EstaVivo(f2);
        }
        private void EstaVivo(Fighter f)
        {
            if (f.Hp > 0)
            {
                return;
            }
            f.Vivo = false;
            Console.WriteLine("{0} a muerto", f.Nombre);
        }
        private void MostrarVida(Fighter f)
        {
            //Puede que con un solo objeto ya modifique todo
            Console.WriteLine("Player:\n{0}", f.Nombre);
            Console.WriteLine("Vida:{0}\nDaño:{1}", f.Hp, f.Dmg);

            string nombre=f.Nombre;
            switch (nombre)
            {
                case "Berzerker":
                    Console.WriteLine("probabilidad de critico:\t{0}", ((BerzerkerFighter)f).Porcentaje);
                    Console.WriteLine("Critico:\t{0}", ((BerzerkerFighter)f).Modificador);
                    Console.WriteLine("********************");
                    break;
                case "Armored":
                    Console.WriteLine("Armadura\t{0}", ((ArmoredFighter)f).Armor);
                    Console.WriteLine("********************");
                    break;
                default:
                    Console.WriteLine("********************");
                    break;
            }
        }
    }
}
