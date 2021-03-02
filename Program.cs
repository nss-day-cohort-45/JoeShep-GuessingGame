using System;
using System.Collections.Generic;
using System.Linq;


//Part 1:  Display a message to the user asking them to guess the secret number.
Console.WriteLine("Try to guess the secret number!");
// Phase 3:  Give the user four chances to guess the number.
for (int i = 0; i < 4; i++) 
{
    // Part 1: Display a prompt for the user's guess.
    Console.Write("Your guess: ");

    // Part 1: Take the user's guess as input and save it as a variable.
    string guess = Console.ReadLine();
    int guessInt;
    Int32.TryParse(guess, out guessInt);

    // Part 1: Display the user's guess back to the screen.
    // Part 2: No longer display the user's guess. They know what they guessed, right?
    // Console.WriteLine($"You guessed {guess}");

    // Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
    int secretNumber = 492;

    // Phase 2: Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.
    if ( guessInt == secretNumber) 
    {
        Console.WriteLine("Whoah. You guessed the secret number! How the hell did you do that?");
    } 
    else if (i <= 2)
    {
        Console.WriteLine($"Nope. Try again. You have {3 - i} chance{ (i == 2 ? "" : "s") } left.");
    }
}
// Console.WriteLine("Sorry, you lost. Better luck next time.")

