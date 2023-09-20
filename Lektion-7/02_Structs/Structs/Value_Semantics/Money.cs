namespace _02_Structs.Structs.Value_Semantics;

public struct Money
{
	public decimal Amount;
	public string Currency;

	public Money(decimal amount, string currency)
	{
		Amount = amount;
		Currency = currency;
	}
}
