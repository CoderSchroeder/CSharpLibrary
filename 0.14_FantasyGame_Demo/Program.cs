using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer talkingConsole = new SpeechSynthesizer();
            talkingConsole.Speak("What is your name?");
           
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What Clan are you affiliated with?");
            string clan = Console.ReadLine();

            Console.WriteLine("What is your player type?\n" +
                "0 : Assassin\n" +
                "1 : BlitzenBlopper\n" +
                "2 : Professor\n" +
                "3 : HorseMange\n" +
                "4 : TaxMan\n" +
                "5 : Human");

            int playerType = int.Parse(Console.ReadLine());

            Player Player = new Player(name, clan);
            Player.ChooseType(playerType);

            
            Console.WriteLine(Player.ToString());

            LizardDog lizardDog = new LizardDog();

            while (true)
            {
                lizardDog.Insult();
                Console.WriteLine("Do you want to fight? y/n");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "y")
                {
                    
                    lizardDog.LizardAttack(Player);

                    if (Player.CurrentPower <= 0)
                    {
                        Console.WriteLine("The End");
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            
           Player.Battlecry();

            /* Enemy Quagga = new Enemy();

             for (int i = 0; i < 5; i++) 
             {
             Quagga.Insult();
             }
             */

            //create a new subclass of enemy (any name) that inherits from enemy class
            //that has a constructor
            //and one method

            Console.ReadLine();

        }
    }
}
