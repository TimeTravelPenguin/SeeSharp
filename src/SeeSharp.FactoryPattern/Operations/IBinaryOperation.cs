#region Title Header

// Name: Phillip Smith
// 
// Solution: SeeSharp
// Project: SeeSharp.FactoryPattern
// File Name: IBinaryOperation.cs
// 
// Current Data:
// 2021-12-18 12:36 PM
// 
// Creation Date:
// 2021-12-18 12:34 PM

#endregion

namespace SeeSharp.FactoryPattern.Operations;

internal interface IBinaryOperation
{
  double Apply(double fst, double snd);
}