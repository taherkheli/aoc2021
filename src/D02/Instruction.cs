namespace aoc.D02
{
  public readonly struct Instruction
  {
    public Instruction(Direction direction, int stepSize)
    {
      Direction = direction;
      StepSize = stepSize;
    }

    public Direction Direction { get; init; }

    public int StepSize { get; init; }

    public override string ToString() => $"{Direction} ({StepSize})";
  }
}
