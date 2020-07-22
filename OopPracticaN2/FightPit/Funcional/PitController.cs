﻿using System;
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
                MostrarVida(fighter1, fighter2);
                SecuenciaCombate(Iniciativa());
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
        private void SecuenciaCombate(int valor)
        {
            switch (valor)
            {
                case 0:
                    Empate();
                    break;
                case 1:
                    P1Ataca();
                    EstaVivo(p2);
                    if (!p2.Vivo)
                    {
                        return;
                    }
                    P2Ataca();
                    EstaVivo(p1);
                    break;
                case 2:
                    P2Ataca();
                    EstaVivo(p1);
                    if (!p1.Vivo)
                    {
                        return;
                    }
                    P1Ataca();
                    EstaVivo(p2);
                    break;
                default:
                    break;
            }
        }
        private void P1Ataca()
        {
            Console.WriteLine("{0}1 ataca", p1.Nombre);
            Console.WriteLine("{0}2 recibe {1} de daño", p2.Nombre, p1.Dmg);
            p2.ReceiveDamage(p1.Dmg);
        }
        private void P2Ataca()
        {
            Console.WriteLine("{0}2 ataca", p2.Nombre);
            Console.WriteLine("{0}1 recibe {1} de daño", p1.Nombre, p2.Dmg);
            p1.ReceiveDamage(p2.Dmg);
        }
        private void Empate()
        {
            Console.WriteLine("Empate:");
            P1Ataca();
            P2Ataca();
            //Chequeo si alguno quedo vivo
            Console.WriteLine("Player 1:");
            EstaVivo(p1);
            Console.WriteLine("Player 2:");
            EstaVivo(p2);
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
        private void MostrarVida(Fighter f1, Fighter f2)
        {
            //Puede que con un solo objeto ya modifique todo
            Console.WriteLine("Player1:\n{0}", f1.Nombre);
            Console.WriteLine("Vida:{0}\nDaño:{1}", f1.Hp, f1.Dmg);
            Console.WriteLine("**************");
            Console.WriteLine("Player2:\n{0}", f2.Nombre);
            Console.WriteLine("Vida:{0}\nDaño:{1}", f2.Hp, f2.Dmg);
            Console.WriteLine("**************");

            switch (f1.Nombre)
            {
                case "Berserker":
                    BerzerkerFighter c1 = (BerzerkerFighter)f1;
                    Console.WriteLine("probabilidad de critico:\t{0}", f1.Porcetaje);
                    Console.WriteLine("Critico:\t{0}", (BerzerkerFighter)f1.Modificador);
                    Console.WriteLine("********************");
                    break;
                case "Fighter":
                    break;
                case "Armored":
                    Console.WriteLine("Armadura\t{0}", (ArmoredFighter)f1.Armor);
                    Console.WriteLine("********************");
                    break;
                default:
                    break;
            }
        }
    }
}
