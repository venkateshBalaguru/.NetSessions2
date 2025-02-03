using System.Reflection;
using MyAttributeApp.Models;

namespace MyAttributeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MethodInfo> methodWithAttribute = new List<MethodInfo>();
            MethodInfo[] methods = typeof(MyAttribute).GetMethods();

            foreach (MethodInfo method in methods)
            {
                object[] attributes = method.GetCustomAttributes(typeof(ThisMethodNeedsAttentionAttribute), false);

                if (attributes.Length > 0)
                {
                    methodWithAttribute.Add(method);
                }
            }
            foreach (MethodInfo method in methodWithAttribute)
            {
                Console.WriteLine($"Method: {method.Name} needs attention.");
            }
        }
    }
}