namespace aoc.D04
{
  public class Bingo
  {
    private List<int> _numbers;
    private List<Board> _boards;

    public Bingo(List<int> numbers, List<Board> boards)
    {
      _numbers = numbers;
      _boards = boards;
    }

    public int PartI() 
    {
      int result = int.MinValue;
      bool winFound = false;

      foreach (var n in _numbers)
      {
        foreach (var b in _boards)
        {
          b.Update(n);

          if (b.Wins > 0)
          {
            result = b.Score;
            winFound = true;
            break;
          }
        }

        if (winFound)
          break;
      }

      return result;  
    }

    public int PartII()
    {
      int result = int.MinValue;
      bool lastBoardFound = false;

      foreach (var n in _numbers)
      {
        foreach (var b in _boards)
        {
          b.Update(n);

          if (b.Wins > 0)
          {
            result = b.Score;
            lastBoardFound = CheckIfItsTheLastBoardToWin();

            if (lastBoardFound)
              break;            
          }
        }

        if (lastBoardFound)
          break;
      }

      return result;
    }

    //called when a new win has been registered
    private bool CheckIfItsTheLastBoardToWin()
    {
      return ((_boards.FindAll(b => b.Wins == 0).Count == 0) ? true : false);
    }
  }
}
