public interface IVehicle
{
    
    public bool IsRunning { get; set; }
    public int Speed { get; set; }
    public abstract void Start();
    public abstract void Stop();
    abstract void Drive();

}