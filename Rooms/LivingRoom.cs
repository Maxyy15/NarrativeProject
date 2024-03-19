using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarrativeProject.Rooms
{
    internal class LivingRoom : Room
    {

        internal override string CreateDescription() =>
@"You are in the living room.
The [door] in front of you leads to the spoooky outside world.
The [kitchen] behind you, no one is there.
From where you stand, you see the [basement] to your right.
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "kitchen":
                    Console.WriteLine("You enter the kitchen.");
                    Game.Transition<Kitchen>();
                    break;
                case "door":
                    if (!AtticRoom.isKeyCollected)
                    {
                        Console.WriteLine("The door is locked.");
                    }
                    else
                    {
                        Console.WriteLine("You open the door with the key and leave your bedroom.");
                        Game.Finish();
                    }
                    break;
                case "basement":
                    if (!Kitchen.isHammerCollected)
                    {
                        Console.WriteLine("The door is locked.");
                    }
                    else
                    {
                        Console.WriteLine("You smash open the door with the hammer and enter the basement.");
                        Game.Transition<Basement>();
                    }
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
