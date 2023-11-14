using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventVenue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introductory statement to tell the user the type of program that they are running. 
            Console.WriteLine("Welcome to the event venue program to help you calculate your selected ticket prices.\r\n");
            //statement showing the ticket choices for the user to select. 
            Console.WriteLine(@"Please select the ticket you are looking to purchase and enter the corresponding selection:
                1)Orchestra
                2)Floor
                3)Tier 1
                4)Tier 2
                5)Tier 3");
            //variable declarations for user input and for the ticket prices. It will convert the selection into an int value.  
            string userSelection = Console.ReadLine();
            int number = Convert.ToInt32(userSelection);
            //variables for the ticket prices by type. 
            int orchestra = 100;
            int floor = 75;
            int tier1 = 50;
            int tier2 = 40;
            int tier3 = 35;

            //if/else statement for user selection. 
            if (number == 1)//using the declared variable from user input to perform an action. 
            {
                Console.WriteLine("You have selected the Orchestra ticket valued at $100 each.");//showing the ticket choice and base price. 
                Console.WriteLine("Please enter the number of tickets purchased");//statement to ask the user for input for how many tickets they would like. 
                string tickets;//variable set for tickets. This is set as a string since Console.ReadLine works in string values only. 
                tickets = Console.ReadLine();
                int ticketVal = Convert.ToInt32(tickets); //converting ticket variable to int value for calculation. 
                int totalPrice = ticketVal * orchestra; //takes the base price of tickets and multiplies that by the number of tickets requested. 
                Console.WriteLine("Type of Ticket\t\tTicket Price\t\t# of Tickets Sold\t\tCost\r\n" + "Ochestra\t\t" + orchestra + "\t\t\t" + ticketVal + "\t\t\t\t" + totalPrice);//output totals. 
                return;
            }

            else if (number == 2)//else if statement for the rest of the selections. Everything is mostly the same aside from variables and selection. 
            {
                Console.WriteLine("You have selected the Floor ticket valued at $75.");
                Console.WriteLine("Please enter the number of tickets purchased");
                string tickets;
                tickets = Console.ReadLine();
                int ticketVal = Convert.ToInt32(tickets);
                int totalPrice = ticketVal * floor;
                Console.WriteLine("Type of Ticket\t\tTicket Price\t\t# of Tickets Sold\t\tCost\r\n" + "Floor\t\t\t" + floor + "\t\t\t" + ticketVal + "\t\t\t\t" + totalPrice);
                return;
            }

            else if (number == 3)
            {
                Console.WriteLine("You have selected the Tier 1 ticket valued at $50.");
                Console.WriteLine("Please enter the number of tickets purchased");
                string tickets;
                tickets = Console.ReadLine();
                int ticketVal = Convert.ToInt32(tickets);
                int totalPrice = ticketVal * tier1;
                Console.WriteLine("Type of Ticket\t\tTicket Price\t\t# of Tickets Sold\t\tCost\r\n" + "Tier 1\t\t\t" + tier1 + "\t\t\t" + ticketVal + "\t\t\t\t" + totalPrice);
                return;
            }

            else if (number == 4)
            {
                Console.WriteLine("You have selected the Tier 2 ticket valued at $40.");
                Console.WriteLine("Please enter the number of tickets purchased");
                string tickets;
                tickets = Console.ReadLine();
                int ticketVal = Convert.ToInt32(tickets);
                int totalPrice = ticketVal * tier2;
                Console.WriteLine("Type of Ticket\t\tTicket Price\t\t# of Tickets Sold\t\tCost\r\n" + "Tier 2\t\t\t" + tier2 + "\t\t\t" + ticketVal + "\t\t\t\t" + totalPrice);
                return;
            }
            else if (number == 5)
            {
                Console.WriteLine("You have selected the Tier 3 ticket valued at $40.");
                Console.WriteLine("Please enter the number of tickets purchased");
                string tickets;
                tickets = Console.ReadLine();
                int ticketVal = Convert.ToInt32(tickets);
                int totalPrice = ticketVal * tier3;
                Console.WriteLine("Type of Ticket\t\tTicket Price\t\t# of Tickets Sold\t\tCost\r\n" + "Tier 3\t\t\t" + tier3 + "\t\t\t" + ticketVal + "\t\t\t\t" + totalPrice);
                return;
            }
        }
    }
}
