using System;

/// <summary>
/// Base class
/// </summary>
abstract class Base {

    public string name { get; set; }

    /// <summary>
    ///  ToString method
    /// </summary>
    /// <returns>String</returns>
    public override string ToString() {
        return $"{name} is a {this.GetType()}";
    }

}