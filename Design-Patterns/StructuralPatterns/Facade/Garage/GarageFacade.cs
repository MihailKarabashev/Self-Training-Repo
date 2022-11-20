using Garage.Models;

namespace Garage;

public class GarageFacade
{
    private readonly CarModel carModel;
    private readonly CarEngine carEngine;
    private readonly CarBody carBody;
    private readonly CarAccessoires carAccessoires;

    public GarageFacade()
    {
        carModel = new CarModel();
        carEngine = new CarEngine();
        carBody = new CarBody();
        carAccessoires = new CarAccessoires();
    }

    public void CreateCar()
    {
        Console.WriteLine("Start creating car");

        carModel.SetModel();
        carEngine.SetEngine();
        carBody.SetBody();
        carAccessoires.SetAccessoires();

        Console.WriteLine("Car Created");
    }
}
