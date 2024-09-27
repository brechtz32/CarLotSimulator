using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var lot = new CarLot();

            // DONE -Create a seperate class file called Car
            // DONE -Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            // DONE -Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            // DONE -The methods should take one string parameter: the respective noise property


            // DONE -Now that the Car class is created we can instanciate 3 new cars
            // DONE -Set the properties for each of the cars
            // DONE -Call each of the methods for each car
            var myCar = new Car();
            myCar.Year = 2019;
            myCar.Make = "Chevy";
            myCar.Model = "Malibu";
            myCar.EngineNoise = "Vroom";
            myCar.HonkNoise = "Toot Toot";
            myCar.IsDriveable = true;

            lot.Cars.Add(myCar);

            //*************BONUS*************//

            var yourCar = new Car()
            {
                Year = 2020,
                Make = "Ford",
                Model = "Focus",
                EngineNoise = "Engine can't run",
                HonkNoise = "Beep Beep",
                IsDriveable = false
            };

            lot.Cars.Add(yourCar);

            var theirCar = new Car(2015, "Tesla", "Model X", "RRRRR", "AhhOooGaaa", true);

            lot.Cars.Add(theirCar);

            myCar.MakeEngineNoise(myCar.EngineNoise);
            yourCar.MakeEngineNoise(yourCar.EngineNoise);
            theirCar.MakeEngineNoise(theirCar.EngineNoise);

            myCar.MakeHonkNoise(myCar.HonkNoise);
            yourCar.MakeHonkNoise(yourCar.HonkNoise);
            theirCar.MakeHonkNoise(theirCar.HonkNoise);

            // DONE -Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            // DONE-Create a CarLot class
            // DONE-It should have at least one property: a List of cars
            // DONE-Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            // DONE-At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year:{car.Year} Make:{car.Make} Model:{car.Model}");
            }
            
        }
    }
}
