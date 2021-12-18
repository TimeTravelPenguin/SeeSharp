#region Title Header

// Name: Phillip Smith
// 
// Solution: SeeSharp.
// Project: SeeSharp.Shared
// File Name: AdditionOperation.cs
// 
// Current Data:
// 2021-12-18 12:00 PM
// 
// Creation Date:
// 2021-12-18 11:59 AM

#endregion

namespace SeeSharp.FactoryPattern.Operations;

internal class AdditionOperation : IBinaryOperation
{
  public double Apply(double fst, double snd)
  {
    return fst + snd;
  }
}