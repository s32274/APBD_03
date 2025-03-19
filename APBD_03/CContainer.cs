namespace APBD_03;

public class CContainer : Container, IHazardNotifier
{
    private static Dictionary<string, double> ProductTemps = new Dictionary<string, double>
    {
        {"Bananas", 13.3},
        {"Chocolate", 18},
        {"Fish", 2},
        {"Meat", -15},
        {"Ice cream", -18},
        {"Frozen pizza", -30},
        {"Cheese", 7.2},
        {"Bananas", 13.3},
        {"Bananas", 13.3},
        {"Bananas", 13.3},
    };
    private double temperatureInside;
    
    public string NotifyHazard(string hazardId, string message)
    {
        return "[" + GetSerialId() + "]: " + message;
    }
}