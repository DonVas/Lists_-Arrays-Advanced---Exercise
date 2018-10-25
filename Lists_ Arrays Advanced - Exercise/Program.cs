using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists__Arrays_Advanced___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passingerOnTrane = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxPassinger = int.Parse(Console.ReadLine());
            
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
                    case "Add":
                        passingerOnTrane.Add(int.Parse(comand[1]));
                        break;
                    default:
                        break;
                }
                bool itsNumber = int.TryParse(comand[0],out int number);
                if (itsNumber==true)
                {
                    for (int i = 0; i < passingerOnTrane.Count; i++)
                    {                                                            
                        if (passingerOnTrane[i] + int.Parse(comand[0]) <= maxPassinger)
                        {

                            passingerOnTrane[i] = passingerOnTrane[i] + int.Parse(comand[0]);
                            break;
                        }                                             
                    }
                }
                
            }
            Console.WriteLine(string.Join(" ", passingerOnTrane));
        }
    }
}
