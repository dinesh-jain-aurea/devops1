using Microsoft.AspNetCore.Mvc.Testing;

namespace WebApi.Test
{
	public class WeatherForecastTest
	{
		[Fact]
		public async Task TestGet()
		{
			await using var application = new WebApplicationFactory<Program>();
			using var client = application.CreateClient();

			var response = await client.GetStringAsync("/weatherforecast");

			Console.WriteLine(response);

			Assert.NotEmpty(response);
		}
	}
}