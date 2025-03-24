namespace cw2;

class GasContainer:Container,IHazardNotifier
{
    private int pressure { get; set; }
    public GasContainer(int maximumCargoWeight, int height, int weight, int depth, ContainerType type, int typeCount,int pressure) 
        : base(maximumCargoWeight, height, weight, depth, type, typeCount)
    {
        pressure = pressure;
    }

    protected override void Unload()
    {
        CargoWeight = (int)(CargoWeight * 0.05);
    }

    public void Notify()
    {
        Console.Write($"There is hazardous situation in a container {SerialNumber}");
    }
}