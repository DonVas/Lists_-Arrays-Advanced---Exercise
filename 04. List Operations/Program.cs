using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.List_Operations
{
    class Program
    {
        static List<int> manupalateNumbers;
        static void Main(string[] args)
        {
            manupalateNumbers = new List<int>(Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToList());

            while (true)
            {
                string line = Console.ReadLine();
                string[] command = line.Split();
                int index = -1;
                int number = 0;

                if (line == "End")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Add":
                        number = int.Parse(command[1]);
                        Add(number, manupalateNumbers);
                        break;
                    case "Insert":
                        number = int.Parse(command[1]);
                        index = int.Parse(command[2]);
                        if (IsIndexOutOfOrder(index, manupalateNumbers) == false)
                        {
                            Console.WriteLine("Invalid index");
                            index = -1;
                            break;
                        }
                        Insert(index, number, manupalateNumbers);
                        break;
                    case "Remove":
                        index = int.Parse(command[1]);
                        if (IsIndexOutOfOrder(index, manupalateNumbers) == false)
                        {
                            Console.WriteLine("Invalid index");
                            index = -1;
                            break;
                        }
                        Remove(index, manupalateNumbers);
                        break;
                    case "Shift":

                        switch (command[1])
                        {
                            case "left":
                                number = int.Parse(command[2]);
                                Shiftleft(number, manupalateNumbers);
                                break;
                            case "right":
                                number = int.Parse(command[2]);
                                ShiftRight(number, manupalateNumbers);
                                break;
                        }
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", manupalateNumbers));
        }
        static bool IsIndexOutOfOrder(int index, List<int> values)
        {
            return values.Count >= index && index >= 0 ? true : false;
        }
        static void Add(int number, List<int> values)
        {
            values.Add(number);
        }
        static void Insert(int index, int number, List<int> values)
        {
            values.Insert(index, number);
        }
        static void Remove(int index, List<int> values)
        {
            values.RemoveAt(index);
        }
        static void Shiftleft(int number, List<int> values)
        {
            List<int> sorted = values;
            //int buffer = 0;


            for (int i = 0; i < number; i++)
            {
                sorted.Add(values[0]);
                sorted.RemoveAt(0);
                //buffer = values[0];
                //values[0] = values[values.Count];
                //values[values.Count] = buffer;
            }
            manupalateNumbers = sorted;
        }
        static void ShiftRight(int number, List<int> values)
        {
            List<int> sorted = values;
            //int buffer = 0;


            for (int i = 0; i < number; i++)
            {
                sorted.Reverse();
                sorted.Add(values[0]);
                sorted.RemoveAt(0);
                sorted.Reverse();
                //buffer = values[values.Count];
                //values[values.Count] = values[0];
                //values[0] = buffer;
            }
            manupalateNumbers = sorted;
        }

    }
}
