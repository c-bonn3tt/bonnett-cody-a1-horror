
internal class Program
{
    private static void Main(string[] args)
    {


        bool winCondion = false;
        bool loseCondition = false;
        Console.WriteLine("What is your name?\n");

        string Name = Console.ReadLine();
        Console.WriteLine(""); // spacing out the text
        Console.WriteLine($"Greetings {Name}, \nYou are driving to work when you start questioning to yourself what you did this morning. \nYou were so tired you couldn't remember.\nTo you, it feels like you suddenly appeared in your car. \nSuddenly, you feel like you're forgetting something and must recall what you did otherwise it can have disastrous- \nconsequences.\n");
        {
            //Picking a number betweeen 1 and 4
            Console.WriteLine("Pick one of the 4 scenarios that you can remember from some point in your life:\n");

            Console.WriteLine("1. You wake up to sounds of the city, cars honking and random people shouting. \nYou quickly chow down your breakfast of bacon and eggs before going out and getting a little exercise with your pup. \nAfter returning you make sure to take your meds, grab your keys and head out the door.\n");

            Console.WriteLine("2. Its a typical morning, you are woken up by your dog needing to go out. While the dog is out, \nyou eat a sandwich and take your meds. \nAfter letting the dog in, you have a shower and get ready. \nChecking the time, you realize you are running late and you run out the door.\n");

            Console.WriteLine("3. After frequent late nights, you tend to feel sluggish and lazy. \nYou get up, eat cereal, feed your dog, and shower before \ntaking your meds and heading out the door.\n");

            Console.WriteLine("4. You suddenly woke up in your car and can't remember what you did this morning.\n");

            Console.WriteLine("Pick by typing the corresponding number below (e.g '1'):");
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

            Console.WriteLine($"You have chosen:{chosenNumber}\n");

            Console.WriteLine("The door is locked. (Yes/No)");
            //Trying to make Yes/No as valid boolion
            {
                string userResponse = Console.ReadLine().ToLower();

                bool procceed = false;

                if (userResponse == "no")
                {
                    procceed = true;
                }

                else if (userResponse == "yes")
                {
                    procceed = false;
                }

                else
                {
                    Console.WriteLine("Please only type 'Yes' or 'No'. ");
                }

                if ((procceed == true) && (testValue == 2))
                {
                    winCondion = true;
                }

                else if ((procceed == true) && (testValue != 2))
                {
                    winCondion = false;
                    loseCondition = true;
                }
                else
                {
                  //  winCondion = false; //after changes to idea, this was no longer needed
                }
                //Console.WriteLine($"{testValue}, {winCondion}, {loseCondition}"); //Just observing the boolion values throughout the questions
            }

                Console.WriteLine("The Stove is off. (Yes/No)");
            {
                string userResponse = Console.ReadLine().ToLower();
                bool procceed = false;
                if (userResponse == "no")
                {
                    procceed = true;
                }

                else if (userResponse == "yes")
                {
                    procceed = false;
                }

                else
                {
                    Console.WriteLine("Please only type 'Yes' or 'No'. ");
                }

                if ((procceed == true) && (testValue == 1))
                {
                    winCondion = true;
                }

                else if ((procceed == true) && (testValue != 1))
                {
                    winCondion = false;
                    loseCondition = true;
                }
                else
                {
                  //  winCondion = false; //changed idea
                }
                // Console.WriteLine($"{testValue}, {winCondion}, {loseCondition}"); //bool values
            }

                Console.WriteLine("The dog has gone out. (Yes/No)");

            {
                string userResponse = Console.ReadLine().ToLower();
                bool procceed = false;
                if (userResponse == "no")
                {
                    procceed = true;
                }

                else if (userResponse == "yes")
                {
                    procceed = false;
                }

                else
                {
                    Console.WriteLine("Please only type 'Yes' or 'No'. ");
                }

                if ((procceed == true) && (testValue == 3))
                {
                    winCondion = true;
                }

                else if ((procceed == true) && (testValue != 3))
                {
                    winCondion = false;
                    loseCondition = true;
                }
                else
                {
                  //  winCondion = false; //changed idea
                }
                Console.WriteLine($"{testValue}, {winCondion}, {loseCondition}"); //Bool values
            }

                Console.WriteLine("Meds have been taken. (Yes/No)");

                {
                    string userResponse = Console.ReadLine().ToLower();
                    bool procceed = false;
                    if (userResponse == "no")
                    {
                        procceed = true;
                    }

                    else if (userResponse == "yes")
                    {
                        procceed = false;
                    }

                    else
                    {
                        Console.WriteLine("Please only type 'Yes' or 'No'. ");
                    }

                    if ((procceed == true) && (testValue == 4))
                    {
                        winCondion = true;
                    }

                    else if ((procceed == true) && (testValue != 4))
                    {
                        winCondion = false;
                        loseCondition =true;
                    }
                    else
                    {
                       // winCondion = false; //changed idea
                    }
                    //Console.WriteLine($"{ testValue}, { winCondion}, { loseCondition}"); //bool value check
                    if (winCondion == true && loseCondition == false) { Console.WriteLine($"Congratulations {Name}! You figured it out!"); }
                    else {
                    Console.WriteLine("Good try! Please play again!");
                            }

                }
        
        }
    }
}