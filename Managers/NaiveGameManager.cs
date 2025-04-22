using DependencyInjection.Shared;

namespace DependencyInjection.Managers;

public class NaiveGameManager
{
    private readonly Random _random = new();
    
    public Result PlayRound()
    {
        Choice? playerOneChoice;

        do
        {
            var input = Console.ReadLine()?.ToLower();
            playerOneChoice = input switch
            {
                "rock" => Choice.Rock,
                "paper" => Choice.Paper,
                "scissors" => Choice.Scissors,
                _ => null
            };

            if (playerOneChoice is not null) break;
            
            Console.WriteLine("Choice is not valid, pick one: rock, paper, or scissors.");
        } while (true);
        
        var playerTwoChoice = (Choice)_random.Next(0, 3);
        
        Console.WriteLine("Player one choice: " + playerOneChoice);
        Console.WriteLine("Player two choice: " + playerTwoChoice);

        Console.Write("Result: ");
        
        if (playerOneChoice == playerTwoChoice) return Result.Draw;

        if (playerOneChoice == Choice.Rock && playerTwoChoice == Choice.Scissors ||
            playerOneChoice == Choice.Paper && playerTwoChoice == Choice.Rock ||
            playerOneChoice == Choice.Scissors && playerTwoChoice == Choice.Paper)
            return Result.PlayerOneWins;

        return Result.PlayerTwoWins;
    }
}