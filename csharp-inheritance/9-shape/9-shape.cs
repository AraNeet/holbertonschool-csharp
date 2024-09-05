using System;

/// <summary>
/// Base class for all shapes
/// </summary>
class Shape
{
    /// <summary>
    /// Calculate the area of the shape
    /// </summary>
    /// <returns>Area of the shape</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Represents a rectangle
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Width of the rectangle
    /// </summary>
    public int Width
    {
        get { return width; }
        set {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    /// <summary>
    /// Height of the rectangle
    /// </summary>
    public int Height
    {
        get { return height; }
        set {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }

    /// <summary>
    /// Calculate the area of the rectangle
    /// </summary>
    public override int Area()
    {
        return Width * Height;
    }

    /// <summary>
    /// Returns a string representation of the rectangle
    /// </summary>
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}

/// <summary>
/// Represents a square
/// </summary>
class Square : Rectangle
{
    private int size;

    /// <summary>
    /// Size of the square
    /// </summary>
    public int Size
    {
        get { return size;}
        set {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            size = value;
            Width = size;
            Height = size;
        }
    }

    public override int Area()
    {
        return size * size;
    }

    public override string ToString()
    {
        return $"[Square] {size} / {size}";
    }
}