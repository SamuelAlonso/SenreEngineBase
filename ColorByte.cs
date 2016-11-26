namespace SenreEngine
{
    public struct ColorByte
    {
        public byte Alpha, Red, Green, Blue;

        public ColorByte(byte a, byte r, byte g, byte b)
        {
            Alpha = MathUtilities.Max(255, a);
            Alpha = MathUtilities.Min(0, a);
            Red = MathUtilities.Max(255, r);
            Red = MathUtilities.Min(0, r);
            Green = MathUtilities.Max(255, g);
            Green = MathUtilities.Min(0, g);
            Blue = MathUtilities.Max(255, b);
            Blue = MathUtilities.Min(0, b);
        }
        public static byte Max(ColorByte color)
        {
            if (color.Blue > color.Green && color.Blue > color.Red)
            {
                return color.Blue;
            }
            else if (color.Green > color.Blue && color.Green > color.Red)
            {
                return color.Green;
            }
            else
            {
                return color.Red;
            }
        }
        public static byte Min(ColorByte color)
        {
            if (color.Blue < color.Green && color.Blue < color.Red)
            {
                return color.Blue;
            }
            else if (color.Green < color.Blue && color.Green < color.Red)
            {
                return color.Green;
            }
            else
            {
                return color.Red;
            }
        }
        public static implicit operator ColorByte(Color c)
        {
            return new ColorByte(System.Convert.ToByte(c.Alpha * 256), System.Convert.ToByte(c.Red * 256), System.Convert.ToByte(c.Green * 256), System.Convert.ToByte(c.Blue * 256));
        }
        public static implicit operator ColorByte(System.Drawing.Color c)
        {
            return new ColorByte(c.A, c.R, c.G, c.B);
        }
    }
}
