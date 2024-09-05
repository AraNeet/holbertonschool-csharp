using System;

/// <summary>
/// Class that contains a method to check if a type is a subclass of another type.
/// </summary>
class Obj
{
    /// <summary>
    /// Check if a type is a subclass of another type.
    /// </summary>
    /// <param name="derivedType">The type to check if it is a subclass.</param>
    /// <param name="baseType">The type to check if it is the base class.</param>
    /// <returns>True if the derivedType is a subclass of baseType, false otherwise.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}