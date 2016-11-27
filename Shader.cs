using OpenTK.Graphics.OpenGL;
using System.Text;
using System.IO;
using System;
using System.Collections.Generic;

namespace SenreEngine
{
    public class Shader
    {
        private int programID = 0;
        private int vertexID = 0;
        private int fragmentID = 0;
        private int geometryID = 0;
        private int computeID = 0;

        public Tuple<List<string>, int> ShaderAddUniform;
        public List<Type> VarsToAddInUniform;

        private int LoadShader(string file_without_path, int type)
        {
            StringBuilder shaderSource = new StringBuilder();
            try
            {
                using (StreamReader reader = new StreamReader(Path.GetFullPath(file_without_path)))
                {
                    string line = string.Empty;
                    while((line = reader.ReadLine()) != null)
                    {
                        shaderSource.Append(line).Append("\n");
                    }
                    reader.Close();
                }
            }
            catch(IOException e)
            {
                Debug.CatchException(e.StackTrace);
            }
            int ShaderId = 0;

            switch (type)
            {
                case 0:
                    ShaderId = GL.CreateShader(ShaderType.VertexShader);
                    break;
                case 1:
                    ShaderId = GL.CreateShader(ShaderType.FragmentShader);
                    break;
                case 2:
                    ShaderId = GL.CreateShader(ShaderType.GeometryShader);
                    break;
                case 3:
                    ShaderId = GL.CreateShader(ShaderType.ComputeShader);
                    break;
            }
            GL.ShaderSource(ShaderId, shaderSource.ToString());
            GL.CompileShader(ShaderId);
            return ShaderId;
        }
        private void BindUniform()
        {
            for (int program = 0; program < ShaderAddUniform.Item2; program ++)
            {
                Type VarToAdd = null;
                int VarToAddCount = VarsToAddInUniform.Count;
                for(int x = 0; x < VarToAddCount; x++)
                {
                    VarToAdd = VarsToAddInUniform[x];
                }
                foreach (string varname in ShaderAddUniform.Item1)
                {

                    int location = GL.GetUniformLocation(programID, varname);

                    
                        if (VarToAdd == typeof(int))
                        {
                            GL.Uniform1(location, Convert.ToInt32(VarToAdd));
                        }
                        else if (VarToAdd == typeof(double))
                        {
                            GL.Uniform1(location, Convert.ToDouble(VarToAdd));
                        }
                        else if (VarToAdd == typeof(float))
                        {
                            GL.Uniform1(location, Convert.ToSingle(VarToAdd));
                        }
                        else if (VarToAdd == typeof(Vector2))
                        {
                            Vector2 Var = (Vector2)Convert.ChangeType(new Vector2(), VarToAdd);

                            GL.Uniform2(location, 1, new float[2] { Var.x, Var.y });

                        }
                        else if (VarToAdd == typeof(Vector3))
                        {
                            Vector3 Var = (Vector3)Convert.ChangeType(new Vector3(), VarToAdd);

                            GL.Uniform3(location, 1, new float[3] { Var.x, Var.y, Var.z });
                        }
                        else if (VarToAdd == typeof(Vector4))
                        {
                            Vector4 Var = (Vector4)Convert.ChangeType(new Vector4(), VarToAdd);

                            GL.Uniform4(location, 1, new float[4] { Var.x, Var.y, Var.z, Var.w });
                        }
                        else if (VarToAdd == typeof(Matrix3x3))
                        {
                            Matrix3x3 m = (Matrix3x3)Convert.ChangeType(new Matrix3x3(), VarToAdd);
                            GL.UniformMatrix3(location, 1, false, m.ToDoubleArray(m));
                        }
                        else if (VarToAdd == typeof(Matrix4x4))
                        {
                            Matrix4x4 m = (Matrix4x4)Convert.ChangeType(new Matrix4x4(), VarToAdd);
                            GL.UniformMatrix4(location, 1, false, m.ToDoubleArray(m));
                        
                    }
                }
            }
        }
        public Shader(string vertexfile, string fragmentfile, string computefile = null, string geometryfile = null)
        {
            vertexID = LoadShader(vertexfile, 0);
            fragmentID = LoadShader(fragmentfile, 1);
            if (geometryfile != null)
            {
                geometryID = LoadShader(geometryfile, 2);
            }
            if(computefile != null)
            {
                computeID = LoadShader(computefile, 3);
            }
            
            programID = GL.CreateProgram();

            if(programID == ShaderAddUniform.Item2)
            {
                BindUniform();
            }

            GL.AttachShader(programID, vertexID);
            GL.AttachShader(programID, fragmentID);
            if(geometryfile != null)
            {
                GL.AttachShader(programID, geometryID);
            }
            if(computefile != null)
            {
                GL.AttachShader(programID, computeID);
            }
            GL.LinkProgram(programID);
            GL.ValidateProgram(programID);
        }

        public void Start()
        {
            GL.UseProgram(programID);
        }
        public void Stop()
        {
            GL.UseProgram(0);
        }
        public void Clean()
        {
            Stop();
            GL.DetachShader(programID, vertexID);
            GL.DetachShader(programID, fragmentID);
            GL.DetachShader(programID, geometryID);
            GL.DetachShader(programID, computeID);
            GL.DeleteShader(vertexID);
            GL.DeleteShader(fragmentID);
            GL.DeleteShader(geometryID);
            GL.DeleteShader(computeID);
            GL.DeleteProgram(programID);
        }
        public void BindAttribute(int Attribute, string VarName)
        {
            GL.BindAttribLocation(programID, Attribute, VarName);
        }
    }
}
