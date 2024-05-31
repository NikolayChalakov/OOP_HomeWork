using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Barbarian : Hero
    {
        public bool Rage { get; private set; }
        public Barbarian(string name, double armor, double strenght, IWeapon weapon) :
            base(name, armor, strenght, weapon)
        {
           Random rage = new Random();
            if(rage.Next(1,3) == 1)
            {
                this.Rage = true;
            }
            else
            {
                Rage = false;
            }
        }

        public Barbarian(string name, double armor, double strenght) : base(name, armor, strenght)
        {
            Random rage = new Random();
            if (rage.Next(1, 3) == 1)
            {
                this.Rage = true;
            }
            else
            {
                Rage = false;
            }
        }

        public override double Attack()
        {
            double damage = base.Attack();
            if (Rage)
            {
                damage *= 4;
            }
            
            return damage;
        }
    }
}
