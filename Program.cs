using System;

namespace NumberToText.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string isNegative = "";
            try
            {
                Console.WriteLine("Enter a Number");
                string number = Console.ReadLine();
                number = Convert.ToDouble(number).ToString();

                if (number.Contains("-"))
                {
                    isNegative = "Minus ";
                    number = number.Substring(1, number.Length - 1);
                }
                if (number == "0")
                {
                    Console.WriteLine("The number in text is \nZero");
                }
                else
                {
                    Console.WriteLine("The number in text is \n{0}", isNegative + NumberToTextHelper.ConvertToWords(number));
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
