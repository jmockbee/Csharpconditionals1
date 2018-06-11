using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpconditionals1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.summer:
                    Console.WriteLine(" the seasons are short ");
                    break;

                default:
                    Console.WriteLine(" I don not understand what your taling about");
                    break;
            }


        }
    }
}
