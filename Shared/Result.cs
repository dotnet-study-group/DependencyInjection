namespace DependencyInjection.Shared;

public enum Result
{
    PlayerOneWins,
    PlayerTwoWins,
    Draw,
    Error
}

internal static class ResultExtensions
{
    public static string Result(this Result result)
    {
        return result switch
        {
            Shared.Result.PlayerOneWins => "Player one wins!",
            Shared.Result.PlayerTwoWins => "Player two wins!",
            Shared.Result.Draw => "It's a draw!",
            _ => "Unknown case!"
        };
    }
}