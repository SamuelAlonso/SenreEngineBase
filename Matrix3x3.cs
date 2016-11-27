namespace SenreEngine
{
    public struct Matrix3x3
    {
        public float M1, M2, M3, M4, M5, M6, M7, M8, M9;
        public Matrix3x3(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9)
        {
            this.M1 = m1;
            this.M2 = m2;
            this.M3 = m3;
            this.M4 = m4;
            this.M5 = m5;
            this.M6 = m6;
            this.M7 = m7;
            this.M8 = m8;
            this.M9 = m9;
        }
        public Matrix3x3(Vector3 row1, Vector3 row2, Vector3 row3)
        {
            this.M1 = row1.x;
            this.M2 = row1.y;
            this.M3 = row1.z;
            this.M4 = row2.x;
            this.M5 = row2.y;
            this.M6 = row2.z;
            this.M7 = row3.x;
            this.M8 = row3.y;
            this.M9 = row3.z;
           
        }
        public Matrix3x3(Vector3 column1, Vector3 column2, Vector3 column3, bool DontAssignValue = true)
        {
            this.M1 = column1.x;
            this.M2 = column2.x;
            this.M3 = column3.x;
            this.M4 = column1.y;
            this.M5 = column2.y;
            this.M6 = column3.y;
            this.M7 = column1.z;
            this.M8 = column2.z;
            this.M9 = column3.z;
        }

        public static Matrix3x3 Identity = new Matrix3x3(1, 0, 0, 0, 1, 0, 0, 0, 1);

        public static Matrix3x3 operator +(Matrix3x3 a, Matrix3x3 b)
        {
            return new Matrix3x3(a.M1 + b.M1, a.M2 + b.M2, a.M3 + b.M3, a.M4 + b.M4, a.M5 + b.M5, a.M6 + b.M6, a.M7 + b.M7, a.M8 + b.M8, a.M9 + b.M9);
        }
        public static Matrix3x3 operator -(Matrix3x3 a, Matrix3x3 b)
        {
            return new Matrix3x3(a.M1 - b.M1, a.M2 - b.M2, a.M3 - b.M3, a.M4 - b.M4, a.M5 - b.M5, a.M6 - b.M6, a.M7 - b.M7, a.M8 - b.M8, a.M9 - b.M9);
        }
        public static Matrix3x3 operator *(Matrix3x3 a, Matrix3x3 b)
        {
            return new Matrix3x3(a.M1 * b.M1, a.M2 * b.M2, a.M3 * b.M3, a.M4 * b.M4, a.M5 * b.M5, a.M6 * b.M6, a.M7 * b.M7, a.M8 * b.M8, a.M9 * b.M9);
        }
        public static Matrix3x3 operator /(Matrix3x3 a, Matrix3x3 b)
        {
            return new Matrix3x3(a.M1 / b.M1, a.M2 / b.M2, a.M3 / b.M3, a.M4 / b.M4, a.M5 / b.M5, a.M6 / b.M6, a.M7 / b.M7, a.M8 / b.M8, a.M9 / b.M9);
        }
        public double[] ToDoubleArray(Matrix3x3 m)
        {
            return new double[9] {m.M1, m.M2, m.M3, m.M4, m.M5, m.M6, m.M7, m.M8, m.M9 };
        }
    }
}
