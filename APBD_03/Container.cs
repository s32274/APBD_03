namespace APBD_03;

public abstract class Container
{
    private ContainerType _containerType; // chłodnicze, na płyny, na gaz (C, L, G)
    private double loadMass;
    private double height;
    private double ownMass;
    private double depth;
    private string serialID;
    private double maxLoad;

    public Container(double loadMass, double height, double ownMass, double depth, double maxLoad)
    {
        serialID = GenerateSerialID();
        this.loadMass = loadMass;
        this.height = height;
        this.ownMass = ownMass;
        this.depth = depth;
        this.maxLoad = maxLoad;
    }

    public Container()
    {
        serialID = GenerateSerialID();
    }

    private string GenerateSerialID()
    {
        return "KON-" + _containerType + "-" + System.Guid.NewGuid();
    }

    public virtual double Unload()
    {
        loadMass = 0.0;
        return GetLoadMass();
    }

    public virtual void Load(double newLoad)
    {
        if (loadMass + newLoad > maxLoad)
        {
            throw new OverfillException("Cannot load more than max load");
        }
    }

    public string GetSerialId()
    {
        return serialID;
    }
    public double GetLoadMass()
    {
        return loadMass;
    }

    public double GetMaxLoad()
    {
        return maxLoad;
    }

    public void SetType(ContainerType containerType)
    {
        this._containerType = containerType;
    }

    public void SetLoadMass(double loadMass)
    {
        this.loadMass = loadMass;
    }
    
}