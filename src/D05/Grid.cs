namespace aoc.D05
{
  public class Grid
  {
    private List<Line> _lines;
    private List<Point> _gridPoints;

    public Grid(List<Line> lines)
    {
      _lines = lines;
      _gridPoints = new List<Point>();
    }

    public int Calculate(bool partII = false)
    {
      int count = 0;
      List<Line> linesOfInterest;

      if (partII)
        linesOfInterest = GetLinesofInterest(true);
      else
        linesOfInterest = GetLinesofInterest();

      //draw
      foreach (var line in linesOfInterest)
      {
        bool horizontal = (line.Start.Y == line.End.Y);
        bool vertical = (line.Start.X == line.End.X);

        var xMin = Math.Min(line.Start.X, line.End.X);
        var xMax = Math.Max(line.Start.X, line.End.X);
        var yMin = Math.Min(line.Start.Y, line.End.Y);
        var yMax = Math.Max(line.Start.Y, line.End.Y);

        if (horizontal)  //y is constant
        {
          for (int i = xMin; i < xMax + 1; i++)
            Process(i, line.Start.Y);
        }
        else if (vertical) //x is constant
        {
          for (int i = yMin; i < yMax + 1; i++)
            Process(line.Start.X, i);
        }
        else //diagonal
        {
          //x n y both inc or x n y both dec
          if ( (line.Start.X < line.End.X) && (line.Start.Y < line.End.Y) || (line.Start.X > line.End.X) && (line.Start.Y > line.End.Y))
          {
            for (int i = 0; i < ((xMax - xMin) + 1); i++)
              Process(xMin + i, yMin + i);
          }
          else //x inc y dec or x dec y inc
          {
            for (int i = 0; i < ((xMax - xMin) + 1); i++)
              Process(xMin + i, yMax - i);
          }
        }
      }

      //count
      foreach (var p in _gridPoints)
        if (p.DrawnCount > 1)
          count++;

      return count;
    }

    private List<Line> GetLinesofInterest(bool partII = false)
    {
      var result = new List<Line>();

      //isolate lines of interest
      foreach (var line in _lines)
      {
        if ((line.Start.X == line.End.X) || (line.Start.Y == line.End.Y))
          result.Add(line);

        if (partII)
        {
          var deltaX = Math.Abs(line.End.X - line.Start.X);
          var deltaY = Math.Abs(line.End.Y - line.Start.Y);

          if (deltaX == deltaY)
            result.Add(line);
        }
      }
      
      return result;
    }

    //if a point with these coords exists udpate count otherwise add n update count
    private void Process(int x, int y)
    {
      var index = _gridPoints.FindIndex(p => ((p.X == x) && (p.Y == y)));
      if (index != -1)
      {
        _gridPoints[index].DrawnCount++;
      }
      else
      {
        var p = new Point(x, y);
        p.DrawnCount++;
        _gridPoints.Add(p);
      }
    }
  }
}
