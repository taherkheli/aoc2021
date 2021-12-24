namespace aoc.D06
{
  public class FishFarm
  {
    private List<int> _intList;

    public FishFarm(int[] ages)
    {
      _intList = new List<int>();

      for (int i = 0; i < ages.Length; i++)
        _intList.Add(ages[i]);      
    }

    public long Simulate(int days)
    {
      for (int i = 0; i < days; i++)
      {
        var newBorns = 0;

        for (int j = 0; j < _intList.Count; j++)
        {
          if (_intList[j] == 0)
          {
            _intList[j] = 6;
            newBorns++;
          }
          else
            _intList[j]--;
        }        

        for (int k = 0; k < newBorns; k++)
          _intList.Add(8);
      }

      return _intList.Count;
    }
  }
}
