using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace ConsoleArenaGame
{
    class Program
    {
        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.");
            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");
        }
        static void Main(string[] args)
        {
            Hero hero1 = new Knight("Knight", 10, 20, new Dagger("Dagger")); ;
            Hero hero2 = new Assassin("Assassin", 10, 5, new Dagger("Dagger")); 

            Console.WriteLine("Enter your hero,with number:");
            Console.WriteLine("1.Archer");
            Console.WriteLine("2.Barbarian");
            Console.WriteLine("3.Assassin ");
            Console.WriteLine("4.Kinght ");
            Console.WriteLine("5.Summoner");
            int heroA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of your weapon: ");
            Console.WriteLine("1.Dagger");
            Console.WriteLine("2.Sword");
            Console.WriteLine("3.EarthShield ");
            Console.WriteLine("4.LightingSword ");
            Console.WriteLine("5.PokerCard");
            int weaponA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter enemy hero,with number:");
            Console.WriteLine("1.Archer");
            Console.WriteLine("2.Barbarian");
            Console.WriteLine("3.Assassin ");
            Console.WriteLine("4.Knight ");
            Console.WriteLine("5.Summoner");
            int heroB = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of your enemy weapon: ");
            Console.WriteLine("1.Dagger");
            Console.WriteLine("2.Sword");
            Console.WriteLine("3.EarthShield ");
            Console.WriteLine("4.LightingSword ");
            Console.WriteLine("5.PokerCard");
            int weaponB = int.Parse(Console.ReadLine());
            /*  case "Knight": hero1 = new Knight("Knight", 10, 20); break;
                case "Assassin": hero1 = new Assassin("Assassin", 10, 5); break;
                case "Barbarian": hero1 = new Barbarian("Barbarian", 10, 20); break;
                case "Archer": hero1 = new Archer("Archer", 5, 30); break;
                case "Summoner": hero1 = new Summoner("Summoner", 10, 15); break;*/
            switch (heroA)
            {
                case 1:
                    switch (weaponA)
                    {
                        case 1: hero1 = new Archer("Archer", 5, 30, new Dagger("Dagger")); break;
                        case 2: hero1 = new Archer("Archer", 5, 30, new Sword("Sword")); break;
                        case 3: hero1 = new Archer("Archer", 5, 30, new EarthShield("EarthShield")); break;
                        case 4: hero1 = new Archer("Archer", 5, 30, new LigtingSword("LightingSword")); break;
                        case 5: hero1 = new Archer("Archer", 5, 30, new PokerCard("PokerCard")); break;
                    }
                    break;
                case 2:
                    switch (weaponA)
                    {
                        case 1: hero1 = new Barbarian("Barbarian", 10, 20, new Dagger("Dagger")); break;
                        case 2: hero1 = new Barbarian("Barbarian", 10, 20, new Sword("Sword")); break;
                        case 3: hero1 = new Barbarian("Barbarian", 10, 20, new EarthShield("EarthShield")); break;
                        case 4: hero1 = new Barbarian("Barbarian", 10, 20, new LigtingSword("LightingSword")); break;
                        case 5: hero1 = new Barbarian("Barbarian", 10, 20, new PokerCard("PokerCard")); break;
                    }
                    break;
                case 3:
                    switch (weaponA)
                    {
                        case 1: hero1 = new Assassin("Assassin", 10, 5, new Dagger("Dagger")); break;
                        case 2: hero1 = new Assassin("Assassin", 10, 5, new Sword("Sword")); break;
                        case 3: hero1 = new Assassin("Assassin", 10, 5, new EarthShield("EarthShield")); break;
                        case 4: hero1 = new Assassin("Assassin", 10, 5, new LigtingSword("LightingSword")); break;
                        case 5: hero1 = new Assassin("Assassin", 10, 5, new PokerCard("PokerCard")); break;
                    }
                    break;
                case 4:
                    switch (weaponA)
                    {
                        case 1: hero1 = new Knight("Knight", 10, 20, new Dagger("Dagger")); break;
                        case 2: hero1 = new Knight("Knight", 10, 20, new Sword("Sword")); break;
                        case 3: hero1 = new Knight("Knight", 10, 20, new EarthShield("EarthShield")); break;
                        case 4: hero1 = new Knight("Knight", 10, 20, new LigtingSword("LightingSword")); break;
                        case 5: hero1 = new Knight("Knight", 10, 20, new PokerCard("PokerCard")); break;
                    }
                    break;
                case 5:
                    switch (weaponA)
                    {
                        case 1: hero1 = new Summoner("Summoner", 10, 15, new Dagger("Dagger")); break;
                        case 2: hero1 = new Summoner("Summoner", 10, 15, new Sword("Sword")); break;
                        case 3: hero1 = new Summoner("Summoner", 10, 15, new EarthShield("EarthShield")); break;
                        case 4: hero1 = new Summoner("Summoner", 10, 15, new LigtingSword("LightingSword")); break;
                        case 5: hero1 = new Summoner("Summoner", 10, 15, new PokerCard("PokerCard")); break;
                    }
                    break;
            }
            switch (heroB)
            {
                case 1:
                    switch (weaponB)
                    {
                        case 1: hero2 = new Archer("Archer", 5, 30, new Dagger("Dagger")); break;
                        case 2: hero2 = new Archer("Archer", 5, 30, new Sword("Sword")); break;
                        case 3: hero2 = new Archer("Archer", 5, 30, new EarthShield("EarthShield")); break;
                        case 4: hero2 = new Archer("Archer", 5, 30, new LigtingSword("LightingSword")); break;
                        case 5: hero2 = new Archer("Archer", 5, 30, new PokerCard("PokerCard")); break;
                    }
                    break;
                case 2:
                    switch (weaponB)
                    {
                        case 1: hero2 = new Barbarian("Barbarian", 10, 20, new Dagger("Dagger")); break;
                        case 2: hero2 = new Barbarian("Barbarian", 10, 20, new Sword("Sword")); break;
                        case 3: hero2 = new Barbarian("Barbarian", 10, 20, new EarthShield("EarthShield")); break;
                        case 4: hero2 = new Barbarian("Barbarian", 10, 20, new LigtingSword("LightingSword")); break;
                        case 5: hero2 = new Barbarian("Barbarian", 10, 20, new PokerCard("PokerCard")); break;
                    }
                    break;
                case 3:
                    switch (weaponB)
                    {
                        case 1: hero2 = new Assassin("Assassin", 10, 5, new Dagger("Dagger")); break;
                        case 2: hero2 = new Assassin("Assassin", 10, 5, new Sword("Sword")); break;
                        case 3: hero2 = new Assassin("Assassin", 10, 5, new EarthShield("EarthShield")); break;
                        case 4: hero2 = new Assassin("Assassin", 10, 5, new LigtingSword("LightingSword")); break;
                        case 5: hero2 = new Assassin("Assassin", 10, 5, new PokerCard("PokerCard")); break;
                    }
                    break;
                case 4:
                    switch (weaponB)
                    {
                        case 1: hero2 = new Knight("Knight", 10, 20, new Dagger("Dagger")); break;
                        case 2: hero2 = new Knight("Knight", 10, 20, new Sword("Sword")); break;
                        case 3: hero2 = new Knight("Knight", 10, 20, new EarthShield("EarthShield")); break;
                        case 4: hero2 = new Knight("Knight", 10, 20, new LigtingSword("LightingSword")); break;
                        case 5: hero2 = new Knight("Knight", 10, 20, new PokerCard("PokerCard")); break;
                    }
                    break;
                case 5:
                    switch (weaponB)
                    {
                        case 1: hero2 = new Summoner("Summoner", 10, 15, new Dagger("Dagger")); break;
                        case 2: hero2 = new Summoner("Summoner", 10, 15, new Sword("Sword")); break;
                        case 3: hero2 = new Summoner("Summoner", 10, 15, new EarthShield("EarthShield")); break;
                        case 4: hero2 = new Summoner("Summoner", 10, 15, new LigtingSword("LightingSword")); break;
                        case 5: hero2 = new Summoner("Summoner", 10, 15, new PokerCard("PokerCard")); break;
                    }
                    break;
            }

            GameEngine gameEngine = new GameEngine()
            {
                HeroA = hero1,
                HeroB = hero2,
                NotificationsCallBack = ConsoleNotification
                //NotificationsCallBack = args => Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {args.Attack} and caused {args.Damage} damage.")
            };

            gameEngine.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine.Winner}");
        }
    }
}