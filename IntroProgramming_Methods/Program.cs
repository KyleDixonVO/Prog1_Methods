using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProgramming_Methods
{
    class Program
    {
    
        
            static int score;
            static string name;
            static int xp;
            static int gold;

            static void ShowHUD()
            {   //hud method
                Console.WriteLine("Score: " + score);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Xp: " + xp);
                Console.WriteLine("Gold: " + gold);
                Console.WriteLine("````````````");
            }

            static void Main(string[] args)
            {   //Aka: functions, procedures, routines, etc.

                Console.WriteLine("Methods:");
                Console.WriteLine("````````````");

                Console.ReadKey(true);
                score = 0;
                name = "Shotty";
                xp = 0;
                gold = 0;

                ShowHUD();

                Console.ReadKey(true);

                score = score + 100;
                xp = xp + 50;

                ShowHUD();

                Console.ReadKey(true);
            }
        
    }
}
