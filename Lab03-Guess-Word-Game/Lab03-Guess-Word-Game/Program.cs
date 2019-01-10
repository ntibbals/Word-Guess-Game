﻿using System;
using System.IO;

namespace Lab03_Guess_Word_Game
{
    public class Program
    {
        public static string Path = "../../../../../GameWords.txt";

        static void Main(string[] args)
        {
            bool displayMenu = true;
            while(displayMenu)
            {
                Console.WriteLine("Do you want to play a game? y/n");
                string start = Console.ReadLine();
                if (start == "y")
                {
                    MainMenu();
                }
                else if (start == "n")
                {
                    Environment.Exit(0);
                }
            }
        }

        public static void MainMenu()
        {
            Console.Clear();
            try
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Word Guess Game!");
                Console.WriteLine("1) Start game");
                Console.WriteLine("2) Admin");
                Console.WriteLine("3) Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        StartGame();
                        break;

                }
            }
            catch (ArgumentNullException e) //catch null exception
            {
                Console.WriteLine($"You did not enter anything. Please try again.");
                Console.ReadLine();
            }
            catch (FormatException e) // catch format exception
            {
                Console.WriteLine($"Unable to read format. Please try agian.");
                Console.ReadLine();
            }
            catch (Exception e) // catch all exception(general)
            {
                Console.WriteLine($"You've hit the following exception: {e.Message}.");
                Console.ReadLine();
            }

        }

        static void StartGame()
        {
            Console.WriteLine("Game Running.");
            ReadFile(Path);
            Console.ReadLine();
        }

        static void ReadFile(string Path)
        {
            string[] lines = File.ReadAllLines(Path);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }
    }
}
