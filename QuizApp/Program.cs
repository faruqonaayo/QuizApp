// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string question1 = "What is the capital of Canada?";
string answer1 = "Ottawa";

string question2 = "What is the capital of France?";
string answer2 = "Paris";

string question3 = "What is the capital of Italy?";
string answer3 = "Rome";

int score = 0;

// Ask the user the question1 and check if the response is correct

Console.WriteLine(question1);
string response1 = Console.ReadLine();

if (response1 == answer1)
{
    Console.WriteLine("Your response is correct");
    score++;
}
else
{
    Console.WriteLine("Wrong response the correct answer is {0}", answer1);
}

// Ask the user the question2 and check if the response is correct
Console.WriteLine(question2);
string response2 = Console.ReadLine();

if (response2 == answer2)
{
    Console.WriteLine("Your response is correct");
    score++;
}
else
{
    Console.WriteLine("Wrong response the correct answer is {0}", answer2);
}

// Ask the user the question3 and check if the response is correct
Console.WriteLine(question3);
string response3 = Console.ReadLine();

if (response3 == answer3)
{
    Console.WriteLine("Your response is correct");
    score++;
}
else
{
    Console.WriteLine("Wrong response the correct answer is {0}", answer2);
}

// Display the score
Console.WriteLine($"You got {score} out of 3 questions correct");

Console.ReadKey();