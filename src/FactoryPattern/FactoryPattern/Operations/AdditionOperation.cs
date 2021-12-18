namespace SeeSharp.FactoryPattern.Operations;

internal class AdditionOperation : IBinaryOperation
{
  public double Apply(double fst, double snd)
  {
    return fst + snd;
  }
}