using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Type something then press Enter key");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed: " + userValue);
            //displays what was recieved by the program from the user input

            Console.WriteLine("Would you prefer what is behind door number 1, 2, or 3???");
            string userValue = Console.ReadLine();
            //string message = "";
            //if (userValue == "1")            
            //    message = "You won a new car!";      
            //else if (userValue == "2")          
            //    message = "You won a new yacht!";            
            //else if (userValue == "3")            
            //    message = "You won a CAT!";            
            //else
            //    message = "Sorry, I don't understand whatchu put. You lose! :(";

            ////ONLY omit brackets when if statment is followed by 1 line of code

            //Console.WriteLine(message);
            //Console.ReadLine();

            //the else ifs allow multiple input variations to be evaluated
            //else is if no condtions are satisfied

            //whatever is input by the user will be evaluated
            //if statements decide whether or not to execute
            //a block of code or not based on set circumstances


            string message = (userValue == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You won a {0}", message);
            //lots can be inserted after here         ^

            Console.ReadLine();
        }
    }
}
