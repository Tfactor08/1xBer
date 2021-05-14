
public class Account
{
    public delegate void AccountHandler(string message);
    public event AccountHandler Added;
    public event AccountHandler DisplayInfo;

    public decimal Amount { get; set; }

    public Account()
    {
        Amount = 0;
    }

    public void Add(decimal sum)
    {
        Amount += sum;
        Added?.Invoke("Операция проведена успешно");
    }

    public void Take(decimal sum)
    {
        if (Amount >= sum)
        {
            Amount -= sum;
            //DisplayInfo?.Invoke($"Со счета списано {sum}");
        }
    }
}