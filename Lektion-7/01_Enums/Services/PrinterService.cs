using _01_Enums.Enums;

namespace _01_Enums.Services;

internal class PrinterService
{
	private PrinterStates _printerState = PrinterStates.Idle;

	public void Print()
	{
		Console.Clear();
		Console.WriteLine("Printer starting up. Please wait...");
		Thread.Sleep(2000);

		do
		{
			switch(_printerState) 
			{ 
				case PrinterStates.Idle:
					_printerState = PrinterStates.LoadingPaper;
					break;

				case PrinterStates.LoadingPaper:
					LoadingPaper();
					_printerState = PrinterStates.Printing;
					break;

				case PrinterStates.Printing:
					Printing();
					_printerState = PrinterStates.Completed;
					break;

				case PrinterStates.Completed:
					Completed();
					_printerState = PrinterStates.Idle;
					break;
			}
		} while (_printerState != PrinterStates.Idle);

		Console.ReadKey();
	}

	private void LoadingPaper()
	{
		Console.WriteLine("Loading paper...");
		Thread.Sleep(2000);
	}

	private void Printing()
	{
		Console.WriteLine("Printing...");
		Thread.Sleep(5000);
	}

	private void Completed()
	{
		Console.WriteLine("Print completed.");
		Thread.Sleep(1000);
	}
}
