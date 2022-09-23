using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Tristan DeMaria, CSCI-1630, 10/4/21
 * Create an application that calculates the value of pi using the
 * Gregory/Leibniz formula. The calculator must output results at
 * 10; 1,000; 100,000; 500,000; 1,000,000; and a user-entered upper
 * value > 1,000,000.
 * Program must validate the user entry is a number greater than 1 million.
 * Program must end at number of iterations specified by user.
 * Iterations and Results must be formatted with commas and ten decimal places.
*/

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userentryString; //create string for user entry
            int userentry = 0, iteration; //create ints to convert user entry and get iterations
            double sum = 0, pi, result; //create floats for the sum, pi, and result for the G/L formula

            WriteLine("Tristan's Implementation of the Gregory/Leibniz Formula");
            WriteLine("");
            WriteLine("Please enter the number of times to run this calculation");

            //prompt user for their number, check that it is a number and that it is over 1 mil
            //otherwise, prompt again
            do {
                Write("Please Enter value > 1 million: ");
                userentryString = ReadLine();
                //use TryParse to validate the result and output it to an int without crashing
                //if user enters a string
                bool correct = int.TryParse(userentryString, out userentry);
            } while (userentry <= 1000000);

            WriteLine("------------------------------------------------------------");

            //run through each iteration, starting with 0, and add it to the sum
            //use the sum to calcualte pi when that iteration is reached
            //iterations are an index, so 9=10th iteration, 999=1000th iteration, so-on
            //make sure this is accurate in the strings.
            for (iteration = 0; iteration <= userentry; iteration++) {
                result = (double)(Math.Pow(-1, iteration) / (2 * iteration + 1));
                sum += result; //result gets added on to with each loop

                if (iteration == 9) {
                    pi = 4 * sum; //calculate pi
                    string piString = pi.ToString("N10"); //conver to string and set decimal palces
                    WriteLine($"At 10 iterations, the value of pi is {piString}"); //display result
                } else if (iteration == 999) {
                    pi = 4 * sum;
                    string piString = pi.ToString("N10");
                    WriteLine($"At 1,000 iterations, the value of pi is {piString}");
                } else if (iteration == 99999) {
                    pi = 4 * sum;
                    string piString = pi.ToString("N10");
                    WriteLine($"At 100,000 iterations, the value of pi is {piString}");
                } else if (iteration == 499999) {
                    pi = 4 * sum;
                    string piString = pi.ToString("N10");
                    WriteLine($"At 500,000 iterations, the value of pi is {piString}");
                } else if (iteration == 999999) {
                    pi = 4 * sum;
                    string piString = pi.ToString("N10");
                    WriteLine($"At 1,000,000 iterations, the value of pi is {piString}");
                } else if (iteration == (userentry - 1)) {
                    pi = 4 * sum;
                    string piString = pi.ToString("N10");
                    userentryString = userentry.ToString("N0");
                    WriteLine($"At {userentryString} iterations, the value of pi is {piString}");
                }
            }
            ReadLine();
        }
    }
}