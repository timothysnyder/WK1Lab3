using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk1Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool UserContinue = true ;

              

                Console.WriteLine("Please Enter Your First Name");
                string UserName = (Console.ReadLine());

                while (UserContinue == true)
            {

                    Console.WriteLine("Enter a Number Between 1 - 100:");
                int x = int.Parse(Console.ReadLine());

                if (x % 2 == 1)
                {

                    Console.WriteLine("Hello " + UserName + " Your Number Was " + x + " and Your Number is Odd");
                }

                else // even 
                {
                    if (x >= 2 & x < 25)
                        Console.WriteLine("Even and Less then 25");
                    else if (x >= 26 & x <= 60)
                        Console.WriteLine("Even");
                    else if (x > 60)
                        Console.WriteLine(x + "Even");
                }

                // Part II Check to see if number is EVEN AND between 2 <25 then Print "Even and Less then 25" 

                //Part III Check to see if number is EVEN AND between 26 <=60 then Print "EVEN"

                //Part IV Check to see if number is EVEN AND >60 then Print "Number AND Even"


                Console.WriteLine(UserName + "Do you wish to enter another number? y/n");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "no" || choice.ToLower() == "n")
                {
                    UserContinue = false;
                }

            } 

        }
    }
}
