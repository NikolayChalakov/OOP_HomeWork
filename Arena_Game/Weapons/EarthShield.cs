using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class EarthShield : IWeapon
    {
      public  string Name { get; set; }
       public string SpecialPower { get; set; }

      public   double AttackDamage { get;private set; }

      public  double BlockingPower { get;private set; }
       public EarthShield(string name)
        {
            Name = name;
            SpecialPower = "The Earth Shield, fortified by the strength of the earth itself, possesses a chance to bolster its defensive capabilities.";
            AttackDamage = 10;
            BlockingPower = 40+EarthDefend();
            
        }
        public double EarthDefend()
        {
            Random temp = new Random();
            double temp2 = temp.Next(1, 6);
            if (1== temp2|| 2 == temp2)
            {
                return BlockingPower *100;
            }
            return 0;
        }
    }
}
