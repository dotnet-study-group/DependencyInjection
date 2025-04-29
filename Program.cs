using DependencyInjection.Entities;
using DependencyInjection.Managers;
using DependencyInjection.Shared;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddSingleton<Random>();
services.AddKeyedTransient<IPlayer, ComputerPlayer>("Computer");
services.AddKeyedTransient<IPlayer, HumanPlayer>("Human");
services.AddSingleton<GameManager>();

using var serviceProvider = services.BuildServiceProvider();

var gameManager = serviceProvider.GetRequiredService<GameManager>();

Console.WriteLine(gameManager.PlayRound(PlayerType.Computer, PlayerType.Human).Result());
