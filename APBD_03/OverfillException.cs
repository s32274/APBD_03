namespace APBD_03;

public class OverfillException : Exception
{
    public OverfillException(string message) : base(message)
    {
    }
}