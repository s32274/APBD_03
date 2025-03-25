namespace APBD_03;

public class CargoShip
{
    private List<Container> containers { get; }
    private static int maxId = 0;
    private int id;
    private double maxSpeed;
    private int maxContainersCount;
    private double maxContainersMass;

    public CargoShip()
    {
        id = maxId;
        maxId++;
    }

    public void LoadContainerOnShip(Container container)
    {
        this.containers.Add(container);
    }

    public void LoadContainersOnShip(List<Container> containers)
    {
        foreach (Container con in containers)
        {
            this.containers.Add(con);
        }
    }

    public void removeContainer(Container container)
    {
        this.containers.Remove(container);
    }

    public void swapContainer(string id, Container container)
    {
        foreach (Container c in containers)
        {
            if (c.GetSerialId().Equals(id))
            {
                containers.Insert(containers.IndexOf(c), container);
            }
        }
    }
    
    
}