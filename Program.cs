using ALMission2;
using System;
using System.Runtime.InteropServices.ComTypes;

internal class Program
{
    private static void Main(string[] args)
    {
        //Gather the input to start
        int number = 0;
        System.Console.WriteLine("Welcome to the throwing dice simulator!");
        System.Console.WriteLine("How many times would you like to roll?");
        number = int.Parse(System.Console.ReadLine());

        //Roll the dice
        ThrowDice td = new ThrowDice();

        int[] rolls = td.RollDice(number);

        //Get the percentages and output it
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS\n Each \"*\" represents 1% of the total number of rolls. \nTotal number of rolls = " + number);
        for (int i = 2; i <= 12; i++)
        {
            int percent = (int)(((double)rolls.Count(x => x == i) / number) * 100);
            string stars = new string('*', percent);
            System.Console.WriteLine($"{i}: {stars}");
        }

        //End the program
        System.Console.WriteLine("Thanks for playing!");
    }
}