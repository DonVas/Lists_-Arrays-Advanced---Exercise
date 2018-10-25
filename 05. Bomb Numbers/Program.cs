using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Bomb_Numbers
{
    class Program
    {
        static List<int> mineFilld;
        static int[] minePower;
        static void Main(string[] args)
        {
             mineFilld = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            minePower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int indexBomb = mineFilld.IndexOf(minePower[0]);

            RemoveFilld(indexBomb, minePower[1]);
        }
        static void RemoveFilld(int bombIndex,int number)
        {
            
            int positivIndex= Math.Abs(mineFilld.Count - (bombIndex + number));
            mineFilld.RemoveRange(bombIndex, positivIndex+1);

            int negativIndex= bombIndex - number;
            mineFilld.RemoveRange(negativIndex+number, negativIndex + number-1);
            if (negativIndex>0 && negativIndex> mineFilld.Count)
            {
                
            }
        }
    }
}
