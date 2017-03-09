using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaconSandwich
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<string> yesAnswers = new System.Collections.Generic.List<string>() { "yes", "true", "aye", "yep", "1" };  //everything is lowercase

            string order = string.Empty;

            bool breakfast = false;



            Console.WriteLine("Good Morning!");



            while (breakfast == false)

            {

                Console.WriteLine("Would you like a bacon sandwich?");



                order = Console.ReadLine();



                breakfast = yesAnswers.Contains(order.ToLower());  //now use ToLower so that I convert the value to be all lower case. I don't have to worry about uppercase now. 



                if (breakfast == false)

                {

                    Console.WriteLine("Suit yourself. Next in line, please!\n");

                    continue;       //go through loop again from the start and ignore rest of logic in this iteration.

                }



                Console.WriteLine("How many rashers of bacon would you like?");



                string rashers = string.Empty;

                int baconAmount = 0;



                do

                {

                    //read rashers value here only.

                    rashers = Console.ReadLine();  // allows the user to input a value



                    //the int parse only happens here, nowhere else, so makes logic flow clearer

                    if (int.TryParse(rashers, out baconAmount) == true)

                    {

                        if (baconAmount < 2)

                        {

                            Console.WriteLine("Sorry, we don't do bacon sandwiches with less than two rashers! Please try another amount.");

                        }

                        else if (baconAmount > 6) // your logic had a flaw: If allowed 6 rashers, then using >= 6 would have failed when the user entered 6!

                        {

                            Console.WriteLine(rashers + " is a lot of bacon! Choose between 2 and 6 rashers"); // error message

                        }

                        else

                        {

                            Console.WriteLine("Enjoy your sandwich.");

                            break; //exit the loop. We have a valid value and we can make the sandwich.

                        }

                    }

                    else

                    {

                        Console.WriteLine("Sorry, I didn't understand that! Please try again.");
                    
                    }

                } while (baconAmount < 2 || baconAmount > 6);  // this loop will repeat until rashers is 6 or below


            }//this loop continues until you get a valid yes/no



            Console.WriteLine("See you again soon");

            Console.ReadLine();   
        }
    }
}
