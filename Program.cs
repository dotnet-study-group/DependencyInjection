using DependencyInjection.Entities;
using DependencyInjection.Managers;
using DependencyInjection.Shared;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddSingleton<Random>();
services.AddKeyedTransient<IPlayer, ComputerPlayer>("ComputerPlayer");
services.AddKeyedTransient<IPlayer, HumanPlayer>("HumanPlayer");
services.AddSingleton<GameManager>();

using var serviceProvider = services.BuildServiceProvider();

var gameManager = serviceProvider.GetRequiredService<GameManager>();

Console.WriteLine(gameManager.PlayRound().Result());