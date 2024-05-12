using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment3_Mam.NumExpression
{
    public static class EnglishNumToWords
    {
        //עשרות אנגלית
        public static string[] Multiplier()
        {
            return new string[] { "", "Thousand", "Million", "Billion", "Trillion" };
        }
        public static string Hundred()
        {
            return "Hundred";
        }
        public static string Zero()
        {
            return "Zero";
        }
        public static string[] First_twenty()
        {
            return new string[]{
            "",        "One",       "Two",      "Three",
            "Four",    "Five",      "Six",      "Seven",
            "Eight",   "Nine",      "Ten",      "Eleven",
            "Twelve",  "Thirteen",  "Fourteen", "Fifteen",
            "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };
        }
        public static string[] Tens()
        {
            return new string[]{ "","","Twenty", "Thirty",
                          "Forty",   "Fifty",  "Sixty",
                          "Seventy", "Eighty", "Ninety" };
        }
    }
}
