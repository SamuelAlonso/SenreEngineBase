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
    }
#pragma warning restore 0660, 0661
}
