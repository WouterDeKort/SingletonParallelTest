using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Singleton.Test
{
	public class ParallelTestsGroupTwo
	{
		private readonly ITestOutputHelper output;

		public ParallelTestsGroupTwo(ITestOutputHelper output)
		{
			this.output = output;
		}

		[Fact]
		public async Task RunIncreaseTest()
		{
			int current = 0;

			for (int x = 0; x < 100; x++)
			{
				current++;
				var value = await MySingleton.Instance.Increase();

				Assert.Equal(current, value);
				output.WriteLine($"Value: {value}");
			}
		}
	}
}
