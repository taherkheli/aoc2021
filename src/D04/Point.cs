namespace aoc.D04
{
  public struct Point
  {
    public Point(int value, bool marked)
    {
      Value = value;
      Marked = marked;
    }

    public int Value { get; set;  }
    public bool Marked { get; set; }

    public override string ToString() => $"({Value}, {Marked})";
  }
}
