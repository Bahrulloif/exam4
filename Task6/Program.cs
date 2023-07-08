var car = new Car();
var motorcicle = new Motorcicle();
car.Start();
car.Speed=Convert.ToInt32(Console.ReadLine());
car.Drive();
System.Console.WriteLine(car.IsRunning);
car.Stop();
System.Console.WriteLine(car.IsRunning);

motorcicle.Start();
motorcicle.Speed = Convert.ToInt32(Console.ReadLine());
motorcicle.Drive();
System.Console.WriteLine(motorcicle.IsRunning);
motorcicle.Stop();
System.Console.WriteLine(motorcicle.IsRunning);