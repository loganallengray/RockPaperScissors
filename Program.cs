using System;

/* Rock, Paper, Scissors */

Main();

void Main()
{
    int playerScore = 0;
    int computerScore = 0;

    int playerChoice = getPlayerChoice(playerScore, computerScore);

    while (playerChoice != 0) {
        Random r = new Random();
        int computerChoice = r.Next(1, 3);

        string result = gameCheck(playerChoice, computerChoice);

        switch (result) 
        {
            case "win":
                playerScore++;
                Console.WriteLine("Match Won!");
                break;
            case "lose":
                computerScore++;
                Console.WriteLine("Match Lost!");
                break;
            case "tie":
                Console.WriteLine("Match Tied!");
                break;
        }

        if (playerScore < 3 && computerScore < 3) 
        {
            playerChoice = getPlayerChoice(playerScore, computerScore);
        }
        else 
        {
            playerChoice = 0;
            if (playerScore == 3) {
                Console.WriteLine("");
                Console.WriteLine("-- YOU WON! ---------------");
                Console.WriteLine($"| Player: {playerScore} | Computer: {computerScore} |");
                Console.WriteLine("---------------------------");
            }
            else {
                Console.WriteLine("");
                Console.WriteLine("-- YOU LOST! --------------");
                Console.WriteLine($"| Player: {playerScore} | Computer: {computerScore} |");
                Console.WriteLine("---------------------------");
            }
        }
    }
}

int getPlayerChoice(int playerScore, int computerScore)
{
    Console.WriteLine("---------------------------");
    Console.WriteLine($"| Player: {playerScore} | Computer: {computerScore} |");
    Console.WriteLine("---------------------------");
    Console.WriteLine("What would you like to throw?");
    Console.WriteLine("1) Rock");
    Console.WriteLine("2) Paper");
    Console.WriteLine("3) Scissors");

    string answer = Console.ReadLine();

    switch (answer) 
    {
        case "1":
            return 1;
        case "2":
            return 2;
        case "3":
            return 3;
        default:
            return 0;
    }
} 

string gameCheck(int playerChoice, int computerChoice) {
    switch(playerChoice) {
        // player chose rock
        case 1:
            printRock(); 
            Console.WriteLine("VS");
            switch(computerChoice) {
                // computer chose rock
                case 1:
                    printRock(); 
                    return "tie";
                // computer chose paper
                case 2:
                    printPaper() ;
                    return "lose";
                //computer chose scissors
                case 3:
                    printScissors();
                    return "win";
                default:
                    return "Error";
            }
        // player chose paper
        case 2:
            printPaper() ;
            Console.WriteLine("VS");
            switch(computerChoice) {
                // computer chose rock
                case 1:
                    printRock(); 
                    return "win";
                // computer chose paper
                case 2:
                    printPaper() ;
                    return "tie";
                //computer chose scissors
                case 3:
                    printScissors();
                    return "lose";
                default:
                    return "Error";
            }
        // player chose scissors
        case 3:
            printScissors();
            Console.WriteLine("VS");
            switch(computerChoice) {
                // computer chose rock
                case 1:
                    printRock(); 
                    return "lose";
                // computer chose paper
                case 2:
                    printPaper() ;
                    return "win";
                //computer chose scissors
                case 3:
                    printScissors();
                    return "tie";
                default:
                    return "Error";
            }
        default:
            return "Error";
    }
}

void printRock() 
{
    Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
    ");
}

void printPaper() 
{
    Console.WriteLine(@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
    ");
}

void printScissors() 
{
    Console.WriteLine(@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
    ");
}