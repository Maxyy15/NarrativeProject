using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarrativeProject.Rooms
{
    internal class Kitchen : Room
    {
        internal static bool isKitchenKeyCollected;
        internal static bool isHammerCollected;

        internal override string CreateDescription() =>
@"You are in the kitchen.
The [drawers] are closed.
The [fridge] was left open, everything is warm.
You can return to the [living room]
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "fridge":
                    Console.WriteLine("You look in the fridge.\nEverything is bad and a rotten smell hits your nose. " +
                        "\nYou notice a key taped to the back of the fridge.\nYou collected another key.");
                    break;
                case "drawers":
                    if (!isKitchenKeyCollected)
                    {
                        Console.WriteLine("The drawers are locked.");
                    }
                    else
                    {
                        Console.WriteLine("You open the drawers with the key and find.. a hammer?");
                        isHammerCollected = true;
                    }
                    break;
                case "living room":
                    Console.WriteLine("You go back to the living room");
                    Game.Transition<LivingRoom>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
