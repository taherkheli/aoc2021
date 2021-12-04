using aoc.D02;
using Xunit;

namespace aoc.test.D02
{
  public class TC01
  {
    private Submarine? _submarine;

    [Fact]
    public void InitialI()
    {
      int expected = 150;
      var input = new Instruction[] { new Instruction() { Direction = Direction.Forward, StepSize = 5 },
                                      new Instruction() { Direction = Direction.Down, StepSize = 5 },
                                      new Instruction() { Direction = Direction.Forward, StepSize = 8 },
                                      new Instruction() { Direction = Direction.Up, StepSize = 3 },
                                      new Instruction() { Direction = Direction.Down, StepSize = 8 },
                                      new Instruction() { Direction = Direction.Forward, StepSize = 2 } };

      _submarine = new Submarine(input);
      _submarine.Execute();

      var actual = _submarine.Position * _submarine.Depth; 
      
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void PartI()
    {
      int expected = 1840243;
      var input = Parser.Parse(@"./D02/input.txt");

      _submarine = new Submarine(input);
      _submarine.Execute();

      var actual = _submarine.Position * _submarine.Depth;

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void InitialII()
    {
      int expected = 900;
      var input = new Instruction[] { new Instruction() { Direction = Direction.Forward, StepSize = 5 },
                                      new Instruction() { Direction = Direction.Down, StepSize = 5 },
                                      new Instruction() { Direction = Direction.Forward, StepSize = 8 },
                                      new Instruction() { Direction = Direction.Up, StepSize = 3 },
                                      new Instruction() { Direction = Direction.Down, StepSize = 8 },
                                      new Instruction() { Direction = Direction.Forward, StepSize = 2 } };

      _submarine = new Submarine(input);
      _submarine.ExecuteII();

      var actual = _submarine.Position * _submarine.Depth;

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void PartII()
    {
      int expected = 1727785422;
      var input = Parser.Parse(@"./D02/input.txt");

      _submarine = new Submarine(input);
      _submarine.ExecuteII();

      var actual = _submarine.Position * _submarine.Depth;

      Assert.Equal(expected, actual);
    }

  }
}