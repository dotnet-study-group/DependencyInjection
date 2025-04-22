using DependencyInjection.Shared;

namespace DependencyInjection.Entities;

public class ComputerPlayer(Random random) : IPlayer
{
    public Choice GetChoice()
    {
        return (Choice)random.Next(0, 3);
    }
}
