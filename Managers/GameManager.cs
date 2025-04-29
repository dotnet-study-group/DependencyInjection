using DependencyInjection.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.Managers;

public class GameManager(IServiceProvider provider)
{
    public Result PlayRound(PlayerType playerOneType, PlayerType playerTwoType)
    {
        var playerOne = provider.GetKeyedService<IPlayer>(playerOneType.ToString());
        var playerTwo = provider.GetKeyedService<IPlayer>(playerTwoType.ToString());
        
        var playerOneChoice = playerOne?.GetChoice();
        var playerTwoChoice = playerTwo?.GetChoice();
        
        Console.WriteLine("Player one choice: " + playerOneChoice);
        Console.WriteLine("Player two choice: " + playerTwoChoice);

        Console.Write("Result: ");

        if (playerOneChoice is null || playerTwoChoice is null) return Result.Error;
        
        if (playerOneChoice == playerTwoChoice) return Result.Draw;

        if (playerOneChoice == Choice.Rock && playerTwoChoice == Choice.Scissors ||
            playerOneChoice == Choice.Paper && playerTwoChoice == Choice.Rock ||
            playerOneChoice == Choice.Scissors && playerTwoChoice == Choice.Paper)
            return Result.PlayerOneWins;

        return Result.PlayerTwoWins;
    }
}