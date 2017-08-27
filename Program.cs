using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerAugust28
{
    class Program
    {
        public void quit()//method for exiting the program
        {
            Console.WriteLine("Nobody likes a quitter...");
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            string userName;
            string userNameLower;
            string userLastName;
            string userLastNameLower;
            string userAge;
            int userAgeInt;
            string userBirthMonth;
            int userBirthMonthInt;
            string favColor;
            string userSiblings;
            int userSiblingsInt;

            int remainder = default(int);


            Program p = new Program();




            Console.WriteLine("I'm going to tell your fortune.  Give me your first name:");
            userName = Console.ReadLine();
            userNameLower = userName.ToLower();
            if (userNameLower == "quit")
            {

                p.quit();

            }

            Console.WriteLine("Great! Now tell me your last name:");
            userLastName = Console.ReadLine();
            userLastNameLower = userLastName.ToLower();
            if (userLastNameLower == "quit")
            {
                p.quit();
            }


            Console.WriteLine("Please enter your age:");
            userAge = Console.ReadLine().ToLower();
            if (userAge == "quit")
            {
                p.quit();
            }
            userAgeInt = int.Parse(userAge);
            remainder = userAgeInt % 2;



            Console.WriteLine("Please enter your birthday month as a number. \nFor example, enter 1 for January.");
            userBirthMonth = Console.ReadLine();
            if (userBirthMonth == "quit")
            {
                p.quit();
            }
            //userBirthMonthInt = int.Parse(Console.ReadLine());
            userBirthMonthInt = int.Parse(userBirthMonth);

            string[] roygbiv = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
            Console.WriteLine("What is your favorite ROYGBIV color? \nEnter \"help\" for a list of ROYGBIV colors.");
            favColor = Console.ReadLine().ToLower();
            if (favColor == "help")
            {
                foreach (string color in roygbiv)
                {
                    Console.Write(color + "  ");

                }
                Console.WriteLine("\nWhich one is your favorite color?");
                favColor = Console.ReadLine().ToLower();
            }
            if (favColor == "quit")
            {
                p.quit();
            }

            Console.WriteLine("How many siblings do you have?");
            userSiblings = Console.ReadLine().ToLower();
            if (userSiblings == "quit")
            {
                p.quit();
            }
            userSiblingsInt = int.Parse(userSiblings);



            //Beging fortune telling with conditional statements
            Console.Write(string.Concat(userName, " ", userLastName, " will retire in "));

            //determine the retirement year from userAge
            if (remainder == 1)
            {
                Console.Write("10 years with");
            }
            else
                Console.Write("20 years with");



            //determining bank account based on number of birth month

            if (userBirthMonthInt <= 0)
            {
                Console.Write(" $0.00 in the bank, a vacation home in ");
            }
            else if (userBirthMonthInt >= 1 && userBirthMonthInt <= 4)
            {
                Console.Write(" $25,000 in the bank, a vacation home in ");
            }
            else if (userBirthMonthInt >= 5 && userBirthMonthInt <= 8)
            {
                Console.Write(" $250,000 in the bank, a vacation home in ");
            }
            else if (userBirthMonthInt >= 9 && userBirthMonthInt <= 12)
            {
                Console.Write(" $1 million in the bank, a vacation home in ");
            }
            else
            {
                Console.Write(" $0.00 in the bank, a vacation home in ");
            }


            //using siblings to determine vacation home location  

            if (userSiblingsInt == 0)
            {
                Console.Write("Aspen and ");
            }
            else if (userSiblingsInt == 1)
            {
                Console.Write("Montana and ");
            }
            else if (userSiblingsInt == 2)
            {
                Console.Write("Naples, FL and ");
            }
            else if (userSiblingsInt == 3)
            {
                Console.Write("Paris and ");
            }
            else if (userSiblingsInt > 3)
            {
                Console.Write("Rehobeth Beach and ");
            }
            else
            {
                Console.Write("Detroit and ");
            }

            //Determining the mode of transportation based on favorite color
            if (favColor == "red")
            {
                Console.Write("a Bentley.");
            }
            else if (favColor == "orange")
            {
                Console.Write("a yacht.");
            }
            else if (favColor == "yellow")
            {
                Console.Write("a helicopter.");
            }
            else if (favColor == "green")
            {
                Console.Write("a Lear jet.");
            }
            else if (favColor == "blue")
            {
                Console.Write("a dinghy.");
            }
            else if (favColor == "indigo")
            {
                Console.Write("a truck.");
            }
            else
            {
                Console.Write("a limousine.");
            }

            Console.WriteLine();




        }
    }
}

