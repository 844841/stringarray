using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringarray
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create an array with six strings.
            string[] array = new string[6];
            array[0] = "chittu";
            array[1] = "chotu";
            array[2] = "motu";
            array[3] = "patlu";
            array[4] = "chintu";
            array[5] = "bittu";

            // Call the methods.
            string result1 = ConvertStringArrayToString(array);
            string result2 = ConvertStringArrayToStringJoin(array);

            // Display the results.
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        static string ConvertStringArrayToString(string[] array)
        {
            // Concatenate all the elements into a StringBuilder.
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append('.');
            }
            return builder.ToString();
        }

        static string ConvertStringArrayToStringJoin(string[] array)
        {
            // Use string Join to concatenate the string elements.
            string result = string.Join(".", array);
            return result;
        }
    }
}






