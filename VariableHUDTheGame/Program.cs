using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableHUDTheGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int health;
                int score;
                int lives;
                int multiplier;

                string stats;
                string enemyAttacks;

                health = 100;
                score = 0;
                lives = 0;
                multiplier = 2;

                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Variable HUD The Game");
                Console.ResetColor();
                Console.WriteLine("");

                stats = "Health: " + health;
                Console.WriteLine(stats);
                stats = "Score: " + score;
                Console.WriteLine(stats);
                stats = "Lives: " + lives;
                Console.WriteLine(stats);
            
                Console.WriteLine();
                Console.WriteLine("Player picked up a gold coin!");
                score = score + 100;
                stats = "Health: " + health;
                Console.WriteLine(stats);
                stats = "Score: " + score;
                Console.WriteLine(stats);
                stats = "Lives: " + lives;
                Console.WriteLine(stats);
                
                Console.WriteLine();
                Console.WriteLine("Player picked up a 2x score bonus!");
                multiplier = score * 2;
                score = score + 100;
                stats = "Health: " + health;
                Console.WriteLine(stats);
                stats = "Score: " + score;
                Console.WriteLine(stats);
                stats = "Lives: " + lives;
                Console.WriteLine(stats);

                Console.WriteLine();
                Console.WriteLine("Player picked up an extra healing item!");
                health = health + 50;
                stats = "Health: " + health;
                Console.WriteLine(stats);
                stats = "Score: " + score;
                Console.WriteLine(stats);
                stats = "Lives: " + lives;
                Console.WriteLine(stats);

            Console.WriteLine();
            Console.WriteLine("Player has taken serious damage and is in the afterlife. Use 200 score for 1UP?");
            health = health - 150;
            stats = "Health: " + health;
            Console.WriteLine(stats);
            stats = "Score: " + score;
            Console.WriteLine(stats);
            stats = "Lives: " + lives;
            Console.WriteLine(stats);

            Console.WriteLine();
            Console.WriteLine("Player uses 200 score for a 1UP!");
            health = health + 100;
            lives = lives + 1;
            score = score - 200;
            stats = "Health: " + health;
            Console.WriteLine(stats);
            stats = "Score: " + score;
            Console.WriteLine(stats);
            stats = "Lives: " + lives;
            Console.WriteLine(stats);

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Player has made it to the end. YOU WIN!");
            Console.ResetColor();
            lives = lives - 1;
            stats = "Health: " + health;
            Console.WriteLine(stats);
            stats = "Score: " + score;
            Console.WriteLine(stats);
            stats = "Lives: " + lives;
            Console.WriteLine(stats);



            Console.ReadKey(true);
        }
    }
}
