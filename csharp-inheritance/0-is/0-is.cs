using System;
using System.Collections.Generic;

/// <summary>
/// The Obj class.
/// </summary>
class Obj
{
    /// <summary>
    /// Determines if the object is an integer.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if the object is an integer, false otherwise.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}