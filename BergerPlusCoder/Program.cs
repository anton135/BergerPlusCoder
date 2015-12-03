using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BergerPlusLib;

namespace BergerPlusCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            BergerPCoder pp = new BergerPCoder();
            //pp.LenthOfInfo = 8;
            foreach (var item in pp.GenerateWeightedCombination("0110100001"))
            {
                Console.WriteLine(item.Value+ " - "+ item.Key);
            }
            Console.WriteLine(pp.CodeBinaryStringBlock("0110100001"));
            Console.WriteLine("Mu =" +pp.Mu);
            Console.WriteLine("R =" +pp.R);
            Console.ReadKey();
        }
    }
}
