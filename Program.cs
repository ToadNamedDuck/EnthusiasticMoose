using System;


void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!\n--------------------------------------------\n");
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic!");
    Console.WriteLine();
    BuildQuestion("Is Canada real?", "I'm not sure whether to believe you or not...", "I  K N E W  I T !");
    BuildQuestion("Are you enthusiastic?", "Yay! I am, too!!!", "You should try it!");
    BuildQuestion("Do you love C# yet???", "Way to suck up to your instructor!", "You will.... yes, in time, the power...");
    BuildQuestion("Do you want to know a secret?", "ME TOO!!! I love secrets! Tell me one!", "Oh, no...secrets are the best, I love to share them!");
}

void MooseSays(string message)
{
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

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N):");
        answer = Console.ReadLine().ToLower();
    }
    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

void BuildQuestion(string question, string trueResponse, string falseResponse){
        if(MooseAsks(question)){
            MooseSays(trueResponse);
        }
        else{
            MooseSays(falseResponse);
        }
}

Main();