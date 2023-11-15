using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberVerifier
{
    public class ISBN
    {
        public static bool VerifyISBNNumber(string isbnString)
        {
            bool verified = false;
            isbnString = isbnString.Replace("-", "");
            var controllNumber = int.Parse(isbnString.Substring(isbnString.Length - 1, 1));
            isbnString = isbnString.Substring(0, isbnString.Length - 1);

            var individualNumberFromIsbnList = new List<int>();

            foreach (char intDigit in isbnString)
            {
                if (char.IsDigit(intDigit))
                {
                    individualNumberFromIsbnList.Add(int.Parse(intDigit.ToString()));
                }
            }

            if (individualNumberFromIsbnList.Count > 10)
            {
                var multiplier = 1;
                var counter = 0;

                foreach (var digit in individualNumberFromIsbnList)
                {
                    counter += digit * multiplier;
                    if (multiplier == 1)
                        multiplier = 3;
                    else
                        multiplier = 1;
                    
                }
                var remainder = counter % 10;
                var comparerToControlDigit = 10 - remainder;

                if (comparerToControlDigit == controllNumber)
                {
                    verified = true;
                }

            }
            else
            {
                var multiplier = 10;
                var counter = 0;

                foreach (var digit in individualNumberFromIsbnList)
                {
                    counter += digit * multiplier;
                    multiplier--;
                }
                var remainder = counter % 11;
                if (11 - remainder == controllNumber)
                {
                    verified = true;
                }


            }
            


            return verified;
        }
    }
}
