using System;

namespace helloVSCode
{
    class Program
    {
        static void Main(string[] args)
        {

            //Option menu given to user to select target operations
            Console.WriteLine("Please select from one of the operations below:\n" +
            "1. Add two Numbers.\n" + "2. Subtract two Numbers.\n"+
            "3. Multiply two Numbers.\n" + "2. Divide two Numbers.\n");
                
            //User selection from the list
            Console.WriteLine("Please enter your desired operation");
            int userSelection = Int32.Parse(Console.ReadLine());

            //Statment to keep calculator running after first operation and until told to quit
            while(userSelection != null){

                //Statment to select correct opperations
                //Used for addition
                if (userSelection == 1) {
                    //Asks user for first digit to enter into the problem
                    Console.WriteLine("Please enter your first digit:");
                    //Takes first digit from user, as well as parse from string to int
                    int x = Int32.Parse(Console.ReadLine());

                    //Asks user for second digit to enter into the problem
                    Console.WriteLine("Please enter you second digit:");
                    //Takes second digit from user, as well as parse from string to int
                    int y = Int32.Parse(Console.ReadLine());

                    //Displayes addition results
                    Console.WriteLine(x + y);
                }   
                //Used for subtraction
                else if (userSelection == 2) {
                    //Asks user for first digit to enter into the problem
                    Console.WriteLine("Please enter your first digit:");
                    //Takes first digit from user, as well as parse from string to int
                    int x = Int32.Parse(Console.ReadLine());

                    //Asks user for second digit to enter into the problem
                    Console.WriteLine("Please enter you second digit:");
                    //Takes second digit from user, as well as parse from string to int
                    int y = Int32.Parse(Console.ReadLine());

                    //Displayes subtraction results
                    Console.WriteLine(x - y);
                }
                //Used for multiplaction 
                else if (userSelection == 3) {
                    //Asks user for first digit to enter into the problem
                    Console.WriteLine("Please enter your first digit:");
                    //Takes first digit from user, as well as parse from string to int
                    int x = Int32.Parse(Console.ReadLine());

                    //Asks user for second digit to enter into the problem
                    Console.WriteLine("Please enter you second digit:");
                    //Takes second digit from user, as well as parse from string to int
                    int y = Int32.Parse(Console.ReadLine());

                    //Displayes multiplcation results
                    Console.WriteLine(x * y);
                }        
                //Used for divison
                else if (userSelection == 4) {
                    //Asks user for first digit to enter into the problem
                    Console.WriteLine("Please enter your first digit:");
                    //Takes first digit from user, as well as parse from string to int
                    int x = Int32.Parse(Console.ReadLine());

                    //Asks user for second digit to enter into the problem
                    Console.WriteLine("Please enter you second digit:");
                    //Takes second digit from user, as well as parse from string to int
                    int y = Int32.Parse(Console.ReadLine());

                    //Displayes divison results
                    Console.WriteLine(x / y);        
                } else if {
                    //Ask user if they would like to select another operation or exit
                    //Option menu given to user to select target operations
                    Console.WriteLine("Please select from one of the operations below:\n" +
                                "1. Add two Numbers.\n" + "2. Subtract two numbers.");
                
                    //User selection from the list
                    Console.WriteLine("Please enter your desired operation");
                    userSelection = Int32.Parse(Console.ReadLine());
                }
            }


        }
    }
}
