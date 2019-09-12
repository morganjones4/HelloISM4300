/* 
 Author: Morgan Jones
 Date: 9/10/2019
 Comments: This is Deliverable 2, making conditional statements.
 */

using System;

namespace Deliverable_2__Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is asking for the user to give their input. 
            Console.WriteLine("What grade do you expect to get in ISM4300 with Professor Clinton Daniel?");
            Console.ReadKey(true);
        
            // This will gather the users input
        string input = Console.ReadLine();

        int grades = int.Parse(Console.ReadLine());
        
            // writting the letter that goes along with the number the user types in.
        if (int grades >= 90)
            {
                Console.WriteLine("Congrats, you have an A in the class!");
                
            }
            // Writting to show grade that the user inputs.
        else if ((int grades >= 80) && (int grades < 90))
        {
                Console.WriteLine("You have a B in the class!");
               
            }

            // Writting to show grade that the user inputs.
        else if (int grades < 80) && (int grades >= 70)
            
            {    
            Console.WriteLine("You will get a C in the class!");
                
            }

            // Writting to show grade that user inputs.
        else if (int grades < 70) && (int grades >= 60)
            {
                Console.Writeline("You will get a D in the class...");
                
            }
            // Writting to show grade the user inputs.
        else if (int grades < 60)
            {
            Console.WriteLine("You are going to fail the class...");
                
            }

}   
        // If they do not type in a number in any of the ranges listed above this message will appear.
        else
            {
              Console.Writeline("Please enter a number you think you will get in the course!");
            }
                

    
    
   






    }

}
