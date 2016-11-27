using System;

namespace SenreEngine
{
#pragma warning disable 0660, 0661 // GetHashCode and Equals wasn't overloaded in operators == or != 
    public struct Vector2
    {
        public float x, y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public Vector2(Vector2 Other)
        {
            this.x = Other.x;
            this.y = Other.y;
        }
        public static Vector2 Empty
        {
            get
            {
                return new Vector2();
            }
        }
        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x + b.x, a.y + b.y);
        }
        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x - b.x, a.y - b.y);
        }
        public static Vector2 operator *(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x * b.x, a.y * b.y);
        }
        public static Vector2 operator /(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x / b.x, a.y / b.y);
        }
        public static Vector2 operator ++(Vector2 a)
        {
            return new Vector2(a.x++, a.y++);
        }
        public static Vector2 operator --(Vector2 a)
        {
            return new Vector2(a.x--, a.y--);
        }
        public static Vector2 operator +(Vector2 a, float b)
        {
            return new Vector2(a.x + b, a.y + b);
        }
        public static Vector2 operator -(Vector2 a, float b)
        {
            return new Vector2(a.x - b, a.y - b);
        }
        public static Vector2 operator *(Vector2 a, float b)
        {
            return new Vector2(a.x * b, a.y * b);
        }
        public static Vector2 operator /(Vector2 a, float b)
        {
            return new Vector2(a.x / b, a.y / b);
        }
        public static Vector2 operator +(Vector2 a, int b)
        {
            return new Vector2(a.x + b, a.y + b);
        }
        public static Vector2 operator -(Vector2 a, int b)
        {
            return new Vector2(a.x - b, a.y - b);
        }
        public static Vector2 operator *(Vector2 a, int b)
        {
            return new Vector2(a.x * b, a.y * b);
        }
        public static Vector2 operator /(Vector2 a, int b)
        {
            return new Vector2(a.x / b, a.y / b);
        }
        public static Vector2 operator +(Vector2 a, double b)
        {
            return new Vector2(a.x + (float)b, a.y + (float)b);
        }
        public static Vector2 operator -(Vector2 a, double b)
        {
            return new Vector2(a.x - (float)b, a.y - (float)b);
        }
        public static Vector2 operator *(Vector2 a, double b)
        {
            return new Vector2(a.x * (float)b, a.y * (float)b);
        }
        public static Vector2 operator /(Vector2 a, double b)
        {
            return new Vector2(a.x / (float)b, a.y / (float)b);
        }
        public static Vector2 operator +(float b, Vector2 a)
        {
            return new Vector2(a.x + b, a.y + b);
        }
        public static Vector2 operator -(float b, Vector2 a)
        {
            return new Vector2(a.x - b, a.y - b);
        }
        public static Vector2 operator *(float b, Vector2 a)
        {
            return new Vector2(a.x * b, a.y * b);
        }
        public static Vector2 operator /(float b, Vector2 a)
        {
            return new Vector2(a.x / b, a.y / b);
        }
        public static Vector2 operator +(int b, Vector2 a)
        {
            return new Vector2(a.x + b, a.y + b);
        }
        public static Vector2 operator -(int b, Vector2 a)
        {
            return new Vector2(a.x - b, a.y - b);
        }
        public static Vector2 operator *(int b, Vector2 a)
        {
            return new Vector2(a.x * b, a.y * b);
        }
        public static Vector2 operator /(int b, Vector2 a)
        {
            return new Vector2(a.x / b, a.y / b);
        }
        public static Vector2 operator +(double b, Vector2 a)
        {
            return new Vector2(a.x + (float)b, a.y + (float)b);
        }
        public static Vector2 operator -(double b, Vector2 a)
        {
            return new Vector2(a.x - (float)b, a.y - (float)b);
        }
        public static Vector2 operator *(double b, Vector2 a)
        {
            return new Vector2(a.x * (float)b, a.y * (float)b);
        }
        public static Vector2 operator /(double b, Vector2 a)
        {
            return new Vector2(a.x / (float)b, a.y / (float)b);
        }
        public static bool operator ==(Vector2 a, Vector2 b)
        {
            if (a.x == b.x && a.y == b.y)
            {
                return true;
            }
            else { return false; }
        }
        public static bool operator !=(Vector2 a, Vector2 b)
        {
            if (a.x != b.x && a.y != b.y)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public override string ToString()
        {
            return base.ToString() + ": " + x.ToString() + ", " + y.ToString();
        }

        public static Vector2 Absolute(Vector2 a)
        {
            if(a.x < 0 && a.y < 0)
            {
                return new Vector2(-a.x, -a.y);
            }
            else if (a.x < 0)
            {
                return new Vector2(-a.x, a.y);
            }
            else if(a.y < 0)
            {
                return new Vector2(a.x, -a.y);
            }
            else
            {
                return a;
            }
        }
        public static float Normalize(Vector2 a)
        {
            return (float)Math.Sqrt(a.x * a.x + a.y * a.y);
        }
        public static float Dot(Vector2 a, Vector2 b)
        {
            return a.x * b.x + a.y * b.y;
        }
        public static float Distance(Vector2 a, Vector2 b)
        {
            return Normalize(a) - Normalize(b);
        }
        public static float Angle(Vector2 a, Vector2 b)
        {
            return (float)Math.Cos(Dot(a, b) / (Normalize(a) * Normalize(b)));
        }
        public static Vector2 Lerp(Vector2 a, Vector2 b, float Time)
        {
            return a + Time * (b - a);
        }
        public static Vector2 Max(Vector2 a, Vector2 b)
        {
            float newX = 0;
            float newY = 0;

            if (a.x > b.x)
            {
                newX = a.x;
            }
            else
            {
                newX = b.x;
            }
            if (a.y > b.y)
            {
                newY = a.y;
            }
            else
            {
                newY = b.y;
            }
            return new Vector2(newX, newY);
        }
        public static Vector2 Min(Vector2 a, Vector2 b)
        {
            float newX = 0;
            float newY = 0;

            if (a.x < b.x)
            {
                newX = a.x;
            }
            else
            {
                newX = b.x;
            }
            if (a.y < b.y)
            {
                newY = a.y;
            }
            else
            {
                newY = b.y;
            }
            return new Vector2(newX, newY);
        }
        public static Vector2 Rotate(Vector2 vec, float angle)
        {
            float rad = MathUtilities.ToRadians(angle);
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);
            return new Vector2(vec.x * cos - vec.y * sin, vec.x * sin + vec.y * cos);
        }
        public static Vector2 Vector4ToVector2(Vector4 a)
        {
            return new Vector2(a.x, a.y);
        }
        public static Vector2 Vector3ToVector2(Vector3 a)
        {
            return new Vector2(a.x, a.y);
        }
    }
#pragma warning restore 0660, 0661
}
