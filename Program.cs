using System;

Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!\n--------------------------------------------\n");

void MooseSays(string message){
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

bool MooseAsks(string question){
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n"){
        Console.Write($"{question} (Y/N):");
        answer = Console.ReadLine().ToLower();
    }
    if(answer == "y"){
        return true;
    }
    else{
        return false;
    }
}

MooseSays("H I, I'M  E N T H U S I A S T I C !");
MooseSays("I really am enthusiastic!");

bool isTrue = MooseAsks("Is Canada Real?");
Console.WriteLine(isTrue);