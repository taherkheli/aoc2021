namespace aoc.D02
{
  public class Submarine
  {
    private Instruction[] _instructions;
    private int _position;
    private int _depth;
    private int _aim;

    public Submarine(Instruction[] instructions)
    {
      _instructions = instructions;
      _depth = 0;
      _position = 0;
      _aim = 0;
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
            _depth += instruction.StepSize;
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

    public void ExecuteII() 
    {
      foreach (var instruction in _instructions)
      {
        switch (instruction.Direction)
        {
          case Direction.Forward:
            _position += instruction.StepSize;
            _depth += _aim * instruction.StepSize;
            break;
          case Direction.Down:
            _aim += instruction.StepSize;
            break;
          case Direction.Up:
            _aim -= instruction.StepSize;
            break;
          case Direction.Undefined:
          default:
            break;
        }
      }
    }
  }
}
