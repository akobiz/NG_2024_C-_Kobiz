
namespace Epic_1_1.Classes
{
    public class Balance
    {
        public int BalanceId { get; set; }
        public int ClientId { get; set; }
        public float BalanceAmount { get; set; }

        public Balance(int balanceId = 0, int clientID = 0, float balanceAmount = 0)
        {
            BalanceId = balanceId;
            ClientId = clientID;
            BalanceAmount = balanceAmount;
        }
        public float GetBalance()
        {
            return BalanceAmount;
        }
        public void UpdateBalance(float newBalance)
        {
            BalanceAmount = newBalance;
        }
    }
}
