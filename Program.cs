//Asking Name
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        

        bool winCondion = false;
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

        Console.WriteLine("You leave the house, as you are getting in your car, you can't remember if you shut off the stove. Go back and check? (Yes/No)");
//Trying to make Yes/No as valid boolion
{
            string userResponse = Console.ReadLine().ToLower();

            bool procceed = false;

            if (userResponse == "yes")
    {  
        procceed = true; 
    }
    
            else if (userResponse == "no")
    {  
        procceed = false; 
    }
            
    else
    {
        Console.WriteLine("Please only type 'Yes' or 'No'. ");
    }
            if ((procceed == true) && (testValue == 2)) ;
            {
                winCondion = true;
            }
             else if ((procceed == true) && (testValue != 2)) ;
            { 
                winCondion = false; 
        }
}
                }
                }