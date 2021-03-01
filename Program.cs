using System;
using System.Collections.Generic;
using System.Linq;



// Display a message to the user asking them to guess the secret number.
System.Console.WriteLine("Try to guess the secret number!");
// Display a prompt for the user's guess.
System.Console.Write("Your guess: ");

// Take the user's guess as input and save it as a variable.
string guess = System.Console.ReadLine();

// Display the user's guess back to the screen.
Console.WriteLine($"You guessed {guess}");
