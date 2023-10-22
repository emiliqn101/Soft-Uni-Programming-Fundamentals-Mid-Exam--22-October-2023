using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main()
        {
            List<string> frendos = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> nononames = new List<string>();
            List<string> lostNames = new List<string>();



            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "Report")
                {
                    Console.WriteLine($"Blacklisted names: {nononames.Count}");
                    Console.WriteLine($"Lost names: {lostNames.Count}");
                    Console.WriteLine(string.Join(" ", frendos));
                    break;
                }

                if (input[0] == "Blacklist")
                {



                    string name = input[1];
                    if (frendos.Contains(name))
                    {
                        nononames.Add(name);
                        lostNames.Remove(name);
                        frendos[frendos.IndexOf(name)] = "Blacklisted";
                        Console.WriteLine($"{name} was blacklisted.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if (input[0] == "Error")
                {
                    int index = int.Parse(input[1]);
                    if (index >= 0 && index < frendos.Count && frendos[index] != "Blacklisted" && !lostNames.Contains(frendos[index]))
                    {
                        string name = frendos[index];
                        lostNames.Add(name);
                        frendos[index] = "Lost";
                        Console.WriteLine($"{name} was lost due to an error.");
                    }
                }
                else if (input[0] == "Change")
                {
                    int index = int.Parse(input[1]);
                    string newName = input[2];
                    if (index >= 0 && index < frendos.Count)
                    {
                        string currentName = frendos[index];
                        frendos[index] = newName;
                        Console.WriteLine($"{currentName} changed his username to {newName}.");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
