//T. Robert Ward    8/24/14
//Assignment # 1-2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trwREVIEWLAB_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            //int day, month, year;
            MagicDate checkToSeeIfMagic = new MagicDate();
            
            Console.WriteLine("*****  MagicDate  *****\n\n");
            Console.Write("Please enter in the Day - [ 1 through 31 ]: ");
            input = Console.ReadLine();
            checkToSeeIfMagic.Day = int.Parse(input);

            Console.Write("Please enter in the Month - [ 1 through 12 ]: ");
            input = Console.ReadLine();
            checkToSeeIfMagic.Month = int.Parse(input);

            Console.Write("Please enter in the Year - [ 00 through 99 ]: ");
            input = Console.ReadLine();
            checkToSeeIfMagic.Year = int.Parse(input);

            if ( checkToSeeIfMagic.DetermineIfMagic() == true )
                Console.WriteLine("This is a Magic Date !!!!");
            else
                Console.WriteLine("This is not a magic date.");

            Console.Write("Press Enter Key");
            input = Console.ReadLine();
        }
    }
}
