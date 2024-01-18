using Mission02;
public class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the dice throwing simulator!"); /* necessary code to display*/
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        int rolls; /* defining integer variable */
        rolls = int.Parse(System.Console.ReadLine());
        DiceRoller dr = new DiceRoller(); /* creating an instance (?) */
        int[] results = dr.RollDice(rolls); /* calling the array */
        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + rolls);

        for (int i = 0; i < results.Length; i++) /* loop to help display the code */
        {
            double percentage = (double)results[i] / rolls * 100;
            System.Console.Write($"{i + 2}: {new string('*', (int)Math.Round(percentage))} "); /* apparently, write and write line are different ... */
            System.Console.WriteLine($"({percentage:F2}%)");
        }

        System.Console.WriteLine("\nThank you for using the Dice Rolling Simulator. Goodbye!");
    }
}