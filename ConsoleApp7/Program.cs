using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    internal class Program
    {
        static List<string> list = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                WriteMenu();
                Console.Write("Válassz menüpontot: ");
                string input = Console.ReadLine().Trim();
                Decide(input);
               
            }
        }

        static void WriteMenu()
        {
           
            Console.WriteLine();
            

            Console.WriteLine("adatok listázása -->list");
            Console.WriteLine("adat hozzáadása -->add");
            Console.WriteLine("lista törlése -->clear");
            Console.WriteLine("adat törlése -->torles");
            Console.WriteLine("kilépés -->exit");
            Console.WriteLine("");
        }

        static void Decide(string command)
        {
            if (command == "list")
            {
                if (list.Count == 0)
                {
                    Console.WriteLine("A lista üres.");
                }
                else
                {
                    Console.WriteLine("A lista elemei:");
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine($"{list[i]}");
                    }
                }
            }
            else if (command != "list"||command != "add"|| command!="clear"||command !="torles"||command !="exit")
            {
                Console.WriteLine("Ez a paerancs nem szerepel a megadhatók között");
            }
            else if (command == "add")
            {
                Console.Write("Mit szeretnél hozzáadni? ");
                string item = Console.ReadLine();
                list.Add(item);
                 Console.WriteLine($"'{item}' hozzáadva.");
                
            }
            else if (command == "clear")
            {
                list.Clear();
                Console.WriteLine("A lista kiürítve.");
            }
            else if (command == "torles")
            {
                Console.Write("Mit szeretnél törölni? ");
                string item = Console.ReadLine();
                if (list.Remove(item))
                {
                    Console.WriteLine($"'{item}' törölve.");
                }
                else
                {
                    Console.WriteLine($"'{item}' nem található a listában.");
                }
            }
            else if (command == "exit")
            {
                Console.WriteLine("Kilépés...");
                Environment.Exit(0);

            }
        }
    }
}
