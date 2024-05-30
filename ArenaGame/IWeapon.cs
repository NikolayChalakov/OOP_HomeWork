using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public interface IWeapon
    {
        string Name { get; set; }
        string SpecialPower { get; set; }
        double AttackDamage { get; } 
        double BlockingPower { get; }
    }
}
