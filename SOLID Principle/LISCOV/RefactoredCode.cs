using System;

namespace LISCOV.Refactored
{
    public interface Shape
    {
        int TotalArea();
    }
    public class Square: Shape
    {
        public Square(int sideLength)
        {
            SideLength = sideLength;
        }
        public int SideLength { get; set; }
        public int TotalArea()
        {
            return SideLength * SideLength;
        }
    }
    public class Rectangle : Shape
    {
        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }
        public int Height { get; set; }
        public int Width { get; set; }
        public int TotalArea()
        {
            return Height * Width;
        }
    }
}
