using System;
using ToHModels;
using ToHBL;
namespace ToHUI
{
    public class HeroMenu : IMenu
    {
        private IHeroBL _heroBL;
        public HeroMenu(IHeroBL heroBL)
        {
            _heroBL = heroBL;
        }
        public void Start()
        {
            Boolean stay = true;
            do
            {
                //menu options
                Console.WriteLine("Welcome to the tour of heroes app!  What would you like to do?");
                Console.WriteLine("[0] Create a hero");
                Console.WriteLine("[1] Get all heroes");
                Console.WriteLine("[2] Exit");

                //user input
                Console.WriteLine("Enter a number: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "0":
                        try
                        {
                            CreateHero();
                        }
                        catch(Exception)
                        {
                            Console.WriteLine("Invalid Input.");
                            continue;
                        }
                        break;
                    case "1":
                        GetHeroes();
                        break;
                    case "2":
                        stay = false;
                        ExitRemarks();
                        break;
                    default:
                        Console.WriteLine("Not part of menu!!! Try again!!! >:(");
                        break;
                }
            } while (stay);
        }

        public void CreateHero(){
            // Create hero method/logic
            Hero newHero = new Hero();
            Console.WriteLine("Enter Hero Name: ");
            newHero.HeroName = Console.ReadLine();
            Console.WriteLine("Enter HP value: ");
            newHero.HP = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter SuperPower details");
            SuperPower newSuperPower = new SuperPower();
            Console.WriteLine("Enter SuperPower name: ");
            newSuperPower.Name = Console.ReadLine();
            Console.WriteLine("Enter SuperPower description: ");
            newSuperPower.Description = Console.ReadLine();
            Console.WriteLine("Enter SuperPower damage: ");
            newSuperPower.Damage = int.Parse(Console.ReadLine());
            newHero.SuperPower = newSuperPower;
            Console.WriteLine("Set the element type of the hero: ");
            newHero.ElementType = Enum.Parse<Element>(Console.ReadLine());
            
            Console.WriteLine("Hero Successfully created!");
            _heroBL.AddHero(newHero);
        }

        public void GetHeroes(){
            //gets all heros
            foreach (var item in _heroBL.GetHeroes())
            {
                Console.WriteLine(item.ToString());
            }
            //pause
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        public void ExitRemarks(){
            Console.WriteLine("Goodbye Friend! I will watch your heros while you are away! :)");
        }
    }
}