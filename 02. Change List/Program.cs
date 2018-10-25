using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lineToManipulate = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string comandEnd = Console.ReadLine();
                if (comandEnd == "end")
                {
                    break;
                }
                string[] comand = comandEnd.Split();

                switch (comand[0])
                {
                    case "Delete":
                        lineToManipulate.RemoveAll(x=> x-int.Parse(comand[1])==0);
                        break;
                    case "Insert":
                        lineToManipulate.Insert(int.Parse(comand[2]), int.Parse(comand[1]));
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(" ",lineToManipulate));
        }
    }
}
