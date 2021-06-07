using System;
using Xunit;
using Xunit.Abstractions;

namespace Singleton.Test
{
	public class ParallelTestsGroupOne
	{
		private readonly ITestOutputHelper output;

		public ParallelTestsGroupOne(ITestOutputHelper output)
		{
			this.output = output;
		}

		[Fact]
		public void RunIncreaseTest()
		{
			int current = 0;

			for (int x = 0; x < 100; x++)
			{
				current++;
				var value = MySingleton.Instance.Increase();

				Assert.Equal(current, value);
				output.WriteLine($"Value: {value}");
			}
		}
	}
}
