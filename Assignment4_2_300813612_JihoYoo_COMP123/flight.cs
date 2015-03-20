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
    class Flight
    {
        //constructor method
        public Flight()
        {
            initializeElements();
        }

        //Initialize all the elements of the array to false to indicate that all the seats are empty.
        private void initializeElements()
        {
            for (int index = 0; index < seats.Length; index++)
            {
                this.seats[index] = false;
            }
        }

        private bool[] seats = new bool[11];

        //First class public method
        public void firstClass()
        {
            int i = 1;
            while (i < 6) // possible to choose seats from 1 to 5
            {
                if (seats[i] == false)
                {
                    this.seats[i] = true;
                    this.representChart();
                    break;
                }
                else if (i == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("first class is full!!!");
                    Console.WriteLine("Next flight leaves in 3 hours");
                    Console.WriteLine();
                }
                i++;
            }
        }

        // Economy class public method
        public void economyClass()
        {
            int j = 6;

            string changeSeat;

            while (j < 11) // possible to choose seats from 6 to 10
            {
                if (seats[j] == false)
                {
                    this.seats[j] = true;
                    this.representChart();
                    break;
                }

                else if (j == 10)
                {
                    Console.WriteLine();
                    Console.WriteLine("economy class is full!!!");
                    Console.WriteLine();
                    Console.Write("Do you want to change a seat for First Clss? y or n : "); //ask the person to change a ticket for First Class
                    changeSeat = Console.ReadLine();

                    if (changeSeat == "y")
                        firstClass();
                    else
                    {
                        Console.WriteLine("Next flight leaves in 3 hours");
                        Console.WriteLine();
                    }
                }
                j++;
            }
        }
        //one-dimensional array of type bool to represent the seating chart of the plane.
        public void representChart()
        {

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("|P: Available / N: Not Available              |");
            Console.WriteLine("|               Aavailable Seats              |");
            Console.WriteLine("|                   -front-                   |");
            Console.WriteLine("|                -first class-                |");
            Console.WriteLine("|     1       2        3        4        5    |");
            for (int index = 1; index < 6; index++)
            {

                if (this.seats[index] == true)
                    Console.Write("   | N |");
                else
                    Console.Write("    | P |");
            }
            Console.WriteLine();
            Console.WriteLine("|                                             |");
            Console.WriteLine("|                -Economy class-              |");
            Console.WriteLine("|     6       7        8         9      10    |");


            for (int index = 6; index < 11; index++)
            {
                if (this.seats[index] == true)
                    Console.Write("   | N |");
                else
                    Console.Write("    | P |");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
        }
    }
}


