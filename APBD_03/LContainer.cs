using System.Transactions;

namespace APBD_03;

public class LContainer : Container, IHazardNotifier
{
    // Kontenery na płyny pozwalają na przewożenie ładunku niebezpiecznego (np. paliwo)
    // i ładunku zwykłego (np. mleko).

    private bool isLoadDangerous = false;

    public LContainer()
    {
        SetType(ContainerType.L);
    }
    
    public override void Load(double newLoad)
    {
        if (isLoadDangerous)
        {
            if (GetLoadMass() + newLoad > 0.5 * GetMaxLoad())
            {
                //throw new OverfillException("Cannot load more than max load");
                NotifyHazard(GetSerialId(), "contains dangerous load, cannot load more than 0.5 max load");
            }
        }
        else
        {
            if (GetLoadMass() + newLoad > 0.9 * GetMaxLoad())
            {
                //throw new OverfillException("Cannot load more than max load");
                NotifyHazard(GetSerialId(), "contains safe load, but cannot load more than 0.9 max load");
            }
        }
    }

    public string NotifyHazard(string hazardId, string message)
    {
        return "[" + GetSerialId() + "]: " + message;
    }

}