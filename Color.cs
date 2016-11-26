namespace SenreEngine
{
    public struct Color
    {
        public float Alpha, Red, Green, Blue;
        

        public Color(float a, float r, float g, float b)
        {
            Alpha = MathUtilities.Max(1, a);
            Alpha = MathUtilities.Min(0, a);
            Red = MathUtilities.Max(1, r);
            Red = MathUtilities.Min(0, r);
            Green = MathUtilities.Max(1, g);
            Green = MathUtilities.Min(0, g);
            Blue = MathUtilities.Max(1, b);
            Blue = MathUtilities.Min(0, b);
        }
        public static float Max(Color color)
        {
            if(color.Blue > color.Green && color.Blue > color.Red)
            {
                return color.Blue;
            }
            else if(color.Green > color.Blue && color.Green > color.Red)
            {
                return color.Green;
            }
            else
            {
                return color.Red;
            }
        }
        public static float Min(Color color)
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
        public static Color Lerp(Color a, Color b, float t)
        {
            return new Color(a.Alpha + (b.Alpha - a.Alpha) * t, a.Red + (b.Red - a.Red) * t, a.Green + (b.Green - a.Green) * t, a.Blue + (b.Blue - a.Blue) * t);
        }
        public static void RGBToHSL(Color RGB, out float H, out float S, out float L)
        {
            L = MathUtilities.FloorCeiling((Min(RGB) + Max(RGB))* 0.5f);
            float max = Color.Max(RGB);
            float d = Color.Max(RGB) - Color.Min(RGB);
            if (max == Color.Min(RGB))
            {
                H = 0;
                S = 0;
            }
            else
            {
                if(L > 0.5f)
                {
                    S = d /(2 - max - Color.Min(RGB));
                }
                else
                {
                    S = d / (max + Color.Min(RGB));
                }
                if (max == RGB.Red)
                {
                    H = (RGB.Green - RGB.Blue)/(max - Color.Min(RGB));
                    if (H > 0)
                    {
                        H *= 60;
                    }
                    else
                    {
                        H += 360;
                    }
                }
                else if(max == RGB.Green)
                {
                    H = 2 +(RGB.Blue - RGB.Red)/(max - Color.Min(RGB));
                    if (H > 0)
                    {
                        H *= 60;
                    }
                    else
                    {
                        H += 360;
                    }
                }
                else
                {
                    H = 4 + (RGB.Red - RGB.Green)/(max - Color.Min(RGB));
                    if(H > 0)
                    {
                        H *= 60;
                    }
                    else
                    {
                        H += 360;
                    }
                }
            }
        }
        public static void RGBToHSV(Color RGB, out float H, out float S, out float V)
        {
            float L = MathUtilities.FloorCeiling((Min(RGB) + Max(RGB)) * 0.5f);
            float max = Color.Max(RGB);
            V = max;
            float d = Color.Max(RGB) - Color.Min(RGB);
            if (max == Color.Min(RGB))
            {
                H = 0;
                S = 0;
            }
            else
            {
                if (L > 0.5f)
                {
                    S = d / (2 - max - Color.Min(RGB));
                }
                else
                {
                    S = d / (max + Color.Min(RGB));
                }
                if (max == RGB.Red)
                {
                    H = (RGB.Green - RGB.Blue) / (max - Color.Min(RGB));
                    if (H > 0)
                    {
                        H *= 60;
                    }
                    else
                    {
                        H += 360;
                    }
                }
                else if (max == RGB.Green)
                {
                    H = 2 + (RGB.Blue - RGB.Red) / (max - Color.Min(RGB));
                    if (H > 0)
                    {
                        H *= 60;
                    }
                    else
                    {
                        H += 360;
                    }
                }
                else
                {
                    H = 4 + (RGB.Red - RGB.Green) / (max - Color.Min(RGB));
                    if (H > 0)
                    {
                        H *= 60;
                    }
                    else
                    {
                        H += 360;
                    }
                }
            }
        }
        public static implicit operator Color(ColorByte c)
        {
            return new Color(c.Alpha / 256, c.Red / 256, c.Green / 256, c.Blue / 256);
        }
    }
}
