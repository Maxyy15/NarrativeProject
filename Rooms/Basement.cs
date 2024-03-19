using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarrativeProject.Rooms
{
    internal class Basement : Room
    {

        internal override string CreateDescription() =>
@"You are in the basement.
The smell of rotting meat and death overwhelms your nose.
It's very dark in the room, probably for the best.
Despite the darkness you have a vague awareness of your surroundings.
To your left is [something cold]
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "kitchen":
                    Console.WriteLine("You enter the kitchen.");
                    Game.Transition<Bathroom>();
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
                    Console.WriteLine("You go up and enter your attic.");
                    Game.Transition<AtticRoom>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
