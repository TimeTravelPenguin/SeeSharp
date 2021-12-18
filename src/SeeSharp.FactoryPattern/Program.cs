#region Title Header

// Name: Phillip Smith
// 
// Solution: SeeSharp
// Project: SeeSharp.FactoryPattern
// File Name: Program.cs
// 
// Current Data:
// 2021-12-18 12:35 PM
// 
// Creation Date:
// 2021-12-18 11:10 AM

#endregion

#region usings

using SeeSharp.FactoryPattern.Operations;
using SeeSharp.Shared.Factory;

#endregion

namespace SeeSharp.FactoryPattern
{
  internal static class Program
  {
    public static void Main()
    {
      /*
       * The Factory Pattern can be used to instantiate object on your behalf.
       * This can allow for more abstract and dynamic code, especially when fitted
       * into other pattern, such as the strategy pattern.
       */

      var factory = new GenericFactory<IBinaryOperation>();
      factory.Register<AdditionOperation>("addition");
      factory.Register<SubtractionOperation>("subtraction");
      factory.Register<MultiplicationOperation>("multiplication");
      factory.Register<DivisionOperation>("division");

      const double x = 3;
      const double y = 4;

      var add = factory.Create("addition");
      Console.WriteLine($"{x} + {y} = " + add.Apply(3, 4));

      var sub = factory.Create("subtraction");
      Console.WriteLine($"{x} - {y} = " + sub.Apply(3, 4));

      var times = factory.Create("multiplication");
      Console.WriteLine($"{x} * {y} = " + times.Apply(3, 4));

      var div = factory.Create("division");
      Console.WriteLine($"{x} / {y} = " + div.Apply(3, 4));

      Console.WriteLine("Done");
      Console.ReadKey(true);
    }
  }
}