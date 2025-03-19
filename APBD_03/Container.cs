namespace APBD_03;

public class Container
{
    private Type type; // chłodnicze, na płyny, na gaz (C, L, G)
    private double mass;
    private int height;
    private double ownMass;
    private int depth;
    private string serialID;

    private int maxLoad;
    

    public Container(Type type)
    {
        this.type = type;
    }
    
    
}