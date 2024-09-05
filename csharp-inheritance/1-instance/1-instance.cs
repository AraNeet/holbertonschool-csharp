using System;
using System.Collections.Generic;

/// <summary>
/// Class to check if an object is an instance of an array.
/// </summary>
class Obj
{
    /// <summary>
    /// Check if an object is an instance of an array.
    /// </summary>
    /// <param name="obj">Object to check.</param>
    /// <returns>True if the object is an instance of an array, false otherwise.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}