using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public static class ExtensionMethods
    {
        public static string ToNAMoneyFormat(double value, bool owo)
        {
            if (owo == true)
            {
                value = Math.Round(value, 2);


                string formatted = value.ToString("C2");

                return formatted;
            }
            else
            {
                string formatted = value.ToString();

                return formatted;
            }
        }
    }
}
