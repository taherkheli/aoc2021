using aoc.D06;
using Xunit;

namespace aoc.test.D06
{
  public class TC01
  {
    [Fact]
    public void InitialI()
    {
      int expected = 5934;
      var ages = new int[] { 3, 4, 3, 1, 2 };

      var farm = new FishFarm(ages);
      var actual = farm.Simulate(80);

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void PartI()
    {
      int expected = 371379;
      var ages = Parser.Parse(@"./D06/input.txt");
            
      var farm = new FishFarm(ages);
      var actual = farm.Simulate(80);

      Assert.Equal(expected, actual);
    }

  //  [Fact]
  //  public void InitialII()
  //  {
  //    long expected = 26984457539;
  //    var ages = new int[] { 3, 4, 3, 1, 2 };

  //    var farm = new FishFarm(ages);
  //    var actual = farm.Simulate(256);

  //    Assert.Equal(expected, actual);
  //  }

  //  [Fact]
  //  public void PartII()
  //  {
  //    long expected = 26984457539;
  //    var ages = Parser.Parse(@"./D06/input.txt");

  //    var farm = new FishFarm(ages);
  //    var actual = farm.Simulate(256);

  //    Assert.Equal(expected, actual);
  //  }

  }
}