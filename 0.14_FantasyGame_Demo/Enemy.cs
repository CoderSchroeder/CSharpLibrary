using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame_Demo
{
    class Enemy
    {
        protected ArrayList insult = new ArrayList { "buck-o", "window licker", "noob", "nerd cakes", "buster", "wimp" };
        protected Random rnd = new Random();

        public string Name { get; set; }
        public int PowerLevel { get; set; }

        //create an insult method with a few insults

        public virtual void Insult()
        {
            int r = rnd.Next(0, insult.Count);

            Console.WriteLine("Put some alcohol in your mouth to block the words coming out {0}", insult[r]);
        }

        public void Attack(Player player, Dictionary<string, int> dict, Object enemyName)
        {
           //dictionary of attacks to use for the opponent
            

            var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;

            Console.WriteLine("The enemy is attacking with {0} and deals {1} points of damage", attackName, attackVal);



            Console.WriteLine("{0}'s power is at {1}%", player.PlayerName, player.CurrentPower);
            player.CurrentPower -= attackVal;




        }
    }
}
