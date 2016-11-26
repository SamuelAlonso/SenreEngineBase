namespace SenreEngine
{
    public class MathUtilities
    {
        public static float Max(float MaxValue, float Variable)
        {
            if(Variable > MaxValue)
            {
                return MaxValue;
            }
            else
            {
                return Variable;
            }
        }
        public static float Min(float MinValue, float Variable)
        {
            if (Variable < MinValue)
            {
                return MinValue;
            }
            else
            {
                return Variable;
            }
        }
        public static byte Max(byte MaxValue, byte Variable)
        {
            if (Variable > MaxValue)
            {
                return MaxValue;
            }
            else
            {
                return Variable;
            }
        }
        public static byte Min(byte MinValue, byte Variable)
        {
            if (Variable < MinValue)
            {
                return MinValue;
            }
            else
            {
                return Variable;
            }
        }
        public static int FloorCeiling(float Variable)
        {
            if(Variable - (int)Variable < 0.5f)
            {
                return (int)Variable;
            }
            else
            {
                return (int)Variable++;
            }
        }
        public static float ToRadians(float Angle)
        {
            return Angle * 0.0174532925f;
        }
        public static float ToAngle(float Angle)
        {
            return Angle * 57.2957795785523f;
        }
        public static void SwapFloats(ref float a, ref float b)
        {
            float stored_a = a;
            a = b;
            b = stored_a;
        }
    }
}
