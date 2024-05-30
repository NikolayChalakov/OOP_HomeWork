using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class PokerCard:IWeapon
    {
        public string Name { get; set; }
        public string SpecialPower { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }
        public PokerCard(string name)
        {
            Name = name;
            SpecialPower = "This is the turbo gambling weapon,you either win hard or lose harder:)";
            Gamble();
        }
        public void Gamble()
        {
            Random temp = new Random();
            if(1== temp.Next(1, 4))
            {
                AttackDamage = 1000;
            }
            else
            {
                AttackDamage = 0;
            }
            if (1 == temp.Next(1, 4))
            {
                BlockingPower = 1000;
            }
            else
            {
                BlockingPower = 0;
            }
        }

    }
}
