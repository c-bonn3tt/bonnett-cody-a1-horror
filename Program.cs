//Asking Name
using System.ComponentModel.Design;

Console.WriteLine("What is your name?");

string Name = Console.ReadLine();
Console.WriteLine($"Greetings {Name}, Welcome to my game!");

//Picking a number betweeen 1 and 4
Console.WriteLine("Pick a number between 1 and 4");
string chosenNumber = Console.ReadLine();
int testValue = int.Parse(chosenNumber);
if (testValue < 1)
{
    Console.WriteLine("The number you chose is too low, please play again.");
testValue = int.Parse(chosenNumber);

}
else if (testValue > 4)
{
    Console.WriteLine("The number you chose is too high, please play again.");
    int newChoice = int.Parse(chosenNumber);
}

Console.WriteLine("Thank you for choosing a number. \nYou wake up . . . insert morning routine");
Console.WriteLine("question 1 (Yes/No)");
//Trying to make Yes/No as valid boolion
{
    string firstResponse = Console.ReadLine();

    bool procceed;

    if (firstResponse == "Yes")
    {  
        procceed = true; 
    }
    
    else if (firstResponse == "No")
    {  
        procceed = false; 
    }
    else
    {
        Console.WriteLine("Please only type 'Yes' or 'No'. ");
    }


}