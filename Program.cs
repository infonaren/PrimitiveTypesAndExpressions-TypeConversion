using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitive_Types_And_Expressions___Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Type Conversion
            byte b = 1;
            int i = b; // This prevents the data loss

            Console.WriteLine(i);

            // Explicit Type Conversion
            int j = 2;
            byte k = (byte) j;

            Console.WriteLine(k);

            int a = 1000;
            byte c = (byte) a;

            Console.WriteLine(c);

            // Non-compatible Types
            var number = "1234";
            int l = Convert.ToInt32(number);

            Console.WriteLine(l);

            try
            {
                var allNumber = "1234";
                byte lastNumber = Convert.ToByte(allNumber);

                Console.WriteLine(lastNumber);

            }
            catch (Exception)
            {
                Console.WriteLine("The number couln't be converted to a byte.");
            }

            try
            {
                string alNumber = "true";
                bool laastNumber = Convert.ToBoolean(alNumber);

                Console.WriteLine(laastNumber);
            }
            catch (Exception)
            {
                Console.WriteLine("The number couln't be converted to a byte.");

            }
            /* 
              
            Overflow Exception: Value was either too large or too small for an unsigned byte.
            var allNumber = "1234";
            byte  lastNumber = Convert.ToByte(allNumber);

            Console.WriteLine(lastNumber);
             
             
             */
        }
    }
}
