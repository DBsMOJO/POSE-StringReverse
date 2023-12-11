/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 3.ACIF
 *--------------------------------------------------------------
 *              Daniel Binder, 11.12.2023
 *--------------------------------------------------------------
 * Description:
 * ...
 *--------------------------------------------------------------
*/

using System;

namespace StringReverse
{
    public class Program
    {
        public static void Main()
        {
            string input,
                output = string.Empty;

            // Input
            Console.Write("Geben Sie einen Text ein: ");
            input = Console.ReadLine();

            // Processing
            for (int i = input.Length; i > 0; --i)
            {
                output += input[i - 1];
            }

            // Output
            Console.WriteLine(output);
        }
    }
}
