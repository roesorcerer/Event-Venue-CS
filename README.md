# Event Venue Ticket Pricing Calculator

Welcome to the Event Venue Ticket Pricing Calculator! This simple console application allows you to calculate the total cost of tickets for different seating options at an event. You can select from five different ticket types and specify the number of tickets you'd like to purchase. The program will then display the ticket type, price per ticket, the number of tickets sold, and the total cost.

## Getting Started

To use this program, follow these steps:

1. Clone or download the code repository to your local machine.
2. Open the code in a C# development environment, such as Visual Studio.
3. Build and run the program.

## Program Usage

Upon running the program, you will see an introductory statement explaining the purpose of the program and a list of available ticket options:

```
Welcome to the event venue program to help you calculate your selected ticket prices.

Please select the ticket you are looking to purchase and enter the corresponding selection:
    1) Orchestra
    2) Floor
    3) Tier 1
    4) Tier 2
    5) Tier 3
```

Enter the number corresponding to your desired ticket type and press Enter. The program will prompt you to enter the number of tickets you want to purchase. After entering the quantity, the program will display a summary of your selection, including the ticket type, price per ticket, the number of tickets sold, and the total cost.

## Example Output

Here is an example of what the program's output might look like:

```
You have selected the Orchestra ticket valued at $100 each.
Please enter the number of tickets purchased: 2

Type of Ticket        Ticket Price        # of Tickets Sold        Cost
Orchestra             $100                2                         $200
```

## Note

- The program assumes that the user will enter valid numeric input for ticket selection and the number of tickets. It does not include extensive error handling.

Feel free to use and modify this code as needed for your specific event ticket pricing calculations. Enjoy calculating ticket costs for your event!
