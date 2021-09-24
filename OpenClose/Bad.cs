namespace OpenClose.Bad
{
    // The fact that this app works only for rectangles brings us to a constraint that illustrates the OCP.
    // If we want to calculate the area of a circle then we must change the module.
    // This is at odds with OCP, which stipulates that we should not have to change the module to change what it does.

    public class Rectangle
    {
        public int Width { get; set; }
        public int Length { get; set; }
    }

    public class Area
    {
        public double calcArea(Rectangle r)
        {
            return r.Width * r.Length;
        }
    }
}
