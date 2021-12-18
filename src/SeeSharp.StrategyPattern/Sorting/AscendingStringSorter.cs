namespace SeeSharp.StrategyPattern.Sorting;

internal class AscendingStringSorter : ISorter<string>
{
  public IEnumerable<string> Sort(IEnumerable<string> collection)
  {
    return collection.OrderBy(x => x);
  }
}