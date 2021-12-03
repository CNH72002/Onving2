using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onving2
{
    public class Menu
    {


        private int choosedInput;  // Menu class instance variable

        #region
        public void Start()  // Start Menu method.
        {
            int choice = -1;   // set the initial out value to -1.

            while (choice != 0)     //While loop to ensure that this loop terminates if the user input is zero (0).
            {
                WriteMenuText();  // Displays the first Menu.

                choice = ReadInputChoice();  // Read the input to the Main Menu and assign value to variable choice.

                choosedInput = choice;  // The out variable from the method ReadInputChoice() assigned to variable  
                                        // choosedInput.

                CurrentOperationMenu();  // This method displays the current operation choosed

            }

        }


        // This method validates the user input to the Menu and ensures it is within(0-2) inclusive
        private int ReadInputChoice()
        {
            bool validNum = false; // valid number initially set to zero
            int choice = 0;  // out variable initally set to zero

            do                   // The do-while loop to read user input and validate it
            {
                Console.Write("Make your choice: ");  // User input to the Menu choice requested
                string strInput = Console.ReadLine();  // Read user input to the Menu as a string
                validNum = int.TryParse(strInput, out choice); // Check if the string can be converted

                if (validNum) // Yes, the string input can be converted!
                {
                    if ((choice >= 0) && (choice <= 3))  // Check if the converted integer lies within 1 -3 inclusive

                        validNum = true;  // Then set validNum to be true if the above condition holds.

                }
                if (!validNum) // No. The string cannot be converted. Maybe contains non digit numbers.
                {
                    Console.WriteLine("Invalid input, try again!\n");   // Print out in the console window an error message!
                }

            } while (!validNum); // Repeat this operation until !validNum is false.

            return choice;  // Return the value of the out variable

        }


        private void CurrentOperationMenu()    // All the operations for this Application is selected here
        {
            switch (choosedInput)   // The switch block used the choosedInput as variable for the check.
            {
                case 0:
                    Environment.Exit(0); // Call this to exit program.
                    break;

                case 1:
                    CheckYouthOrPension();  // Call this method for youth, pensionare and group
                    break;

                case 2:
                    RepeatInputTenTimes(); // Call this method to reapeat and inpt 10 times
                    break;

                case 3:
                    GetTheThirdWord();  //Call this method to return the third word
                    break;

                default:
                    Console.WriteLine("Wrong choice try again!");   // default if no right choice was made
                    break;

            }

        }



        private void WriteMenuText()  // This method displays the first main Menu.
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("                  MAIN MENU                   ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("     Exit the program                        :0");
            Console.WriteLine("     Youth, pensioner or group               :1");
            Console.WriteLine("     Repeat input Ten Time                   :2");
            Console.WriteLine("     Get the third word from a sentence      :3");
            Console.WriteLine("----------------------------------------------");



        }



        //Sub menu to appear
        private void CheckYouthOrPension()
        {

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("                  SUB-MENU                   ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("     For individuals                         :1");
            Console.WriteLine("     For a group                             :2");
            Console.WriteLine("     To terminate the program                :3");
            Console.WriteLine("----------------------------------------------");


            int userResponse = ReadInputChoice2();

            if (userResponse == 1)
            {
                IndividualOperation();  //For individuals

            }
            else if (userResponse == 2)
            {
                GroupOperation();   //For groups of friends , family etc
            }
            else if (userResponse == 3)
            {
                Environment.Exit(3);   //Exit the program
            }
            else
            {

            }

            Console.WriteLine("-------------------------------");


        }


        #endregion






        #region For individuals
        private void IndividualOperation()
        {

            int age = ReadInputChoice3();
            if (age > 5 && age < 20)
            {
                //Youth price
                Console.WriteLine("Youth price = SEK 80");
                Console.WriteLine();
                

            }
            if (age >= 20 && age < 64)
            {
                //Adult price
                Console.WriteLine("Standard price = SEK 120");
                Console.WriteLine();


            }
            if (age >= 64 && age <= 100)
            {
                //pensioner price
                Console.WriteLine("Retirement price = SEK 90");
                Console.WriteLine();

            }
            if (age > 100 || age <= 5)
            {
                //Free
                Console.WriteLine("Price = SEK 0 -- free");
                Console.WriteLine();

            }
        }


        #endregion  For individuals For individuals



        #region  For group

        int sum ;
        int noOfPeople;

        //This method enables the program to compute a group cost using the number of people and their respective ages
        private void GroupOperation()
        {
             noOfPeople = ReadInputChoice4();
            sum = 0;

            for (int i = 0; i < noOfPeople; i++)
            {
                Console.Write("What is your age person" + (i + 1) + " " );  // User input to the Menu choice requested
                IndividualOperation2();

            }

            //Print the sum
            Console.WriteLine("Total cost for " + noOfPeople + " people in this group is  SEK " + sum);

        }


        //For individuals
        private void IndividualOperation2()
        {

            int age = ReadInputChoice5();
            if (age > 5 && age < 20)
            {
                //Youth price
                Console.WriteLine("Youth price = SEK 80");
                sum += 80;
                Console.WriteLine();

            }
            if (age >= 20 && age < 64)
            {
                //Adult price
                Console.WriteLine("Standard price = SEK 120");
                sum += 120;
                Console.WriteLine();

            }
            if (age > 64 && age < 100)
            {
                //pensioner price
                Console.WriteLine("Retirement price = SEK 90");
                sum += 90;
                Console.WriteLine();
            }
            if (age > 100 || age <= 5)
            {
                //Free
                Console.WriteLine("Price = SEK 0 -- free");
                sum += 0;
                Console.WriteLine();

            }


        }


        #endregion
        








        #region



        // This method validates the user input to the Menu and ensures it is within(0-2) inclusive
        private int ReadInputChoice2()
        {
            bool validNum = false; // valid number initially set to zero
            int choice = 0;  // out variable initally set to zero

            do                   // The do-while loop to read user input and validate it
            {
                Console.Write("Make your choice: ");  // User input to the Menu choice requested
                string strInput = Console.ReadLine();  // Read user input to the Menu as a string
                validNum = int.TryParse(strInput, out choice); // Check if the string can be converted

                if (validNum) // Yes, the string input can be converted!
                {
                    if ((choice >= 1) && (choice <= 3))  // Check if the converted integer lies within 1 -3 inclusive

                        validNum = true;  // Then set validNum to be true if the above condition holds.

                }
                if (!validNum) // No. The string cannot be converted. Maybe contains non digit numbers.
                {
                    Console.WriteLine("Invalid input, try again!\n");   // Print out in the console window an error message!
                }

            } while (!validNum); // Repeat this operation until !validNum is false.

            return choice;  // Return the value of the out variable

        }





        private int ReadInputChoice3()
        {
            bool validNum = false; // valid number initially set to zero
            int choice = 0;  // out variable initally set to zero

            do                   // The do-while loop to read user input and validate it
            {
                Console.Write("What is your age: ");  // User input to the Menu choice requested
                string strInput = Console.ReadLine();  // Read user input to the Menu as a string
                validNum = int.TryParse(strInput, out choice); // Check if the string can be converted

                if (validNum) // Yes, the string input can be converted!
                {
                    if ((choice >= 0) && (choice <= 300))  // Check if the converted integer lies within 1 -300 inclusive

                        validNum = true;  // Then set validNum to be true if the above condition holds.

                }
                if (!validNum) // No. The string cannot be converted. Maybe contains non digit numbers.
                {
                    Console.WriteLine("Invalid input, try again! Max age is 300\n");   // Print out in the console window an error message!
                }

            } while (!validNum); // Repeat this operation until !validNum is false.

            return choice;  // Return the value of the out variable

        }






        private int ReadInputChoice4()
        {
            bool validNum = false; // valid number initially set to zero
            int choice = 0;  // out variable initally set to zero

            do                   // The do-while loop to read user input and validate it
            {
                Console.Write("How many are you in the group: ");  // User input to the Menu choice requested
               // Console.WriteLine();
                string strInput = Console.ReadLine();  // Read user input to the Menu as a string
                validNum = int.TryParse(strInput, out choice); // Check if the string can be converted

                if (validNum) // Yes, the string input can be converted!
                {
                    if ((choice >= 0) && (choice <= 100))  // Check if the converted integer lies within 1 -100 inclusive

                        validNum = true;  // Then set validNum to be true if the above condition holds.

                }
                if (!validNum) // No. The string cannot be converted. Maybe contains non digit numbers.
                {
                    Console.WriteLine("Invalid input, try again. NB!, Max group number is 100\n");   // Print out in the console window an error message!
                }

            } while (!validNum); // Repeat this operation until !validNum is false.

            return choice;  // Return the value of the out variable

        }



        private int ReadInputChoice5()
        {
            bool validNum = false; // valid number initially set to zero
            int choice = 0;  // out variable initally set to zero

            do                   // The do-while loop to read user input and validate it
            {
               
                string strInput = Console.ReadLine();  // Read user input to the Menu as a string
                validNum = int.TryParse(strInput, out choice); // Check if the string can be converted

                if (validNum) // Yes, the string input can be converted!
                {
                    if ((choice >= 0) && (choice <= 300))  // Check if the converted integer lies within 1 -300 inclusive

                        validNum = true;  // Then set validNum to be true if the above condition holds.

                }
                if (!validNum) // No. The string cannot be converted. Maybe contains non digit numbers.
                {
                    Console.WriteLine("Invalid input, try again! Max age is 300\n");   // Print out in the console window an error message!
                }

            } while (!validNum); // Repeat this operation until !validNum is false.

            return choice;  // Return the value of the out variable

        }


        #endregion


        #region


        //This method prints any input string ten times
        private void RepeatInputTenTimes()
        {
            Console.WriteLine("This will Repeat input string ten times");
            Console.Write("Enter a string ");
            string mystring = Console.ReadLine();

            Console.WriteLine("---------------------------------------------------");

            for(int i =0; i < 10; i++)   //Loop 10 times
            {
                Console.Write( (i+1) +"."+ mystring + ", ");
            }

            Console.WriteLine("\n-------------------------------------------------");
           

        }




      
        //This method return the third word in a statement or phrase
        private void GetTheThirdWord()
        {
            try
            {
                Console.WriteLine("Enter the statement");

                string strInput = Console.ReadLine();

                string[] words = strInput.Split(' ');  // Row split

                Console.WriteLine("-----------------------------");

                Console.WriteLine("The third word is : " + words[2]);    //Print the third wrod

                Console.WriteLine("-----------------------------");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error happens because : " + ex.Message);

            }
            //
            


        }


        #endregion



    }

}
