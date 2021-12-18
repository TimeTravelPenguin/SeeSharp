namespace SeeSharp.FactoryPattern.Operations;

internal class SubtractionOperation : IBinaryOperation
{
  public double Apply(double fst, double snd)
  {
    return fst - snd;
  }
}