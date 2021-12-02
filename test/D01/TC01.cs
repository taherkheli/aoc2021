using Xunit;
using aoc.D01;

namespace aoc.test
{
  public class TC01
  {
    private MeasurementsCounter _measurementCounter;

    public TC01()
    {
      _measurementCounter = new MeasurementsCounter();
    }
    
    [Fact]
    public void InitialI()
    {
      var input = new[] { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };
      int expected = 7;

      var actual = _measurementCounter.GetMeasurementsIncreasedCount(input);

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void PartI()
    {
      int expected = 1139;
      var input = Parser.Parse(@"./D01/input.txt");

      var actual = _measurementCounter.GetMeasurementsIncreasedCount(input);

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void InitialII()
    {
      var input = new[] { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };
      int expected = 5;

      var actual = _measurementCounter.GetMeasurementsIncreasedCount(input, 3);

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void PartII()
    {
      int expected = 1103;
      var input = Parser.Parse(@"./D01/input.txt");

      var actual = _measurementCounter.GetMeasurementsIncreasedCount(input, 3);

      Assert.Equal(expected, actual);
    }
  }
}