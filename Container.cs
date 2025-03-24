namespace cw2;

abstract class Container
{
    public string SerialNumber { get; }
    public int MaximumCargoWeight { get; }
    public int Height { get; }
    public int Weight { get; }
    public int Depth { get; }
    public int CargoWeight { get; protected set; } = 0;

    public enum ContainerType
    {
        L,
        G,
        C
    }

    protected Container(int maximumCargoWeight, int height, int weight, int depth, ContainerType type, int typeCount)
    {
        MaximumCargoWeight = maximumCargoWeight;
        Height = height;
        Weight = weight;
        Depth = depth;

        SerialNumber = $"KON-{type}-{typeCount}";
    }

    protected virtual void Unload()
    {
        CargoWeight = 0;
    }

    protected virtual void Load(Cargo cargo,int amount)
    {
        if (CargoWeight > 0)
        {
            throw new Exception("Container is not empty");
        }
        if (amount > MaximumCargoWeight)
        {
            throw new OverfillException();
        }

        CargoWeight = amount;
    }

    public void info()
    {
        Console.Write($"Container number: {SerialNumber}\n" +
                      $"Maximum cargo weight: {CargoWeight}\n" +
                      $"Weight: {Weight}\n" +
                      $"Maximum cargo weight: {CargoWeight}\n" +
                      $"Maximum cargo weight: {CargoWeight}\n" +);
    }
}