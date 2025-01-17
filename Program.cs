﻿using NarrativeProject.Rooms;
using System;

namespace NarrativeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.Add(new Bedroom());
            game.Add(new Bathroom());
            game.Add(new AtticRoom());
            game.Add(new LivingRoom());
            game.Add(new Kitchen());
            game.Add(new Basement());

            while (!game.IsGameOver())
            {
                Console.WriteLine("--");
                Console.WriteLine(game.CurrentRoomDescription);
                string choice = Console.ReadLine().ToLower() ?? "";
                Console.Clear();
                game.ReceiveChoice(choice);
            }

            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}
