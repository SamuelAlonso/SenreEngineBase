using System;

namespace SenreEngine
{
#pragma warning disable 0660, 0661 //Same as Vector2
    public struct Vector3
    {
        public float x, y, z;

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Vector3(Vector3 Other)
        {
            this.x = Other.x;
            this.y = Other.y;
            this.z = Other.z;
        }
        public static Vector3 Empty
        {
            get
            {
                return new Vector3();
            } 
        }
        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
        }
        public static Vector3 operator *(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
        }
        public static Vector3 operator /(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x / b.x, a.y / b.y, a.z / b.z);
        }
        public static Vector3 operator ++(Vector3 a)
        {
            return new Vector3(a.x++, a.y++, a.z++);
        }
        public static Vector3 operator --(Vector3 a)
        {
            return new Vector3(a.x--, a.y--, a.z--);
        }
        public static Vector3 operator +(Vector3 a, float b)
        {
            return new Vector3(a.x + b, a.y + b, a.z + b);
        }
        public static Vector3 operator -(Vector3 a, float b)
        {
            return new Vector3(a.x - b, a.y - b, a.z - b);
        }
        public static Vector3 operator *(Vector3 a, float b)
        {
            return new Vector3(a.x * b, a.y * b, a.z * b);
        }
        public static Vector3 operator /(Vector3 a, float b)
        {
            return new Vector3(a.x / b, a.y / b, a.z / b);
        }
        public static Vector3 operator +(Vector3 a, int b)
        {
            return new Vector3(a.x + b, a.y + b, a.z + b);
        }
        public static Vector3 operator -(Vector3 a, int b)
        {
            return new Vector3(a.x - b, a.y - b, a.z - b);
        }
        public static Vector3 operator *(Vector3 a, int b)
        {
            return new Vector3(a.x * b, a.y * b, a.z * b);
        }
        public static Vector3 operator /(Vector3 a, int b)
        {
            return new Vector3(a.x / b, a.y / b, a.z / b);
        }
        public static Vector3 operator +(Vector3 a, double b)
        {
            return new Vector3(a.x + (float)b, a.y + (float)b, a.z + (float)b);
        }
        public static Vector3 operator -(Vector3 a, double b)
        {
            return new Vector3(a.x - (float)b, a.y - (float)b, a.z - (float)b);
        }
        public static Vector3 operator *(Vector3 a, double b)
        {
            return new Vector3(a.x * (float)b, a.y * (float)b, a.z * (float)b);
        }
        public static Vector3 operator /(Vector3 a, double b)
        {
            return new Vector3(a.x / (float)b, a.y / (float)b, a.z / (float)b);
        }
        public static Vector3 operator +(float b, Vector3 a)
        {
            return new Vector3(a.x + b, a.y + b, a.z + b);
        }
        public static Vector3 operator -(float b, Vector3 a)
        {
            return new Vector3(a.x - b, a.y - b, a.z - b);
        }
        public static Vector3 operator *(float b, Vector3 a)
        {
            return new Vector3(a.x * b, a.y * b, a.z * b);
        }
        public static Vector3 operator /(float b, Vector3 a)
        {
            return new Vector3(a.x / b, a.y / b, a.z / b);
        }
        public static Vector3 operator +(int b, Vector3 a)
        {
            return new Vector3(a.x + b, a.y + b, a.z + b);
        }
        public static Vector3 operator -(int b, Vector3 a)
        {
            return new Vector3(a.x - b, a.y - b, a.z - b);
        }
        public static Vector3 operator *(int b, Vector3 a)
        {
            return new Vector3(a.x * b, a.y * b, a.z * b);
        }
        public static Vector3 operator /(int b, Vector3 a)
        {
            return new Vector3(a.x / b, a.y / b, a.z / b);
        }
        public static Vector3 operator +(double b, Vector3 a)
        {
            return new Vector3(a.x + (float)b, a.y + (float)b, a.z + (float)b);
        }
        public static Vector3 operator -(double b, Vector3 a)
        {
            return new Vector3(a.x - (float)b, a.y - (float)b, a.z - (float)b);
        }
        public static Vector3 operator *(double b, Vector3 a)
        {
            return new Vector3(a.x * (float)b, a.y * (float)b, a.z * (float)b);
        }
        public static Vector3 operator /(double b, Vector3 a)
        {
            return new Vector3(a.x / (float)b, a.y / (float)b, a.z / (float)b);
        }
        public static bool operator ==(Vector3 a, Vector3 b)
        {
            if (a.x == b.x && a.y == b.y && a.z == b.z)
            {
                return true;
            }
            else { return false; }
        }
        public static bool operator !=(Vector3 a, Vector3 b)
        {
            if (a.x != b.x && a.y != b.y && a.z != b.z)
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
            return base.ToString() + ": " + x.ToString() + ", " + y.ToString() + ", " + z.ToString();
        }
        public static Vector3 Vector4ToVector3(Vector4 a)
        {
            return new Vector3(a.x, a.y, a.z);
        }
        public static Vector3 Vector2ToVector3(Vector2 a, float z = 1)
        {
            return new Vector3(a.x, a.y, z);
        }
        public static Vector3 Absolute(Vector3 a)
        {
            if(a.x < 0 && a.y < 0 && a.z < 0)
            {
                return new Vector3(-a.x, -a.y, -a.z);
            }
            else if(a.x < 0 && a.y < 0)
            {
                return new Vector3(-a.x, -a.y, a.z);
            }
            else if(a.x < 0 && a.z < 0)
            {
                return new Vector3(-a.x, a.y, -a.z);
            }
            else if(a.y < 0 && a.z < 0)
            {
                return new Vector3(a.x, -a.y, -a.z);
            }
            else if (a.x < 0)
            {
                return new Vector3(-a.x, a.y, a.z);
            }
            else if(a.y < 0)
            {
                return new Vector3(a.x, -a.y, a.z);
            }
            else if(a.z < 0)
            {
                return new Vector3(a.x, a.y, -a.z);
            }
            else
            {
                return a;
            }
        }
        public static Vector3 Max(Vector3 a, Vector3 b)
        {
            float newX = 0;
            float newY = 0;
            float newZ = 0;

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
            if(a.z > b.z)
            {
                newZ = a.z;
            }
            else
            {
                newZ = b.z;
            }
            return new Vector3(newX, newY, newZ);
        }
        public static Vector3 Min(Vector3 a, Vector3 b)
        {
            float newX = 0;
            float newY = 0;
            float newZ = 0;

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
            if (a.z < b.z)
            {
                newZ = a.z;
            }
            else
            {
                newZ = b.z;
            }
            return new Vector3(newX, newY, newZ);
        }
        public static float Normalize(Vector3 a)
        {
            return (float)Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z);
        }
        public static float Dot(Vector3 a, Vector3 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }
        public static float Distance(Vector3 a, Vector3 b)
        {
            return Normalize(a) - Normalize(b);
        }
        public static float Angle(Vector3 a, Vector3 b)
        {
            return (float)Math.Cos(Dot(a, b) / (Normalize(a) * Normalize(b)));
        }
        public static Vector3 Cross(Vector3 a, Vector3 b)
        {
            return new Vector3(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x);
        }
        public static Vector3 Lerp(Vector3 a, Vector3 b, float time_to_interpolate)
        {
            return a + time_to_interpolate * (b - a);
        }
        public static Vector3 Slerp(Vector3 a, Vector3 b, float time_to_interpolate)
        {
            float dot = Dot(a, b);
            MathUtilities.Clamp(ref dot, -1, 1);
            float theta = (float)Math.Acos(dot) * time_to_interpolate;
            float Relative = Normalize(b - a * dot);
            return new Vector3((a.x * (float)Math.Cos(theta)) + (Relative * (float)Math.Sin(theta)), (a.y * (float)Math.Cos(theta)) + (Relative * (float)Math.Sin(theta)), (a.z * (float)Math.Cos(theta)) + (Relative * (float)Math.Sin(theta)));
        }
        public static bool Orthogonals(Vector3 a, Vector3 b)
        {
            if(Dot(a, b) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Orthonormals(Vector3 a, Vector3 b)
        {
            if(Dot(a, b) == 0 && Normalize(a) == Normalize(b) && Normalize(a) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Vector3 ProjectOnVector(Vector3 a, Vector3 b)
        {
            return new Vector3((a * b)/(b * b) * b);
        }
        public static Vector3 ProjectOnScalar(Vector3 a, Vector3 b)
        {
            return new Vector3((a * b) / Absolute(b));
        }
        public static Vector3 Reflect(Vector3 a, Vector3 b)
        {
            return new Vector3(a - 2 * (a * b) * b);
        }
        public static Vector3 FindOrthogonal(Vector3 a, Vector3 b)
        {
            Vector3 cross = Cross(a, b);
            return new Vector3(cross / Normalize(cross));
        }
    }
#pragma warning restore 0660, 0661
}
