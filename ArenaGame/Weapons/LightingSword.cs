using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class LigtingSword : IWeapon
    {
        public string Name { get; set; }

        public string SpecialPower { get; set; }
        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }
     
        public LigtingSword(string name)
        {
            Name = name;
            AttackDamage = 20+LightingDamage();
            BlockingPower = 10;
            SpecialPower = "The Lighting Sword, forged from storm's heart. Swift as lightning, deadly as thunder, it deals critical blows, leaving foes trembling.";

        }
        protected double LightingDamage() {
            Random temp = new Random();
            if(1 == temp.Next(1, 6))
            {
             return  AttackDamage * 2;
            }
            return 0;
        }
    }
}