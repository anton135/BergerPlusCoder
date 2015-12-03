using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BergerPlusLib
{
    public class BergerPCoder
    {
        public int LenthOfInfo { get; set; }

        public int Mu 
        {
            get
            {
                int i = 0;

                while (true)
                {
                    int a = LenthOfInfo;
                    int b = a + i;
                    if (a + i > Math.Pow(2, (i - 1)) && a + i < Math.Pow(2, i))
                    {
                        break;
                    }
                    i++;
                }
                return i;
            }
        }

        public int R
        {
            get
            {
                double TerribleFormulaValue = ((LenthOfInfo + Mu) * ((LenthOfInfo + Mu + 1) / 2)) - (2 * Mu) + 1;// i = mu

                int r = (int)Math.Ceiling(Math.Log(TerribleFormulaValue, 2));
                return r;
            }
        }
       
       //private int 
       public BergerPCoder()
       {
           
       }

        public Dictionary<int,char> GenerateWeightedCombination(string _binaryBlock)
        {
            int i=3;
            Dictionary<int,char> weightedComb = new Dictionary<int,char>();
            foreach (char c in _binaryBlock)
            {
                while(Math.Floor(Math.Log(i,2))==Math.Log(i,2))  //целое ли
                {
                    i++;
                }
                weightedComb.Add(i,c);
                i++;
            }
            return weightedComb;
        }
       
       //public string CodeBlock(string _line)
       //{
       //    string binary = stringToBinary(_line);
       //    int countOfOnes = 0;
       //    foreach (char c in binary)
       //    {
       //        if (c == '1')
       //        {
       //            countOfOnes++;
       //        }
       //    }


       //    return binary+calcAdditionalPart(countOfOnes);

       //}

       public string CodeBinaryStringBlock(string _binary)
       {
           this.LenthOfInfo = _binary.Length;
           int sumOfOnesWeingts = 0;
           foreach (var item in GenerateWeightedCombination(_binary))
           {
               if (item.Value=='1')
               {
                   sumOfOnesWeingts+=item.Key;
               }
           }


           return _binary + calcAdditionalPart(sumOfOnesWeingts);

       }
        //public string DecodeBinaryStringBlock(string _binary)
        //{
        //    string inform = "", check = "";
        //    for (int i = 0; i < _binary.Length; i++)
        //    {
        //        if (i < LenthOfBlock)
        //        {
        //            inform += _binary[i];
        //        }
        //        else
        //        {
        //            check += _binary[i];
        //        }
        //    }
        //    string invertedData = check.Replace('0', '*').Replace('1', '0').Replace('*', '1');
        //    int countOfOnes = 0;
        //    foreach (char c in inform)
        //    {
        //        if (c == '1')                     ///into method
        //        {
        //            countOfOnes++;
        //        }
        //    }

        //    if (countOfOnes == Convert.ToInt32(invertedData, 2))
        //    {
        //        return inform;
        //    }
        //    else
        //    {
        //        return "error";
        //    }

        //}
       // private string stringToBinary(string _line)
       //{
       //    byte[] bytes = ASCIIEncoding.Default.GetBytes(_line);
       //    string binary = "";
       //    foreach (byte b in bytes)
       //    {
       //        binary += ("0"+Convert.ToString(b, 2));
       //    }
       //    return binary;
       //}
        private string calcAdditionalPart(int _sumOfOnesWeingts)
       {
           string binary = Convert.ToString(_sumOfOnesWeingts, 2);
            
           
           while(true)
           {
               if (binary.Length < R)
               {
                   binary=binary.Insert(0, "0");
               }
               else
               {
                   break;
               }
           }
           string invertedData = binary.Replace('0', '*').Replace('1', '0').Replace('*', '1');
           return invertedData;
       }
    }
}
