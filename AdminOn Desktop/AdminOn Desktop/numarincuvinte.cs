using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminOn_Desktop
{
    class numarincuvinte
    {
        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " millioane ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                if ((number / 1000) > 0 && (number / 1000) < 2)
                {
                    words += NumberToWords(number / 1000) + " mie ";
                    number %= 1000;
                }
                else
                {

                    words += NumberToWords(number / 1000) + " mii ";
                    number %= 1000;
                }
            }

            if ((number / 100) > 0)
            {
                if ((number / 100) > 0 && (number / 100) < 2)
                {
                    words += NumberToWords(number / 100) + " suta ";
                    number %= 100;
                }
                else
                {
                    words += NumberToWords(number / 100) + " sute ";
                    number %= 100;
                }
               
            }

            if (number > 0)
            {
                if (words != "")
                    words += " ";

                var unitsMap = new[] { "zero", "unu", "doi", "trei", "patru", "cinci", "sase", "sapte", "opt", "noua", "zece", "unsprezece", "doisprezece", "treisprezece", "paisprezece", "cinsprezece", "saisprezece", "saptesprezece", "optsprezece", "nouasprezece" };
                var tensMap = new[] { "zero", "zece", "douazeci", "treizeci", "patruzeci", "cincizeci", "saizeci", "saptezeci", "optzeci", "nouazeci" };
                var suteMap = new[] { "zero", "o", "doua" };
                if (number < 20)
                {
                    if (number < 3&& number > 0)
                    {
                        words += suteMap[number];
                    }
                    else
                        words += unitsMap[number];
                }
                   
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += " si " + unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}
