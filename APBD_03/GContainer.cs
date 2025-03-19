namespace APBD_03;

public class GContainer : Container, IHazardNotifier
{
    private double pressure;

    public override double Unload()
    {
        SetLoadMass(0.05 * GetLoadMass());
        return 0.95 * GetLoadMass();
    }
    
    public string NotifyHazard(string hazardId, string message)
    {
        return "[" + GetSerialId() + "]: " + message;
    }
}