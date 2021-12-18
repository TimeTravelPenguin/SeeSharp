#region Title Header

// Name: Phillip Smith
// 
// Solution: FactoryPattern
// Project: SeeSharp.Shared
// File Name: GenericFactory.cs
// 
// Current Data:
// 2021-12-18 11:37 AM
// 
// Creation Date:
// 2021-12-18 11:12 AM

#endregion

namespace SeeSharp.Shared.Factory
{
  public class GenericFactory<T> : IFactory<T>
  {
    private readonly Dictionary<string, Func<T>> _registry = new();

    public void Register<TType>(string key) where TType : T
    {
      if (_registry.ContainsKey(key))
      {
        throw new InvalidOperationException($"The key '{key}' is already registered.");
      }

      _registry.Add(key, () => Activator.CreateInstance<TType>());
    }

    public T Create(string key)
    {
      if (!_registry.TryGetValue(key, out var item))
      {
        throw new InvalidOperationException($"The key '{key}' is not registered.");
      }

      if (item is null)
      {
        throw new InvalidOperationException($"The value associated with the key '{key}' is null.");
      }

      return item();
    }
  }
}