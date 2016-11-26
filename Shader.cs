using OpenTK.Graphics.OpenGL;
using System.Text;
using System.IO;
using System;

namespace SenreEngine
{
    public class Shader
    {
        private int programID = 0;
        private int vertexID = 0;
        private int fragmentID = 0;
        private int geometryID = 0;
        private int computeID = 0;

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
