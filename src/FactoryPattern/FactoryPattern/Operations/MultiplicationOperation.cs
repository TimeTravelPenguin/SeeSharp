namespace SeeSharp.FactoryPattern.Operations;

internal class MultiplicationOperation : IBinaryOperation
{
  public double Apply(double fst, double snd)
  {
    return fst * snd;
  }
}