using _01_Enums.Enums;

namespace _01_Enums.Services;

internal class UrlCheckerService
{
	public async Task Run(string url)
	{
		var result = await CheckUrlAsync(url);
		switch (result)
		{
			case StatusCodes.Online:
				Console.WriteLine($"{url} är online och är tillgänglig.");
				break;

			case StatusCodes.Offline:
				Console.WriteLine($"{url} är offline och är inte tillgänglig.");
				break;
		}

		Console.ReadKey();
	}


	public async Task<StatusCodes> CheckUrlAsync(string url)
	{
		using var http = new HttpClient();
		var response = await http.GetAsync(url);

		if (response.IsSuccessStatusCode) 
			return StatusCodes.Online;

		return StatusCodes.Offline;
	}
}
