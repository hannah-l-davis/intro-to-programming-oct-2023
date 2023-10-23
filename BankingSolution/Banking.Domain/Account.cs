
namespace Banking.Domain;
public class Account
{
    private decimal _balance = 5000M;

    public decimal GetBalance()
    {
        return _balance;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (amountToWithdraw >= _balance)
        {
            return;
        }
        _balance -= amountToWithdraw;
    }
}