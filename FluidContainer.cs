namespace cw2;

class FluidContainer : Container, IHazardNotifier
{
    private static int _typeCount;

    public FluidContainer(int maximumCargoWeight, int height, int weight, int depth)
        : base(maximumCargoWeight, height, weight, depth, ContainerType.L, _typeCount)
    {
        _typeCount++;
    }

    protected override void Load(Cargo cargo,int amount)
    {
        if (amount > 0.9 * MaximumCargoWeight || (amount > 0.5*MaximumCargoWeight && cargo.IsHazardous))
        {
            Notify();
        }
        else
        {
            CargoWeight = amount;
        }
    }
    public void Notify()
    {
        Console.Write($"There is hazardous situation in a container {SerialNumber}");
    }
}