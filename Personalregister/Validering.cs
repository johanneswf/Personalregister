using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal class Validering
    {
        public static string ValideraSträng(string buffer, string felmeddelande)
        {
            string valid;
            do
            {
                Console.Write(buffer);
                valid = Console.ReadLine();
                if (valid == "")
                    Console.WriteLine(felmeddelande);
            } while (valid == "");
            return valid;
        }

        public static double ValideraDubbel(string buffer, string felmeddelande)
        {
            double valid;
            do
            {
                Console.Write(buffer);
                Double.TryParse(Console.ReadLine(), out valid);
                if (valid == 0)
                    Console.WriteLine(felmeddelande);
            } while (valid == 0);
            return valid;
        }
    }
}
