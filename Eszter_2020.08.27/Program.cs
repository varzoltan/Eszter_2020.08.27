using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._08._27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Készítsünk programot, amely bekér a felhasználótól két számot. A program döntse el, 
            //hogy az elsőként bekért számnak osztója-e a másodikként bekért szám. 
            //Amennyiben igen, írja ki az osztás eredményét is.(egyszerű)
            Console.Write("Kérem adjon meg egy egész számot! ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("Kérem adjon meg egy másik egész számot! ");
            int szam2 = int.Parse(Console.ReadLine());
            if (szam1 > szam2)
            {
                if (szam1 % szam2 == 0)
                {
                    int eredmeny = szam1 / szam2;
                    Console.WriteLine($"Az osztás eredménye: {eredmeny}");
                }
                else
                {
                    Console.WriteLine($"A {szam1} nem osztója {szam2}-nek. ");
                }
            }
            else
            {
                if (szam2 % szam1 == 0)
                {
                    int eredmeny = szam2 / szam1;
                    Console.WriteLine($"Az osztás eredménye: {eredmeny}");
                }
                else
                {
                    Console.WriteLine($"A {szam2} nem osztója {szam1}-nek. ");
                }
            }

            //16. Összetett feladat!
            //Készítsünk programot, mely a következő feladatokat végzi el:
            //-Feltölt egy N elemű tömböt egy és száz közé eső véletlen számokkal.
            //A tömb méretét a felhasználó határozza meg!
            Console.Write("Kérem adja meg a tömb hosszát! ");
            int hossz = int.Parse(Console.ReadLine());
            int[] tomb1 = new int[hossz];
            //Feltöltjük  a tömböt - 1-100 közé esú véletlen számokkal
            Random veletlen = new Random();//Inicializáltuk a Random osztály
            for (int i = 0;i<hossz;i++)
            {
                tomb1[i] = veletlen.Next(1, 101);
            }

            //-Feltöltés után a tömb elemeit a program írja ki a képernyőre!
            Console.ReadKey();
        }
    }
}
