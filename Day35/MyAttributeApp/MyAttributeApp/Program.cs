using System.Reflection;
using MyAttributeApp.Models;

namespace MyAttributeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<MethodInfo> methodAttribute = new List<MethodInfo>();
            MethodInfo[] methods = typeof(Test).GetMethods();


            foreach (MethodInfo method in methods)
            {
                object[] attributes = method.GetCustomAttributes(typeof(ThisMethodNeedsAttentionAttribute), false);

                if (attributes.Length > 0)
                {
                    methodAttribute.Add(method);
                }
            }
            foreach (MethodInfo method in methodAttribute)
            {
                Console.WriteLine($"This method : \"{method.Name}\" needs Priority.");
            }
        }
    }
}
