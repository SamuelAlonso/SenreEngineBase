namespace SenreEngine
{
    public struct Matrix4x4
    {
        public float M1, M2, M3, M4, M5, M6, M7, M8, M9, M10, M11, M12, M13, M14, M15, M16;
        public Matrix4x4(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9, float m10, float m11, float m12, float m13, float m14, float m15, float m16)
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
            this.M10 = m10;
            this.M11 = m11;
            this.M12 = m12;
            this.M13 = m13;
            this.M14 = m14;
            this.M15 = m15;
            this.M16 = m16;
        }
        public Matrix4x4(Vector4 row1, Vector4 row2, Vector4 row3, Vector4 row4)
        {
            this.M1 = row1.x;
            this.M2 = row1.y;
            this.M3 = row1.z;
            this.M4 = row1.w;
            this.M5 = row2.x;
            this.M6 = row2.y;
            this.M7 = row2.z;
            this.M8 = row2.w;
            this.M9 = row3.x;
            this.M10 = row3.y;
            this.M11 = row3.z;
            this.M12 = row3.w;
            this.M13 = row4.x;
            this.M14 = row4.y;
            this.M15 = row4.z;
            this.M16 = row4.w;
        }
        public Matrix4x4(Vector4 column1, Vector4 column2, Vector4 column3, Vector4 column4, bool DontAssignValue = true)
        {
            this.M1 = column1.x;
            this.M2 = column2.x;
            this.M3 = column3.x;
            this.M4 = column4.x;
            this.M5 = column1.y;
            this.M6 = column2.y;
            this.M7 = column3.y;
            this.M8 = column4.y;
            this.M9 = column1.z;
            this.M10 = column2.z;
            this.M11 = column3.z;
            this.M12 = column4.z;
            this.M13 = column1.w;
            this.M14 = column2.w;
            this.M15 = column3.w;
            this.M16 = column4.w;
        }

        public static Matrix4x4 Identity = new Matrix4x4(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);

        public static Matrix4x4 operator +(Matrix4x4 a, Matrix4x4 b)
        {
            return new Matrix4x4(a.M1 + b.M1, a.M2 + b.M2, a.M3 + b.M3, a.M4 + b.M4, a.M5 + b.M5, a.M6 + b.M6, a.M7 + b.M7, a.M8 + b.M8, a.M9 + b.M9, a.M10 + b.M10, a.M11 + b.M11, a.M12 + b.M12, a.M13 + b.M13, a.M14 + b.M14, a.M15 + b.M15, a.M16 + b.M16);
        }
        public static Matrix4x4 operator -(Matrix4x4 a, Matrix4x4 b)
        {
            return new Matrix4x4(a.M1 - b.M1, a.M2 - b.M2, a.M3 - b.M3, a.M4 - b.M4, a.M5 - b.M5, a.M6 - b.M6, a.M7 - b.M7, a.M8 - b.M8, a.M9 - b.M9, a.M10 - b.M10, a.M11 - b.M11, a.M12 - b.M12, a.M13 - b.M13, a.M14 - b.M14, a.M15 - b.M15, a.M16 - b.M16);
        }
        public static Matrix4x4 operator *(Matrix4x4 a, Matrix4x4 b)
        {
            return new Matrix4x4(a.M1 * b.M1, a.M2 * b.M2, a.M3 * b.M3, a.M4 * b.M4, a.M5 * b.M5, a.M6 * b.M6, a.M7 * b.M7, a.M8 * b.M8, a.M9 * b.M9, a.M10 * b.M10, a.M11 * b.M11, a.M12 * b.M12, a.M13 * b.M13, a.M14 * b.M14, a.M15 * b.M15, a.M16 * b.M16);
        }
        public static Matrix4x4 operator /(Matrix4x4 a, Matrix4x4 b)
        {
            return new Matrix4x4(a.M1 / b.M1, a.M2 / b.M2, a.M3 / b.M3, a.M4 / b.M4, a.M5 / b.M5, a.M6 / b.M6, a.M7 / b.M7, a.M8 / b.M8, a.M9 / b.M9, a.M10 / b.M10, a.M11 / b.M11, a.M12 / b.M12, a.M13 / b.M13, a.M14 / b.M14, a.M15 / b.M15, a.M16 / b.M16);
        }
        public static double[] ToDoubleArray(Matrix4x4 a)
        {
            return new double[16] {a.M1, a.M2, a.M3, a.M4, a.M5, a.M6, a.M7, a.M8, a.M9, a.M10, a.M11, a.M12, a.M13, a.M14, a.M15, a.M16};
        }
    }
}
