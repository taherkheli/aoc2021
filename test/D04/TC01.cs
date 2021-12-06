using aoc.D04;
using Xunit;

namespace aoc.test.D04
{
  public class TC01
  {
    [Fact]
    public void InitialI()
    {
      int expected = 4512;
      var (numbers, boards) = Parser.Parse(@"./D04/input_initial.txt");
      var bingo = new Bingo(numbers, boards);

      int actual =bingo.PartI();

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void PartI()
    {
      int expected = 31424;
      var (numbers, boards) = Parser.Parse(@"./D04/input.txt");

      var bingo = new Bingo(numbers, boards);

      int actual = bingo.PartI();
      
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void InitialII()
    {
      int expected = 1924;
      var (numbers, boards) = Parser.Parse(@"./D04/input_initial.txt");

      var bingo = new Bingo(numbers, boards);

      int actual = bingo.PartII();

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void PartII()
    {
      int expected = 23042;
      var (numbers, boards) = Parser.Parse(@"./D04/input.txt");

      var bingo = new Bingo(numbers, boards);

      int actual = bingo.PartII();

      Assert.Equal(expected, actual);
    }
  }
}