using _01_Enums.Enums;

namespace _01_Enums.Services;

internal class WeekdayService
{
	public void Run()
	{
		var weekday = Weekdays.Wednesday;

		switch (weekday)
		{
			case Weekdays.Monday:
				Console.WriteLine("Det är måndag idag.");
				break;

			case Weekdays.Tuesday:
				Console.WriteLine("Det är tisdag idag.");
				break;

			case Weekdays.Wednesday:
				Console.WriteLine("Det är onsdag idag, dvs lill-lördag.");
				break;

			case Weekdays.Thursday:
				Console.WriteLine("Det är torsdag idag.");
				break;

			case Weekdays.Friday:
				Console.WriteLine("Det är fredag idag. HELG!!!");
				break;

			case Weekdays.Saturday:
				Console.WriteLine("Det är lördag idag.");
				break;

			case Weekdays.Sunday:
				Console.WriteLine("Det är söndag idag. Dags att städa...suck...");
				break;
		}

		Console.ReadKey();
	}

}
