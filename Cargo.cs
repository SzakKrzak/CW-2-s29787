namespace cw2;

public class Cargo
{
    public bool IsHazardous;
    public bool name;
    public int temperature;

    public Cargo(bool isHazardous, bool name,int temperature)
    {
        IsHazardous = isHazardous;
        this.name = name;
        this.temperature = temperature;
    }
}