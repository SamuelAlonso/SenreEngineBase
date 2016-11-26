using System.Reflection;
using System.Collections.Generic;
using System;

namespace SenreEngine
{
    public abstract class MethodsTasked
    {
        protected static MethodInfo mUpdate;
        protected static MethodInfo mLateUpdate;

        private static List<string> GetClasses()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string nameSpace = asm.GetType().Namespace;

            List<string> classeslist = new List<string>();

            foreach (Type type in asm.GetTypes())
            {
                if (type.Namespace == nameSpace)
                    classeslist.Add(type.Name);
            }
            return classeslist;
        }
        public static void GetDefaultMethods()
        {
            try
            {
                foreach (string Class in GetClasses())
                {
                    Type ClassType = Type.GetType(Class);
                    mUpdate = ClassType.GetMethod("Update");
                    mLateUpdate = ClassType.GetMethod("LateUpdate");
                }
            }
            catch (Exception e)
            {
                Debug.CatchException(e.InnerException.Message);
            }
        }
    }
}
