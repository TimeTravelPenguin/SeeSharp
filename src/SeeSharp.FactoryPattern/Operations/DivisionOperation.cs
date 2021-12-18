namespace SeeSharp.FactoryPattern.Operations;

internal class DivisionOperation : IBinaryOperation
{
  public double Apply(double fst, double snd)
  {
    return fst / snd;
  }
}