using DependencyInjection.Shared;

namespace DependencyInjection.Entities;

public class HumanPlayer : IPlayer
{
    public Choice GetChoice()
    {
        Choice? choice;
        do
        {
            var input = Console.ReadLine()?.ToLower();
            choice = input switch
            {
                "rock" => Choice.Rock,
                "paper" => Choice.Paper,
                "scissors" => Choice.Scissors,
                _ => null
            };

            if (choice is not null) break;
            
            Console.WriteLine("Choice is not valid, pick one: rock, paper, or scissors.");
        } while (true);
        
        return choice.Value;
    }
}