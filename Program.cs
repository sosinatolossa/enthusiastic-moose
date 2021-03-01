using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    //Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");


    // Ask the questions
    ListOfQuestions("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
    ListOfQuestions("Are you enthusiastic?", "Yay!", "You should try it!");
    ListOfQuestions("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
    ListOfQuestions("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");


    void ListOfQuestions(string question, string y, string n)
    {
        bool isTrue = MooseAsks(question);

        if (isTrue)
        {
            MooseSays(y);
        }
        else
        {
            MooseSays(n);
        }
    }

    void MooseSays(string message)
    {
        //@ sign means multiple lines
        Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
");
    }

    //true or false function that takes a string type question
    bool MooseAsks(string question)
    {
        //ask the question with the expectastion of Y/N answer
        Console.Write($"{question} (Y/N): ");
        //take what the user enters and change it to lower case
        string answer = Console.ReadLine().ToLower();

        //while the answer is NOT y or n
        while (answer != "y" && answer != "n")
        {
            //keep asking them the question
            Console.Write($"{question} (Y/N): ");
            //and still change what's been entered to lower case
            answer = Console.ReadLine().ToLower();
        }

        //if the answer is y
        if (answer == "y")
        {
            //return true
            return true;
        }
        else //if not
        {
            //return false
            return false;
        }
    }
}