using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnc = new Random();
            int[,] rybyArr = new int[100, 100];

            for (int row = 0; row < 100; row++)
            {
                for(int column = 0; column < 100; column++)
                {
                    int nahoda = rnc.Next(0,1000);
                    rybyArr[row, column] = nahoda;
                    
                }
            }

            int randomColumnCheck = rnc.Next(0, 100);
            int randomRowCheck = rnc.Next(0, 100);
            Console.WriteLine($"Vygenerováno náhodné pole 10x10 m. Celkem se v něm nacházelo {rybyArr[randomRowCheck, randomColumnCheck]} ryb.");

            int vysledek = 0;
            int kdeX = 0, kdeY = 0;
            int soucet = 0;

            for (int row = 0; row < 100 && row + 2 < 100; row++)
            {
                for (int column = 0; column < 100 && column + 2 < 100; column++)
                {
                    soucet = rybyArr[row, column] + rybyArr[row+1, column] + rybyArr[row+2, column] + rybyArr[row, column+1] + rybyArr[row, column+1] + rybyArr[row+1, column+1] + rybyArr[row+1, column+2] + rybyArr[row+2, column+1] + rybyArr[row+2, column+2];
                    if(soucet > vysledek) { vysledek = soucet; kdeX = row; kdeY = column; }
                }
            }

            



            Console.WriteLine($"Nalezeno 30x30 m pole, kde je nejvíce ryb. Je v rozsahu {kdeX}. - {kdeX+2}. řádek a {kdeY}. - {kdeY+2}. sloupec a je tam {vysledek} ryb");

            Console.ReadLine();
        }
    }
}
