#region Title Header

// Name: Phillip Smith
// 
// Solution: SeeSharp
// Project: SeeSharp.StrategyPattern
// File Name: Program.cs
// 
// Current Data:
// 2021-12-18 12:33 PM
// 
// Creation Date:
// 2021-12-18 12:01 PM

#endregion

#region usings

#endregion

#region usings

using SeeSharp.Shared.Factory;
using SeeSharp.StrategyPattern.Sorting;

#endregion

namespace SeeSharp.StrategyPattern
{
  internal static class Program
  {
    public static void Main()
    {
      /*
       * The Strategy Pattern uses an interface to generify and abstract code.
       * In this example, a factory pattern implements the creation of two ISorter
       * objects. Then, the strategy pattern uses this factory to (naively) sort
       * any collection using the objects within the factory.
       */

      // Factory is created with all the relevant sorters
      var stringSorterFactory = new GenericFactory<ISorter<string>>();
      stringSorterFactory.Register<AscendingStringSorter>("ascending");
      stringSorterFactory.Register<DescendingStringSorter>("descending");

      // The StrategySorter implements the Strategy Pattern.
      var sorter = new StrategySorter<string>(stringSorterFactory);

      // The collection of words we wish to sort.
      var words = new List<string> { "Polymorphism", "Abstraction", "Generification", "Inheritance" };

      // We tell the StrategySorter to sort our collection using the keys registered within our factory.
      // Since the Strategy Pattern is implemented, it matters not which key we call to use.
      var asc = sorter.SortUsing("ascending", words);
      var desc = sorter.SortUsing("descending", words);

      Console.WriteLine("Ascending:");
      Console.WriteLine(string.Join(", ", asc));
      Console.WriteLine();

      Console.WriteLine("Descending:");
      Console.WriteLine(string.Join(", ", desc));
      Console.WriteLine();

      Console.WriteLine("Done");
      Console.ReadKey(true);
    }
  }
}