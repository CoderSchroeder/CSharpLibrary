using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame_Demo
{
    public enum CharacterType
    {
        Assassin = 0,
        BlitzenBlopper = 1,
        Professor = 2,
        HorseMange = 3,
        TaxMan = 4,
        Human = 5
    }
    class Player
    {
        public string PlayerName { get; set; }
        public string Clan { get; set; }
        public int CurrentPower { get; set; }
        public CharacterType Type { get; set; }

        public Player(string name, string clanName, CharacterType type = CharacterType.HorseMange)
        {
            this.PlayerName = name;
            this.Clan = clanName;
            this.CurrentPower = 100;
            this.Type = type;
        }

        public CharacterType ChooseType(int t)
        {
            switch (t)
            {
                case 0:
                    Console.WriteLine("You are an Assassin");
                    return this.Type = CharacterType.Assassin;
                case 1:
                    Console.WriteLine("You are a Blitzenblopper");
                    return this.Type = CharacterType.BlitzenBlopper;
                case 2:
                    Console.WriteLine("You are a Professor");
                    return this.Type = CharacterType.Professor;
                case 3:
                    Console.WriteLine("You are a HorseMange");
                    return this.Type = CharacterType.HorseMange;
                case 4:
                    Console.WriteLine("You are a TaxMan");
                    return this.Type = CharacterType.TaxMan;
                case 5:
                    Console.WriteLine("You are a Ron Swanson");
                    return this.Type = CharacterType.Human;
                default:
                    Console.WriteLine("You have been turned into HorseMange");
                    return this.Type = CharacterType.HorseMange;
            }
        }

        //make a method that you can call on a player object that prints out the players power

        public void HealthLevel()
        {
            Console.WriteLine("{0}'s power level is at {1}", this.PlayerName, this.CurrentPower);
        }


        //make a method for your player objects for your battle cry

        public void Battlecry()
        {
            Console.WriteLine("I NEED SCOTCH!!! WAAAAAA");
        }

        //Create a method of ToString that returns your players details

        public override string ToString()
        {
            return $"Player Name: {this.PlayerName}\nClan Name: {this.Clan}\nPlayer Type: {this.Type}";
        }


    }
}
