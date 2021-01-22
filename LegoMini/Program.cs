using LegoMini.LegoCharacter;
using System;

namespace LegoMini
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas fill in the following character sheet to creat your character.");
            Console.WriteLine("---------------------------------------");
            //variables
            Console.WriteLine("Enter character's name: ");
            string characterName = Console.ReadLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("From this point on choose a number 1-3 for your choice");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Choose your character's hat ( 1: Cowboy 2: Space Helmet 3: Captain's Hat )");
            string characterHatNumChoice = Console.ReadLine();
            Console.WriteLine("Choose your character's face ( 1: Happy Face 2: Angry Face 3: Sad Face )");
            string characterHeadNumChoice = Console.ReadLine();
            Console.WriteLine("Choose your character's torso ( 1: Space Suit 2: Pirate Vest 3: Cowboy Jacket )");
            string characterTorsoNumChoice = Console.ReadLine();
            Console.WriteLine("Choose your character's legs ( 1: Space Legs 2: Skinny Jeans 3: Cowboy Pants )");
            string characterLegsNumChoice = Console.ReadLine();
            Console.WriteLine("Choose your character's feet ( 1: Space Boots 2: Pirate Boots 3: Cowboy Boots )");
            string characterFeetNumChoice = Console.ReadLine();
            Console.WriteLine("Choose your character's weapons ( 1: Hook Hand 2: Laser Gun 3: Revolver )");
            string characterWeaponNumChoice = Console.ReadLine();
            Console.WriteLine("\n");

            

            //calling character class
            LegoPersonCreation character1 = new LegoPersonCreation(characterName, characterHatNumChoice, characterHeadNumChoice, characterTorsoNumChoice, characterLegsNumChoice, characterFeetNumChoice, characterWeaponNumChoice);
        }
    }
}
