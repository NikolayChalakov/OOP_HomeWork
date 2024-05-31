using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ArenaGame.Heroes
{
    public class Summoner:Hero
    {

        int Entities { get; set; }
        public Summoner(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            Random entities = new Random();
            Entities = entities.Next(15);
        }

        public Summoner(string name, double armor, double strenght) : base(name, armor, strenght)
        {

            Random entities = new Random();
            Entities = entities.Next(15);
        }

        public override double Attack() => base.Attack() + Entities;
        
        public override double Defend(double damage) => base.Defend(damage)+Entities;
        

    }
}
