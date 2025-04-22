using DependencyInjection.Entities;
using DependencyInjection.Managers;
using DependencyInjection.Shared;

var naiveGameManager = new NaiveGameManager();

Console.WriteLine(naiveGameManager.PlayRound().Result());

var gameManager = new GameManager(new HumanPlayer(), new ComputerPlayer(new Random()));

Console.WriteLine(gameManager.PlayRound().Result());