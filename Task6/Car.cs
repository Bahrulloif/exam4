public class Car : IVehicle
{
    public bool IsRunning { get; set; }
    public int Speed { get; set; }
    public void Start()
    {
        System.Console.WriteLine("Starting car engine.");
        IsRunning = true;
    }
    public void Stop()
    {
        System.Console.WriteLine("Stopping car engine.");
        IsRunning = false;
    }
    public void Drive()
    {
        System.Console.WriteLine("Driving down the road.");
        System.Console.WriteLine($"Driving at {Speed} mph");
    }

}