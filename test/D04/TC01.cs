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
      int actual = -1;
      int count = 1;
      bool winFound = false;

      foreach (var n in numbers)
      {
        foreach (var b in boards)
        {
          b.Update(n);

          if (b.HasWon)
          {
            actual = b.Score;
            winFound = true;
            break;
          }
        }

        if (winFound)
          break;    

        count++;
      }

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void PartI()
    {
      int expected = 31424;
      var (numbers, boards) = Parser.Parse(@"./D04/input.txt");
      int actual = -1;
      int count = 1;
      bool winFound = false;

      foreach (var n in numbers)
      {
        foreach (var b in boards)
        {
          b.Update(n);

          if (b.HasWon)
          {
            actual = b.Score;
            winFound = true;
            break;
          }
        }

        if (winFound)
          break;

        count++;
      }

      Assert.Equal(expected, actual);
    }
  }
}