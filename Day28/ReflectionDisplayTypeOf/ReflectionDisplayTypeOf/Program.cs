using System.Reflection;
using ReflectionDisplayTypeOf.Models;
namespace ReflectionDisplayTypeOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayNameOfType.DoReflection(typeof(Employee));

        }
    }
}

