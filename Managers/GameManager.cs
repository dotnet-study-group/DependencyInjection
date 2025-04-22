using DependencyInjection.Shared;

namespace DependencyInjection.Managers;

public class GameManager(IPlayer playerOne, IPlayer playerTwo)
{
    public Result PlayRound()
    {
        var playerOneChoice = playerOne.GetChoice();
        var playerTwoChoice = playerTwo.GetChoice();
        
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