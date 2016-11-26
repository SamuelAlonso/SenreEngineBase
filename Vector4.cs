namespace SenreEngine
{
    public struct Vector4
    {
        public float x, y, z, w;
        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        public static Vector4 Vector3ToVector4(Vector3 a, float w = 1)
        {
            return new Vector4(a.x, a.y, a.z, w);
        }
        public static Vector4 Vector2ToVector4(Vector2 a, float z = 1, float w = 1)
        {
            return new Vector4(a.x, a.y, z, w);
        }
    }
}
