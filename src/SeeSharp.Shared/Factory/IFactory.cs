namespace SeeSharp.Shared.Factory;

public interface IFactory<T>
{
  public void Register<TType>(string key) where TType : T;
  public T Create(string key);
}