using aoc.D07;
using Xunit;

namespace aoc.test.D07
{
  public class TC01
  {
    [Fact]
    public void InitialI()
    {
      int expected = 37;
      var positions = new int[] { 16, 1, 2, 0, 4, 2, 7, 1, 2, 14 };

      var actual = FuelCalculator.Calculate(positions);

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void PartI()
    {
      int expected = 355521;
      var positions = Parser.Parse(@"./D07/input.txt");
            
      var actual = FuelCalculator.Calculate(positions);

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void InitialII()
    {
      int expected = 168;
      var positions = new int[] { 16, 1, 2, 0, 4, 2, 7, 1, 2, 14 };

      var actual = FuelCalculator.Calculate(positions, true);

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void PartII()
    {
      int expected = 100148777;
      var positions = Parser.Parse(@"./D07/input.txt");

      var actual = FuelCalculator.Calculate(positions, true);

      Assert.Equal(expected, actual);
    }
  }
}