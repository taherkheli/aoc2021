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

    //accepts only horizontal or vertical lines
    public static List<Point> GetPoints(Line l)
    {
      var result = new List<Point>();
      bool horizontal = (l.Start.Y == l.End.Y);
      bool vertical = (l.Start.X == l.End.X);

      if (!horizontal && !vertical)
        throw new InvalidOperationException("line must be verticla or horizontal");

      if (horizontal)  //y is constant
      {
        var xMin = Math.Min(l.Start.X, l.End.X);
        var xMax = Math.Max(l.Start.X, l.End.X);

        for (int i = xMin; i < xMax + 1; i++)
          result.Add(new Point(i, l.Start.Y));
      }
      else if (vertical) //x is constant
      {
        var yMin = Math.Min(l.Start.Y, l.End.Y);
        var yMax = Math.Max(l.Start.Y, l.End.Y);

        for (int i = yMin; i < yMax + 1; i++)
          result.Add(new Point(l.Start.X, i));
      }

      return result;
    }
  }
}
