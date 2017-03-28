using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame_Demo
{
    class LizardDog : Enemy
    {

        Dictionary<string, int> Attacks = new Dictionary<string, int>
            {
                {"Head-but", 20 },
                { "Mallet", 15},
                {"Poison Fangs", 25},
            };

        public LizardDog()
        {
            this.PowerLevel = 100;
            this.Name = "Lizard Dog";
        }

        public override void Insult()
        {
            int r = rnd.Next(0, insult.Count);
            Console.WriteLine("I am {0} you {1}", this.Name, insult[r]);
        }

        public void LizardAttack(Player p)
        {
            Attack(p, Attacks, this.Name);
        }

    }
}
