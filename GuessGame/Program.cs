bool isCorrectGuess = false;
Random  random = new Random();
int randomNum = random.Next(1, 11);
Console.WriteLine("welcome to the guessing game.");
Console.WriteLine("the number between 1 and 10 is generated!");
Console.WriteLine("if you guess the correct number, you win");
while (!isCorrectGuess)
{
    Console.WriteLine("please inter your guess");
    string guess = "";
    int cleanGuess = 0;
    while (!int.TryParse(guess, out cleanGuess))
    {
        Console.WriteLine("this input not a number pleas inter the correct number!");
        guess = Console.ReadLine() ?? "";
    }
    if(cleanGuess > randomNum) 
    {
        Console.WriteLine("Your guess is to high.");
    }
    else if (cleanGuess < randomNum)
    {
        Console.WriteLine("Your guess is to low.");
    }
    else 
    { 
        Console.WriteLine("Correct!");
        isCorrectGuess = true;
    }
}
Console.ReadKey();
Console.WriteLine("Congratulation, you won.");