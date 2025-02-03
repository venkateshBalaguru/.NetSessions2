using MyAttribute_2.Models;

namespace MyAttribute_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReflectionExample.FindMethodsNeedingAttention(typeof(TestClass));
        }
    }
}
