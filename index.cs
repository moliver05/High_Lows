using System;

class NumberGame {

    public int initialNumber = 50;
    public int upperBound = 100;
    public int lowerBound = 0;
    public int NumberFinder (string direction) {
        int newNumber = initialNumber;
        if (direction == "Lower") {
            upperBound = initialNumber;
            newNumber -= ((initialNumber - lowerBound) / 2);
            initialNumber = newNumber;
        } else {
            lowerBound = initialNumber;
            newNumber += ((upperBound - initialNumber) / 2);
            initialNumber = newNumber;
        }
        return newNumber;
    }
}

class Program {
    public static void Main () {
        Console.WriteLine ("Would you like to play the higher/lower game? (Y/N)");
        if (Console.ReadLine () == "y") {
            Console.WriteLine ("Okay!");
        } else {
            Console.WriteLine ("Goodbye!");
            System.Environment.Exit(1);
        }
        NumberGame myNumber = new NumberGame ();
        Console.WriteLine ("Is this your number higher or lower than " + myNumber.initialNumber + "? (Higher/Lower/Correct)");
        string direction = Console.ReadLine ();
        if (direction == "Correct") {
            Console.WriteLine ("Yay!");
        } else {
            while (direction != "Correct") {
                Console.WriteLine ("Is this your number higher or lower than " + myNumber.NumberFinder (direction) + "? (Higher/Lower/Correct)");
                direction = Console.ReadLine ();
            }
        }

    }
}
