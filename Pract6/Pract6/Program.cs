using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parse()
            string dateString1 = "2023-10-15";
            DateTime date1 = DateTime.Parse(dateString1);
            Console.WriteLine($"Parsed date using Parse(): {date1}");

            //ParseExact()
            string dateString2 = "15-10-2023";
            string format = "dd-MM-yyyy";
            DateTime date2 = DateTime.ParseExact(dateString2, format, CultureInfo.InvariantCulture);
            Console.WriteLine($"Parsed date using ParseExact(): {date2}");

            //TryParse()
            string dateString3 = "2023/10/15";
            if (DateTime.TryParse(dateString3, out DateTime date3))
            {
                Console.WriteLine($"Parsed date using TryParse(): {date3}");
            }
            else
            {
                Console.WriteLine("Failed to parse date using TryParse().");
            }

            //TryParseExact()
            string dateString4 = "2023-15-10"; // Неверный формат
            string format2 = "yyyy-dd-MM";
            if (DateTime.TryParseExact(dateString4, format2, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date4))
            {
                Console.WriteLine($"Parsed date using TryParseExact(): {date4}");
            }
            else
            {
                Console.WriteLine("Failed to parse date using TryParseExact().");
            }
        }
    }
}
