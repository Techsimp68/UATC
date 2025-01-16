using System;
Start: //if user wants to play again it will return here
string name;
Console.WriteLine("What is your name?");
name = Console.ReadLine();
Console.WriteLine("Your name is " + name + "!");
Random rand = new Random(); //random number
int answer = rand.Next(0, 11);
GuessAgain: //this is the GuessAgain if user doesn't get the answer correct the first time.
Console.WriteLine("guess the number between 1 and 10!");
int guess = Convert.ToInt32(Console.ReadLine());

if (guess == answer) //statement to check if guess is equal to answer.
{
    Console.WriteLine("Great Job you got it!"); //the good job message
    Console.WriteLine("Did you have fun? Yes or No"); //ask user to play again
    string fun = Console.ReadLine().ToUpper();
    switch (fun) //switch inside the "correct" if statement to find out if user wants to play again and had fun
    {
        case "YES":
            Console.WriteLine("I am glad, do you want to play again?");
            string again = Console.ReadLine().ToUpper();
            if (again == "YES")
            {
                goto Start;
            }
            else
            {
                Console.WriteLine("Bye!"); //Since the user doesn't want to play again program says "Bye" the break ends the code
                break; //break leaves the switch statement
            }
        case "NO": //this is what happens when the user says "No"
            Console.WriteLine("I am sorry to hear that");
            break;
    }
}
else //The else statement if the user got the wrong number.
{
    if (guess > answer) // if guess is greater than answer the message below gets written
    {
        Console.WriteLine("Your guess is to High! Try again");
        goto GuessAgain; //goes to GuessAgain for user to try again
    }
    else // else statement if the guess is to low the below message is written
    {
        Console.WriteLine("Your guess is to low, try again");
        goto GuessAgain; // goes to guessAgain for user to try again.
    }
}
