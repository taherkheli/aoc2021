using aoc.D05;
using Xunit;

namespace aoc.test.D05
{
  public class TC01
  {
    [Fact]
    public void InitialI()
    {
      int expected = 5;
      var lines = Parser.Parse(@"./D05/input_initial.txt");

      var grid = new Grid(lines);

      var actual = grid.Calculate();

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void PartI()
    {
      int expected = 7297;
      var lines = Parser.Parse(@"./D05/input.txt");

      var grid = new Grid(lines);
      
      var actual = grid.Calculate();

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void InitialII()
    {
      int expected = 12;
      var lines = Parser.Parse(@"./D05/input_initial.txt");

      var grid = new Grid(lines);

      var actual = grid.Calculate(true);

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void PartII()
    {
      int expected = 21038;
      var lines = Parser.Parse(@"./D05/input.txt");

      var grid = new Grid(lines);

      var actual = grid.Calculate(true);

      Assert.Equal(expected, actual);
    }
  }
}