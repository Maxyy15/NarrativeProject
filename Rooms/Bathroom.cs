using System;

namespace NarrativeProject.Rooms
{
    internal class Bathroom : Room
    {
        internal static bool isBathFull = false;

        internal override string CreateDescription() =>
@"In your bathroom, there is a [bath] to your left.
The [mirror] in front of you reflects your depressed face.
You can return to your [bedroom].
";

        internal override void ReceiveChoice(string choice)
        {
            if (isBathFull == false)
            {
                switch (choice)
                {
                    case "bath":
                        Console.WriteLine("You fill the bath up.");
                        isBathFull = true;
                        break;
                    case "mirror":
                        Console.WriteLine("You see your very depressed face.");
                        break;
                    case "bedroom":
                        Console.WriteLine("You return to your bedroom.");
                        Game.Transition<Bedroom>();
                        break;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            }
            else
            {
                switch (choice)
                {
                    case "bath":
                        Console.WriteLine("You relax in the bath.");
                        break;
                    case "mirror":
                        Console.WriteLine("You see the numbers 6969 written on the fog on your mirror.");
                        break;
                    case "bedroom":
                        Console.WriteLine("You return to your bedroom.");
                        Game.Transition<Bedroom>();
                        break;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            }
        }
    }
}
