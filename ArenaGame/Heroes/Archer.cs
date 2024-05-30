using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Archer : Hero
    {
        public int Arrows { get; set; }
        public Archer(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            Random arrows = new Random();
            Arrows = arrows.Next(0, 64);
        }

        public Archer(string name, double armor, double strenght) : base(name, armor, strenght)
        {
        }

        public override double Attack()
        {
            double attack = base.Attack();
           return attack + (Arrows*0.2);
        }
    }
}
