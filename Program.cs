using System;
using System.Collections.Generic;
using System.Linq;

// Part 1: Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
// int secretNumber = 492;
// Part 5: Make the secret number random between 1 and 100
int secretNumber = new Random().Next(1, 100);

//Part 1:  Display a message to the user asking them to guess the secret number.
Console.WriteLine("Try to guess the secret number!");
// Part 7: Prompt the user for a difficulty level before they are prompted to guess the number.
// Part 8: Add a difficulty level of "Cheater" which will cause the program to continue prompting the user until they get the answer correct.
Console.WriteLine("Select a difficulty level.");
Console.WriteLine("1. Easy\n2. Medium\n3. Hard\n4. Cheater (unlimted guesses) ");

// Convert the incoming user input to a number before saving it
int level = Int32.Parse(Console.ReadLine());

// Associate the level numbers with the number of guesses to give the player
Dictionary<int, int> counterCollection = new Dictionary<int, int>() {
    {1, 8},
    {2, 6},
    {3, 4},
    {4, int.MaxValue}
};
int levelTries = counterCollection[level];
int counter = levelTries;
// Phase 3:  Give the user four chances to guess the number.
for (int i = 1; i <= counter; i++) 
{
     // Part 1: Display a prompt for the user's guess.
    // part 4: Display the number of the user's current guess in the prompt.
    Console.Write($"Your guess ({i}): ");

    // Part 1: Take the user's guess as input and save it as a variable.
    string guess = Console.ReadLine();
    int guessInt;
    Int32.TryParse(guess, out guessInt);

    // Part 1: Display the user's guess back to the screen.
    // Part 2: No longer display the user's guess. They know what they guessed, right?
    // Console.WriteLine($"You guessed {guess}");

    // Phase 2: Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.
    if ( guessInt == secretNumber) 
    {
        Console.WriteLine("Whoah. You guessed the secret number! How the hell did you do that?");
        // part 4: End the loop early if the user guesses the correct number.
        return;
    } 
    else if (i <= levelTries - 1)
    {
        string hiLow = guessInt > secretNumber ? "high" : "low";
        Console.WriteLine($"Nope. You guessed too {hiLow}. Try again. You have {levelTries - i} chance{ (i == levelTries - 1 ? "" : "s") } left.");
    }
    else
    {
         Console.WriteLine($"You lost. The answer was {secretNumber}. Better luck next time");
    }
}
Console.WriteLine("Bye now!");