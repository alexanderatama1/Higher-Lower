
// 1. Declare Variables - Random rng, int first, int second, string guess
using System.ComponentModel.Design;

int first, second;
string guess;

Random rng = new Random();

// 2. Assign first and second to random between 1 and 10
first = rng.Next(1, 11);
second = rng.Next(1, 11);

// 3. Output the first number
Console.WriteLine($"The first number is {first}.");

// 4. Prompt user whether the second number will be higher, lower, or equal.
// a. To simplify, we will ask them for H, L, or E.v
Console.Write("Will the second number be (H)igher, (L)ower, or E(qual): ");

// 5. Store
guess = Console.ReadLine().ToUpper();

// 6. Clear the console
Console.Clear();

// 7. Output the values of first and second.
Console.WriteLine($"The numbers were {first}, {second}");

// 8. if guess is higher
//   a. if first is less than second print right message.
//   b. else print wrong message
// 9. if guess is lower
//   a. if first is greater than second print right message.
//   b. else print wrong message
// 10. if guess is equal
//   a. if first is equal to second print right message.
//   b. else print wrong message
// 11. Otherwise print invalid message

if (guess == "H")
{
    if (first < second)
    {
        Console.WriteLine("You guessed higher and you were right!");
    }
    else
    {
        Console.WriteLine("You guessed higher and you were wrong!");
    }
    
}
else if (guess == "L")
{
    if (first > second)
    {
        Console.WriteLine("You guessed lower and you were right!");
    }
    else
    {
        Console.WriteLine("You guessed lower and you were wrong!");
    }
}
else if (guess == "E")
{
    if (first == second)
    {
        Console.WriteLine("You guessed equal and you were right!");
    }
    else
    {
        Console.WriteLine("You guessed equal and you were wrong!");
    }
}
else
{
    Console.WriteLine("That wasn't a valid guess. Game Over!");
}