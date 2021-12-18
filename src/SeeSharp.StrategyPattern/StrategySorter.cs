#region Title Header

// Name: Phillip Smith
// 
// Solution: SeeSharp
// Project: SeeSharp.StrategyPattern
// File Name: StrategySorter.cs
// 
// Current Data:
// 2021-12-18 12:34 PM
// 
// Creation Date:
// 2021-12-18 12:20 PM

#endregion

#region usings

using SeeSharp.Shared.Factory;
using SeeSharp.StrategyPattern.Sorting;

#endregion

namespace SeeSharp.StrategyPattern;

internal class StrategySorter<T>
{
  private readonly IFactory<ISorter<T>> _factory;

  public StrategySorter(IFactory<ISorter<T>> sorterFactory)
  {
    _factory = sorterFactory;
  }

  public IEnumerable<T> SortUsing(string sorterName, IEnumerable<T> collection)
  {
    // This is the heart of our Strategy Pattern. It delegates the work to the object
    // inheriting the interface. This way, our object doesn't need to know anything about
    // what or 'how' it is going to sort. It simply passes the collection to the sorter object.
    var sorter = _factory.Create(sorterName);
    return sorter.Sort(collection);
  }
}