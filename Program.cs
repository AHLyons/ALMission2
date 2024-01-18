using IPMission2;
using System;

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
        ThrowDice.RollDice(number);

        //Get the percentages
        int twos = (rolls.Count(x => x == 2) / num) * 10);
        int threes = (rolls.Count(x => x == 3) / num) * 10);
        int fours = (rolls.Count(x ==> x == 4) / num) * 10);
        int fives = (rolls.Count(x ==> x == 5) / num) * 10);
        int sixes = (rolls.Count(x ==> x == 6) / num) * 10);
        int sevens = (rolls.Count(x ==> x == 7) / num) * 10);
        int eights = (rolls.Count(x ==> x == 8) / num) * 10);
        int nines = (rolls.Count(x ==> x == 9) / num) * 10);
        int tens = (rolls.Count(x ==> x == 10) / num) * 10);
        int elevens = (rolls.Count(x ==> x == 11) / num) * 10);
        int twelves = (rolls.Count(x ==> x == 12) / num) * 10);

        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS\n Each \"*\" represents 1% of the total number of rolls. \nTotal number of rolls = " + num);
        System.Console.WriteLine("2: " + twos);
        System.Console.WriteLine("3: " + threes);
        System.Console.WriteLine("4: " + fours);
        System.Console.WriteLine("5: " + fives);
        System.Console.WriteLine("6: " + sixes);
        System.Console.WriteLine("7: " + sevens);
        System.Console.WriteLine("8: " + eights);
        System.Console.WriteLine("9: " + nines);
        System.Console.WriteLine("10: " + tens);
        System.Console.WriteLine("11: " + elevens);
        System.Console.WriteLine("12: " + twelves);
    }
}