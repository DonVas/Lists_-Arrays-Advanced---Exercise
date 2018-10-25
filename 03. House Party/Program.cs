using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[1] + " " + command[2] == "is going!")
                {

                    if (ExistinElement(command[0], names) == false)
                    {
                        names.Add(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }

                }
                else if (command[2] == "not" && command[3] == "going!")
                {


                    if (ExistinElement(command[0], names) == true)
                    {
                        names.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }

            }

            Console.WriteLine(string.Join("\n", names));
        }

        static bool ExistinElement(string name, List<string> names)
        {
            //return names.Where(x => x == name ? true : false).;
            bool result = false;
            foreach (string item in names)
            {
                if (name == item)
                {
                    result = true;
                }

            }

            return result;
        }
    }
}
