//Author: Tanner Greenwood
// Create a program to simulate the rolling of 2 dice displaying the percentage of times each sum of the dice was rolled
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize variables to hold total dice rolls and array to hold the sum of the dice rolls
            int rolls = 0;
            int[] counts = new int[11];

            //give the introduction to the user
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.WriteLine("How many dice rolls would you like to simulate?\n");

            //retrieve user input for number of rolls
            rolls = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS\n" + "Each \"*\" represents 1% of the total rolls.");
            Console.WriteLine("Total number of rolls = " + rolls);

            //initialize randomization variable
            Random dice1 = new Random();

            //add up number of rolls for each value and add into the array
            for (int i = 0; i < rolls; i++)
            {
                int num = dice1.Next(1, 7);
                int num2 = dice1.Next(1, 7);
                int roll = num + num2;
                //Determine which value the roll falls under
                switch (roll)
                {
                    case 2:
                        counts[0] = counts[0] + 1;
                        break;
                    case 3:
                        counts[1] = counts[1] + 1;
                        break;
                    case 4:
                        counts[2] = counts[2] + 1;
                        break;
                    case 5:
                        counts[3] = counts[3] + 1;
                        break;
                    case 6:
                        counts[4] = counts[4] + 1;
                        break;
                    case 7:
                        counts[5] = counts[5] + 1;
                        break;
                    case 8:
                        counts[6] = counts[6] + 1;
                        break;
                    case 9:
                        counts[7] = counts[7] + 1;
                        break;
                    case 10:
                        counts[8] = counts[8] + 1;
                        break;
                    case 11:
                        counts[9] = counts[9] + 1;
                        break;
                    case 12:
                        counts[10] = counts[10] + 1;
                        break;
                }
            }
            Console.Write("\n");

            //array to hold the asterisks
            string[] stars = new string[11];

            //Calculate pct of total for each count and then add the string of * to another array
            for (int i = 0; i < 11; i++)
            {
                string pctgs = "";
                int pct = Convert.ToInt32((Math.Round(counts[i] / (double)rolls, 2)) * 100);
    
                for (int i2 = 0; i2 < pct; i2++)
                {
                    pctgs = pctgs + "*";
                }

                stars[i] = pctgs;

            }

            // Print out the dice sums and the percentage ****
            for (int i = 0; i < 11; i++)
            {
                    int diceamt = i + 2;
                    Console.WriteLine(diceamt + ": " + stars[i]);
            }

            // Display final statement
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");


            // keep console open to see results
            Console.ReadKey();





        }
    }
}
