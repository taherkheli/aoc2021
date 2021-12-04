using System.Text;

namespace aoc.D03
{
  public class Diagnostics
  {
    private string[] _codes;

    public Diagnostics(string[] codes)
    {
      _codes = codes;
    }

    public int Process() 
    {
      int ones = 0;
      int zeroes = 0;
      int iterations = _codes[0].Length;
      var gammaRate_s = new StringBuilder();
      var epsilonRate_s = new StringBuilder();        

      for (int i = 0; i < iterations; i++)
      {
        ones = CountOnes(i, _codes.ToList());
        zeroes = _codes.Length - ones;

        if (ones > zeroes)
        {
          gammaRate_s.Append("1");
          epsilonRate_s.Append("0");
        }
        else
        {
          gammaRate_s.Append("0");
          epsilonRate_s.Append("1");
        }
      }

      int gammaRate = Convert.ToInt32(Convert.ToInt32(gammaRate_s.ToString(), 2).ToString());
      int epsilonRate = Convert.ToInt32(Convert.ToInt32(epsilonRate_s.ToString(), 2).ToString());

      return gammaRate * epsilonRate;
    }

    public int ProcessII()
    {
      int ones = 0;
      int zeroes = 0;
      int iterations = _codes[0].Length;

      var o2Generator_list = _codes.ToList<String>();
      var co2Scrubber_list = _codes.ToList<String>();

      for (int i = 0; i < iterations; i++)
      {
        ones = CountOnes(i, o2Generator_list);
        zeroes = o2Generator_list.Count - ones;

        if (ones >= zeroes)
        {
          if (o2Generator_list.Count > 1)
            KeepOnes(i, o2Generator_list);
        }
        else
        {
          if (o2Generator_list.Count > 1)
            KeepZeroes(i, o2Generator_list);
        }
      }

      for (int i = 0; i < iterations; i++)
      {
        ones = CountOnes(i, co2Scrubber_list);
        zeroes = co2Scrubber_list.Count - ones;

        if (ones >= zeroes)
        {
          if (co2Scrubber_list.Count > 1)
            KeepZeroes(i, co2Scrubber_list);
        }
        else
        {
          if (co2Scrubber_list.Count > 1)
            KeepOnes(i, co2Scrubber_list);
        }
      }

      int o2Generator = Convert.ToInt32(Convert.ToInt32(o2Generator_list[0], 2).ToString());
      int co2Scrubber = Convert.ToInt32(Convert.ToInt32(co2Scrubber_list[0], 2).ToString());

      return o2Generator * co2Scrubber;
    }

    private int CountOnes(int index, List<string> list)
    {
      int ones = 0;

      for (int i = 0; i < list.Count; i++)
      {
        if (Int32.Parse((list[i][index]).ToString()) > 0)
          ones++;
      }

      return ones;
    }

    //given a list of strings, and an index, remove an item if it has a Zero in that 'column'
    private void KeepOnes(int index, List<string> list)
    {
      if (list.Count > 1)
        list.RemoveAll(s => Int32.Parse(s[index].ToString()) < 1);      
    }

    //given a list of strings, and an index, remove an item if it has a One in that 'column'
    private void KeepZeroes(int index, List<string> list)
    {
      if (list.Count > 1)
        list.RemoveAll(s => Int32.Parse(s[index].ToString()) > 0);
    }
  }
}
