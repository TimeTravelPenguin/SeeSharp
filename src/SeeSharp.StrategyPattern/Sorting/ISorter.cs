namespace SeeSharp.StrategyPattern.Sorting;

internal interface ISorter<T>
{
  IEnumerable<T> Sort(IEnumerable<T> collection);
}