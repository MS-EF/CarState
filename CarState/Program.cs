// See https://aka.ms/new-console-template for more information
using CarState.Builders;
using CarState.Models;

 
Console.WriteLine("plz enter state of engine's car");
Console.WriteLine("\'1\' for FIX , \'2\' for BROKEN , \'3\' for NORMAl");
string engineInput = Console.ReadLine();
EngineState engine;
Enum.TryParse(engineInput, out engine);


Console.WriteLine("plz enter state of backup's car");
Console.WriteLine("\'1\' for EXIST , \'2\' for NONE ");
string backupInput = Console.ReadLine();
BackupState backup;
Enum.TryParse(backupInput, out backup);


Console.WriteLine("plz enter number of your selected workshop");
Console.WriteLine("\'1\' for 1 , \'2\' for 2 ");
string workshopInput = Console.ReadLine();
var workshop = int.Parse(workshopInput);

int id = 0;
CarBuilder carBuilder = new CarBuilder();
Car car = carBuilder.WithEngine(engine).WithBakup(backup).Build(++id);

WorkShopFactory shopFactory = new WorkShopFactory();
WorkShop workShop = shopFactory.Create(workshop);

StateBuilder stateBuilder = new StateBuilder();
Car finalState = stateBuilder.WithCar(car).WithWorkShop(workShop).Build();


Console.WriteLine("final state of car is : ");
Console.WriteLine($"car engine is {finalState.Engine}");
Console.WriteLine($"car backup is {finalState.Backup}");


Console.ReadKey();

