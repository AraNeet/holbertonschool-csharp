using System;

/// <summary>
/// Queue class
/// </summary>
/// <typeparam name="T"></typeparam>
class Queue<T>{
  /// <summary>
  /// CheckType method
  /// </summary>
  /// <returns>Type</returns>
  public Type CheckType(){
    return typeof(T);
  }
}