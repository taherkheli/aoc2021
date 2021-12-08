namespace aoc.D05
{
  public class Point
  {
    public Point(int x, int y)
    {
      X = x;
      Y = y;
      DrawnCount = 0;
    }

    public int X { get; }

    public int Y { get; }
    
    public int DrawnCount { get; set; }

    public override string ToString() => $"({X}, {Y})";
  }
}
