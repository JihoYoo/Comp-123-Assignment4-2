/*  
 *  Author's name:Jiho Yoo  
 *  Date : 3/20/2015  
 *  Program description : Array Practice 2 : Airline Reservations System 
 *  Revision History :  
 *                    3/17/2015 set up the values 
 *                    3/19/2015 Initialize all the elements and assigned seat.
 *                    3/20/2015 find out some errors 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_2_300813612_JihoYoo_COMP123
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int choice = 0;
            
            Flight flight = new Flight();
            bool quit = false; //to quit
            while (!quit) //while loop
            {
                Console.WriteLine("++++++++++++++++++++++++++++++");
                Console.WriteLine("+    Welcome to AirCanada    +");
                Console.WriteLine("+                            +");
                Console.WriteLine("+    1. First class          +");
                Console.WriteLine("+    2. Economy class        +");
                Console.WriteLine("+    3. Exit                 +");
                Console.WriteLine("+                            +");
                Console.WriteLine("++++++++++++++++++++++++++++++");
                Console.Write("Choice number: ");
                
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    choice = 0;
                }

                switch (choice) //switch numbers to represent values.
                {
                    case 1:
                        flight.firstClass();
                        break;
                    case 2:
                        flight.economyClass();
                        break;
                    case 3:
                        quit = true;
                        Console.WriteLine();
                        break;
                    default:
                        
                        Console.WriteLine();
                        Console.WriteLine("Please check your number!!!");
                        Console.WriteLine();
                        break;
                }
            }
        }   
    }
}
