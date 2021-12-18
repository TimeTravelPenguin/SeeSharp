namespace SeeSharp.StrategyPattern.Sorting;

internal class DescendingStringSorter : ISorter<string>
{
  public IEnumerable<string> Sort(IEnumerable<string> collection)
  {
    return collection.OrderByDescending(x => x);
  }
}