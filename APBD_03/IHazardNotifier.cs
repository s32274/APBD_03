namespace APBD_03;

public interface IHazardNotifier
{
    public string NotifyHazard(string serialID, string message);
    //{
    //    return "[" + serialID + "]: " + message;
    //}
}