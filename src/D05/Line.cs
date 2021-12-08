using System.Linq;

namespace aoc.D05
{
  public class Line
  {
    private Point _start;
    private Point _end;

    public Line(Point start, Point end)
    {
      _start = start;
      _end = end;
    }

    public Point Start { get { return _start; } }

    public Point End { get { return _end; } }
  }
}
