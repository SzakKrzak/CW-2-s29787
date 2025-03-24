namespace cw2;

class ContainerShip
{
    private List<Container> Containers;
    private int MaximumSpeed;
    private int MaximumContainersAmount;
    private int MaximumWeight;

    public ContainerShip(int maximumSpeed, int maximumContainersAmount, int maximumWeight)
    {
        Containers = new List<Container>();
        MaximumSpeed = maximumSpeed;
        MaximumContainersAmount = maximumContainersAmount;
        MaximumWeight = maximumWeight;
    }

    void LoadContainer(Container container)
    {
        if (Containers.Count + 1 > MaximumContainersAmount)
        {
            throw new Exception("Container ship is full");
        }
        Containers.Add(container);
    }
    void LoadContainers(List<Container> containers)
    {
        if (Containers.Count + containers.Count > MaximumContainersAmount)
        {
            throw new Exception("Container ship is full");
        }

        foreach (Container container in containers)
        {
            Containers.Add(container);
        }
    }

    void UnloadContainer()
    {
        Containers.RemoveAt(0);
    }

    void ReplaceContainer(string toReplace, Container containerToAdd)
    {
        foreach (Container container in Containers)
        {
            if (container.SerialNumber.Equals(toReplace))
            {
                Containers.Remove(container);
                LoadContainer(containerToAdd);
                break;
            }
        }
    }

    void TransferContainer(Container containerToTransfer, ContainerShip shipToTransfer)
    {
        Containers.Remove(containerToTransfer);
        shipToTransfer.LoadContainer(containerToTransfer);
    }
}