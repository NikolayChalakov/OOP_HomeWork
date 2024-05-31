using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Sword : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }
        public string SpecialPower { get; set; }
        public Sword(string name)
        {
            Name = name;
            AttackDamage = 20;
            BlockingPower = 10;
            SpecialPower = "A cute shiny sword without a power";
        }
    }
}
