namespace aoc.D02
{
  public class Submarine
  {
    private Instruction[] _instructions;
    private int _position;
    private int _depth;

    public Submarine(Instruction[] instructions)
    {
      _instructions = instructions;
      _depth = 0;
      _position = 0;
    }

    public int Depth { get { return _depth; } }

    public int Position { get { return _position;} }

    public void Execute() 
    {
      foreach (var instruction in _instructions)
      {
        switch (instruction.Direction)
        {
          case Direction.Forward:
            _position += instruction.StepSize;
            break;
          case Direction.Down:
            _depth+=instruction.StepSize;
            break;
          case Direction.Up:
            _depth -= instruction.StepSize;
            break;
          case Direction.Undefined:
          default:
            break;
        }
      }
    }
  }
}
