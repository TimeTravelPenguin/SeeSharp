#region Title Header

// Name: Phillip Smith
// 
// Solution: SeeSharp
// Project: SeeSharp.FactoryPattern
// File Name: SubtractionOperation.cs
// 
// Current Data:
// 2021-12-18 12:36 PM
// 
// Creation Date:
// 2021-12-18 12:34 PM

#endregion

namespace SeeSharp.FactoryPattern.Operations;

internal class SubtractionOperation : IBinaryOperation
{
  public double Apply(double fst, double snd)
  {
    return fst - snd;
  }
}