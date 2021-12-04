using aoc.D03;
using Xunit;

namespace aoc.test.D03
{
  public class TC01
  {
    [Fact]
    public void InitialI()
    {
      int expected = 198;
      var input = new string[] {
        "11110",
        "10110",
        "10111",
        "10101",
        "00100",
        "01111",
        "00111",
        "11100",
        "10000",
        "11001",
        "00010",
        "01010"
      };

      var d = new Diagnostics(input);

      var actual = d.Process();

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void PartI()
    {
      int expected = 4006064;
      var input = Parser.Parse(@"./D03/input.txt");

      var d = new Diagnostics(input);

      var actual = d.Process();

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void InitialII()
    {
      int expected = 230;
      var input = new string[] {
        "11110",
        "10110",
        "10111",
        "10101",
        "00100",
        "01111",
        "00111",
        "11100",
        "10000",
        "11001",
        "00010",
        "01010"
      };

      var d = new Diagnostics(input);

      var actual = d.ProcessII();

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void PartII()
    {
      int expected = 5941884;
      var input = Parser.Parse(@"./D03/input.txt");

      var d = new Diagnostics(input);

      var actual = d.ProcessII();

      Assert.Equal(expected, actual);
    }
  }
}