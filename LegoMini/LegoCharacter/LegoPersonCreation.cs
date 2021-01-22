using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMini.LegoCharacter
{
    class LegoPersonCreation
    {
        //properties
        public string Name { get; set; }
        public string Hat { get; set; }
        public string Face { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Feet { get; set; }
        public string Weapon { get; set; }

        //constructor
        public LegoPersonCreation(string name, string hat, string face, string torso, string legs, string feet, string weapon)
        {
            Name = name;
            Hat = CharacterHatType(hat);
            Face = CharacterFaceType(face);
            Torso = CharacterTorsoType(torso);
            Legs = CharacterLegType(legs);
            Feet = CharacterFeetType(feet);
            Weapon = CharacterWeaponType(weapon);

            Console.WriteLine("This is the character you created:");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Character's name: {Name}");
            Console.WriteLine($"Character's hat: {Hat}");
            Console.WriteLine($"Character's face: {Face}");
            Console.WriteLine($"Character's torso: {Torso}");
            Console.WriteLine($"Character's legs: {Legs}");
            Console.WriteLine($"Character's feet: {Feet}");
            Console.WriteLine($"Character's weapon: {Weapon}");
            Console.WriteLine("-----------------------------------\n");

        }

        //Methods
        public string CharacterHatType(string answer)
        {
            switch (answer)
            {
                case "1":
                    return "Cowboy";
                case "2":
                    return "Space Helmet";
                case "3":
                    return "Captain's Hat";
                default:
                    return "Fedora";
            }
        }

        public string CharacterFaceType(string answer)
        {
            switch (answer)
            {
                case "1":
                    return "Happy Face";
                case "2":
                    return "Angry Face";
                case "3":
                    return "Sad Face";
                default:
                    return "No Face (audible gasp!)";
            }
        }

        public string CharacterTorsoType(string answer)
        {
            switch (answer)
            {
                case "1":
                    return "Space Suit";
                case "2":
                    return "Pirate Vest";
                case "3":
                    return "Cowboy Jacket";
                default:
                    return "Leafs";
            }
        }

        public string CharacterLegType(string answer)
        {
            switch (answer)
            {
                case "1":
                    return "Space Legs";
                case "2":
                    return "Skinny Jeans";
                case "3":
                    return "Cowboy Pants";
                default:
                    return "Leafs";
            }
        }

        public string CharacterFeetType(string answer)
        {
            switch (answer)
            {
                case "1":
                    return "Space Boots";
                case "2":
                    return "Pirate Boots";
                case "3":
                    return "Cowboy Boots";
                default:
                    return "Who do you think I am!?!?! I don't need shoes!";
            }
        }

        public string CharacterWeaponType(string answer)
        {
            switch (answer)
            {
                case "1":
                    return "Hook Hand";
                case "2":
                    return "Laser Gun";
                case "3":
                    return "Revolver";
                default:
                    return "Drill (This drill is the drill that will pierce the heavans!)";
            }
        }

    }
}
